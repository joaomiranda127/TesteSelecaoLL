using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TesteSelecao.Application.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteSelecaoController : ControllerBase
    {
        private readonly IOperacaoNumericaApplication _operacaoNumericaApp;

        public TesteSelecaoController(IOperacaoNumericaApplication operacaoApp)
        {
            _operacaoNumericaApp = operacaoApp;
        }

        [HttpGet]
        [Route("divisores/{numero}")]
        [ProducesResponseType(typeof(int[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<int> ObterDivisores([FromRoute] int numero)
        {
            var divisores = _operacaoNumericaApp.ListarDivisores(numero);
            
            return divisores.ToArray();
        }

        [HttpGet]
        [Route("primos/{numero}")]
        [ProducesResponseType(typeof(int[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<int> ObterPrimos([FromRoute] int numero)
        {
            var primos = _operacaoNumericaApp.ListarPrimos(numero);

            return primos.ToArray();
        }
    }
}
