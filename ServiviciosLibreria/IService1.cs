using EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BL;

namespace ServiviciosLibreria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public class IService1 : Service
    {
        _BL compra = new _BL();

        public int agregar_compra (_EN pen)
        {
           return compra.pago(pen);
        }
        
        
    }


    
    
}
