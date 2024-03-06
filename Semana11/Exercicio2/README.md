# Principais conceitos, princípios e características de cada modelo

## Modelo Relacional

### Conceitos e Princípios:

    O modelo relacional de gestão de base de dados é fundamentado na teoria de conjuntos e lógica, sendo amplamente utilizado em sistemas de gestão de bases de dados (SGBD). Algumas características principais deste modelo incluem a capacidade de controlar os dados de forma escalável, manter a consistência dos dados entre aplicações e instâncias do banco de dados, e estruturar informações em tabelas, linhas e colunas.

    É baseado no conceito de relação, onde uma relação é uma tabela de valores.
    Uma tabela de valores pode ser vista como um conjunto de linhas ou tuplos.
    Cada tuplo é identificado por um conjunto de colunas ou atributos.
    Uma base de dados é representada como um conjunto de relações.
    
![Captura de ecrã 2024-03-06 121420](https://github.com/rafilourenco/AulasPSI/assets/145566372/4ef90ced-b763-4029-9225-4006d76a3ff7)


### Características:

    Organização de Dados: Estrutura os dados em tabelas, facilitando a organização e recuperação das informações.
    Relações: Permite estabelecer relações entre diferentes tabelas por meio de chaves primárias e estrangeiras.
    Consultas: Oferece uma linguagem (SQL) para realizar consultas complexas e obter informações específicas.
    Flexibilidade: Permite adicionar, modificar e excluir dados com facilidade, mantendo a integridade do banco.
    Escalabilidade: Capacidade de lidar com grandes volumes de dados e crescer conforme as necessidades.

### Aplicações no mundo real:

    O modelo relacional é amplamente utilizado em sistemas de gestão empresarial, sistemas bancários, sistemas de reservas online, entre outros.

## Modelo Hierárquico

### Conceitos e Princípios:

    O Modelo Hierárquico de gestão de base de dados é um modelo que organiza os dados em uma estrutura hierárquica, onde os registros são conectados em forma de árvore. Alguns dos principais conceitos, princípios e características deste modelo incluem a representação dos dados em uma estrutura de árvore, a existência de um único caminho descendente para cada registro e a utilização de ponteiros para estabelecer relações entre os dados.

### Características:

    Organização de Dados: Estrutura os dados em forma de árvore, com um único caminho descendente para cada registro.
    Relações: Estabelece relações hierárquicas entre os registros por meio de ponteiros.
    Consultas: Permite consultas eficientes ao seguir a estrutura hierárquica dos dados.
    Flexibilidade: Menos flexível que o modelo relacional devido à rigidez da estrutura hierárquica.
    Escalabilidade: Pode enfrentar desafios de escalabilidade ao lidar com grandes volumes de dados.

### Aplicações no mundo real:

Em aplicações onde a relação entre os dados é naturalmente hierárquica, como organizações com estruturas organizacionais bem definidas.

## Modelo de Rede

### Conceitos e Princípios:

    O Modelo de Rede na gestão de base de dados é uma estrutura que permite representar relações complexas entre os dados, utilizando um formato de grafo. Alguns dos principais conceitos, princípios e características deste modelo incluem a capacidade de estabelecer múltiplas relações entre os registros, a utilização de ponteiros para navegar entre os dados e a representação dos dados em forma de grafo.

### Características:

    Organização de Dados: Estrutura os dados em forma de grafo, permitindo múltiplas relações entre os registros.
    Relações: Permite estabelecer relações complexas entre os dados, facilitando a representação de conexões intricadas.
    Consultas: Oferece uma forma eficiente de realizar consultas que envolvem múltiplas entidades interconectadas.
    Flexibilidade: Mais flexível que o modelo hierárquico, permitindo representar relações mais complexas.
    Escalabilidade: Pode lidar com volumes consideráveis de dados e é adequado para cenários com estruturas interligadas.

### Aplicações no mundo real:

    Em aplicações onde as relações entre os dados são complexas e necessitam ser representadas de forma detalhada.


## Fontes:

    http://host.di.uevora.pt/~ccaldeira/e/sp/imd/docs/BD1.pdf
    https://www.profissionaisti.com.br/um-pouco-sobre-banco-de-dados-hierarquico/
    https://pt.wikipedia.org/wiki/Modelo_hier%C3%A1rquico_de_banco_de_dados
    https://www.dcc.fc.up.pt/~ricroc/aulas/1011/bd/apontamentos/parteIII.pdf
    https://edworking.com/pt/blog/startups/estrutura-hierarquica-o-que-e-vantagens-desvantagens-e-exemplos
    

    Chatgpt