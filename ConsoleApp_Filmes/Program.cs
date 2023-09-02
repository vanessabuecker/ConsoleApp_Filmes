using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Filmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> filmesSelecionados = new List<string>();
            bool mostrarMenu = true;

            while (mostrarMenu)
            {
                mostrarMenu = MenuPrincipal(filmesSelecionados);
            }
        }
        private static bool MenuPrincipal(List<string> filmesSelecionados)
        {
            Console.Clear();
            Console.WriteLine("Escolha um gênero de filme: ");
            Console.WriteLine("1) Ação");
            Console.WriteLine("2) Terror");
            Console.WriteLine("3) Comédia");
            Console.WriteLine("4) Drama");
            Console.WriteLine("5) Animação");
            Console.WriteLine("6) Ver meus filmes assistidos");
            Console.WriteLine("7) Sair");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\nSELECIONE UMA OPÇÃO");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Opção selecionada: ");
            Console.ResetColor();

            switch (Console.ReadLine())
            {
                case "1":
                    ExibirAcao(filmesSelecionados);
                    return true;

                case "2":
                    ExibirTerror(filmesSelecionados);
                    return true;

                case "3":
                    ExibirComedia(filmesSelecionados);
                    return true;

                case "4":
                    ExibirDrama(filmesSelecionados);
                    return true;

                case "5":
                    ExibirAnimacao(filmesSelecionados);
                    return true;

                case "6":
                    Console.WriteLine();
                    FilmesAssistidos(filmesSelecionados);
                    return true;

                case "7":
                    return false;
                default: return true;
            }
        }
        private static void ExibirComedia(List<string> filmesSelecionados)
        {
            Console.WriteLine("FILMES DE COMÉDIA");

            Console.WriteLine("\r\nQual filme deseja assistir? ");


            Console.WriteLine("\r\n1) Todo mundo em pânico I");
            Console.WriteLine("2) O Peso do Talento");
            Console.WriteLine("3) O Homem de Toronto");
            Console.WriteLine("4) Shiva Baby");
            Console.WriteLine("5) Free Guy - Assumindo o Controle");
            Console.WriteLine("6) De Férias da Família");
            Console.WriteLine("7) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    filmesSelecionados.Add($"Todo mundo em pânico I - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "2":
                    filmesSelecionados.Add($"O Peso do Talento Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "3":
                    filmesSelecionados.Add($"O Homem de Toronto Data:{DateTime.Now} ");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "4":
                    filmesSelecionados.Add($"Shiva Baby Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "5":
                    filmesSelecionados.Add($"Free Guy - Assumindo o Controle Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "6":
                    filmesSelecionados.Add($"De Férias da Família Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "7":
                    Console.WriteLine("Digite o nome do filme: ");
                    string novoFilme = Console.ReadLine();
                    filmesSelecionados.Add(novoFilme);
                    Console.WriteLine($"Filme '{novoFilme}' cadastrado com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                default:
                    Console.WriteLine("\r\nOpção escolhida inválida. Tente novamente.");
                    Console.ReadLine();
                    break;
            }

            Console.ReadLine();
        }
        private static void ExibirAcao(List<string> filmesSelecionados)
        {
            Console.WriteLine("FILMES DE COMÉDIA");

            Console.WriteLine("\r\nQual filme deseja assistir? ");

            Console.WriteLine("\r\n1) Sr e Sra Smith");
            Console.WriteLine("2) Viúva Negra");
            Console.WriteLine("3) Batman - O Cavaleiro Das Trevas");
            Console.WriteLine("4) Vingadores: Ultimato");
            Console.WriteLine("5) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    filmesSelecionados.Add($"Sr e Sra Smith - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "2":
                    filmesSelecionados.Add($"Viúva Negra - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "3":
                    filmesSelecionados.Add($"Batman - O Cavaleiro Das Trevas - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "4":
                    filmesSelecionados.Add($"Vingadores: Ultimato - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "5":
                    Console.WriteLine("Digite o nome do filme: ");
                    string novoFilme = Console.ReadLine();
                    filmesSelecionados.Add(novoFilme);
                    Console.WriteLine($"Filme '{novoFilme}' cadastrado com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                default:
                    Console.WriteLine("Opção escolhida inválida. Tente novamente.");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
        private static void ExibirTerror(List<string> filmesSelecionados)
        {
            Console.WriteLine("FILMES DE COMÉDIA");

            Console.WriteLine("\r\nQual filme deseja assistir? ");

            Console.WriteLine("1) Premonição");
            Console.WriteLine("2) Não! Não Olhe!");
            Console.WriteLine("3) Sorria");
            Console.WriteLine("4) O Telefone Preto");
            Console.WriteLine("5) Os Inocentes");
            Console.WriteLine("6) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    filmesSelecionados.Add($"Premonição - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "2":
                    filmesSelecionados.Add($"Não! Não Olhe! - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "3":
                    filmesSelecionados.Add($"Sorria - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "4":
                    filmesSelecionados.Add($"O Telefone Preto - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "5":
                    filmesSelecionados.Add($"s Inocentes - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "6":
                    Console.WriteLine("\r\nDigite o nome do filme: ");
                    string novoFilme = Console.ReadLine();
                    filmesSelecionados.Add(novoFilme);
                    Console.WriteLine($"\r\nFilme '{novoFilme}' cadastrado com sucesso.");
                    break;

                default:
                    Console.WriteLine("Opção escolhida inválida. Tente novamente.");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
        private static void ExibirDrama(List<string> filmesSelecionados)
        {
            Console.WriteLine("FILMES DE COMÉDIA");

            Console.WriteLine("\r\nQual filme deseja assistir? ");

            Console.WriteLine("1) Éramos seis");
            Console.WriteLine("2) O Poderoso Chefão");
            Console.WriteLine("3) Um Sonho de Liberdade");
            Console.WriteLine("4) A Lista de Schindler");
            Console.WriteLine("5) Forrest Gump - O Contador de Histórias");
            Console.WriteLine("6) À Espera de um Milagre");
            Console.WriteLine("7) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    filmesSelecionados.Add($"Éramos seis - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "2":
                    filmesSelecionados.Add($"O Poderoso Chefão - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "3":
                    filmesSelecionados.Add($"Um Sonho de Liberdade - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "4":
                    filmesSelecionados.Add($"A Lista de Schindler - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "5":
                    filmesSelecionados.Add($"Forrest Gump - O Contador de Histórias - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "6":
                    filmesSelecionados.Add($"À Espera de um Milagre - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "7":
                    Console.WriteLine("\r\nDigite o nome do filme: ");
                    string novoFilme = Console.ReadLine();
                    filmesSelecionados.Add(novoFilme);
                    Console.WriteLine($"\r\nFilme '{novoFilme}' cadastrado com sucesso.");
                    break;

                default:
                    Console.WriteLine("Opção escolhida inválida. Tente novamente.");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
        private static void ExibirAnimacao(List<string> filmesSelecionados)
        {
            Console.WriteLine("FILMES DE COMÉDIA");

            Console.WriteLine("\r\nQual filme deseja assistir? ");

            Console.WriteLine("1) Meu amigãozão");
            Console.WriteLine("2) Franquia Gato de Botas");
            Console.WriteLine("3) Red: Crescer É uma Fera");
            Console.WriteLine("4) Pinóquio");
            Console.WriteLine("5) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    filmesSelecionados.Add($"Meu amigãozão - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "2":
                    filmesSelecionados.Add($"Franquia Gato de Botas - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "3":
                    filmesSelecionados.Add($"Red: Crescer É uma Fera - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "4":
                    filmesSelecionados.Add($"Pinóquio - Data: {DateTime.Now}");
                    Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
                    break;

                case "5":
                    Console.WriteLine("\r\nDigite o nome do filme: ");
                    string novoFilme = Console.ReadLine();
                    filmesSelecionados.Add(novoFilme);
                    Console.WriteLine($"\r\nFilme '{novoFilme}' cadastrado com sucesso.");
                    break;

                default:
                    Console.WriteLine("Opção escolhida inválida. Tente novamente.");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
        private static void FilmesAssistidos(List<string> filmesSelecionados)
        {
            Console.WriteLine("Lista de filmes já assistidos: ");
            Console.WriteLine();

            if (filmesSelecionados.Count == 0)
            {
                Console.WriteLine("Você ainda não assistiu nenhum filme.");
            }
            else
            {
                foreach (var filmes in filmesSelecionados)
                {
                    Console.WriteLine($"{filmes}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\nPressione Enter para continuar");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
}
