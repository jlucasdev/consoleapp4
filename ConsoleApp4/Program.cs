using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        private static bool linha;

        //PacelCase
        //camelCase
        //under_line

        public static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("ola pessoal");
        }

        public static void Tabuada(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("=================");
        }

        private static void LerArquivo(string nomeArquivo)
        {
            using (StreamReader aquivo = File.OpenText(nomeArquivo))
            {
                string linha;
                while ((linha = aquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }

        static void Main(string[] args)
        {
            LerArquivo(@"E:\arquivo\arq1.txt");
        }
    }
}
