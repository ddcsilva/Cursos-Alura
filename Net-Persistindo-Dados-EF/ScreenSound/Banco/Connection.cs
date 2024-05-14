using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class Connection
{
    // Define a string de conexão usada para conectar ao banco de dados SQL Server.
    private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    // Método para obter uma nova conexão SQL usando a string de conexão definida.
    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }

    // Método para listar todos os artistas presentes no banco de dados.
    public IEnumerable<Artista> ListarArtistas()
    {
        // Cria uma lista para armazenar os artistas que serão lidos do banco de dados.
        var listaArtistas = new List<Artista>();

        // Obtém uma nova conexão com o banco de dados e abre a conexão.
        using var connection = ObterConexao();
        connection.Open();

        // Define a consulta SQL que será executada para obter todos os artistas.
        string sql = "SELECT * FROM Artistas";
        SqlCommand command = new(sql, connection);

        // Executa o comando e obtém um leitor de dados para ler os resultados da consulta.
        using SqlDataReader reader = command.ExecuteReader();

        // Itera sobre os resultados da consulta.
        while (reader.Read())
        {
            // Lê os valores de cada coluna no resultado da consulta.
            string nomeArtista = Convert.ToString(reader["Nome"]);
            string biografiaArtista = Convert.ToString(reader["Bio"]);
            int idArtista = Convert.ToInt32(reader["Id"]);

            // Cria um novo objeto Artista com os valores lidos.
            Artista artista = new Artista(nomeArtista, biografiaArtista)
            {
                Id = idArtista
            };

            // Adiciona o artista à lista de artistas.
            listaArtistas.Add(artista);
        }

        // Retorna a lista de artistas.
        return listaArtistas;
    }
}
