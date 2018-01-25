using System.ServiceModel;

namespace WCF.Server.ByCode
{
    [ServiceContract(Namespace = "https://github.com/victorbu", Name = "GithubService")]
    public interface IService
    {
        [OperationContract]
        string Hello();
    }

    public class GithubService : IService
    {
        public string Hello()
        {
            return "Hello from Github";
        }
    }
}
