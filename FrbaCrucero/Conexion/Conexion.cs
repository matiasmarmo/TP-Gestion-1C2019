using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Conexion
{
    class Conexion
    {
        public SqlConnection conectar()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = DESKTOP-Q7PPQN2\\SQLSERVER2012; Initial Catalog = GD1C2019; Integrated Security = true";
            return cn;

        }
    }
}