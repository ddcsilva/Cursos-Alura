using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class ArtistaDAL
{
    // Método para listar todos os artistas presentes no banco de dados.
    public IEnumerable<Artista> Listar()
    {
        // Cria uma lista para armazenar os artistas que serão lidos do banco de dados.
        var listaArtistas = new List<Artista>();

        // Obtém uma nova conexão com o banco de dados e abre a conexão.
        using var connection = new Connection().ObterConexao();
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

    // Método para adicionar um novo artista ao banco de dados.
    public void Adicionar(Artista artista)
    {
        // Obtém uma nova conexão com o banco de dados e abre a conexão.
        using var connection = new Connection().ObterConexao();
        connection.Open();

        // Define a consulta SQL que será executada para adicionar um novo artista.
        string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@Nome, @FotoPerfil, @Bio)";
        SqlCommand command = new(sql, connection);

        // Define os parâmetros da consulta com os valores do artista.
        command.Parameters.AddWithValue("@Nome", artista.Nome);
        command.Parameters.AddWithValue("@FotoPerfil", artista.FotoPerfil);
        command.Parameters.AddWithValue("@Bio", artista.Bio);

        // Executa o comando para adicionar o artista ao banco de dados.
        int linhasAfetadas = command.ExecuteNonQuery();
        Console.WriteLine($"Artista adicionado com sucesso! Linhas afetadas: {linhasAfetadas}");
    }
}
