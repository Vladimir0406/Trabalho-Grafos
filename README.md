# Trabalho - Grafos
Um repositório para o desenvolvimento de um trabalho sobre Grafos, abordando conceitos iniciais e alguns algoritmos principais com DFS, BFS e Kruskal

# DFS (Depth-First Search)

Este projeto implementa a Busca em Profundidade (DFS) usando uma versão iterativa do algoritmo.
Em vez de usar recursão, a DFS aqui é executada por meio de uma pilha (Stack<int>), que controla a ordem dos vértices a serem visitados.

Para entender o funcionamento da DFS iterativa, é importante compreender primeiro como funciona uma pilha (Stack).

A pilha possui duas operações principais:

Push → adiciona um elemento no topo da pilha

Pop → remove o elemento do topo da pilha

A pilha segue o princípio LIFO (Last In, First Out): o último item que entra é sempre o primeiro a sair.
Uma boa analogia é imaginar várias caixas empilhadas: para pegar uma caixa que foi colocada por último, você a remove primeiro, mantendo a ordem sem derrubar as outras.

Agora que entendemos o funcionamento de uma pilha, podemos começar a montar nosso algoritmo de DFS e ver como ele foi implementado no código.

A ideia é simples: escolhemos um vértice para iniciar a busca e o colocamos na pilha.
Enquanto ainda houver vértices dentro da pilha, continuamos repetindo o processo:

Pegamos o elemento do topo da pilha (com Pop()), que representa o próximo vértice a ser visitado.

 - Verificamos se ele já foi visitado.

 - Se não foi, marcamos como visitado e mostramos na tela.

 - Depois, analisamos todos os vizinhos desse vértice.

 - Para cada vizinho ainda não visitado, fazemos um Push na pilha.

Seguindo esse fluxo, o algoritmo sempre tenta ir o mais fundo possível no grafo antes de voltar.
A pilha faz esse controle naturalmente: cada novo vizinho encontrado é colocado no topo, garantindo que ele seja explorado antes dos vértices mais antigos que já estavam na pilha.

O resultado é uma navegação “em profundidade”, que avança por caminhos cada vez mais longos até que não haja mais para onde ir, retornando então pela pilha até encontrar outros caminhos ainda não explorados.
