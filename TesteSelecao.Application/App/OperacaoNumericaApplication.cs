using System.Collections.Generic;
using TesteSelecao.Application.Interfaces;

namespace TesteSelecao.Application.App
{
    public class OperacaoNumericaApplication : IOperacaoNumericaApplication
    {
        public List<int> ListarDivisores(int numero)
        {
            var divisores = new List<int>();

            for (int i = numero; i > 0; i--)
            {
                if (numero % i == 0)
                    divisores.Add(i);
            }
            return divisores;
        }

        public List<int> ListarPrimos(int numero)
        {
            var primos = new List<int>();

            for (int i = numero; i > 0; i--)
            {
                var divisores = ListarDivisores(i);

                if (divisores.Count.Equals(2))
                    primos.Add(i);
            }

            return primos;
        }
    }
}
