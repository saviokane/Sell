using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using _C____ProjetoVendas.Controller;

namespace _C____ProjetoVendas.View
{
    internal class TelaPrincipal
    {

        public static void Home()
        {

            Console.WriteLine("=== BEM VINDO A TELA PRINCIPAL ===");

            Console.WriteLine("Escolha uma opção abaixo: ");
            Console.WriteLine("[1] Cadastro");
            Console.WriteLine("[2] Listar");
            Console.WriteLine("[3] Deletar");
            Console.WriteLine("[4] Alterar");
            String escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Controller.ControllerFuncionario.Cadastro();
                    break;
                case "2":
                    Controller.ControllerFuncionario.Listar();
                    break;
                case "3":
                    Controller.ControllerFuncionario.Demitir();
                    break;
                case "4":
                    Controller.ControllerFuncionario.Alterar();
                    break;  
            }

        }
    }
}

