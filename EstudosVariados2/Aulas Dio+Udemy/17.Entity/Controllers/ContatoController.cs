using Entity.BD;
using Entity.Contexto;
using Microsoft.AspNetCore.Mvc;

namespace Entity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContexto _contexto;
        public ContatoController(AgendaContexto contexto) 
        {
            _contexto = contexto;
        }


        //Criar um novo contato
        [HttpPost]
        public ActionResult Criar(Contato contato) 
        {
            _contexto.Add(contato);
            _contexto.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id_Contato }, contato);
        }

        //Listar um contato por ID
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id) 
        {
            var contato = _contexto.Contatos.Find(id);
            if (contato == null) 
            {
                return NotFound();
            }
            return Ok(contato);
        }
        //Listar um contato por Nome
        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _contexto.Contatos.Where(x => x.Nome_Contato!.Contains(nome));
            if(contatos == null || !contatos.Any())
            {
                return NotFound();
            }
            return Ok(contatos);
        }

        //Atualizar um contato
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato) 
        {
            var contatoBanco = _contexto.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            contatoBanco!.Nome_Contato = contato.Nome_Contato;
            contatoBanco!.Telefone_Contato = contato.Telefone_Contato;
            contatoBanco!.Ativo = contato.Ativo;

            _contexto.Contatos.Update(contatoBanco);
            _contexto.SaveChanges();
            return Ok(contatoBanco);
        }

        //Deletar um contato por ID
        [HttpDelete("{id}")]
        public IActionResult DeletarPorId(int id)
        {
            var contato = _contexto.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            _contexto.Contatos.Remove(contato);
            _contexto.SaveChanges();
            return NoContent();
        }
    }
}
