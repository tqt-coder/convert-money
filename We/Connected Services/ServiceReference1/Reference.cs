﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace We.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VNDToUSD", ReplyAction="*")]
        double VNDToUSD(double money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VNDToUSD", ReplyAction="*")]
        System.Threading.Tasks.Task<double> VNDToUSDAsync(double money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VNDToEUR", ReplyAction="*")]
        double VNDToEUR(double money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VNDToEUR", ReplyAction="*")]
        System.Threading.Tasks.Task<double> VNDToEURAsync(double money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/USDToVND", ReplyAction="*")]
        double USDToVND(double money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/USDToVND", ReplyAction="*")]
        System.Threading.Tasks.Task<double> USDToVNDAsync(double money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EURToVND", ReplyAction="*")]
        double EURToVND(double money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EURToVND", ReplyAction="*")]
        System.Threading.Tasks.Task<double> EURToVNDAsync(double money);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : We.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<We.ServiceReference1.WebService1Soap>, We.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double VNDToUSD(double money) {
            return base.Channel.VNDToUSD(money);
        }
        
        public System.Threading.Tasks.Task<double> VNDToUSDAsync(double money) {
            return base.Channel.VNDToUSDAsync(money);
        }
        
        public double VNDToEUR(double money) {
            return base.Channel.VNDToEUR(money);
        }
        
        public System.Threading.Tasks.Task<double> VNDToEURAsync(double money) {
            return base.Channel.VNDToEURAsync(money);
        }
        
        public double USDToVND(double money) {
            return base.Channel.USDToVND(money);
        }
        
        public System.Threading.Tasks.Task<double> USDToVNDAsync(double money) {
            return base.Channel.USDToVNDAsync(money);
        }
        
        public double EURToVND(double money) {
            return base.Channel.EURToVND(money);
        }
        
        public System.Threading.Tasks.Task<double> EURToVNDAsync(double money) {
            return base.Channel.EURToVNDAsync(money);
        }
    }
}
