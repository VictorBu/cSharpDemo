using System.ServiceModel;

namespace WCF.Server.CustomValidator
{
    [ServiceContract(Namespace = "https://github.com", Name = "CustomValidatorService")]
    public interface IService
    {
        [OperationContract]
        string Hello();
    }

    public class CustomValidatorService : IService
    {
        public string Hello()
        {
            return "Hello from CustomValidator";
        }
    }
}
