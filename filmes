using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Ano { get; set; }

    public Filme()
    {
    }

    public Filme(string titulo, string genero, int ano)
    {
        Titulo = titulo;
        Genero = genero;
        Ano = ano;
    }

    public override string ToString()
    {
        return $"{Id} - {Titulo} - {Genero} - {Ano}";
    }

    public void Inserir()
    {
        Conexao conexao = new Conexao();

        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql =
                "INSERT INTO filmes (titulo, genero, ano) " +
                "VALUES (@titulo, @genero, @ano)";

            MySqlCommand comando =
                new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@titulo", Titulo);
            comando.Parameters.AddWithValue("@genero", Genero);
            comando.Parameters.AddWithValue("@ano", Ano);

            comando.ExecuteNonQuery();
        }
    }
    public void Atualizar()
    {
        Conexao conexao = new Conexao();

        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql =
                "UPDATE filmes SET titulo = @titulo, genero = @genero, ano = @ano " +
                "WHERE id = @id";

            MySqlCommand comando =
                new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@titulo", Titulo);
            comando.Parameters.AddWithValue("@genero", Genero);
            comando.Parameters.AddWithValue("@ano", Ano);
            comando.Parameters.AddWithValue("@id", Id);

            comando.ExecuteNonQuery();
        }
    }
    public void Excluir()
    {
        Conexao conexao = new Conexao();

        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql =
                "DELETE FROM filmes WHERE id = @id";

            MySqlCommand comando =
                new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@id", Id);

            comando.ExecuteNonQuery();
        }
    }
    public List<Filme> Listar()
    {
        List<Filme> filmes = new List<Filme>();

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

                filmes.Add(filme);
            }
        }

        return filmes;
    }
    public static Filme ObterPorId(int id)
    {
        Filme filme = null;

        Conexao conexao = new Conexao();

        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql = "SELECT * FROM filmes WHERE id = @id";

            MySqlCommand comando =
                new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader leitor =
                comando.ExecuteReader();

            if (leitor.Read())
            {
                filme = new Filme();

                filme.Id = leitor.GetInt32("id");
                filme.Titulo = leitor.GetString("titulo");
                filme.Genero = leitor.GetString("genero");
                filme.Ano = leitor.GetInt32("ano");
            }
        }

        return filme;
    }
    public void Menu()
{
    int opcao = 0;

    do
    {
        Console.WriteLine("\n--- MENU FILMES ---");
        Console.WriteLine("1 - Inserir filme");
        Console.WriteLine("2 - Atualizar filme");
        Console.WriteLine("3 - Excluir filme");
        Console.WriteLine("4 - Listar filmes");
        Console.WriteLine("5 - Obter filme por ID");
        Console.WriteLine("0 - Sair");

        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Gênero: ");
                string genero = Console.ReadLine();

                Console.Write("Ano: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                Filme novoFilme = new Filme(
                    titulo,
                    genero,
                    ano
                );

                novoFilme.Inserir();

                Console.WriteLine("Filme inserido!");
                break;

            case 2:
                Console.Write("ID do filme: ");
                int idAtualizar = Convert.ToInt32(
                    Console.ReadLine()
                );

                Filme filmeAtualizar =
                    Filme.ObterPorId(idAtualizar);

                if (filmeAtualizar != null)
                {
                    Console.Write("Novo título: ");
                    filmeAtualizar.Titulo =
                        Console.ReadLine();

                    Console.Write("Novo gênero: ");
                    filmeAtualizar.Genero =
                        Console.ReadLine();

                    Console.Write("Novo ano: ");
                    filmeAtualizar.Ano =
                        Convert.ToInt32(Console.ReadLine());

                    filmeAtualizar.Atualizar();

                    Console.WriteLine("Filme atualizado!");
                }
                else
                {
                    Console.WriteLine("Filme não encontrado!");
                }
                break;

            case 3:
                Console.Write("ID do filme: ");
                int idExcluir = Convert.ToInt32(
                    Console.ReadLine()
                );

                Filme filmeExcluir =
                    Filme.ObterPorId(idExcluir);

                if (filmeExcluir != null)
                {
                    filmeExcluir.Excluir();

                    Console.WriteLine("Filme excluído!");
                }
                else
                {
                    Console.WriteLine("Filme não encontrado!");
                }
                break;

            case 4:
                List<Filme> filmes = Listar();

                foreach (Filme filme in filmes)
                {
                    Console.WriteLine(filme);
                }
                break;

            case 5:
                Console.Write("ID do filme: ");
                int idBuscar = Convert.ToInt32(
                    Console.ReadLine()
                );

                Filme filmeBuscar =
                    Filme.ObterPorId(idBuscar);

                if (filmeBuscar != null)
                {
                    Console.WriteLine(filmeBuscar);
                }
                else
                {
                    Console.WriteLine("Filme não encontrado!");
                }
                break;

            case 0:
                Console.WriteLine("Saindo...");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

    } while (opcao != 0);
  }
}
