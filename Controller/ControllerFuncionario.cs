using _C____ProjetoVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C____ProjetoVendas.Controller
{
    internal class ControllerFuncionario
    {   
        public static List<Funcionario> funcionarios = new List<Funcionario>();
        public static void Cadastro() { 

        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        funcionario.Nome = nome;

        Console.WriteLine("Digite seu CPF: ");
        string cpf = Console.ReadLine();
        funcionario.Cpf = cpf;

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        funcionario.Idade = idade;

        funcionarios.Add(funcionario);


        Console.WriteLine("Funcionario "+funcionario.Nome+" registrado !!!");
            View.TelaPrincipal.Home();
    }

    public static void Listar()
        {
         
            foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine("Dados do funcionário");
                    Console.WriteLine("Nome: " + funcionario.Nome);
                    Console.WriteLine("CPF: " + funcionario.Cpf);
                    Console.WriteLine("Idade: " + funcionario.Idade);
                    Console.WriteLine();

                }
        }

        public static void Demitir() 
        {
            Controller.ControllerFuncionario.Listar();

            Console.WriteLine("Qual funcionario deseja demitir ? (CPF)");
            string cpf = Console.ReadLine();

            foreach(var funcionario in funcionarios)
            {
                if (funcionario.Cpf == cpf)
                {
                    funcionarios.Remove(funcionario);
                    Console.WriteLine("Funcionario demitido "+funcionario.Nome+" !!!");
                    View.TelaPrincipal.Home();
                }
                else
                {
                    Console.WriteLine("Funcionario não encontrado");
                    View.TelaPrincipal.Home();
                }

            }

        }

        public static void Alterar()
        {
            Controller.ControllerFuncionario.Listar();

            Console.WriteLine("Qual funcionario deseja alterar ? (CPF)");
            string cpf = Console.ReadLine();

            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Cpf == cpf)
                {
                    Console.WriteLine("Digite seu nome: ");
                    string nome = Console.ReadLine();
                    funcionario.Nome = nome;

                    Console.WriteLine("Digite seu CPF: ");
                    string ncpf = Console.ReadLine();
                    funcionario.Cpf = ncpf;

                    Console.WriteLine("Digite sua idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    funcionario.Nome = nome;
                    funcionario.Cpf = ncpf;
                    funcionario.Idade = idade;

                    Console.WriteLine("Dados atualizados !!!!");

                    View.TelaPrincipal.Home();
                }
                else
                {
                    Console.WriteLine("Funcionario não encontrado");
                    View.TelaPrincipal.Home();
                }

            }

        }
    }
}
