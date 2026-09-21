 Como o C# se conecta ao banco?
O C# usa um "conector" de código. Você cria um objeto de conexão no código, passa o endereço do banco para ele e chama o comando .Open() para abrir a porta de comunicação.
 
Qual biblioteca/driver é utilizado?
Para o SQL Server (o banco mais comum com C#), o driver oficial atual se chama Microsoft.Data.SqlClient.
 
Como ela é adicionada ao projeto?
Ela é adicionada pelo NuGet (a loja de componentes do C#). Você pode instalar digitando o comando dotnet add package Microsoft.Data.SqlClient no terminal ou clicando com o botão direito no projeto no Visual Studio e escolhendo "Gerenciar Pacotes NuGet".
 
O que é uma string de conexão?
É um texto de configuração. Funciona como o "endereço completo com senha" que o seu programa usa para encontrar e entrar no banco de dados.
 
Quais informações aparecem nela?
Geralmente são 4 informações principais
 
1. Server: Onde o banco está (ex: no seu computador ou na nuvem).
 
2. Database: O nome do banco de dados que você quer abrir.
 
3.User ID: O usuário de acesso.
 
4. Password: A senha desse usuário.
 
Exemplo visual: Server=MeuServidor;Database=MeuBanco;User Id=usuario;Password=senha123;
