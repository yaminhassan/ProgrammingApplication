﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentGrades;
using StudentGrades.Data;

namespace StudentGrades.Controllers
{
    public class MessagePostsController : Controller
    {
        private readonly StudentData _context;

        public MessagePostsController(StudentData context)
        {
            _context = context;
        }

        // GET: MessagePosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.MessagePosts.ToListAsync());
        }

        // GET: MessagePosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messagePost = await _context.MessagePosts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (messagePost == null)
            {
                return NotFound();
            }

            return View(messagePost);
        }

        // GET: MessagePosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MessagePosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Message,Likes,ID,Username")] MessagePost messagePost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(messagePost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(messagePost);
        }

        // GET: MessagePosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messagePost = await _context.MessagePosts.FindAsync(id);
            if (messagePost == null)
            {
                return NotFound();
            }
            return View(messagePost);
        }

        // POST: MessagePosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Message,Likes,ID,Username")] MessagePost messagePost)
        {
            if (id != messagePost.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(messagePost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessagePostExists(messagePost.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(messagePost);
        }

        // GET: MessagePosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messagePost = await _context.MessagePosts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (messagePost == null)
            {
                return NotFound();
            }

            return View(messagePost);
        }

        // POST: MessagePosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var messagePost = await _context.MessagePosts.FindAsync(id);
            _context.MessagePosts.Remove(messagePost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MessagePostExists(int id)
        {
            return _context.MessagePosts.Any(e => e.ID == id);
        }
    }
}
