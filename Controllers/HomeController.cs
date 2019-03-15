using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Resultado(long numero)
        {
             
                var retornoFeliz = numeroFeliz(numero);
                var retornoSortudo = numeroSortudo(numero);

                NumeroViewModel retorno = new NumeroViewModel();

                if (retornoFeliz)
                {
                    retorno.ResultadoFeliz = " Feliz";
                }
                else
                {
                    retorno.ResultadoFeliz =  " Não-Feliz";
                }
                
            if (retornoSortudo)
                {
                    retorno.ResultadoSortudo = " Sortudo";
                }
                else
                {
                    retorno.ResultadoSortudo = " Não-sortudo";
                }
                retorno.Numero = numero;
            
            return base.View(retorno);
            
        }

          public IActionResult Voltar()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static bool numeroFeliz(long numero)
        {
            for (int i = 1; i <= 100; i++)
            {
                var lista = numero.ToString().ToCharArray();
                double resultado = 0;

                foreach (var item in lista)
                {
                    resultado += Math.Pow(double.Parse(item.ToString()), 2);
                }

                if(resultado == 1)
                {
                    return true;
                }
                else
                {
                    numero = long.Parse(resultado.ToString());
                }
            }

            return false;
        }

        private static bool numeroSortudo(long numero)
        {
            List<long> lista = new List<long>();

            for (int i = 1; i <= numero; i++)
            {
                lista.Add(i);
            }

            lista.RemoveAll(x => (x % 2 == 0));

            for (int i = 1; i < lista.Count; i++)
            {
                long multiplo = lista[i];

                int j = 1;

                while (true)
                {
                    var quadrado = Math.Pow(multiplo, j);

                    if(quadrado < lista.Count)
                    {
                        lista.RemoveAt(int.Parse(quadrado.ToString()) - 1);
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return lista.Contains(numero);
        }
    }
}
