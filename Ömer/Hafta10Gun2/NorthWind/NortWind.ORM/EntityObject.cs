using NorthWind.ORM;
using NortWind.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace NorthWind.ORM
{
    public interface IEntityObject
    {
        string InsertProcedure { get; }
    }
    public static partial class EntityObject
    {
        public static bool Insert<T>(this T entityObject) where T : IEntityObject
        {
            var command = new SqlCommand(entityObject.InsertProcedure, Tools.Connection)
            {
                CommandType = CommandType.StoredProcedure,
            };
            IEnumerable<PropertyInfo> assignProperties = GetAssignableProps(entityObject);
            foreach (var property in assignProperties)
            {
                command.Parameters.AddWithValue("@" + property.Name, property.GetValue(entityObject));
            }
            return Tools.ExecuteNonQuery(command);
        }
        public static bool Insert<T>(this T entityObject, string procedureName, params SqlParameter[] parameters) where T : IEntityObject
        {
            var command = new SqlCommand(procedureName)
            {
                CommandType = CommandType.StoredProcedure,
            };
            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }
            return Tools.ExecuteNonQuery(command);
        }
        private static IEnumerable<PropertyInfo> GetAssignableProps<T>(T entityObject)
        {
            PropertyInfo[] allProps = typeof(T).GetProperties();
            foreach (var property in allProps)
            {
                if (property.GetCustomAttribute<DontInclude>() == null)
                {
                    yield return property;
                }
            }
        }

    }
    public static partial class EntityObject
    {
        public static DataTable SelectQuery(string procedureName)
        {
            var adp = new SqlDataAdapter(procedureName, Tools.Connection);
            var dt = new DataTable();

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
    }
}
