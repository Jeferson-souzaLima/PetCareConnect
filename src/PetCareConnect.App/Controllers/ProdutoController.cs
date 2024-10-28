using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetCareConnect.App.ViewModels;
using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;
using PetCareConnect.Data.Repositories;


namespace PetCareConnect.App.Controllers
{
    public class ProdutoController : Controller
    {
        public IMapper Mapper { get; }

        private readonly IProdutoService _produtoService;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoService produtoService, IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoService = produtoService;
            _produtoRepository = produtoRepository;
            Mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoRepository.ObterTodos();
            var produtosViewModel = Mapper.Map<IEnumerable<ProdutoViewModel>>(produtos);
            return View(produtosViewModel);
        }


        public async Task<IActionResult> Details(Guid id)
        {
            var produtoViewModel = await ObterProdutoViewModel(id);

            return View(produtoViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid) return View(produtoViewModel);

            var imgPrefixo = Guid.NewGuid() + "_";

            if (!await UploadArquivo(produtoViewModel.ImagemUpload, imgPrefixo))
            {
                return View(produtoViewModel);
            }

            produtoViewModel.Imagem = imgPrefixo + produtoViewModel.ImagemUpload.FileName;
            var produto = Mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Adicionar(produto);
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

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty) return NotFound();

            var produtoViewModel = await ObterProdutoViewModel(id);

            return View(produtoViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel produtoViewModel)
        {
            if (id != produtoViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(produtoViewModel);
                
                var produto = Mapper.Map<Produto>(produtoViewModel);
                await _produtoService.Alterar(produto);
                
                return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty) return NotFound();

            var produtoViewModel = await ObterProdutoViewModel(id);

            return View(produtoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (id == Guid.Empty) return NotFound();

            await _produtoService.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<ProdutoViewModel> ObterProdutoViewModel(Guid id)
        {
            var produtoViewModel = Mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterPorId(id));
            return produtoViewModel;
        }
    }
}
