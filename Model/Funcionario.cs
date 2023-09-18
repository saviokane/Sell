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
        // Futuramente limitar a 11 digitos o cpf
        private string _cpf;
        private int _idade;

        public string Nome { get; set; }
        public string Cpf { get; set; } 
        public int Idade { get; set; }
        public List<Funcionario> List { get; set; }
        public  Funcionario()
        {
            _nome = null;
            _cpf = null;
            _idade = 0;
            
        }
    }
}
