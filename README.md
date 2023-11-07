# ArraySort :arrows_counterclockwise::chart_with_downwards_trend:

O repositório "ArraySort" é um programa destinado a testar diferentes algoritmos de ordenação em arrays de diversos tamanhos e estados iniciais. Os algoritmos de ordenação incluem Bubble Sort, Improved Bubble Sort, Insertion Sort, Selection Sort, Merge Sort, Quick Sort e Shell Sort. Cada algoritmo será avaliado em relação ao tempo de execução, à quantidade de trocas (ou mesclas, no caso do Merge Sort) e à quantidade de comparações envolvidas no processo de ordenação.

<br>

## Algoritmos de Ordenação :arrows_counterclockwise:

- **Bubble Sort**: Este é um algoritmo de ordenação simples que compara pares de elementos adjacentes e os troca se estiverem fora de ordem, repetindo esse processo até que nenhum elemento precise ser trocado.

- **Improved Bubble Sort**: Uma variação do Bubble Sort que inclui uma otimização para reduzir o número de comparações no melhor caso.

- **Insertion Sort**: Este algoritmo divide o array em uma parte ordenada e uma parte não ordenada. Ele seleciona elementos da parte não ordenada e os insere na parte ordenada na posição correta.

- **Selection Sort**: O Selection Sort encontra o menor elemento no array e o move para a posição inicial, repetindo esse processo para o restante do array até que todo o array esteja ordenado.

- **Merge Sort**: O Merge Sort é um algoritmo de ordenação eficiente que divide o array em duas metades, ordena cada metade e, em seguida, mescla as duas metades ordenadas.

- **Quick Sort**: O Quick Sort divide o array em torno de um elemento chamado "pivot", colocando todos os elementos menores que o pivot à esquerda e todos os elementos maiores à direita, repetindo esse processo para as submatrizes resultantes.

- **Shell Sort**: Shell Sort é uma variação do Insertion Sort que compara elementos distantes em vez de elementos adjacentes, usando um intervalo chamado "gap".

<br>

## Testes :man_scientist:

Os testes serão realizados em arrays de três tamanhos diferentes: 1.000, 10.000 e 100.000 elementos. Cada tamanho de array será testado em três cenários distintos:

1. **Array Ordenado**: Os elementos já estão ordenados.
2. **Array Aleatório**: Os elementos são organizados aleatoriamente.
3. **Array em Ordem Decrescente**: Os elementos estão em ordem decrescente.

<br>

## Métricas :bar_chart:

Para avaliar o desempenho de cada algoritmo, serão registradas as seguintes métricas:

- **Tempo de Execução**: O tempo necessário para ordenar o array.
- **Quantidade de Trocas (ou Mesclas)**: O número de trocas ou mesclas realizadas durante o processo de ordenação.
- **Quantidade de Comparações**: O número de comparações realizadas para determinar a ordem dos elementos no array.

<br>

## Como Executar :arrow_forward:

Você pode executar o programa de ordenação de arrays usando o Visual Studio ou sua IDE preferida, seguindo estas etapas:

1. **Clone o repositório**:

`git clone https://github.com/brenonsc/ArraySort.git`

2. **Abra a solução `ArraySort.sln` no Visual Studio ou em sua IDE preferida**.
3. **Compile e execute o programa**.

<br>

Este repositório visa fornecer uma visão geral do desempenho dos algoritmos de ordenação em diferentes cenários e tamanhos de array, ajudando os desenvolvedores a escolher a abordagem mais apropriada para suas necessidades de ordenação.