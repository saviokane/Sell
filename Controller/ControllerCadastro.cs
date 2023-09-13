using _C____ProjetoVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C____ProjetoVendas.Controller
{
    internal class ControllerCadastro
    {
        public static void Cadastro() { 

        List<Funcionario> funcionarios = new List<Funcionario>();

        Funcionario funcionario = new Funcionario();
        Funcionario defaults = new Funcionario("Savio", 111111111, 12);

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        funcionario.Nome = nome;

        
        funcionarios.Add(defaults);

        
        for(int i = 0; i<funcionarios.Count; i++)
        {
            Console.WriteLine("Dados do funcionario");
            Console.WriteLine("Nome: " + funcionario.Nome);
        }
    }
}
}
