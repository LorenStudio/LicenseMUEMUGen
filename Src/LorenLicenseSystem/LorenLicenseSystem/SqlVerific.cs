
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace LorenLicenseSystem
{
    [Synchronization]
    public class SQLjec
    {
        protected SqlConnectionStringBuilder connBuilder;

        public SQLjec()
        {
            connBuilder = new SqlConnectionStringBuilder
            {
                InitialCatalog = Config.dbName,
                DataSource = Config.dbHost,
                UserID = Config.dbUser,
                Password = Config.dbPass
                //Port = Config.dbPort
            };
        }

        public static SQLjec getInstance() => new SQLjec();

        public SqlConnection Conn() => new SqlConnection(connBuilder.ConnectionString);
    }
}