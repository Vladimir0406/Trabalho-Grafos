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
        int[,] grafo4 = { { 0, 1, 1, 0, 0 }, { 1, 0, 0, 1, 0 }, { 1, 0, 0, 0, 1 }, { 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0 } };
        int[,] grafo5 = { { 0, 2, 0, 0, 6 }, { 2, 0, 3, 0, 0 }, { 0, 3, 0, 1, 0 }, { 0, 0, 1, 0, 4 }, { 6, 0, 0, 4, 0 } };
        int[,] grafo6 = { { 0, 4, 0, 0, 0, 0 }, { 4, 0, 8, 0, 0, 0 }, { 0, 8, 0, 7, 0, 4 }, { 0, 0, 7, 0, 9, 14 }, { 0, 0, 0, 9, 0, 10 }, { 0, 0, 4, 14, 10, 0 } };
        int[,] grafo7 = { { 0, 1, 0, 4 }, { 1, 0, 2, 0 }, { 0, 2, 0, 3 }, { 4, 0, 3, 0 } };
        int[,] grafo8 = { { 0, 1, 3 }, { 1, 0, 2 }, { 3, 2, 0 } };

        operacoes.ListaGrafos.Add(grafo);
        operacoes.ListaGrafos.Add(grafo2);
        operacoes.ListaGrafos.Add(grafo3);
        operacoes.ListaGrafos.Add(grafo4);
        operacoes.ListaGrafos.Add(grafo5);
        operacoes.ListaGrafos.Add(grafo6);
        operacoes.ListaGrafos.Add(grafo7);
        operacoes.ListaGrafos.Add(grafo8);

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
            Console.WriteLine("        TRABALHO GRAFOS        ");
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
            Console.WriteLine("    2 - Voltar\n               ");
            Console.WriteLine("===============================\n");
            Console.Write("   ");

            if (int.TryParse(Console.ReadLine(), out opcao))
                switch (opcao)
                {
                    case 1:
                        operacoes.LerGrafo();
                        break;
                    case 2:
                        MensagemAnimada("\nvoltando.", 250);
                        break;
                    default:
                        MensagemAnimada("\nOpção inexistente");
                        break;
                }
            else
                MensagemAnimada("\nOpção inválida");

        } while (opcao != 2);
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
        if (operacoes.ListaGrafos.Count <= 0) // Verifica se há grafos antes da execução do código
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
                Console.WriteLine($" Grafo {grafoNum + 1} :");

                operacoes.ListarGrafo(grafoNum);

                Console.WriteLine("\n===============================");
                Console.WriteLine(" Algoritmos :");
                Console.WriteLine("    1 - DFS                    ");
                Console.WriteLine("    2 - BFS                    ");
                Console.WriteLine("    3 - Dijkstra               ");
                Console.WriteLine("    4 - Prim                   ");
                Console.WriteLine("    5 - Kruskal                ");
                Console.WriteLine("    6 - Voltar                 ");
                Console.WriteLine("===============================\n");
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

                LerArestas(grafo);

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
    public void LerArestas(int[,] matriz) // Lê cada dado para uma parte do grafo
    {
        int n = matriz.GetLength(0);

        Console.WriteLine("O grafo é ponderado? (S/N)");
        string opcao = Console.ReadLine().ToUpper();
        bool ponderado = opcao == "S";

        Console.WriteLine("Quantas arestas deseja inserir?");
        int numArestas = int.Parse(Console.ReadLine());

        for (int i = 0; i < numArestas; i++)
        {
            Console.WriteLine($"Aresta {i + 1}:");

            Console.Write("Vértice 1: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Vértice 2: ");
            int v2 = int.Parse(Console.ReadLine());

            int peso = 1; // padrão se não ponderado

            if (ponderado)
            {
                Console.Write("Peso da aresta: ");
                peso = int.Parse(Console.ReadLine());
            }

            // Preenche matriz (grafo não direcionado)
            matriz[v1, v2] = peso;
            matriz[v2, v1] = peso;
        }
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

                    if (!int.TryParse(escolha, out int pos) || pos - 1 >= ListaGrafos.Count || pos - 1 < 0) // Verifica se um numero foi digitado e se representa um grafo válido
                        throw new Exception("\nValor inválido");

                    return pos - 1;
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
    public void ApagarGrafo() // Remove um grafo por seu índice
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
    public void LimparGrafos() // Remove todos os grafos
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
    public void DFS(int GrafoNum)
    {

        Console.Clear();
        int[,] g = ListaGrafos[GrafoNum]; /* Referenciando o grafo  */
        int numV = g.GetLength(0);  /* Pega o numero de linhas do grafo */
        Stack<int> p = new Stack<int>();


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
        int[,] matriz = ListaGrafos[GrafoNum]; // Pegar uma matriz da lista

        // Inicializa os vetores
        bool[] visitado = new bool[matriz.GetLength(0)];
        int[] dist = new int[matriz.GetLength(0)];
        int[] pred = new int[matriz.GetLength(0)];
        int i = 0;
        Queue<int> fila = new();

        for (int j = 0; j < matriz.GetLength(0); j++)
        {
            dist[j] = -1;
            pred[j] = -1;
        }
        // Vértice 0 sendo inciado
        visitado[0] = true;
        dist[0] = i;
        pred[0] = -1;
        fila.Enqueue(0);

        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("          Algoritmo - BFS           ");
        Console.WriteLine("====================================");
        Console.WriteLine(" Vértices | Distância | Predecessor");

        while (fila.Count > 0) // Funciona enquanto não passou por todos os vértices
        {
            // Tira o vertice atual e escreve na tela
            int vAtual = fila.Dequeue();
            Console.WriteLine($" {vAtual,4}{dist[vAtual],11}{pred[vAtual],13}");

            for (i = 0; i < matriz.GetLength(0); i++)// Percorre o grafo encontrando arestas
            {
                if (matriz[vAtual, i] >= 1 && !visitado[i]) // Aresta nova encontrada
                {
                    fila.Enqueue(i); // Coloca na fila
                    // Salva o predecesessor e a distância da raiz
                    dist[i] = dist[vAtual] + 1;
                    pred[i] = vAtual;
                    visitado[i] = true; // Marca como visitado
                }
            }
        }
        Console.WriteLine("====================================");
        Console.WriteLine("\nVoltar - Qualquer tecla");
        Console.ReadKey(true); // Para ler os resultados
    }
    public void Dijkstra(int GrafoNum)
    {
        int[,] matriz = ListaGrafos[GrafoNum];
        int n = matriz.GetLength(0);

        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("        Algoritmo - Dijkstra        ");
        Console.WriteLine("====================================");

        // Pede o vértice de origem
        Console.Write("Informe o vértice de origem (0 a " + (n - 1) + "): ");
        int origem;

        while (!int.TryParse(Console.ReadLine(), out origem) || origem < 0 || origem >= n)
        {
            Console.Write("Vértice inválido. Digite um número entre 0 e " + (n - 1) + ": ");
        }

        // Arrays para armazenar distâncias, predecessores e se o vértice foi processado
        int[] dist = new int[n];
        int[] pai = new int[n];
        bool[] processado = new bool[n];

        // Inicializa todos os vértices
        for (int i = 0; i < n; i++)
        {
            dist[i] = int.MaxValue;
            pai[i] = -1;
            processado[i] = false;
        }

        // Distância da origem para ela mesma é 0
        dist[origem] = 0;

        Console.WriteLine("\nPassos do algoritmo:");
        Console.WriteLine("------------------------------------");
        Console.WriteLine(" Vértice | Distância | Predecessor | Status");
        Console.WriteLine("------------------------------------");

        // Processa todos os vértices
        for (int count = 0; count < n - 1; count++)
        {
            // Encontra o vértice com menor distância não processado
            int u = MenorDistancia(dist, processado, n);

            // Marca como processado
            processado[u] = true;

            Console.WriteLine($" {u,7} | " +
                             $"{(dist[u] == int.MaxValue ? "INF" : dist[u].ToString()),9} | " +
                             $"{pai[u],10} | Processado");

            // Atualiza as distâncias dos vértices adjacentes
            for (int v = 0; v < n; v++)
            {
                // Se há uma aresta, v não foi processado, dist[u] não é infinito
                // e a nova distância é menor que a atual
                if (matriz[u, v] != 0 && !processado[v] && dist[u] != int.MaxValue &&
                    dist[u] + matriz[u, v] < dist[v])
                {
                    dist[v] = dist[u] + matriz[u, v];
                    pai[v] = u;
                }
            }

            Thread.Sleep(400); // Pequena pausa para visualização
        }

        Console.WriteLine("====================================");
        Console.WriteLine("  Resultados finais:");
        Console.WriteLine("------------------------------------");
        Console.WriteLine(" Vértice | Distância | Predecessor | Caminho");
        Console.WriteLine("------------------------------------");

        // Mostra os resultados finais
        for (int i = 0; i < n; i++)
        {
            string caminho = ObterCaminho(pai, i, origem);

            Console.WriteLine($" {i,7} | " +
                             $"{(dist[i] == int.MaxValue ? "INF" : dist[i].ToString()),9} | " +
                             $"{pai[i],10} | {caminho}");
        }

        Console.WriteLine("====================================");
        Console.WriteLine("\nVoltar - Qualquer tecla");
        Console.ReadKey(true);
    }

    // Métodos auxiliares
    private int MenorChave(int[] chave, bool[] naAGM, int n)
    {
        int menor = int.MaxValue;
        int indiceMenor = -1;

        for (int v = 0; v < n; v++)
        {
            if (!naAGM[v] && chave[v] < menor)
            {
                menor = chave[v];
                indiceMenor = v;
            }
        }

        return indiceMenor;
    }

    private int MenorDistancia(int[] dist, bool[] processado, int n)
    {
        int menor = int.MaxValue;
        int indiceMenor = -1;

        for (int v = 0; v < n; v++)
        {
            if (!processado[v] && dist[v] <= menor)
            {
                menor = dist[v];
                indiceMenor = v;
            }
        }

        return indiceMenor;
    }

    private bool GrafoConexo(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        bool[] visitado = new bool[n];
        Stack<int> pilha = new Stack<int>();

        // Começa do vértice 0
        pilha.Push(0);

        while (pilha.Count > 0)
        {
            int v = pilha.Pop();

            if (!visitado[v])
            {
                visitado[v] = true;

                // Adiciona todos os vértices adjacentes não visitados
                for (int i = 0; i < n; i++)
                {
                    if (matriz[v, i] != 0 && !visitado[i])
                    {
                        pilha.Push(i);
                    }
                }
            }
        }

        // Verifica se todos os vértices foram visitados
        for (int i = 0; i < n; i++)
        {
            if (!visitado[i])
            {
                return false;
            }
        }

        return true;
    }

    private string ObterCaminho(int[] pai, int destino, int origem)
    {
        if (pai[destino] == -1 && destino != origem)
        {
            return "Inalcançável";
        }

        Stack<int> caminho = new Stack<int>();
        int atual = destino;

        // Reconstrói o caminho do destino até a origem
        while (atual != -1)
        {
            caminho.Push(atual);
            atual = pai[atual];
        }

        // Converte o caminho para string
        string resultado = "";
        while (caminho.Count > 0)
        {
            resultado += caminho.Pop().ToString();
            if (caminho.Count > 0)
            {
                resultado += " → ";
            }
        }

        return resultado;

    }
    public void Prim(int GrafoNum)
    {
        int[,] matriz = ListaGrafos[GrafoNum];
        int n = matriz.GetLength(0);

        // Verifica se o grafo é conexo
        if (!GrafoConexo(matriz))
        {
            Console.WriteLine("Grafo não é conexo. Algoritmo de Prim requer grafo conexo.");
            Console.WriteLine("\nVoltar - Qualquer tecla");
            Console.ReadKey(true);
            return;
        }

        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("          Algoritmo - Prim          ");
        Console.WriteLine("====================================");

        // Arrays para armazenar as chaves, predecessores e se o vértice está na AGM
        int[] chave = new int[n];
        int[] pai = new int[n];
        bool[] naAGM = new bool[n];

        // Inicializa todos os vértices
        for (int i = 0; i < n; i++)
        {
            chave[i] = int.MaxValue;
            naAGM[i] = false;
        }

        // Começa pelo vértice 0
        chave[0] = 0;
        pai[0] = -1; // Primeiro vértice não tem predecessor

        int pesoTotal = 0;

        Console.WriteLine(" Passo | Vértice | Chave | Predecessor | Status");
        Console.WriteLine("-----------------------------------------------");

        // Para cada vértice, encontra o de menor chave
        for (int count = 0; count < n; count++)
        {
            // Encontra o vértice com menor chave que ainda não está na AGM
            int u = MenorChave(chave, naAGM, n);

            // Adiciona à AGM
            naAGM[u] = true;

            // Se não for o primeiro vértice, adiciona o peso
            if (pai[u] != -1)
            {
                pesoTotal += matriz[u, pai[u]];
            }

            // Mostra o passo atual
            Console.WriteLine($" {count + 1,5} | {u,7} | " +
                             $"{(chave[u] == int.MaxValue ? "INF" : chave[u].ToString()),5} | " +
                             $"{pai[u],10} | Adicionado");

            // Atualiza as chaves dos vértices adjacentes
            for (int v = 0; v < n; v++)
            {
                // Se há uma aresta entre u e v, v não está na AGM, e o peso é menor que a chave atual
                if (matriz[u, v] != 0 && !naAGM[v] && matriz[u, v] < chave[v])
                {
                    pai[v] = u;
                    chave[v] = matriz[u, v];
                }
            }

            Thread.Sleep(500); // Pequena pausa para visualização
        }

        Console.WriteLine("====================================");
        Console.WriteLine("  Árvore Geradora Mínima (AGM):");
        Console.WriteLine("------------------------------------");

        for (int i = 1; i < n; i++)
        {
            if (pai[i] != -1)
            {
                Console.WriteLine($"     Aresta ({pai[i]},{i}) - Peso: {matriz[i, pai[i]]}");
            }
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine($" Peso total da AGM: {pesoTotal}");
        Console.WriteLine("====================================");
        Console.WriteLine("\nVoltar - Qualquer tecla");
        Console.ReadKey(true);
    }
    public void Kruskal(int GrafoNum)
    {
        int[,] matriz = ListaGrafos[GrafoNum];
        int n = matriz.GetLength(0);

        // Lista para armazenar todas as arestas
        List<(int origem, int destino, int peso)> arestas = new();

        // Extrai todas as arestas da matriz de adjacência
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++) // j = i+1 para evitar duplicatas (grafo não direcionado)
                if (matriz[i, j] > 0)
                    arestas.Add((i, j, matriz[i, j]));

        // Ordena as arestas por peso (ordem crescente)
        arestas.Sort((a, b) => a.peso.CompareTo(b.peso));

        int[] pai = new int[n];
        int[] rank = new int[n];

        for (int i = 0; i < n; i++)
        {
            pai[i] = i;
            rank[i] = 0;
        }

        // Lista para armazenar as arestas da árvore
        List<(int origem, int destino, int peso)> agm = new();
        int pesoTotal = 0;

        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("        Algoritmo - Kruskal         ");
        Console.WriteLine("====================================");
        Console.WriteLine("     Aresta | Peso | Status");
        Console.WriteLine("------------------------------------");

        // Processa cada aresta em ordem crescente de peso
        foreach (var aresta in arestas)
        {
            int raizOrigem = Encontrar(pai, aresta.origem);
            int raizDestino = Encontrar(pai, aresta.destino);

            Console.Write($"      ({aresta.origem},{aresta.destino})   {aresta.peso,4}   ");

            // Raízes diferentes não formam ciclos
            if (raizOrigem != raizDestino)
            {
                agm.Add(aresta);
                pesoTotal += aresta.peso;
                Juncao(pai, rank, raizOrigem, raizDestino);
                Console.WriteLine("Aceita");
            }
            else
                Console.WriteLine("Rejeitada (forma ciclo)");
            Thread.Sleep(300);
        }

        Console.WriteLine("====================================");
        Console.WriteLine("  Árvore Geradora Mínima (AGM):");
        Console.WriteLine("------------------------------------");

        foreach (var aresta in agm)
            Console.WriteLine($"     Aresta ({aresta.origem},{aresta.destino}) - Peso: {aresta.peso}");

        Console.WriteLine("------------------------------------");
        Console.WriteLine($" Peso total da AGM: {pesoTotal}");
        Console.WriteLine("====================================");
        Console.WriteLine("\nVoltar - Qualquer tecla");

        Console.ReadKey(true);
    }
    private int Encontrar(int[] pai, int i)
    {
        if (pai[i] != i)
            pai[i] = Encontrar(pai, pai[i]);
        return pai[i];
    }
    private void Juncao(int[] pai, int[] rank, int x, int y)
    {
        int raizX = Encontrar(pai, x);
        int raizY = Encontrar(pai, y);

        if (rank[raizX] < rank[raizY])
            pai[raizX] = raizY;
        else if (rank[raizX] > rank[raizY])
            pai[raizY] = raizX;
        else
        {
            pai[raizY] = raizX;
            rank[raizX]++;
        }
    }
}
