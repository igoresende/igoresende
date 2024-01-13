using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DesignPatterns2.Factory
{
    public class ConnectionFactory
    {
        /*
         * Usamos uma fábrica quando temos que isolar o processo de criação de um objeto em um único lugar. 
         * Essa fábrica pode descobrir como criar o objeto dentro dela própria, mas geralmente ela não precisa 
         * de muitas informações para criar o objeto.
         */
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = "User Id=root; Server=localhost;Database=meuBanco";
            connection.Open();

            return connection;
        }
    }
}
