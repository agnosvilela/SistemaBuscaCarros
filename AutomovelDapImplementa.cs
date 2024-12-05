using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSCARROS
{
    public class AutomovelDapImplementa : IAutomovelDAO
    {
        private readonly SqlConnection connection;

        public AutomovelDapImplementa()
        {
            connection = new SqlConnection(); // Inicializa com uma nova instância
        }

        public void inserir(Automovel automovel)
        {
            connection.ConnectionString = DbConnectionFactory.getInstance().ConnectionString;
            connection.Open();

            SqlCommand command = new SqlCommand
            {
                CommandText = "INSERT INTO Carro (ID, MARCA, MODELO, ANO, COR) VALUES(@ID, @MARCA, @MODELO, @ANO, @COR)",
                Connection = connection,
                CommandType = System.Data.CommandType.Text
            };

            // adicionando valores à query
            command.Parameters.AddWithValue("@ID", automovel.Id);
            command.Parameters.AddWithValue("@MARCA", automovel.Marca);
            command.Parameters.AddWithValue("@MODELO", automovel.Modelo);
            command.Parameters.AddWithValue("@ANO", automovel.Ano);
            command.Parameters.AddWithValue("@COR", automovel.Cor);
            command.ExecuteNonQuery();
            connection.Close();
        }

        

        

        public Automovel buscarPorModelo(string modelo)
        {
            connection.ConnectionString = DbConnectionFactory.getInstance().ConnectionString;
            connection.Open();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT * FROM Carro WHERE MODELO = @MODELO",
                Connection = connection,
                CommandType = System.Data.CommandType.Text
            };
            command.Parameters.AddWithValue("@MODELO", modelo);

            SqlDataReader reader = command.ExecuteReader();
            Automovel automovel = new Automovel();

            if (reader.Read())
            {
                automovel.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
                automovel.Marca = reader["MARCA"]?.ToString() ?? string.Empty;
                automovel.Modelo = reader["MODELO"]?.ToString() ?? string.Empty;
                automovel.Ano = reader["ANO"] != DBNull.Value ? Convert.ToInt32(reader["ANO"]) : 0;
                automovel.Cor = reader["COR"]?.ToString() ?? string.Empty;
            }

            connection.Close();
            return automovel;
        }
    }
}
