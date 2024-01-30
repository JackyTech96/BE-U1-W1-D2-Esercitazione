using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D2_Esercitazione
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }

        public Persona(string nome, string cognome, int età) 
        {
            Nome = nome;
            Cognome = cognome;
            Età = età;
        }

        public string GetNome()
        {
            return Nome;
        }

        /*public void GetNome()
        {
        Console.WriteLine("Inserisci il nome della persona: ");
        Nome=Console.ReadLine();
        }
        */

        public string GetCognome()
        {
            return Cognome;
        }

        /* public void GetCognome()
       {
       Console.WriteLine("Inserisci il cognome della persona: ");
       Cognome=Console.ReadLine();
       }
       */

        public int GetEtà()
        {
            return Età;
        }

        /* public void GetEtà()
       {
       Console.WriteLine("Inserisci l'età della persona: ");
       Età=Console.ReadLine();
       }
       */

        public string GetDettagli() 
        { 
            return Nome + " " + Cognome + " " + Età;
        }
    }
}
