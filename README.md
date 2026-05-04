# Programa-feito-na-aula-da-carol
# 📚 ControleBiblioteca

## 📌 Descrição

O projeto **ControleBiblioteca** é uma aplicação de console desenvolvida em C# com o objetivo de simular um sistema simples de cadastro de livros e alunos, além de realizar o controle de empréstimos.

Este projeto foi desenvolvido como atividade prática para aplicar os conceitos de **Programação Orientada a Objetos (POO)**.

---

## 🎯 Objetivo

* Organizar o cadastro de livros
* Registrar alunos
* Simular o empréstimo de livros
* Exibir informações no console

---

## 🧠 Conceitos aplicados

* Classes e Objetos
* Atributos
* Métodos
* Construtores (padrão e com parâmetros)
* Listas (`List<T>`)

---

## 🏗️ Estrutura do Projeto

### Classe Livro

Responsável por representar um livro no sistema.

**Atributos:**

* Titulo
* Autor
* AnoPublicacao
* Disponivel

**Métodos:**

* `ExibirDetalhes()` → Exibe as informações do livro
* `Emprestar()` → Altera o status para emprestado

---

### Classe Aluno

Representa um aluno que pode realizar empréstimos.

**Atributos:**

* Nome
* Matricula
* Turma

**Métodos:**

* `ExibirDados()` → Exibe os dados do aluno

---

## ⚙️ Funcionalidades

* Cadastro de livros
* Cadastro de alunos
* Listagem de livros
* Simulação de empréstimo
* Exibição de dados no console

---

## ▶️ Como executar

1. Abra o projeto no **Visual Studio**
2. Compile o projeto
3. Execute a aplicação
4. O console exibirá:

   * Lista de livros cadastrados
   * Situação dos livros (disponível ou emprestado)
   * Dados do aluno

---

## 💻 Exemplo de saída

```
LISTA DE LIVROS CADASTRADOS
Título: Dom Casmurro | Autor: Machado de Assis | Ano: 1899 | Situação: Disponível
Título: O Pequeno Príncipe | Autor: Antoine de Saint-Exupéry | Ano: 1943 | Situação: Emprestado

ALUNO RESPONSÁVEL PELO EMPRÉSTIMO
Nome: Ana Souza | Matrícula: 2026001 | Turma: Informática
```

---

## 📦 Tecnologias utilizadas

* C#
* .NET (Console Application)
* Visual Studio

---

## 📚 Conclusão

O projeto demonstra na prática a aplicação dos principais conceitos de Programação Orientada a Objetos, permitindo representar elementos do mundo real (livros e alunos) através de classes e objetos, além de simular operações como empréstimos de forma simples e eficiente.

---
