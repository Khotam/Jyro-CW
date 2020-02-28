using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.DAL
{
    public class DbManager
    {
        protected SqlCeConnection Connection
        {
            get
            {
                return new SqlCeConnection(Properties.Settings.Default.ConnectionString);
            }
        }

    }
}
