﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightWebServices.ServiceReferenceFightManager {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceFightManager.InsertSaleSoap")]
    public interface InsertSaleSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaleRequest", ReplyAction="*")]
        bool SaleRequest(int parRow, int parSeat, int parTravel, int parCustomer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InsertSaleSoapChannel : FlightWebServices.ServiceReferenceFightManager.InsertSaleSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InsertSaleSoapClient : System.ServiceModel.ClientBase<FlightWebServices.ServiceReferenceFightManager.InsertSaleSoap>, FlightWebServices.ServiceReferenceFightManager.InsertSaleSoap {
        
        public InsertSaleSoapClient() {
        }
        
        public InsertSaleSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InsertSaleSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InsertSaleSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InsertSaleSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SaleRequest(int parRow, int parSeat, int parTravel, int parCustomer) {
            return base.Channel.SaleRequest(parRow, parSeat, parTravel, parCustomer);
        }
    }
}
