using SubscriptionUserAdministration.Core.Models;
using SubscriptionUserAdministration.Utils;
using System.Data.SqlClient;
using System.Text.Json;

namespace SubscriptionUserAdministration.Core.Queries;
internal static class QueryHolder
{
    #region CRUD-methods apply Subatabase.Subscribers
    public static async Task Create(UserModel subscriber)
    {
        using SqlConnection conn = DBUtils.GetConnection();
        await conn.OpenAsync();

        String sql = "Insert into Subscribers (Id, Name, LastName, PhoneNumber, IsExpired, ExpiriationDate)" +
        "values (@id, @name, @lastName, @phoneNumber, @isExpired, @expiriationDate)";

        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        try
        {
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = subscriber.Id;
            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = subscriber.Name;
            cmd.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar).Value = subscriber.LastName;
            cmd.Parameters.Add("@phoneNumber", System.Data.SqlDbType.Char).Value = subscriber.PhoneNumber;
            cmd.Parameters.Add("@isExpired", System.Data.SqlDbType.Bit).Value = subscriber.IsExpired;
            cmd.Parameters.Add("@expiriationDate", System.Data.SqlDbType.SmallDateTime).Value = subscriber.SubExpiriationDate;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Пользователь успешно добавлен в базу");
        }
        catch (System.Data.SqlClient.SqlException sqlEx)
        {
            MessageBox.Show("Пользователь с таким идентификационным номером уже существует\n" +
                              "Используйте предложенный идентификатор", "Ошибка внесения в базу", MessageBoxButtons.OK);
        }
    }
    public static UserModel Read(Int32 subId)
    {
        UserModel result = new UserModel(0, String.Empty, String.Empty, String.Empty, DateTime.Now);
        SqlConnection? conn = DBUtils.GetConnection();
        conn.Open();
        String sql = @$"Select * From Subscribers as subs where subs.Id = {subId}";

        SqlCommand command = new SqlCommand(sql, conn);

        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Int32 id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String lastname = reader.GetString(2);
                    String phoneNumber = reader.GetString(3);
                    Boolean isExpired = reader.GetBoolean(4);
                    DateTime subExpiriationDate = reader.GetDateTime(5);

                    UserModel subscriber = new UserModel(id, name, lastname, phoneNumber, subExpiriationDate, isExpired);
                    result = subscriber;
                }
            }
            return result;
        }
    }
    public static UserModel Read(String subPhoneNumber)
    {
        UserModel result = new UserModel(0, String.Empty, String.Empty, String.Empty, DateTime.Now);
        SqlConnection? conn = DBUtils.GetConnection();
        conn.Open();
        String sql = @$"Select * From Subscribers as subs where subs.Id = {subPhoneNumber}";

        SqlCommand command = new SqlCommand(sql, conn);

        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Int32 id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String lastname = reader.GetString(2);
                    String phoneNumber = reader.GetString(3);
                    Boolean isExpired = reader.GetBoolean(4);
                    DateTime subExpiriationDate = reader.GetDateTime(5);

                    UserModel subscriber = new UserModel(id, name, lastname, phoneNumber, subExpiriationDate, isExpired);
                    result = subscriber;
                }
            }
            return result;
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
    #endregion

    #region Support methods aplly SubsDatabase.Identificators
    public static async Task Pop(Int32 id)
    {
        String sql = @$"Delete from Identificators where Id = {id}";

        using (SqlConnection conn = DBUtils.GetConnection())
        {
            await conn.OpenAsync();
            SqlCommand command = new SqlCommand(sql, conn);

            command.ExecuteNonQuery();
        }
    }
    public static async Task Push(Int32 id)
    {
        String sql = $@"Insert into Identificators (Id) values (@id)";

        using (SqlConnection conn = DBUtils.GetConnection())
        {
            await conn.OpenAsync();

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            command.ExecuteNonQuery();
        }
    }
    public static Int32 GetMinFreeId()
    {
        String sql = $@"Select top(1) * from Identificators order by Identificators.Id asc";
        Int32 result = 0;

        using (SqlConnection conn = DBUtils.GetConnection())
        {
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                    while (reader.Read())
                        result = reader.GetInt32(0);

                return result;
            }
        }
    }
    #endregion
}