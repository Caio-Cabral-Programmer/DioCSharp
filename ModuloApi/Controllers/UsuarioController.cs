using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")] // Desse modo, o endpoint será /Usuario/ObterDataHoraAtual . "Usuario" vem do nome do controller.
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]  // Anota o tipo de resposta para sucesso e código 200. Isso ajuda na documentação do Swagger, deixando claro o que a API retorna.
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")] // {nome} é um parâmetro de rota.
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]  
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá, {nome}! Seja bem-vindo à API do ModuloApi."; // Por que o uso de var? Porque o compilador infere o tipo string automaticamente. Por que não usar string diretamente? Poderia, mas o uso de var torna o código mais conciso. Nesse caso é seguro e recomendado, pois o tipo é evidente.
            return Ok(mensagem);
        }
    }
}