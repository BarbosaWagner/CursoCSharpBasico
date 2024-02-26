// Aula 3: Variáveis

// Tipos primitivos: https://www.alura.com.br/apostila-csharp-orientacao-objetos/variaveis-e-tipos-primitivos

// Principais tipos de dados.
using Newtonsoft.Json;

var indicaClienteAtivo = true;
var idade = 28;
var valorTotal = 10.5;
var letra = 'a';
var nome = "Lucas Fábio";
DateTime? data = DateTime.Now;

// camelCase
// PascalCase


// Exemplo de sistema de venda com 2 classes (Cliente e Venda).
/*
Sistema.ExecutarVenda();

public class Venda
{
    public int Id { get; set; }
    public int IdCliente { get; set; }
    public double ValorTotal { get; set; }
    public DateTime DataHora { get; set; }
}

public class Cliente
{
    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public int Id { get; set; }
    public string Nome { get; }
    public DateTime Nascimento { get; set; }
    public string Cpf { get; }
}

public class Sistema
{
    public static void ExecutarVenda()
    {
        // Cadastrar cliente.
        var cliente1 = new Cliente("", "091.481.777-77")
        {
            Id = 1,
            Nascimento = new DateTime(1966, 10, 3)
        };

        // Gerar uma venda.
        var venda1 = new Venda
        {
            Id = 1,
            IdCliente = cliente1.Id,
            DataHora = DateTime.Now,
            ValorTotal = 106.41
        };




        // Imprimir a venda.
        var jsonVenda = JsonConvert.SerializeObject(venda1);
        Console.WriteLine(jsonVenda);
    }
}
*/

