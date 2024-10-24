using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetCareConnect.App.ViewModels;
using PetCareConnect.Business.Interfaces;
using PetCareConnect.Business.Models;


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
            var produtoViewModel = Mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterPorId(id));

            return View(produtoViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid) return View(produtoViewModel);
            
                var produto = Mapper.Map<Produto>(produtoViewModel);
                await _produtoService.Adicionar(produto);
                return RedirectToAction(nameof(Index));
            
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty) return NotFound();

            var produto = await _produtoRepository.ObterPorId(id);

            if (produto == null) return NotFound();

            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);

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

            var produto = await _produtoRepository.ObterPorId(id);

            if (produto == null) return NotFound();

            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);

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

        //        private bool ObterProdutoViewModel(Guid id)
        //        {
        //            return _context.ProdutoViewModel.Any(e => e.Id == id);
        //        }
    }
    }
