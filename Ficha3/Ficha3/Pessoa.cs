using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    class Pessoa
    {
        string Nome;
        DateTime Data_de_Nascimento;
        string Morada;
        int pontuacao;

        public Pessoa(string nome, DateTime data_de_nascimento, string morada)
        {
            this.Nome = nome;
            this.Data_de_Nascimento = data_de_nascimento;
            this.Morada = morada;
            this.pontuacao = 0;
        }
        public int Idade()
        {
            int idade = DateTime.Now.Year - this.Data_de_Nascimento.Year;
            if(DateTime.Now.DayOfYear < Data_de_Nascimento.DayOfYear)
            {
                idade--;    
            }
            return idade;
        }
        public void Pontuar(int pontos)
        {
            this.pontuacao += pontos;
        }
        public override string ToString()
        {
            return $"{Nome} ({Idade()} anos): {this.pontuacao}";
        }

    }
}
