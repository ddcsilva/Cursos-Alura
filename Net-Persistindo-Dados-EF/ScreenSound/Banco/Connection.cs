using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class Connection
{
    private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }

    public IEnumerable<Artista> ListarArtistas()
    {
        var listaArtistas = new List<Artista>();

        using var connection = ObterConexao();
        connection.Open();

        string sql = "SELECT * FROM Artistas";
        SqlCommand command = new(sql, connection);
        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            string nomeArtista = Convert.ToString(reader["Nome"]);
            string biografiaArtista = Convert.ToString(reader["Bio"]);
            int idArtista = Convert.ToInt32(reader["Id"]);

            Artista artista = new Artista(nomeArtista, biografiaArtista)
            {
                Id = idArtista
            };

            listaArtistas.Add(artista);
        }

        return listaArtistas;
    }
}
