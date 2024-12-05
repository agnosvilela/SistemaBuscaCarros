using BUSCARROS;
using System;

class Program
{
    static void Main(string[] args)
    {
        IAutomovelDAO automovelDAO = new AutomovelDapImplementa();

        Console.WriteLine("Cadastro de Automóvel");

        // Solicitar dados do usuário
        Console.Write("Digite o ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Digite o Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Digite o Ano: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a Cor: ");
        string cor = Console.ReadLine();

        // Criar o objeto Automovel com os dados inseridos pelo usuário
        Automovel novoAutomovel = new Automovel
        {
            Id = id,
            Marca = marca,
            Modelo = modelo,
            Ano = ano,
            Cor = cor
        };

        // Inserir o automóvel no banco de dados
        automovelDAO.inserir(novoAutomovel);
        Console.WriteLine("Automóvel cadastrado com sucesso!");


        // Buscar o automóvel por modelo
        Console.Write("Digite o Modelo para buscar: ");
        string modeloBusca = Console.ReadLine();
        Automovel automovelBuscado = automovelDAO.buscarPorModelo(modeloBusca);
        if (automovelBuscado != null)
        {
            Console.WriteLine($"ID: {automovelBuscado.Id}, Marca: {automovelBuscado.Marca}, Modelo: {automovelBuscado.Modelo}, Ano: {automovelBuscado.Ano}, Cor: {automovelBuscado.Cor}");
        }
        else
        {
            Console.WriteLine("Automóvel não encontrado.");
        }

    }
}
