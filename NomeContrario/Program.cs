using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeContrario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
                                    
            Console.Write("Digite seu nome aqui: ");
            nome = Console.ReadLine().ToUpper();
            
            string invertido = new string(nome.Reverse().ToArray());
                                    
            Console.WriteLine("Seu nome invertido é: " + invertido);

            
            Console.ReadLine();

        }
    }
}
