using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetCareConnect.App.Data;
using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Data.Repositories;

namespace PetCareConnect.App.Controllers
{
    public class ProdutoController : Controller
    {
        public IProdutoRepository ProdutoRepository { get; }
        public IMapper Mapper { get; }

        private readonly ApplicationDbContext _context;

        public ProdutoController(ApplicationDbContext context, IProdutoRepository produtoRepository, IMapper mapper)
        {
            _context = context;
            ProdutoRepository = produtoRepository;
            Mapper = mapper;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var produtos = await ProdutoRepository.ObterTodos();
            var produtosViewModel = Mapper.Map<IEnumerable<ProdutoViewModel>>(produtos);
            return View(produtosViewModel);
        }

        
        public async Task<IActionResult> Details(Guid id)
        {
            var produtoViewModel = Mapper.Map<ProdutoViewModel>(await ProdutoRepository.ObterPorId(id));

            return View(produtoViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Descricao,Imagem,Valor,Id")] ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                produtoViewModel.Id = Guid.NewGuid();
                _context.Add(produtoViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexAsync));
            }
            return View(produtoViewModel);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var produtoViewModel = await ProdutoRepository.ObterPorId(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel produtoViewModel)
        {
            if (id != produtoViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid) return View(produtoViewModel);
            //{
            //    try
            //    {
            //        _context.Update(produtoViewModel);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!ProdutoViewModelExists(produtoViewModel.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(IndexAsync));
            //}
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoViewModel = await _context.ProdutoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produtoViewModel = await _context.ProdutoViewModel.FindAsync(id);
            if (produtoViewModel != null)
            {
                _context.ProdutoViewModel.Remove(produtoViewModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAsync));
        }

        private bool ProdutoViewModelExists(Guid id)
        {
            return _context.ProdutoViewModel.Any(e => e.Id == id);
        }
    }
}
