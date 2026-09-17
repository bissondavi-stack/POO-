using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        Conexao conexao = new Conexao();

        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql = "SELECT * FROM filmes";

            MySqlCommand comando =
                new MySqlCommand(sql, conn);

            MySqlDataReader leitor =
                comando.ExecuteReader();

            while (leitor.Read())
            {
                Filme filme = new Filme();

                filme.Id = leitor.GetInt32("id");
                filme.Titulo = leitor.GetString("titulo");
                filme.Genero = leitor.GetString("genero");
                filme.Ano = leitor.GetInt32("ano");

                Console.WriteLine(filme);
            }
        }
    }
}
