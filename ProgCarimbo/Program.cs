using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCarimbo
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(" Carimbo ");
			Carimbo C = new Carimbo("Aprovado");
			C.carregar("", 2);
			C.usar();

			C.trocarCor("Azul");
			C.usar();
			

			C.carregar("Vermelho", 1);
			C.trocarTexto("Recuperação");
			C.usar();
			C.usar();
			
			C.carregar("Preto", 2);
			C.trocarTexto("Aprovado");
			C.usar();

			C.trocarCor("Roxo");
			C.trocarTexto("Cor Aprovada");
			C.usar();

			Console.WriteLine("\n");

			Console.WriteLine(" Caneta ");
			Caneta Ca = new Caneta("Aprovado");
			Ca.carregar("Cinza", 2);
			Ca.usar();

			Ca.trocarCor("Verde");
			Ca.usar();


			Ca.carregar("Amarelo", 1);
			Ca.trocarTexto("Recuperação");
			Ca.usar();
			Ca.usar();

			Ca.carregar("Rosa", 3);
			Ca.trocarTexto("Recuperação");
			Ca.usar();
			Ca.usar();
			Ca.trocarCor("");
			Ca.usar();

			System.Console.ReadKey();
		}
    }
}
