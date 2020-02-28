using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;


namespace Jyro.DAL
{
    public class SprintManager : DbManager
    {

        public void Create(Sprint s)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
INSERT INTO sp_sprint (sp_name_7717, sp_date_7717, sp_no_of_developers_7717, sp_status) 
VALUES('{s.Name}', '{s.Date}', '{s.NumberOfDevelopers}', '{s.Status}')";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }

        public void Update(Sprint s)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
UPDATE sp_sprint SET 
    sp_name_7717 = '{s.Name}', 
    sp_date_7717 = '{s.Date},
    sp_no_of_developers_7717 = '{s.NumberOfDevelopers}', 
    sp_status = '{s.Status}', 
WHERE ti_id_7717 = {s.Id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM sp_sprint WHERE sp_id_7717 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public Sprint GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT sp_id_7717, sp_name_7717, sp_date_7717, sp_no_of_developers_7717, sp_status
FROM sp_sprint
WHERE sp_id_7717 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var a = GetFromReader(reader);
                    return a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            // if we are here - something went wrong
            return null;
        }

        public List<Sprint> GetAll()
        {
            var connection = Connection;
            var result = new List<Sprint>();
            try
            {
                var sql = "SELECT sp_id_7717, sp_name_7717, sp_date_7717, sp_no_of_developers_7717, sp_status FROM sp_sprint";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }

        private Sprint GetFromReader(SqlCeDataReader reader)
        {
            var s = new Sprint
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = reader.GetValue(1).ToString(),
                Date = Convert.ToDateTime(reader.GetValue(2)),
                NumberOfDevelopers = Convert.ToInt32(reader.GetValue(3)),
                Status = reader.GetValue(4).ToString(),
            };

            return s;
        }
    }
}
