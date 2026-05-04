using System;
using System.Collections.Generic;

class Livro
{
    public string Titulo;
    public string Autor;
    public int AnoPublicacao;
    public bool Disponivel;

    public Livro()
    {
        Disponivel = true;
    }

    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = ano;
        Disponivel = true;
    }

    public void ExibirDetalhes()
    {
        string status = Disponivel ? "Disponível" : "Emprestado";
        Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Ano: {AnoPublicacao} | Situação: {status}");
    }

    public void Emprestar()
    {
        Disponivel = false;
    }
}
class Aluno
{
    public string Nome;
    public string Matricula;
    public string Turma;

    public Aluno() { }

    public Aluno(string nome, string matricula, string turma)
    {
        Nome = nome;
        Matricula = matricula;
        Turma = turma;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome} | Matrícula: {Matricula} | Turma: {Turma}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Livro> livros = new List<Livro>();

        Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
        Livro livro2 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943);

        Livro livro3 = new Livro();
        livro3.Titulo = "1984";
        livro3.Autor = "George Orwell";
        livro3.AnoPublicacao = 1949;

        livros.Add(livro1);
        livros.Add(livro2);
        livros.Add(livro3);

        Aluno aluno1 = new Aluno("Ana Souza", "2026001", "Informática");

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Carlos Lima";
        aluno2.Matricula = "2026002";
        aluno2.Turma = "Informática";

        livro2.Emprestar();
        Console.WriteLine("LISTA DE LIVROS CADASTRADOS");
        foreach (Livro livro in livros)
        {
            livro.ExibirDetalhes();
        }

        Console.WriteLine("\nALUNO RESPONSÁVEL PELO EMPRÉSTIMO");
        aluno1.ExibirDados();
    }
}