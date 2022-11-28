using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstacionamento
{
    internal class Estacionamento
    {
        public string NomeDono { get; set; }
        public string DocumentoDono { get; private set; }
        public string Modelo { get; set; }
        public string Placa { get; private set; }
        
        public Estacionamento(string nomedono, string documentodono, string modelo, string placa )
        {
            NomeDono = nomedono;
            DocumentoDono = documentodono;
            Modelo = modelo;
            Placa = placa;
        }

        public override string ToString()
        {
            return " Nome: " + NomeDono +
                   " Documento: " + DocumentoDono +
                   " Modelo: " + Modelo + 
                   " Placa: " + Placa;
        }
    }
}
