using _C____ProjetoVendas.Model;

internal class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        
        Funcionario funcionario = new Funcionario();
        Funcionario defaults = new Funcionario("Savio",111111111,12);

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        funcionario.Nome = nome;

        
        funcionarios.Add(defaults);

        
        for(int i = 0; i < funcionarios.Count; i++)
        {
            Console.WriteLine("Dados do funcionario");
            Console.WriteLine("Nome: " + funcionario.Nome);
        }



    }
}
