using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetCareConnect.App.ViewModels;
using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;

namespace PetCareConnect.App.Controllers
{
    public class ServicoController : Controller
    {
        public IMapper Mapper { get; }

        private readonly IServicoService _servicoService;
        private readonly IServicoRepository _servicoRepository;

        public ServicoController( IServicoService servicoService, IServicoRepository servicoRepository, IMapper mapper)
        {
            _servicoService = servicoService;
            _servicoRepository = servicoRepository;
            Mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var servicos = await _servicoRepository.ObterTodos();
            var servicoViewModel = Mapper.Map<IEnumerable<ServicoViewModel>>(servicos);
            return View(servicoViewModel);
        }


        public async Task<IActionResult> Details(Guid id)
        {
            var servicoViewModel = await ObterServicoViewModel(id);
            return View(servicoViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServicoViewModel servicoViewModel)
        {
            if (!ModelState.IsValid) return View(servicoViewModel);
            var servico = Mapper.Map<Servico>(servicoViewModel);
            await _servicoService.Adicionar(servico);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty) return NotFound();
            var servicoViewModel = await ObterServicoViewModel(id);
            return View(servicoViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ServicoViewModel servicoViewModel)
        {
            if (id != servicoViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return View(servicoViewModel);
            var servico = Mapper.Map<Servico>(servicoViewModel);
            await _servicoService.Alterar(servico);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty) return NotFound();
            var servicoViewModel = await ObterServicoViewModel(id);
            return View(servicoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (id == Guid.Empty) return NotFound();
            await _servicoService.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<ServicoViewModel> ObterServicoViewModel(Guid id)
        {
            var servicoViewModel = Mapper.Map<ServicoViewModel>(await _servicoRepository.ObterPorId(id));
            return servicoViewModel;
        }
    }
}
