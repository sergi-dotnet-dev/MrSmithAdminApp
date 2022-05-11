using System.Data.SqlClient;

namespace SubscriptionUserAdministration.Utils;

internal sealed class DBUtils
{
    public static SqlConnection GetConnection()
    {
        String datasource = @"inspector\localsqlserver";
        String database = "SubsDatabase";
        String username = @"Inspector\buras";
        String password = "win461983";

        return DBSqlServerUtils.GetConnection(datasource, database, username, password);
    }
}