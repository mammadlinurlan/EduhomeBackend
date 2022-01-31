﻿using BackendProjectNurlanSenior.Dal;
using BackendProjectNurlanSenior.Models;
using BackendProjectNurlanSenior.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProjectNurlanSenior.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        public IActionResult Index()
        {
            BlogVM blogVM = new BlogVM
            {
                Blogs = _context.Blogs.Include(b=>b.Comments).ToList(),
                Blog = _context.Blogs.Include(b=>b.Comments).FirstOrDefault()

            };

            return View(blogVM);
        }

        public IActionResult Details(int id)
        {
            BlogVM blogVM = new BlogVM
            {
                Blogs = _context.Blogs.Include(b => b.Comments).ThenInclude(c=>c.AppUser).ToList(),
                Blog = _context.Blogs.Include(b => b.Comments).ThenInclude(c=>c.AppUser).FirstOrDefault(b=>b.Id == id)

            };
            return View(blogVM);
        }

        public IActionResult SearchResult(string Name)
        {
            BlogVM BlogVM = new BlogVM
            {
                Blogs = Name==null ? _context.Blogs.Include(b=>b.Comments).ToList() : _context.Blogs.Include(b => b.Comments).Where(e => e.Name.ToLower().Trim().Contains(Name.ToLower().Trim())).ToList()
            };
            ViewBag.LastBlogs = _context.Blogs.OrderByDescending(e => e.Id).Take(3).ToList();
            return View(BlogVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return Json(StatusCode(400));
            if (!_context.Blogs.Any(f => f.Id == comment.BlogId))
            {
                return NotFound();
            }
            Comment cmnt = new Comment
            {
                AppUserId = user.Id,
                BlogId = comment.BlogId,
                CreatedTime = DateTime.Now,
                Message = comment.Message,
                Subject = comment.Subject,
                IsAccepted = true
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();

            return RedirectToAction("Details","Blog",new { id = cmnt.BlogId});

        }

        public async Task<IActionResult> DeleteComment(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Details", "Blog");
            if (!_context.Comments.Any(c => c.Id == id && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            BlogVM BlogVM = new BlogVM
            {
                Blog = _context.Blogs.Include(e => e.Comments).ThenInclude(c => c.AppUser).FirstOrDefault()
            };
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            //return RedirectToAction("Details", "Blog", new { id = comment.BlogId });
            return Json(new { status = 200 });

            //return PartialView("_eCommentPartialView", BlogVM);



        }
    }
}