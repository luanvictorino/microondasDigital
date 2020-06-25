using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Models
{
    public class ProgramasAquecimento
    {
        private string _nome;
        private string _tempo;
        private int _potencia;
        private char _caracter;
        private string _instrucoes;

        public ProgramasAquecimento()
        {

        }

        public ProgramasAquecimento(string nome, string tempo, int potencia, char caracter, string instrucoes)
        {
            Nome = nome;
            Tempo = tempo;
            Potencia = potencia;
            Caracter = caracter;
            Instrucoes = instrucoes;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Tempo { get => _tempo; set => _tempo = value; }
        public int Potencia { get => _potencia; set => _potencia = value; }
        public char Caracter { get => _caracter; set => _caracter = value; }
        public string Instrucoes { get => _instrucoes; set => _instrucoes = value; }
    }
}
