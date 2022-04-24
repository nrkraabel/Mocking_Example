
using System.Data;


namespace SQLExample
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
