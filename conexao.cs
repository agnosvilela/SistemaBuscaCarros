using Microsoft.Data.SqlClient;


public static class DbConnectionFactory
{
    private static readonly string connectionString = "";

    public static SqlConnection getInstance()
    {
        return new SqlConnection(connectionString);
    }
}
