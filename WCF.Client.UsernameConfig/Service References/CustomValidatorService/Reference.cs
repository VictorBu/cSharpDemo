﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF.Client.UsernameConfig.CustomValidatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://github.com", ConfigurationName="CustomValidatorService.CustomValidatorService")]
    public interface CustomValidatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://github.com/CustomValidatorService/Hello", ReplyAction="https://github.com/CustomValidatorService/HelloResponse")]
        string Hello();
        
        [System.ServiceModel.OperationContractAttribute(Action="https://github.com/CustomValidatorService/Hello", ReplyAction="https://github.com/CustomValidatorService/HelloResponse")]
        System.Threading.Tasks.Task<string> HelloAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CustomValidatorServiceChannel : WCF.Client.UsernameConfig.CustomValidatorService.CustomValidatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomValidatorServiceClient : System.ServiceModel.ClientBase<WCF.Client.UsernameConfig.CustomValidatorService.CustomValidatorService>, WCF.Client.UsernameConfig.CustomValidatorService.CustomValidatorService {
        
        public CustomValidatorServiceClient() {
        }
        
        public CustomValidatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomValidatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomValidatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomValidatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Hello() {
            return base.Channel.Hello();
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync() {
            return base.Channel.HelloAsync();
        }
    }
}
