using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;
namespace BL
{
    public class _BL
    {
        Dal _dal = new Dal();

        public int pago( _EN en)
        {
            return _dal.agregar_pago(en);
        }


    }
}
