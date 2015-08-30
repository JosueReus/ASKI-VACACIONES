using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service_Asky
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        void addDepartamentos(string descripcion);
        [OperationContract]
        void addRoles(string descripcion);

        [OperationContract]
        void addUsuario(int talento_humano, string email, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, DateTime fecha_ingreso, string password);

        [OperationContract]
        void addPermisos(string descripcion);

        [OperationContract]
        vsystem_askiEntities getDb();

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Service_Asky.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
