using SubscriptionUserAdministration.Core.Models;
using SubscriptionUserAdministration.Utils;
using System.Data.SqlClient;
using System.Text.Json;

namespace SubscriptionUserAdministration.Core.Queries;
internal static class QueryHolder
{
    public static async Task Create(UserModel subscriber)
    {
        using (SqlConnection conn = DBUtils.GetConnection())
        {
            await conn.OpenAsync();

            String sql = "Insert into Subscribers (Id, Name, LastName, PhoneNumber, IsExpired, ExpiriationDate)" +
            "values (@id, @name, @lastName, @phoneNumber, @isExpired, @expiriationDate)";

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = subscriber.Id;
            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = subscriber.Name;
            cmd.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar).Value = subscriber.LastName;
            cmd.Parameters.Add("@phoneNumber", System.Data.SqlDbType.Char).Value = subscriber.PhoneNumber;
            cmd.Parameters.Add("@isExpired", System.Data.SqlDbType.Bit).Value = subscriber.IsExpired;
            cmd.Parameters.Add("@expiriationDate", System.Data.SqlDbType.SmallDateTime).Value = subscriber.SubExpiriationDate;

            cmd.ExecuteNonQuery();
        }
    }
    public static async Task Read(Int32 subId)
    {
        SqlConnection? conn = DBUtils.GetConnection();
        await conn.OpenAsync();
        String sql = @$"Select * From Subscribers as subs where subs.Id = {subId}";

        SqlCommand command = new SqlCommand(sql, conn);

        using (SqlDataReader reader = await command.ExecuteReaderAsync())
        {
            if (reader.HasRows)
            {
                while (await reader.ReadAsync())
                {
                    Int32 id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String lastname = reader.GetString(2);
                    String phoneNumber = reader.GetString(3);
                    Boolean isExpired = reader.GetBoolean(4);
                    DateTime subExpiriationDate = reader.GetDateTime(5);

                    UserModel subscriber = new UserModel(id, name, lastname, phoneNumber, subExpiriationDate, isExpired);
                    if (File.Exists("subscriber.json"))
                        File.Delete("subscriber.json");
                    using (FileStream fs = new FileStream("subscriber.json", FileMode.OpenOrCreate))
                        await JsonSerializer.SerializeAsync(fs, subscriber);
                }
            }
        }
    }
    public static async Task Read(String subPhoneNumber)
    {
        SqlConnection? conn = DBUtils.GetConnection();
        await conn.OpenAsync();
        String sql = @$"Select * From Subscribers as subs where subs.PhoneNumber = {subPhoneNumber}";

        SqlCommand command = new SqlCommand(sql, conn);

        using (SqlDataReader reader = await command.ExecuteReaderAsync())
        {
            if (reader.HasRows)
            {
                while (await reader.ReadAsync())
                {
                    Int32 id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String lastname = reader.GetString(2);
                    String phoneNumber = reader.GetString(3);
                    Boolean isExpired = reader.GetBoolean(4);
                    DateTime subExpiriationDate = reader.GetDateTime(5);

                    UserModel subscriber = new UserModel(id, name, lastname, phoneNumber, subExpiriationDate, isExpired);
                    if (File.Exists("subscriber.json"))
                        File.Delete("subscriber.json");
                    using (FileStream fs = new FileStream("subscriber.json", FileMode.OpenOrCreate))
                        await JsonSerializer.SerializeAsync(fs, subscriber);
                }
            }
        }
    }
    public static async Task Read()
    {
        SqlConnection? conn = DBUtils.GetConnection();
        await conn.OpenAsync();
        String sql = @$"select top(1) * from Subscribers order by Subscribers.Id desc";

        SqlCommand command = new SqlCommand(sql, conn);
        try
        {
            using (SqlDataReader reader = await command.ExecuteReaderAsync())
            {
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        Int32 id = reader.GetInt32(0);
                        String name = reader.GetString(1);
                        String lastname = reader.GetString(2);
                        String phoneNumber = reader.GetString(3);
                        Boolean isExpired = reader.GetBoolean(4);
                        DateTime subExpiriationDate = reader.GetDateTime(5);

                        UserModel subscriber = new UserModel(id, name, lastname, phoneNumber, subExpiriationDate, isExpired);
                        if (File.Exists("lastSub.json")) 
                            File.Delete("lastSub.json");
                        using (FileStream fs = new FileStream("lastSub.json", FileMode.OpenOrCreate))
                            await JsonSerializer.SerializeAsync(fs, subscriber);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"sd");
        }
    }
    public static async Task Update(UserModel subscriber)
    {
        String sql = @$"Update Subscribers set Name = @name, LastName = @lastname, PhoneNumber = @phonenumber, ExpiriationDate = @date where Id = {subscriber.Id}";
        using (SqlConnection conn = DBUtils.GetConnection())
        {
            await conn.OpenAsync();
            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = subscriber.Name;
            command.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar).Value = subscriber.LastName;
            command.Parameters.Add("@phonenumber", System.Data.SqlDbType.Char).Value = subscriber.PhoneNumber;
            command.Parameters.Add("@date", System.Data.SqlDbType.SmallDateTime).Value = subscriber.SubExpiriationDate;

            command.ExecuteNonQuery();
        }
    }
    public static async Task Delete(UserModel subscriber)
    {
        String sql = @$"Delete from Subscribers where Id = {subscriber.Id}";

        using (SqlConnection conn = DBUtils.GetConnection())
        {
            await conn.OpenAsync();

            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
        }
    }
}

