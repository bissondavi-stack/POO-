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
