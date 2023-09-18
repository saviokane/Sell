using _C____ProjetoVendas.Controller;
using _C____ProjetoVendas.Model;
using _C____ProjetoVendas.View;

internal class Program
{
    static void Main(string[] args)
    {

        Funcionario func = new();
       
        func.Nome = "Savio";
        func.Cpf = "1111";
        func.Idade = 20;
        ControllerFuncionario.funcionarios.Add(func);

        TelaPrincipal.Home();


    }

 
}
