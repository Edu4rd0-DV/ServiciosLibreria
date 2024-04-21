using EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;
namespace ServiviciosLibreria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        int agregar_producto(_EN pen);
    }
}
