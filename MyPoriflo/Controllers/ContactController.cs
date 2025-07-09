﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPoriflo.Models;

namespace MyPoriflo.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;


        public ContactController(AppDbContext appDb)
        {
            
            _context = appDb;
        }

        // GET: لعرض النموذج
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: لحفظ البيانات
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact contact)
        {
            if (!ModelState.IsValid)
                return View(contact);

            _context.contacts.Add(contact);
            _context.SaveChanges();
            TempData["Create"] = "The message was sent successfully.";
            
            return RedirectToAction("Index", "Home");
        }



    }



}
