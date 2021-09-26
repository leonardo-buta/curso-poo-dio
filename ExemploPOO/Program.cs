using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstração
            Pessoa p1 = new Pessoa();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar();

            // Encapsulamento - valores inválidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 0);
            System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Encapsulamento - valores validos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);
            System.Console.WriteLine($"Área: {r.ObterArea()}");

            // Herança e polimorfismo com a classe professor, através da sobrescrita de métodos
            // (Early Binding)
            Professor p2 = new Professor();
            p2.Nome = "Leo";
            p2.Idade = 20;
            p2.Documento = "123456";
            p2.Salario = 1000;
            p2.Apresentar();

            // Herança e polimorfismo com a classe aluno, através da sobrescrita de métodos
            // (Late Binding)
            Aluno aluno = new Aluno();
            aluno.Nome = "Bob";
            aluno.Idade = 20;
            aluno.Documento = "123456";
            aluno.Nota = 10;
            aluno.Apresentar();

            // Polimorfismo com construtores (Early Binding)
            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

            // Herança com classe abstrata
            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();

            // Utilizando interfaces
            ICalculadora calcInterface = new Calculadora();
            System.Console.WriteLine(calcInterface.Somar(10, 20));

            // Definição de caminhos para trabalharmos com arquivos
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

            // Linhas para serem escritas no arquivo
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            // Operações com arquivos utilizando o nosso FileHelper
            FileHelper helper = new FileHelper(caminho);
            helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);
            helper.CriarDiretorio(caminhoPathCombine);
            helper.ApagarDiretorio(caminhoPathCombine, true);
            helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            helper.LerArquivoStream(caminhoArquivo);
            helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
        }
    }
}
