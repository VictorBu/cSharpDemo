using System;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace WCF.Server.CustomValidator
{
    /// <summary>
    /// 
    /// https://docs.microsoft.com/en-us/dotnet/framework/wcf/feature-details/how-to-use-a-custom-user-name-and-password-validator
    /// 
    /// </summary>
    public class CustomUserNameValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException();
            }

            if (!(userName == "test1" && password == "1tset"))
            {
                // This throws an informative fault to the client.
                throw new FaultException("Unknown Username or Incorrect Password");
                // When you do not want to throw an infomative fault to the client,
                // throw the following exception.
                // throw new SecurityTokenException("Unknown Username or Incorrect Password");
            }
        }
    }
}
