using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetCareConnect.App.ViewModels;
using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Business.Services;
using PetCareConnect.Data.Repositories;

namespace PetCareConnect.App.Controllers
{
    public class PrestadorController : Controller
    {
        public IMapper Mapper { get; }

        private readonly IPrestadorService _prestadorService;
        private readonly IPrestadorRepository _prestadorRepository;

        public PrestadorController(IPrestadorService prestadorService, IPrestadorRepository prestadorRepository, IMapper mapper)
        {
            _prestadorService = prestadorService;
            _prestadorRepository = prestadorRepository;
            Mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var prestador = await _prestadorRepository.ObterTodos();
            var prestadorViewModel = Mapper.Map<IEnumerable<PrestadorViewModel>>(prestador);
            return View(prestadorViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PrestadorViewModel prestadorViewModel)
        {
            if (!ModelState.IsValid) return View(prestadorViewModel);

            var imgPrefixo = Guid.NewGuid() + "_";

            if (!await UploadArquivo(prestadorViewModel.ImagemUpload, imgPrefixo))
            {
                return View(prestadorViewModel);
            }

            prestadorViewModel.Imagem = imgPrefixo + prestadorViewModel.ImagemUpload.FileName;
            var prestador = Mapper.Map<Prestador>(prestadorViewModel);
            await _prestadorRepository.Adicionar(prestador);
            return RedirectToAction(nameof(Index));
        }
        private async Task<bool> UploadArquivo(IFormFile arquivo, string imgPrefixo)
        {
            if (arquivo == null || arquivo.Length <= 0) return false;

            var caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", imgPrefixo + arquivo.FileName);

            if (System.IO.File.Exists(caminho))
            {
                ModelState.AddModelError(String.Empty, "Já existe um arquivo com este nome");
                return false;
            }

            using (var stream = new FileStream(caminho, FileMode.Create))
            {
                await arquivo.CopyToAsync(stream);
            }

            return true;
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var prestadorViewModel = await ObterPrestadorViewModel(id);
            return View(prestadorViewModel);
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty) return NotFound();

            var prestadorViewModel = await ObterPrestadorViewModel(id);

            return View(prestadorViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (id == Guid.Empty) return NotFound();

            await _prestadorService.Remover(id);

            return RedirectToAction(nameof(Index));
        }


        private async Task<PrestadorViewModel> ObterPrestadorViewModel(Guid id)
        {
            var prestadorViewModel = Mapper.Map<PrestadorViewModel>(await _prestadorRepository.ObterPorId(id));
            return prestadorViewModel;
        }
    }
}
