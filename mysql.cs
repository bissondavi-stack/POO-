using MySql.Data.MySqlClient;

public class Conexao
{
    private string conexao =
        "Server=localhost;" +
        "Database=cinema;" +
        "Uid=root;" +
        "Pwd=Senac2026;";

    public MySqlConnection Conectar()
    {
        MySqlConnection conn =
            new MySqlConnection(conexao);

        conn.Open();

        return conn;
    }
}

#agora o codigo do banco de dados

#CREATE DATABASE IF NOT EXISTS cinema;

#USE cinema;

#CREATE TABLE IF NOT EXISTS filmes (
#    id INT AUTO_INCREMENT PRIMARY KEY,
#    titulo VARCHAR(150) NOT NULL,
#    genero VARCHAR(100) NOT NULL,
#    ano INT NOT NULL
#);
