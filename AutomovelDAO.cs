using BUSCARROS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public interface IAutomovelDAO
{
    void inserir(Automovel automovel);
    Automovel buscarPorModelo(string modelo);
}
//  private string connectionString ="Data Source =DESKTOP-VSKKMH7\\SQLEXPRESS; Initial catalog=Loja; TrustServerCertificate=true; Integrated Security=true";
