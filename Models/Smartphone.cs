using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTelefone.Models
{
    public abstract class Smartphone
    {
        protected int Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
        public Smartphone(int numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void MostrarDadosDoTelefone()
        {
            Console.WriteLine($"Número do Smarphone: {Numero}");
            Console.WriteLine($"Modelo do Smarphone: {Modelo}");
            Console.WriteLine($"IMEI do Smarphone: {IMEI}");
            Console.WriteLine($"Memória do Smarphone: {Memoria}");
        }

        public void Ligar()
        {
            Console.WriteLine("Você está ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Você está recebendo uma ligação...");
        }
        public abstract void InstalarAplicativo(string aplicativo);
    }
}