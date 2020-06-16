using System.Collections.Generic;

namespace TesteSelecao.Application.Interfaces
{
    public interface IOperacaoNumericaApplication
    {
        List<int> ListarDivisores(int numero);
        List<int> ListarPrimos(int numero);
    }
}
