using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using financas.WebApi.Models;

namespace financas.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DespesaController : Controller
    {       
        private IDespesaRepository _repository;
        private IGrupoDespesaRepository _repositoryGrupoDespesa;

        public DespesaController(IDespesaRepository repository, IGrupoDespesaRepository repositoryGrupoDespesa){
            _repository = repository;
            _repositoryGrupoDespesa = repositoryGrupoDespesa;
        }

                 // GET api/values
        [HttpGet]
        public IEnumerable<Despesa> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet]
        public IEnumerable<GrupoDespesa> GetGrupo(){
            return _repositoryGrupoDespesa.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Despesa Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpGet("{id}")]
        public GrupoDespesa GetDespesa(int id){
            return _repositoryGrupoDespesa.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Despesa despesa)
        {
            if(despesa==null)
                return BadRequest();

            _repository.Create(despesa);

            return CreatedAtAction("Get", new {despesa.id, despesa});
        }

        [HttpPost]
        public IActionResult Post([FromBody]GrupoDespesa grupoDespesa){
            if(grupoDespesa==null)
                return BadRequest();

            _repositoryGrupoDespesa.Create(grupoDespesa);

            return BadRequest();
        }

        // put api/todo
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Despesa despesa)
        {
            if(despesa==null)
                return BadRequest();

            _repository.Update(despesa);

            return Ok(despesa);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody]GrupoDespesa grupoDespesa)
        {
            if(grupoDespesa==null)
                return BadRequest();

            _repositoryGrupoDespesa.Update(grupoDespesa);

            return Ok(grupoDespesa);
        }

        // put api/todo
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody]Despesa despesa)
        {
            _repository.Delete(id);

            return Ok(new {
                retorno= "Deletado com Sucesso",
                id=id
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody]GrupoDespesa grupoDespesa)
        {
            _repositoryGrupoDespesa.Delete(id);

            return Ok(new {
                retorno= "Deletado com Sucesso",
                id=id
            });
        }
    }
}