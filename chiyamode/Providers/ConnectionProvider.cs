using System.Data;
using Npgsql;

namespace chiyamode.Providers
{
    public class ConnectionProvider
    {
        public static IDbConnection GetConnection() => new NpgsqlConnection("Server=localhost;database=chiyamode;Uid=postgres;Pwd=12345678");
    }
}