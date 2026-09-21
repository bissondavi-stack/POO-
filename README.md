# POO-Sistema de cadastro de filmes

## Integrantes
- Davi M
- Daniel
- Igor

## Tecnologias utilizadas
- C#
- .NET
- MySQL
- MySql.Data (biblioteca/driver de conexão com o MySQL)
- Visual Studio Code

## Banco de dados utilizado
O projeto utiliza o MySQL, com um banco de dados chamado `cinema` e uma tabela chamada `filmes`.

### Estrutura da tabela
| Coluna | Tipo |
|---|---|
| id | INT |
| titulo | VARCHAR |
| genero | VARCHAR |
| ano | INT |

## Como instalar as dependências
1. Instale o .NET SDK.
2. Instale o MySQL Server.
3. Abra o projeto no Visual Studio Code.
4. Instale o pacote MySql.Data pelo terminal
  -dotnet add package MySql.Data

## Como configurar o banco de dados
Abra o MySQL.

Crie um banco de dados chamado cinema.

Crie a tabela filmes.

Abra o arquivo Conexao.cs.

Configure a string de conexão com os dados do seu MySQL.

##Como executar o projeto
Abra o terminal na pasta do projeto.

Restaure as dependências:
dotnet restore

dotnet run

## Breve resumo de como funciona o projeto
A classe Conexao é responsável por conectar o programa C# ao banco de dados MySQL.

O método Conectar() cria uma conexão utilizando MySqlConnection e abre essa conexão com o banco.

A classe Filme utiliza essa conexão para executar comandos SQL:

INSERT: cadastra um filme.

SELECT: consulta os filmes.

UPDATE: atualiza os dados de um filme.

DELETE: exclui um filme.

O projeto utiliza parâmetros SQL, como @titulo, @genero e @id, para enviar valores ao banco de forma mais segura.

O MySqlDataReader é utilizado para ler os resultados das consultas SELECT.

A conexão com o banco de dados depende de o MySQL estar instalado e funcionando corretamente.

Também é necessário configurar a string de conexão com o usuário, senha e nome do banco de dados corretos.
