﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using PetCareConnect.App.Data;
//using PetCareConnect.App.ViewModels;

//namespace PetCareConnect.App.Controllers
//{
//    public class ClienteController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public ClienteController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Cliente
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.ClienteViewModel.ToListAsync());
//        }

//        // GET: Cliente/Details/5
//        public async Task<IActionResult> Details(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var clienteViewModel = await _context.ClienteViewModel
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (clienteViewModel == null)
//            {
//                return NotFound();
//            }

//            return View(clienteViewModel);
//        }

//        // GET: Cliente/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Cliente/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id")] ClienteViewModel clienteViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                clienteViewModel.Id = Guid.NewGuid();
//                _context.Add(clienteViewModel);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(clienteViewModel);
//        }

//        // GET: Cliente/Edit/5
//        public async Task<IActionResult> Edit(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var clienteViewModel = await _context.ClienteViewModel.FindAsync(id);
//            if (clienteViewModel == null)
//            {
//                return NotFound();
//            }
//            return View(clienteViewModel);
//        }

//        // POST: Cliente/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(Guid id, [Bind("Id")] ClienteViewModel clienteViewModel)
//        {
//            if (id != clienteViewModel.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(clienteViewModel);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ClienteViewModelExists(clienteViewModel.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(clienteViewModel);
//        }

//        // GET: Cliente/Delete/5
//        public async Task<IActionResult> Delete(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var clienteViewModel = await _context.ClienteViewModel
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (clienteViewModel == null)
//            {
//                return NotFound();
//            }

//            return View(clienteViewModel);
//        }

//        // POST: Cliente/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(Guid id)
//        {
//            var clienteViewModel = await _context.ClienteViewModel.FindAsync(id);
//            if (clienteViewModel != null)
//            {
//                _context.ClienteViewModel.Remove(clienteViewModel);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ClienteViewModelExists(Guid id)
//        {
//            return _context.ClienteViewModel.Any(e => e.Id == id);
//        }
//    }
//}
