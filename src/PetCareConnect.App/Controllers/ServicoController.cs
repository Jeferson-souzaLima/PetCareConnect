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
    public class ServicoController : Controller
    {
        public IServicoRepository ServicoRepository { get; }
        public IMapper Mapper { get; }

        private readonly ApplicationDbContext _context;

        public ServicoController(ApplicationDbContext context, IServicoRepository servicoRepository, IMapper mapper)
        {
            _context = context;
            ServicoRepository = servicoRepository;
            Mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(Mapper.Map<IEnumerable<ServicoViewModel>>(await ServicoRepository.ObterTodos()));
        }


        //public async Task<IActionResult> IndexAsync()
        //{
        //    var servico = await ServicoRepository.ObterTodos();
        //    var servicoViewModel = Mapper.Map<IEnumerable<ServicoViewModel>>(servico);
        //    return View(servicoViewModel);
        //}


        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoViewModel = await _context.ServicoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicoViewModel == null)
            {
                return NotFound();
            }

            return View(servicoViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Descricao,Valor,Id")] ServicoViewModel servicoViewModel)
        {
            if (ModelState.IsValid)
            {
                servicoViewModel.Id = Guid.NewGuid();
                _context.Add(servicoViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servicoViewModel);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoViewModel = await _context.ServicoViewModel.FindAsync(id);
            if (servicoViewModel == null)
            {
                return NotFound();
            }
            return View(servicoViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Descricao,Valor,Id")] ServicoViewModel servicoViewModel)
        {
            
            return View(servicoViewModel);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoViewModel = await _context.ServicoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicoViewModel == null)
            {
                return NotFound();
            }

            return View(servicoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var servicoViewModel = await _context.ServicoViewModel.FindAsync(id);
            if (servicoViewModel != null)
            {
                _context.ServicoViewModel.Remove(servicoViewModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //RECOMENDADO REMOVER
        //private bool ServicoViewModelExists(Guid id)
        //{
        //    return _context.ServicoViewModel.Any(e => e.Id == id);
        //}
    }
}
