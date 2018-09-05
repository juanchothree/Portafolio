using System.ServiceModel;

namespace WSPortafolio
{


    [ServiceContract]

    public interface IWsPortafolio
    {
        //Validacion
        [OperationContract]
        bool Validar(string userName, string password);
    }
}