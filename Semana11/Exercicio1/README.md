# **Sistemas de gestão de bases de dados**

### SGDB Relacional (SGBDR)

#### Características:

        Organiza dados em tabelas com linhas e colunas.
        Usa linguagem SQL para consultas.
        Mantém integridade referencial entre tabelas.

#### Funcionalidades:

        Suporte a transações ACID (Atomicidade, Consistência, Isolamento, Durabilidade).
        Escalabilidade vertical e horizontal.
        Facilidade de consultas complexas.

#### Vantagens:

        Estrutura bem definida e fácil de entender.
        Suporte a consultas complexas.
        Integridade dos dados garantida.

#### Linguagem de consulta (query) usada:

        SQL

#### Casos de aplicações de cada tipo no mundo real:

        Aplicação de Finanças: Um sistema bancário que armazena transações, informações de contas e histórico de clientes em um banco de dados relacional. Ele precisa de estrutura de dados sólida e consistente para garantir a integridade das transações financeiras.

### SGBD Não-Relacional (NoSQL)

#### Características:

        Armazena dados de forma flexível, como documentos, grafos ou pares chave-valor.
        Escalabilidade horizontal mais fácil que em bancos relacionais.

#### Funcionalidades:

        Flexibilidade no esquema dos dados.
        Alta disponibilidade e desempenho em grandes volumes de dados não estruturados.

#### Vantagens:

        Escalabilidade horizontal eficiente.
        Flexibilidade no armazenamento de diferentes tipos de dados.
        Melhor desempenho para certos tipos de aplicativos.

#### Linguagem de consulta (query) usada:

        JSON

#### Casos de aplicações de cada tipo no mundo real:

        Redes Sociais: Plataformas de redes sociais como o Facebook ou o Twitter lidam com enormes quantidades de dados não estruturados, como feeds de notícias, comentários, curtidas e compartilhamentos. Bancos de dados NoSQL, como o MongoDB, são úteis para escalar horizontalmente e lidar com grandes volumes de dados variáveis.

### SGBD Orientado a Objetos (SGBDOO)

#### Características:

        Armazena objetos como entidades principais.
        Suporta herança, polimorfismo e encapsulamento.

#### Funcionalidades:

        Mapeamento objeto-relacional para integração com linguagens orientadas a objetos.
        Suporte a complexidade de dados em sistemas com estruturas complexas.

#### Vantagens:

        Melhor representação da realidade do mundo real.
        Facilita a modelagem de sistemas complexos.

#### Linguagem de consulta (query) usada:

        Java e C#

#### Casos de aplicações de cada tipo no mundo real:

        Sistemas de Controle de Versão: Ferramentas de controle de versão de software, como o Git, podem usar um SGBD orientado a objetos para armazenar e gerenciar eficientemente as mudanças no código-fonte e nos artefatos associados.

### SGBD Em Memória

#### Características:

        Armazena dados na memória principal para acesso rápido.
        Ideal para aplicações que exigem baixa latência e alto desempenho.

#### Funcionalidades:

        Acesso extremamente rápido aos dados.
        Redução significativa do tempo de resposta das consultas.

#### Vantagens:

        Alta velocidade de processamento.
        Ideal para aplicações que requerem respostas instantâneas.

#### Linguagem de consulta (query) usada:

        SQL

#### Casos de aplicações de cada tipo no mundo real:

        Análise de Dados em Tempo Real: Aplicações que exigem análise de dados em tempo real, como monitoramento de sistemas, análise de logs e detecção de fraudes, podem se beneficiar de bancos de dados em memória para processar e analisar grandes volumes de dados em tempo real.


## Fontes:

        https://www.alura.com.br/artigos/sgbds-relacionais
        https://www.mongodb.com/databases/types
        https://www.pluralsight.com/blog/software-development/relational-vs-non-relational-databases
        https://www.talend.com/resources/sql-vs-nosql/
        https://www.mongodb.com/nosql-explained/nosql-vs-sql

        Chatgpt