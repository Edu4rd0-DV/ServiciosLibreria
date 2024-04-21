using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
namespace DAL
{
    public class Dal
    {

         _EN en_ = new _EN();
        public int agregar_pago(_EN en_)
        {
            IDbConnection _con = conexion.cnBD();
            SqlCommand _comando = new SqlCommand("guardar_compra", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@tipo", en_.tipo));
            _comando.Parameters.Add(new SqlParameter("@cantidad", en_.cantidad));
            _comando.Parameters.Add(new SqlParameter("@pago", en_.pago));
            _comando.Parameters.Add(new SqlParameter("@fecha", en_.fecha));
            int resuladato = _comando.ExecuteNonQuery();
            _con.Close();
            return resuladato;



        }

    }
}
