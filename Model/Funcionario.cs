using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C____ProjetoVendas.Model
{
    internal class Funcionario
    {
        private string _nome;
        [MaxLength(11)]
        private int _cpf;
        private int _idade;

        public string Nome { get; set; }
        public int Cpf { get; set; } 
        public int Idade { get; set; }
        public List<Funcionario> List { get; set; }
        public  Funcionario()
        {
            _nome = null;
            _cpf = 0;
            _idade = 0;
            
        }

        public Funcionario(string _nome, int _cpf, int _idade)
        {
            Nome = _nome;
            Cpf = _cpf;
            Idade = _idade;
        }



    }
}
