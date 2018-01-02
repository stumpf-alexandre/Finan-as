using financas.domain;
using financas.repository;
using Microsoft.AspNetCore.Mvc;

namespace financas.UI.Controllers
{
    public class DespesaController : Controller
    {
        private IDespesaRepository _repository;
        private IGrupoDespesaRepository _repositoryGrupoDespesa;

        public DespesaController(IDespesaRepository repository, IGrupoDespesaRepository repositoryGrupoDespesa){
            _repository = repository;
            _repositoryGrupoDespesa = repositoryGrupoDespesa;
        }

        public IActionResult Index(){
            return View(_repository.GetAll());
        }

        public IActionResult Create(){
            ViewBag.GrupoDespesa = _repositoryGrupoDespesa.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Despesa despesa){
            _repository.Create(despesa);
            return RedirectToAction("Index");
        }
    }
}