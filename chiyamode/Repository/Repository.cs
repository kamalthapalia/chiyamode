using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using chiyamode.Repository;
using Dapper;

namespace chiyamode.Providers
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IDbConnection _connection;

        public Repository()
        {
            _connection = ConnectionProvider.GetConnection();
        }
        protected void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
        }

        protected void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
                _connection.Close();
        }

        public virtual T Save(T entity)
        {
            try
            {
                OpenConnection();

                var tableName = typeof(T).Name.ToLower();
                var properties = typeof(T).GetProperties();
                var nonIdProperties = properties.Where(p => !p.Name.Equals("Id", StringComparison.OrdinalIgnoreCase));
                var columns = string.Join(", ", nonIdProperties.Select(p => $"\"{p.Name.ToLower()}\""));
                var values = string.Join(", ", nonIdProperties.Select(p => $"@{p.Name.ToLower()}"));


                var insertQuery = $"INSERT INTO {tableName} ({columns}) VALUES ({values}) RETURNING *";

                // Execute the query and return the inserted entity
                return _connection.QuerySingleOrDefault<T>(insertQuery, entity);
            }
            catch (Exception ex)
            {
                // Handle the exception. You might want to log it or throw a custom exception.
                throw new ApplicationException($"Error saving {typeof(T).Name}.", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public virtual T GetById(int id)
        {
            try
            {
                OpenConnection();

                var tableName = typeof(T).Name;
                var getByIdQuery = $"SELECT * FROM {tableName} WHERE Id = @Id";

                return _connection.QuerySingleOrDefault<T>(getByIdQuery, new { Id = id });
            }
            catch (Exception ex)
            {
                // Handle the exception. You might want to log it or throw a custom exception.
                throw new ApplicationException($"Error getting {typeof(T).Name} by ID.", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                OpenConnection();

                var tableName = typeof(T).Name;
                var getAllQuery = $"SELECT * FROM {tableName}";

                return _connection.Query<T>(getAllQuery);
            }
            catch (Exception ex)
            {
                // Handle the exception. You might want to log it or throw a custom exception.
                throw new ApplicationException($"Error getting all {typeof(T).Name}.", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                OpenConnection();

                var tableName = typeof(T).Name;
                var properties = typeof(T).GetProperties();

                var updateColumns = string.Join(", ", properties.Select(p => $"\"{p.Name}\" = @{p.Name}"));
                var updateQuery = $"UPDATE {tableName} SET {updateColumns} WHERE Id = @Id RETURNING *";

                _connection.QuerySingleOrDefault<T>(updateQuery, entity);
            }
            catch (Exception ex)
            {
                // Handle the exception. You might want to log it or throw a custom exception.
                throw new ApplicationException($"Error updating {typeof(T).Name}.", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public virtual void Delete(int id)
        {
            try
            {
                OpenConnection();

                var tableName = typeof(T).Name;
                var deleteQuery = $"DELETE FROM {tableName} WHERE Id = @Id";

                _connection.Execute(deleteQuery, new { Id = id });
            }
            catch (Exception ex)
            {
                // Handle the exception. You might want to log it or throw a custom exception.
                throw new ApplicationException($"Error deleting {typeof(T).Name} by ID.", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool Login(string username, string password)
        {
            try
            {
                OpenConnection();

                // Assuming you have a 'Users' table with 'Username' and 'Password' columns
                var tableName = "Users";
                var loginQuery = $"SELECT COUNT(*) FROM {tableName} WHERE Username = @Username AND Password = @Password";

                var result = _connection.ExecuteScalar<int>(loginQuery, new { Username = username, Password = password });

                return result > 0;
            }
            catch (Exception ex)
            {
                // Handle the exception. You might want to log it or throw a custom exception.
                throw new ApplicationException($"Error during login check for {typeof(T).Name}.", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
