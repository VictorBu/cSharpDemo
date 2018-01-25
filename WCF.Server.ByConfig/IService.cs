using System.ServiceModel;

namespace WCF.Server.ByConfig
{
    [ServiceContract(Namespace = "https://github.com/victorbu/csharpdemo", Name = "CSharpDemoService")]
    public interface IService
    {
        [OperationContract]
        string Hello();
    }

    public class CSharpDemoService : IService
    {
        public string Hello()
        {
            return "Hello from CSharpDemo";
        }
    }
}
