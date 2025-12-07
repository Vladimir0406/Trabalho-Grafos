/*
Objetivo
Implementar e testar os principais algoritmos clássicos de grafos estudados na disciplina,
demonstrando domínio conceitual e prático sobre suas aplicações.

Descrição Geral
Cada grupo deverá desenvolver um Sistema de Análise de Grafos, capaz de:
Representar o grafo
    • A partir de lista de arestas, lista de adjacência ou matriz de adjacência.
    • O grafo deve ser ponderado e não direcionado.

Executar os seguintes algoritmos:
    • Travessia em Profundidade (DFS)
    • Travessia em Amplitude (BFS)
    • Dijkstra – menor caminho entre dois vértices
    • Prim ou Kruskal – árvore geradora mínima

Relatório Técnico (entregue junto com o código)
O grupo deverá elaborar um relatório em PDF contendo:
    Capa: título do trabalho, nomes dos integrantes, turma e data.
    Introdução: breve descrição do que foi implementado e objetivos.
    Descrição dos algoritmos: resumo teórico e função de cada algoritmo.
    Explicação dos principais trechos de código (em linguagem natural, com comentários
    curtos).

Execução prática:
o Capturas de tela (prints) mostrando cada algoritmo em execução.
o Indicação clara dos resultados obtidos.
Conclusão: principais aprendizados e dificuldades encontradas.
*/
using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using System.Xml.XPath;
class Program
{
    static void Main(string[] args)
    {
        OperacoesGrafos operacoes = new();

        int[,] grafo = { { 0, 1 }, { 1, 0 } };
        int[,] grafo2 = { { 0, 7 }, { 7, 0 } };
        int[,] grafo3 = { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } };

        operacoes.ListaGrafos.Add(grafo);
        operacoes.ListaGrafos.Add(grafo2);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo2);
        operacoes.ListaGrafos.Add(grafo2);
        operacoes.ListaGrafos.Add(grafo2);

        Menu Inicializador = new();

        Inicializador.MenuPrincipal(operacoes);

    }
}
class Menu
{
    public void MenuPrincipal(OperacoesGrafos operacoes) // Menu que controla o fluxo do programa entre criar grafos e usar algoritmos
    {
        int opcao = 0;

        do
        {
            Console.Clear();

            Console.WriteLine("===============================");
            Console.WriteLine("          nome sistema         ");
            Console.WriteLine("===============================");
            Console.WriteLine("    1 - Manipular Grafos       ");
            Console.WriteLine("    2 - Ultilizar Algoritmos   ");
            Console.WriteLine("    3 - Finalizar programa     ");
            Console.WriteLine("===============================\n");
            Console.Write("   ");

            if (int.TryParse(Console.ReadLine(), out opcao)) // Filtro para receber apenas int
                switch (opcao)
                {
                    case 1:
                        MenuGrafos(operacoes);
                        break;
                    case 2:
                        MenuAlgoritmos(operacoes);
                        break;
                    case 3:
                        MensagemAnimada("\nFinalizando programa", 500);
                        break;
                    default:
                        MensagemAnimada("\nOpção inexistente");
                        break;
                }
            else
                MensagemAnimada("\nOpção inválida");

        } while (opcao != 3);
    }
    public void MenuGrafos(OperacoesGrafos operacoes) // Menu para realizar o CRUD com grafos
    {
        int opcao = 0;

        do
        {
            Console.Clear();

            Console.WriteLine("===============================");
            Console.WriteLine("     Manipulação de Grafos     ");
            Console.WriteLine("===============================\n");
            Console.WriteLine("    1 - Criar Grafos           ");
            Console.WriteLine("    2 - Apagar Grafos          ");
            Console.WriteLine("    3 - Listar Grafos          ");
            Console.WriteLine("    4 - Voltar\n               ");
            Console.WriteLine("===============================\n");
            Console.Write("   ");

            if (int.TryParse(Console.ReadLine(), out opcao))
                switch (opcao)
                {
                    case 1:
                        MenuCriarGrafo(operacoes);
                        break;
                    case 2:
                        MenuApagarGrafo(operacoes);
                        break;
                    case 3:
                        operacoes.ListarGrafos();
                        break;
                    case 4:
                        MensagemAnimada("\nvoltando.", 250);
                        break;
                    default:
                        MensagemAnimada("\nOpção inexistente");
                        break;
                }
            else
                MensagemAnimada("\nOpção inválida");
        } while (opcao != 4);
    }
    public void MenuCriarGrafo(OperacoesGrafos operacoes) // Menu para inserção de grafos
    {
        int opcao = 0;
        do
        {
            Console.Clear();

            Console.WriteLine("===============================");
            Console.WriteLine($"      Criação de Grafos ({operacoes.ListaGrafos.Count})");
            Console.WriteLine("===============================\n");
            Console.WriteLine("    1 - Digitar                ");
            Console.WriteLine("    2 - Inserir arquivo        ");
            Console.WriteLine("    3 - Voltar\n               ");
            Console.WriteLine("===============================\n");
            Console.Write("   ");

            if (int.TryParse(Console.ReadLine(), out opcao))
                switch (opcao)
                {
                    case 1:
                        operacoes.LerGrafo();
                        /*Console.WriteLine("   Inserir outro grafo?");
                        Console.WriteLine("     (Enter para confirmar)");
                        Console.WriteLine("     (Qualquer tecla para cancelar)");
                    */

                        break;
                    case 2:
                        operacoes.LerGrafoArquivo();
                        break;
                    case 3:
                        MensagemAnimada("\nvoltando.", 250);
                        break;
                    default:
                        MensagemAnimada("\nOpção inexistente");
                        break;
                }
            else
                MensagemAnimada("\nOpção inválida");

        } while (opcao != 3);
    }
    public void MenuApagarGrafo(OperacoesGrafos operacoes) // Menu para remoção de grafos
    {
        int opcao = 0;
        do
        {
            Console.Clear();

            Console.WriteLine("===============================");
            Console.WriteLine("       Remoção de Grafos       ");
            Console.WriteLine("===============================\n");
            Console.WriteLine("    1 - Apagar grafo           ");
            Console.WriteLine("    2 - Apagar todos           ");
            Console.WriteLine("    3 - Voltar\n               ");
            Console.WriteLine("===============================\n");
            Console.Write("   ");

            if (operacoes.ListaGrafos.Count <= 0)
            {
                Console.WriteLine("Não há grafos a serem removidos.");
                Console.ReadKey(true);
                break;
            }

            if (int.TryParse(Console.ReadLine(), out opcao))
                switch (opcao)
                {
                    case 1:
                        operacoes.ApagarGrafo();
                        break;
                    case 2:
                        operacoes.LimparGrafos();
                        break;
                    case 3:
                        MensagemAnimada("\nvoltando.", 250);
                        break;
                    default:
                        MensagemAnimada("\nOpção inexistente");
                        break;
                }
            else
                MensagemAnimada("\nOpção inválida");
        } while (opcao != 3);
    }
    public void MenuAlgoritmos(OperacoesGrafos operacoes) // Menu para aplicação de algoritmos em grafos
    {
        if (operacoes.ListaGrafos.Count <= 0)
        {
            Console.WriteLine("\nNão há grafos para aplicar algoritmos.");
            Console.ReadKey(true);
        }
        else
        {
            int opcao = 0;

            while (true)
            {


                Console.Clear();

                int grafoNum = operacoes.EscolherGrafo();

                if (grafoNum == -1)
                    break;

                Console.Clear();

                Console.WriteLine("===============================");
                Console.WriteLine("    Aplicação de Algoritmos    ");
                Console.WriteLine("===============================");
                Console.WriteLine($" Grafo {grafoNum} :");

                operacoes.ListarGrafo(grafoNum);

                Console.WriteLine("\n===============================");
                Console.WriteLine(" Algoritmos :");
                Console.WriteLine("    1 - DFS                    ");
                Console.WriteLine("    2 - BFS                    ");
                Console.WriteLine("    3 - Dijkstra               ");
                Console.WriteLine("    4 - Prim                   ");
                Console.WriteLine("    5 - Kruskal                ");
                Console.WriteLine("    6 - Voltar\n               ");
                Console.Write("   ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                    switch (opcao)
                    {
                        case 1:
                            operacoes.DFS(grafoNum);
                            break;
                        case 2:
                            operacoes.BFS(grafoNum);
                            break;
                        case 3:
                            operacoes.Dijkstra(grafoNum);
                            break;
                        case 4:
                            operacoes.Prim(grafoNum);
                            break;
                        case 5:
                            operacoes.Kruskal(grafoNum);
                            break;
                        case 6:
                            MensagemAnimada("\nvoltando.", 200);
                            break;
                        default:
                            MensagemAnimada("\nOpção inexistente");
                            break;
                    }
                else
                    MensagemAnimada("\nOpção inválida");
            }
        }
    }
    private void MensagemAnimada(string Mensagem, int tempo = 300, int pontos = 4)
    {
        Console.Write(Mensagem);
        for (int i = 0; i < pontos; i++)
        {
            Thread.Sleep(tempo);
            Console.Write(".");
        }
        Console.WriteLine("");
    }
}

class OperacoesGrafos
{
    public List<int[,]> ListaGrafos = new();
    public OperacoesGrafos()
    {
        // Inicia arquivo database
    }
    public void LerGrafo()
    {
        int[,] grafo;

        while (true)
        {
            try
            {
                Console.Clear();

                Console.WriteLine("===============================");
                Console.WriteLine("       Leitura de Grafos       ");
                Console.WriteLine("===============================\n");
                Console.Write("Número de vértices : ");

                if (!(int.TryParse(Console.ReadLine(), out int n) || n <= 0)) // Verifica se o vértice é inválido
                    throw new Exception("\nValor de vértice inválido");

                grafo = new int[n, n];

                Console.Write("E = ");

                string arestas = Console.ReadLine();

                InserirArestas(arestas, grafo);

                ListaGrafos.Add(grafo);

                Console.WriteLine("\nGrafo adicionado com sucesso.");
                Console.WriteLine("===============================");


            }
            catch (Exception ex) // Escreve a mensagem de erro
            {
                Console.Write(ex.Message);
                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(300);
                    Console.Write(".");
                }
                Console.WriteLine("");
            }
            break;
        }
    }
    public void InserirArestas(string arestas, int[,] grafo)
    {
        int resultado = ValidaArestas(arestas);
        bool ponderado = false;
        arestas = arestas.Trim();

        if (resultado != 1 || resultado != 0)
            throw new Exception("\nArestas inválidas");

        else if (resultado == 0)
            ponderado = false;

        else if (resultado == 1)
            ponderado = true;

        // Faz os vérctices da aresta começarem em 0
        if (!arestas.Contains('0') && arestas.Any(char.IsDigit)) // Verificação se os vertices NÃO então começando no zero
        {
            string arestaCopia = "";

            if (ponderado)
            {
                // arestas = Regex.Replace(arestas, @"(?<=\(|,)([0-9]+)")
                // Cria uma cópia das arestas com os vértices começando no zero
                for (int i = 0; i < arestas.Length; i++)
                    if (char.IsDigit(arestas[i]) && ((arestas[i - 1] == '(') || (arestas[i - 1] == ',' && arestas[i + 1] == ',')))
                        arestaCopia += int.Parse(arestas[i].ToString()) - 1; // Adiciona na aresta copiada os caracteres convertidos em números - 1 

                    else
                        arestaCopia += arestas[i]; // Adiciona sem conversão

                arestas = arestaCopia;
            }
            else
            {
                // Cria uma cópia das arestas com os vértices começando no zero
                for (int i = 0; i < arestas.Length; i++)
                    if (char.IsDigit(arestas[i]))
                        arestaCopia += int.Parse(arestas[i].ToString()) - 1; // Adiciona na aresta copiada os caracteres convertidos em números - 1 

                    else
                        arestaCopia += arestas[i]; // Adiciona sem conversão

                arestas = arestaCopia;
            }
        }

        // Converte os vertices em números e adiciona cada aresta no grafo 
        for (int i = 0; i < arestas.Length; i++)
            if (arestas[i] == '(')
            {
                int vertice1, vertice2;

                if (char.IsLetter(arestas[i + 1])) // Verifica se o primeiro vértice está escrito em letra
                    vertice1 = char.ToUpper(arestas[i + 1]) - 'A'; // Converte o primeiro caractere letra dentro do parenteses em numero (A,B) => (0,B)
                else
                    vertice1 = arestas[i + 1];

                if (char.IsLetter(arestas[i + 3])) // Verifica se o segundo vértice está escrito em letra
                    vertice2 = char.ToUpper(arestas[i + 3]) - 'A'; // Converte o Segundo caractere letra dentro do parenteses em numero (0,B) => (0,1)
                else
                    vertice2 = arestas[i + 3];

                grafo[vertice1, vertice2] = 1; // Adiciona uma aresta ligando os vértices 1 e 2

                i += 5; // Avança o i para a proxima aresta
            }
    }
    public int ValidaArestas(string arestas) // Verifica se a string de arestas é válida
    {
        //                             {  ((A-Z ou 0-9),(A-z ou 0-9),(0-9)  espaçadores ( ,:)    }                           )
        if (Regex.IsMatch(arestas, @"^\{?\([A-Za-z0-9]+,[A-Za-z0-9]+(,[0-9]+)?\)([ ,;]+\([A-Za-z0-9]+,[A-Za-z0-9]+(,[0-9]+)?\))*\}?$"))
        {
            string[] matches = Regex.Matches(arestas, @"\(([0-9]+),([0-9]+)(,([0-9]+))?\)").Cast<Match>().Select(m => m.Value).ToArray();
            foreach (string vertice in matches)
                for (int i = 0; i < vertice.Length; i++)
                    //       if (char.IsDigit(vertice[i]) || vertice[i])



                    if (Regex.IsMatch(arestas, @"^\{? \([A-Za-z0-9]+,[A-Za-z0-9]+,[0-9]+       \)   \}?$"))
                    { }
        }
        /*   try
           {
               string Edge;
               bool ponderado = false, simples = false;

               for (int i = 0; i < arestas.Length; i++)
               {
                   ponderado = false;
                   simples = false;

                   if (arestas[i] == '(') // Procura abertura do parenteses
                   {
                       Edge = "(";

                       for (int j = i + 1; arestas[j - 1] != ')'; j++) // Copia uma aresta de toda a string 
                       {
                           Edge += arestas[j];
                           i = j; // Atualiza o i para o final da aresta
                       }

                       if (Regex.IsMatch(Edge, @"^\([A-Za-z0-9],[A-Za-z0-9]\)$")) // Verifica se a aresta é simples e está escrita como: (A,B) ou (0,1) ou (0,B)
                       {
                           simples = true;
                           ponderado = false;
                       }
                       else if (Regex.IsMatch(Edge, @"^\([A-Za-z0-9],[A-Za-z0-9],[0-9]+\)$")) // Verifica se a aresta é ponderada e está escrita como: (A,B,3) ou (0,1,3) ou (0,B,3)
                       {
                           ponderado = true;
                           simples = false;
                       }

                   }

               }
               if (!simples && !ponderado)
                   return -1;
               r
               }
           catch
           {
               Console.WriteLine("\nArestas inválidas");
               
           }*/
        return -1;
    }
    public void ListarGrafos(int GrafosPorPag = 6) // Lista todos os grafos em páginas
    {
        if (ListaGrafos.Count <= 0)
        {
            Console.WriteLine("\nNão há grafos a serem listados.");
            Console.ReadKey(true);
        }
        else
        {
            int numPags = (int)Math.Ceiling((double)ListaGrafos.Count / GrafosPorPag); // Atribui o numero de paginas dividindo a quantidade de grafos total por grafos por pag, arrendondada pra cima
            int i = 0;
            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("=================================");
                    Console.WriteLine($"       Lista de Grafos ({ListaGrafos.Count})");
                    Console.WriteLine("=================================");
                    Console.WriteLine($"  Página {i + 1}/{numPags}");

                    // Listagem da quantidade máxima de gafos suportados por página
                    for (int j = i * GrafosPorPag; j < (i + 1) * GrafosPorPag && j < ListaGrafos.Count; j++) // incia o j na posição do primeiro grafo da página e segue até o final da página ou ultimo da lista
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine($" Grafo {j + 1}");
                        ListarGrafo(j);
                        Thread.Sleep(10);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("=================================");

                    // Opções dinâmicas 
                    if (i <= 0) // Primeira página
                    {
                        Console.WriteLine("                 ---Próxima-->");
                        Console.WriteLine("                  (D ou seta) ");
                    }
                    else if (i < numPags - 1) // Paginas do meio
                    {
                        Console.WriteLine("<--Anterior---   ---Próxima-->");
                        Console.WriteLine(" (A ou seta)      (D ou seta) ");
                    }
                    else // Ultima página 
                    {
                        Console.WriteLine("<--Anterior---");
                        Console.WriteLine(" (A ou seta)  ");
                    }
                    Console.WriteLine("            Voltar            ");
                    Console.WriteLine("             (ESC)            ");

                    ConsoleKeyInfo tecla = Console.ReadKey(true);

                    // Movimenta as páginas pelas teclas apertadas
                    if (tecla.Key == ConsoleKey.D || tecla.Key == ConsoleKey.RightArrow)
                    {
                        if (i < numPags - 1)
                            i++;
                        else
                        {
                            Console.Write("\n  Não há próxima página\n");
                            Console.ReadKey(true);
                        }
                    }
                    else if (tecla.Key == ConsoleKey.A || tecla.Key == ConsoleKey.LeftArrow)
                        if (i > 0)
                            i--;
                        else
                        {
                            Console.Write("\n  Não há página anterior\n");
                            Console.ReadKey(true);
                        }
                    else if (tecla.Key == ConsoleKey.Escape)
                        break;
                    else
                        throw new Exception("\nTecla inválida");
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    for (int k = 0; k < 4; k++)
                    {
                        Thread.Sleep(300);
                        Console.Write(".");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
    public int EscolherGrafo(int GrafosPorPag = 5) // Lista todos os grafos para a escolha de aplicação de um algoritmo
    {
        int numPags = (int)Math.Ceiling((double)ListaGrafos.Count / GrafosPorPag); // Atribui o numero de paginas dividindo a quantidade de grafos total por grafos por pag, arrendondada pra cima
        int i = 0;
        while (true)
        {
            try
            {
                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine("        Seleção de Grafo         ");
                Console.WriteLine("=================================");
                Console.WriteLine($"  Página {i + 1}/{numPags}");

                // Listagem da quantidade máxima de gafos suportados por página
                for (int j = i * GrafosPorPag; j < (i + 1) * GrafosPorPag && j < ListaGrafos.Count; j++) // incia o j na posição do primeiro grafo da página e segue até o final da página ou ultimo da lista
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($" Grafo {j + 1}");
                    ListarGrafo(j);
                    Thread.Sleep(10);
                    Console.WriteLine("");
                }
                Console.WriteLine("=================================");

                // Opções dinâmicas 
                if (i <= 0) // Primeira página
                {
                    Console.WriteLine("                 ---Próxima-->");
                    Console.WriteLine("                  (D ou seta) ");
                }
                else if (i < numPags - 1) // Paginas do meio
                {
                    Console.WriteLine("<--Anterior---   ---Próxima-->");
                    Console.WriteLine(" (A ou seta)      (D ou seta) ");
                }
                else // Ultima página 
                {
                    Console.WriteLine("<--Anterior---");
                    Console.WriteLine(" (A ou seta)  ");
                }
                Console.WriteLine("            Voltar            ");
                Console.WriteLine("             (ESC)            ");
                Console.WriteLine("=================================");

                Console.Write("\nNúmero do grafo : ");

                ConsoleKeyInfo tecla = Console.ReadKey(true);

                if (char.IsDigit(tecla.KeyChar)) // Verifica se a tecla pressionada é int 
                {
                    string escolha = tecla.KeyChar.ToString(); // Coloca o numero pressionado em string
                    do
                    {
                        Console.Write(tecla.KeyChar);
                        tecla = Console.ReadKey(true);
                        escolha += tecla.KeyChar; // Adiciona as teclas pressionadas em uma string
                    }
                    while (tecla.Key != ConsoleKey.Enter);

                    if (!int.TryParse(escolha, out int pos) || pos >= ListaGrafos.Count || pos < 0) // Verifica se um numero foi digitado e se representa um grafo válido
                        throw new Exception("\nValor inválido");

                    return pos;
                }
                else // Não é número de grafo
                {
                    if (tecla.Key == ConsoleKey.D || tecla.Key == ConsoleKey.RightArrow)
                    {
                        if (i < numPags - 1)
                            i++;
                        else
                        {
                            Console.Write("\n  Não há próxima página\n");
                            Console.ReadKey(true);
                        }
                    }
                    else if (tecla.Key == ConsoleKey.A || tecla.Key == ConsoleKey.LeftArrow)
                        if (i > 0)
                            i--;
                        else
                        {
                            Console.WriteLine("\n  Não há página anterior");
                            Console.ReadKey(true);
                        }
                    else if (tecla.Key == ConsoleKey.Escape)
                        break;
                    else
                        throw new Exception("\nTecla inválida");
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                for (int k = 0; k < 4; k++)
                {
                    Thread.Sleep(300);
                    Console.Write(".");
                }
                Console.WriteLine("");
            }
        }
        return -1;
    }
    public void ListarGrafo(int NumGrafo) // Lista as propriedades de um grado
    {
        int[,] grafo = ListaGrafos[NumGrafo];

        Console.WriteLine($"  Número de vértices : {grafo.GetLength(0)}");
        Console.Write("  Arestas : ");

        for (int j = 0; j < grafo.GetLength(0); j++) // Linhas
            for (int k = 0; k < grafo.GetLength(0); k++) // Colunas
                if (grafo[j, k] != 0) // Existe aresta
                    if (grafo[j, k] > 1) // Grafo ponderado
                        Console.Write($"({j},{k},{grafo[j, k]})");
                    else // Grafo não ponderado
                        Console.Write($"({j},{k})");

    }
    public void ApagarGrafo()
    {
        Console.Write("Número do grafo a ser apagado : ");
        if (int.TryParse(Console.ReadLine(), out int numGrafo) && numGrafo > 0 && numGrafo < ListaGrafos.Count)
        {
            ListaGrafos.RemoveAt(numGrafo);
            Console.WriteLine("\nGrafo removido com sucesso.");
            Console.ReadKey(true);
        }
        else
        {
            Console.Write("\nValor inválido");
            for (int k = 0; k < 4; k++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }
            Console.WriteLine("");
        }
    }
    public void LimparGrafos()
    {
        Console.WriteLine("\nREMOVENDO TODOS OS GRAFOS");
        Console.WriteLine("  Tem certeza?");
        Console.WriteLine("  (Enter confirma)");
        Console.WriteLine("  (Qualquer tecla para cancelar)");

        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        {
            Console.Write("\nRemovendo todos.");
            for (int k = 0; k < 4; k++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }
            Console.WriteLine("");
            Console.WriteLine("  Grafos removidos com sucesso");
            Console.ReadKey(true);

            ListaGrafos.Clear();
        }
        else
        {
            Console.Write("Remoção cancelada.");
            for (int k = 0; k < 4; k++)
            {
                Thread.Sleep(200);
                Console.Write(".");
            }
            Console.WriteLine("");
        }
    }

    public void LerGrafoArquivo() { }
    /*
                ALGORITMOS DO TRABALHO ABAIXO  

                "GrafoNum" é o numero do algoritmo em "ListaGrafos" pode ser removido de varios jeitos como:   

                int[,]Matriz = ListaGrafos[GrafoNum] 
    */

    public void DFS(int GrafoNum)
    {

        Console.Clear(); 
        int[,] g = ListaGrafos[GrafoNum]; /* Referenciando o grafo  */
        int numV = g.GetLength(0);  /* Pega o numero de linhas do grafo */
        Stack<int> p  = new Stack<int>();

       
        bool[] visited = new bool[numV];

    p.Push(0);  // Adiciona vértice inicial
    Console.WriteLine("\nDFS - Busca em Profundidade");
    Console.WriteLine("Ordem de visitação:");
    
    while (p.Count > 0)
    {
        int atual = p.Pop();  // Remove da pilha
        
        if (!visited[atual])  
        {
            visited[atual] = true;  // Marca como visitado
            Console.WriteLine($" → {atual} "); 

            for (int j = 0; j < numV; j++)
            {
                if (g[atual, j] != 0 && !visited[j])
                {
                    p.Push(j);
                }
            }
        }
    }


    Console.WriteLine("Pressione qualquer tecla para voltar...");
    Console.ReadKey();
    }
    public void BFS(int GrafoNum)
    {
            
    }

    public void Dijkstra(int GrafoNum)
    {

    }
    public void Prim(int GrafoNum)
    {

    }
    public void Kruskal(int GrafoNum)
    {

    }
}
