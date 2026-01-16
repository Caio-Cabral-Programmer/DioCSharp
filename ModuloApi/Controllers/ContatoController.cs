using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloApi.Context;
using ModuloApi.Entities;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Contato), StatusCodes.Status200OK)]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Contato), StatusCodes.Status200OK)]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        [ProducesResponseType(typeof(List<Contato>), StatusCodes.Status200OK)]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(c => c.Nome.Contains(nome)).ToList();
            if (contatos.Count == 0)
            {
                return NotFound();
            }   
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Contato), StatusCodes.Status200OK)]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoExistente = _context.Contatos.Find(id);

            if (contatoExistente == null)
            {
                return NotFound();
            }

            contatoExistente.Nome = contato.Nome;
            contatoExistente.Telefone = contato.Telefone;
            contatoExistente.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoExistente);
            _context.SaveChanges();

            return Ok(contatoExistente);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Deletar(int id)
        {
            var contatoExistente = _context.Contatos.Find(id);

            if (contatoExistente == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatoExistente);
            _context.SaveChanges();

            return NoContent();
        }
    }
}