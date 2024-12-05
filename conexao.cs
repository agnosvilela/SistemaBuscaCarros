using Microsoft.Data.SqlClient;


public static class DbConnectionFactory
{
    private static readonly string connectionString = "Data Source =DESKTOP-VSKKMH7\\SQLEXPRESS; Initial catalog=Loja; TrustServerCertificate=true; Integrated Security=true";

    public static SqlConnection getInstance()
    {
        return new SqlConnection(connectionString);
    }
}
