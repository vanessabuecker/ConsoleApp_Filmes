using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp_Filmes
{
    internal class Program
    {
        static string nome = "";
        static void Main(string[] args)
        {
            List<string> filmesSelecionados = new List<string>();
            List<string> filmesDesejados = new List<string>();
            
            if (File.Exists("nome.txt"))
            {
                nome = File.ReadAllText("nome.txt");
            }
            else
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();
                File.WriteAllText("nome.txt", nome);
            }
            bool mostrarMenu = true;
            while (mostrarMenu)

            {
                mostrarMenu = MenuPrincipal(filmesSelecionados);
            }
        }
        private static bool MenuPrincipal(List<string> filmesSelecionados)
        {
            Console.Clear();
            Console.WriteLine($"Ola, {nome}. Escolha um gênero de filme: ");
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
        private static void AdicionarFilme(List<string> filmesSelecionados, string nomeFilme)
        {
            Console.WriteLine($"Você já assistiu a este filme? Digite 'S' para SIM e 'N' para NAO");
            string assistiuFilme = Console.ReadLine().ToUpper();
            if (assistiuFilme.Contains("S"))
            {
                Console.WriteLine("Digite a data em que assistiu a este filme.");
                string dataFilmeAssistido = Console.ReadLine();
                filmesSelecionados.Add($"{nomeFilme}  \r\nData de cadastro: {DateTime.Now} \r\n Assistido dia: {dataFilmeAssistido} ");
            }
            else if (assistiuFilme.Contains("N"))
            {
                filmesSelecionados.Add($"{nomeFilme}  \r\nData de cadastro: {DateTime.Now} \r\n Assistido dia: Não assistido. ");
            }

            Console.WriteLine("Filme adicionado à lista com sucesso! Pessione Enter para retornar ao Menu.");
        }
        private static void CadastrarNovoFilme(List<string>filmesSelecionados)
        {
            Console.WriteLine("Escolha o tipo de entretenimento que deseja cadastrar");

            Console.WriteLine("1) Filme");
            Console.WriteLine("2) Seriado");
            Console.WriteLine("3) Documentario");
            string tipoEntretenimento = Console.ReadLine();

            switch (tipoEntretenimento)
            {
                case "1":
                    CadastrarFilme(filmesSelecionados);
                    break;

                case "2":
                    CadastrarSeriado(filmesSelecionados);
                    break;

                case "3":
                   CadastrarDocumentario(filmesSelecionados);
                    break;
            }
        }
        private static void CadastrarSeriado(List<string> filmesSelecionados)
        {
            Console.WriteLine("Digite o nome do seriado que deseja adicionar");
            string novofilme = Console.ReadLine();

            Console.WriteLine("Qual o dia, mês e ano você assistiu a este seriado?");
            string dataFilmeAssistido = Console.ReadLine();

            int nota;
            while (true)
            {
                Console.WriteLine("O que achou do filme? Digite uma nota de 0 a 5");
                if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um valor válido para a nota (0 a 5).");
                }
            }

            filmesSelecionados.Add($"Tipo de entretenimento: Filme\r\nNome: {novofilme}\r\nNota: {nota}\r\nData de cadastro: {DateTime.Now}\r\nAssistido dia: {dataFilmeAssistido}");
            Console.WriteLine($"O filme '{novofilme}' foi cadastrado com sucesso! Pressione Enter para retornar ao Menu.");
        }
        private static void CadastrarFilme(List<string> filmesSelecionados)
        {
            Console.WriteLine("Digite o nome do filme que deseja adicionar");
            string novofilme = Console.ReadLine();

            Console.WriteLine("Qual o dia, mês e ano você assistiu a este filme?");
            string dataFilmeAssistido = Console.ReadLine();

            Console.WriteLine("O que achou do filme? Digite uma nota de 0 a 5");
            int nota = int.Parse(Console.ReadLine());
            if (nota < 0 || nota > 5)
            {
                Console.WriteLine("Digite um valor válido");
            }
            else
            {
                filmesSelecionados.Add($"Tipo de entretenimento: Filme \r\n Nome: {novofilme} \r\n Nota: {nota} \r\n Data de cadastro: {DateTime.Now}\r\n Assistido dia: {dataFilmeAssistido}");
                Console.WriteLine($"o filme '{novofilme}' foi cadastrado com sucesso! Pessione Enter para retornar ao Menu.");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        private static void CadastrarDocumentario(List<string> filmesSelecionados)
        {
            Console.WriteLine("Digite o nome do documentário que deseja adicionar");
            string novofilme = Console.ReadLine();

            Console.WriteLine("Qual o dia, mês e ano você assistiu a este documentário?");
            string dataFilmeAssistido = Console.ReadLine();

            Console.WriteLine("O que achou do documentário? Digite uma nota de 0 a 5");
            int nota = int.Parse(Console.ReadLine());
            if (nota < 0 || nota > 5)
            {
                Console.WriteLine("Digite um valor válido");
            }
            else
            {
                filmesSelecionados.Add($"Tipo de entretenimento: Documentário \r\n Nome: {novofilme} \r\n Nota: {nota} \r\n Data de cadastro: {DateTime.Now}\r\n Assistido dia: {dataFilmeAssistido}");
                Console.WriteLine($"o documentário '{novofilme}' foi cadastrado com sucesso! Pessione Enter para retornar ao Menu.");
                Console.WriteLine();
            }
            Console.ReadLine();
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
                    AdicionarFilme(filmesSelecionados, "Todo mundo em pânico I");
                    break;

                case "2":
                    AdicionarFilme(filmesSelecionados, "O Peso do Talento");
                    break;

                case "3":
                    AdicionarFilme(filmesSelecionados, "O Homem de Toronto");
                    break;

                case "4":
                    AdicionarFilme(filmesSelecionados, "Shiva Baby");
                    break;

                case "5":
                    AdicionarFilme(filmesSelecionados, "Free Guy - Assumindo o Controle");
                    break;

                case "6":
                    AdicionarFilme(filmesSelecionados, "De Férias da Família");
                    break;

                case "7":
                    CadastrarNovoFilme(filmesSelecionados);
                    break;

                default:
                    Console.WriteLine("Opção escolhida inválida. Tente novamente.");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
        private static void ExibirAcao(List<string> filmesSelecionados)
        {
            Console.WriteLine("FILMES DE AÇÃO");

            Console.WriteLine($"\r\n{nome}, Qual filme deseja assistir? ");

            Console.WriteLine("\r\n1) Sr e Sra Smith");
            Console.WriteLine("2) Viúva Negra");
            Console.WriteLine("3) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    AdicionarFilme(filmesSelecionados, "Sr e Sra Smith");
                    break;

                case "2":
                    AdicionarFilme(filmesSelecionados, "Viúva Negra");
                    break;

                case "3":
                    CadastrarNovoFilme(filmesSelecionados);
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
            Console.WriteLine("FILMES DE TERROR");

            Console.WriteLine("\r\nQual filme deseja assistir? ");

            Console.WriteLine("1) Premonição");
            Console.WriteLine("2) Não! Não Olhe!");
            Console.WriteLine("3) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    AdicionarFilme(filmesSelecionados, "Premoniçã");
                    break;

                case "2":
                    AdicionarFilme(filmesSelecionados, " Não! Não Olhe!");
                    break;

                case "3":
                    CadastrarNovoFilme(filmesSelecionados);
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
            Console.WriteLine("FILMES DE DRAMA");

            Console.WriteLine("\r\nQual filme deseja assistir? ");

            Console.WriteLine("1) Éramos seis");
            Console.WriteLine("2) O Poderoso Chefão");
            Console.WriteLine("3) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    AdicionarFilme(filmesSelecionados, "Éramos seis");
                    break;

                case "2":
                    AdicionarFilme(filmesSelecionados, "O Poderoso Chefão");
                    break;

                case "3":
                    CadastrarNovoFilme(filmesSelecionados);
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
            Console.WriteLine("FILMES DE ANIMAÇÃO");

            Console.WriteLine("\r\nQual filme deseja assistir? ");

            Console.WriteLine("1) Meu amigãozão");
            Console.WriteLine("2) Franquia Gato de Botas");
            Console.WriteLine("3) Cadastrar um novo filme");

            switch (Console.ReadLine())
            {
                case "1":
                    AdicionarFilme(filmesSelecionados, "Meu amigãozão");
                    break;

                case "2":
                    AdicionarFilme(filmesSelecionados, "Franquia Gato de Botas");
                    break;

                case "3":
                    CadastrarNovoFilme(filmesSelecionados);
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
            Console.WriteLine($"Olá {nome}! Aqui está sua Lista de filmes já assistidos! :)  ");
            Console.WriteLine();

            if (filmesSelecionados.Count == 0)
            {
                Console.WriteLine($"{nome}, você ainda não assistiu a nenhum filme.");
            }
            else
            {
                foreach (var filmes in filmesSelecionados)
                {
                    Console.WriteLine($"\r\n{filmes}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\nPressione Enter para continuar");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}

