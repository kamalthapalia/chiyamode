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

                var tableName = typeof(T).Name;
                var properties = typeof(T).GetProperties();

                var columns = string.Join(", ", properties.Select(p => $"\"{p.Name}\""));
                var values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

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
    }
}
