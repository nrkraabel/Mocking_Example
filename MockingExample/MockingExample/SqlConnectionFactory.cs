using MySql.Data.MySqlClient;
using System.Data;


namespace SQLExample
{
    class SqlConnectionFactory: IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new MySqlConnection("Conection String");
        }
    }
}
