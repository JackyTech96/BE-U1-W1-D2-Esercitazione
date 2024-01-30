using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D2_Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Luca", "Rossi", 27);
            /* persona1.Nome = "Luca";
            persona1.Cognome = "Rossi";
            persona1.Età = 27;*/
            Console.WriteLine("Nome: " + persona1.GetNome());
            Console.WriteLine("Cognome: " + persona1.GetCognome());
            Console.WriteLine("Età: " + persona1.GetEtà());

            Console.WriteLine("\n");

            Console.WriteLine("Dettagli persona: " + persona1.GetDettagli());
            Console.ReadLine();
        }
    }
}
