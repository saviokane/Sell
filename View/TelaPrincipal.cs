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
            String escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Controller.ControllerCadastro();
                    break;
                case "2":
                    Console.WriteLine("111");
                    // Tela de alteração
                    break;

            }

        }
    }
}

