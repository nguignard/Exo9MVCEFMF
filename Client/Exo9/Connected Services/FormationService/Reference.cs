﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exo9.FormationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FormationService.IServiceStagiaire")]
    public interface IServiceStagiaire {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/GetSection", ReplyAction="http://tempuri.org/IServiceStagiaire/GetSectionResponse")]
        Exo9.FormationService.MSection GetSection(string codeSection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/GetSection", ReplyAction="http://tempuri.org/IServiceStagiaire/GetSectionResponse")]
        System.Threading.Tasks.Task<Exo9.FormationService.MSection> GetSectionAsync(string codeSection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/GetStagiairesSection", ReplyAction="http://tempuri.org/IServiceStagiaire/GetStagiairesSectionResponse")]
        Exo9.FormationService.MStagiaire[] GetStagiairesSection(string codeSection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/GetStagiairesSection", ReplyAction="http://tempuri.org/IServiceStagiaire/GetStagiairesSectionResponse")]
        System.Threading.Tasks.Task<Exo9.FormationService.MStagiaire[]> GetStagiairesSectionAsync(string codeSection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/AddStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/AddStagiaireResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Exo9.FormationService.MStagiaireDE))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Exo9.FormationService.MStagiaireCIF))]
        string AddStagiaire(Exo9.FormationService.MStagiaire newStagiaire, Exo9.FormationService.MSection laSection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/AddStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/AddStagiaireResponse")]
        System.Threading.Tasks.Task<string> AddStagiaireAsync(Exo9.FormationService.MStagiaire newStagiaire, Exo9.FormationService.MSection laSection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/UpdateStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/UpdateStagiaireResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Exo9.FormationService.MStagiaireDE))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Exo9.FormationService.MStagiaireCIF))]
        string UpdateStagiaire(Exo9.FormationService.MStagiaire leStagiaire);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/UpdateStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/UpdateStagiaireResponse")]
        System.Threading.Tasks.Task<string> UpdateStagiaireAsync(Exo9.FormationService.MStagiaire leStagiaire);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/DeleteStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/DeleteStagiaireResponse")]
        bool DeleteStagiaire(int laCleStagiaire);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/DeleteStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/DeleteStagiaireResponse")]
        System.Threading.Tasks.Task<bool> DeleteStagiaireAsync(int laCleStagiaire);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceStagiaireChannel : Exo9.FormationService.IServiceStagiaire, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceStagiaireClient : System.ServiceModel.ClientBase<Exo9.FormationService.IServiceStagiaire>, Exo9.FormationService.IServiceStagiaire {
        
        public ServiceStagiaireClient() {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStagiaireClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Exo9.FormationService.MSection GetSection(string codeSection) {
            return base.Channel.GetSection(codeSection);
        }
        
        public System.Threading.Tasks.Task<Exo9.FormationService.MSection> GetSectionAsync(string codeSection) {
            return base.Channel.GetSectionAsync(codeSection);
        }
        
        public Exo9.FormationService.MStagiaire[] GetStagiairesSection(string codeSection) {
            return base.Channel.GetStagiairesSection(codeSection);
        }
        
        public System.Threading.Tasks.Task<Exo9.FormationService.MStagiaire[]> GetStagiairesSectionAsync(string codeSection) {
            return base.Channel.GetStagiairesSectionAsync(codeSection);
        }
        
        public string AddStagiaire(Exo9.FormationService.MStagiaire newStagiaire, Exo9.FormationService.MSection laSection) {
            return base.Channel.AddStagiaire(newStagiaire, laSection);
        }
        
        public System.Threading.Tasks.Task<string> AddStagiaireAsync(Exo9.FormationService.MStagiaire newStagiaire, Exo9.FormationService.MSection laSection) {
            return base.Channel.AddStagiaireAsync(newStagiaire, laSection);
        }
        
        public string UpdateStagiaire(Exo9.FormationService.MStagiaire leStagiaire) {
            return base.Channel.UpdateStagiaire(leStagiaire);
        }
        
        public System.Threading.Tasks.Task<string> UpdateStagiaireAsync(Exo9.FormationService.MStagiaire leStagiaire) {
            return base.Channel.UpdateStagiaireAsync(leStagiaire);
        }
        
        public bool DeleteStagiaire(int laCleStagiaire) {
            return base.Channel.DeleteStagiaire(laCleStagiaire);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteStagiaireAsync(int laCleStagiaire) {
            return base.Channel.DeleteStagiaireAsync(laCleStagiaire);
        }
    }
}