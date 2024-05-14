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
}
