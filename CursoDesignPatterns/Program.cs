using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Fogao", 250));
            orcamento.AdicionaItem(new Item("Micro", 250));
            orcamento.AdicionaItem(new Item("XBox", 250));


            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);


            Console.ReadKey();
        }
    }
}
