using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class conexion
    {
        
            private static string conn = @"Data Source=DESKTOP-RTQRIVR\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";

            public static IDbConnection cnBD()
            {
                return new SqlConnection(conn);
            }
            public static IDbCommand conexionCommand(string pComando, IDbConnection pcn)
            {

                return new SqlCommand(pComando, pcn as SqlConnection);

            }




        }
    }
