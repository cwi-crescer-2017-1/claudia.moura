using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe seu peso: ");
            var entradaPeso = Console.ReadLine();
            Console.WriteLine("Informe sua altura: ");
            var entradaAltura = Console.ReadLine();


            //var peso = double.Parse(entradaPeso);
            var altura = double.Parse(entradaAltura);
            var peso = 0D;
            if (!double.TryParse(entradaPeso, out peso))
                Console.WriteLine("Entrada Inválida");

            var calculoIMC = new CalculoIMC(altura, peso);
            var imc = calculoIMC.CalcularIMC();

            Console.WriteLine($"Seu IMC: {imc}");
            Console.ReadKey();
            /*
            var entradas = new int[] { };

            
            while (true)
            {
                Console.WriteLine("Digite um valor (exit para sair): ");
                var linhaLida = Console.ReadLine();
                if (linhaLida == "exit")
                {
                    break;
                }
                var nrEntradas = entradas.Length;
                var entradasAux = new int[nrEntradas + 1];

                for (int i = 0; i < nrEntradas; i++)
                {
                    entradasAux[i] = entradas[i];
                }
                entradasAux[nrEntradas] = int.Parse(linhaLida);
                entradas = entradasAux;
            }
            foreach (var entrada in entradas)
            {
                Console.Write(entrada);
            }
            Console.Write("FIM");
            Console.ReadKey();
        }*/
            List<int> entradas = new List<int>();

            while (true)
            {
                Console.WriteLine("Digite um valor (exit para sair): ");
                var linhaLida = Console.ReadLine();
                if (linhaLida == "exit")
                {
                    break;
                }
                entradas.Add(int.Parse(linhaLida));
            }
            foreach (var entrada in entradas)
            {
                Console.Write(entrada);
            }
            Console.Write("FIM");
            Console.ReadKey();
        }




        /*
    Pessoa pessoa = new Pessoa();
    pessoa.Id = 1;
    pessoa.Nascimento = new DateTime(2010, 7, 31);
    pessoa.Nome = "Olar";
    Console.WriteLine(pessoa.Nome);

    Console.ReadKey();*/
    }

    
}
