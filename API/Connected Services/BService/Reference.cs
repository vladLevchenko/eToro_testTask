﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.BService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FundingInfo", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    [System.SerializableAttribute()]
    public partial class FundingInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FundingTypeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MaxDepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MinDepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MonthlyQuoteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FundingTypeName {
            get {
                return this.FundingTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FundingTypeNameField, value) != true)) {
                    this.FundingTypeNameField = value;
                    this.RaisePropertyChanged("FundingTypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MaxDeposit {
            get {
                return this.MaxDepositField;
            }
            set {
                if ((this.MaxDepositField.Equals(value) != true)) {
                    this.MaxDepositField = value;
                    this.RaisePropertyChanged("MaxDeposit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MinDeposit {
            get {
                return this.MinDepositField;
            }
            set {
                if ((this.MinDepositField.Equals(value) != true)) {
                    this.MinDepositField = value;
                    this.RaisePropertyChanged("MinDeposit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MonthlyQuote {
            get {
                return this.MonthlyQuoteField;
            }
            set {
                if ((this.MonthlyQuoteField.Equals(value) != true)) {
                    this.MonthlyQuoteField = value;
                    this.RaisePropertyChanged("MonthlyQuote");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FundingCurrencyInfo", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    [System.SerializableAttribute()]
    public partial class FundingCurrencyInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FundingTypeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MaxDepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MinDepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] SupportedCurrenciesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FundingTypeName {
            get {
                return this.FundingTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FundingTypeNameField, value) != true)) {
                    this.FundingTypeNameField = value;
                    this.RaisePropertyChanged("FundingTypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MaxDeposit {
            get {
                return this.MaxDepositField;
            }
            set {
                if ((this.MaxDepositField.Equals(value) != true)) {
                    this.MaxDepositField = value;
                    this.RaisePropertyChanged("MaxDeposit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MinDeposit {
            get {
                return this.MinDepositField;
            }
            set {
                if ((this.MinDepositField.Equals(value) != true)) {
                    this.MinDepositField = value;
                    this.RaisePropertyChanged("MinDeposit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] SupportedCurrencies {
            get {
                return this.SupportedCurrenciesField;
            }
            set {
                if ((object.ReferenceEquals(this.SupportedCurrenciesField, value) != true)) {
                    this.SupportedCurrenciesField = value;
                    this.RaisePropertyChanged("SupportedCurrencies");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BService.IBillingWCF")]
    public interface IBillingWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingWCF/GetAllSupportedFundingTypes", ReplyAction="http://tempuri.org/IBillingWCF/GetAllSupportedFundingTypesResponse")]
        API.BService.FundingInfo[] GetAllSupportedFundingTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingWCF/GetAllSupportedFundingTypes", ReplyAction="http://tempuri.org/IBillingWCF/GetAllSupportedFundingTypesResponse")]
        System.Threading.Tasks.Task<API.BService.FundingInfo[]> GetAllSupportedFundingTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingWCF/GetFundingTypeSupportedCurrencies", ReplyAction="http://tempuri.org/IBillingWCF/GetFundingTypeSupportedCurrenciesResponse")]
        API.BService.FundingCurrencyInfo GetFundingTypeSupportedCurrencies(int fTypeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingWCF/GetFundingTypeSupportedCurrencies", ReplyAction="http://tempuri.org/IBillingWCF/GetFundingTypeSupportedCurrenciesResponse")]
        System.Threading.Tasks.Task<API.BService.FundingCurrencyInfo> GetFundingTypeSupportedCurrenciesAsync(int fTypeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingWCF/SetFundingTypeDeposits", ReplyAction="http://tempuri.org/IBillingWCF/SetFundingTypeDepositsResponse")]
        void SetFundingTypeDeposits(int FundingTypeID, int DepositID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingWCF/SetFundingTypeDeposits", ReplyAction="http://tempuri.org/IBillingWCF/SetFundingTypeDepositsResponse")]
        System.Threading.Tasks.Task SetFundingTypeDepositsAsync(int FundingTypeID, int DepositID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBillingWCFChannel : API.BService.IBillingWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BillingWCFClient : System.ServiceModel.ClientBase<API.BService.IBillingWCF>, API.BService.IBillingWCF {
        
        public BillingWCFClient() {
        }
        
        public BillingWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BillingWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BillingWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BillingWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public API.BService.FundingInfo[] GetAllSupportedFundingTypes() {
            return base.Channel.GetAllSupportedFundingTypes();
        }
        
        public System.Threading.Tasks.Task<API.BService.FundingInfo[]> GetAllSupportedFundingTypesAsync() {
            return base.Channel.GetAllSupportedFundingTypesAsync();
        }
        
        public API.BService.FundingCurrencyInfo GetFundingTypeSupportedCurrencies(int fTypeId) {
            return base.Channel.GetFundingTypeSupportedCurrencies(fTypeId);
        }
        
        public System.Threading.Tasks.Task<API.BService.FundingCurrencyInfo> GetFundingTypeSupportedCurrenciesAsync(int fTypeId) {
            return base.Channel.GetFundingTypeSupportedCurrenciesAsync(fTypeId);
        }
        
        public void SetFundingTypeDeposits(int FundingTypeID, int DepositID) {
            base.Channel.SetFundingTypeDeposits(FundingTypeID, DepositID);
        }
        
        public System.Threading.Tasks.Task SetFundingTypeDepositsAsync(int FundingTypeID, int DepositID) {
            return base.Channel.SetFundingTypeDepositsAsync(FundingTypeID, DepositID);
        }
    }
}
