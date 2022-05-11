using System.Data.SqlClient;

namespace SubscriptionUserAdministration.Utils;

internal sealed class DBSqlServerUtils
{
    public static SqlConnection GetConnection(String datasource, String database, String username, String password)
    {
        string connString = @"Data Source=" + datasource + ";Initial Catalog="
                     + database + ";Integrated Security=true; User ID=" + username + ";Password=" + password;

        SqlConnection connect = new SqlConnection(connString);
        return connect;
    }
}

