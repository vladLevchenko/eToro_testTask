using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBillingWCF" in both code and config file together.
    [ServiceContract]
    public interface IBillingWCF
    {

        [OperationContract]
        List<FundingInfo> GetAllSupportedFundingTypes();

        [OperationContract]
        FundingCurrencyInfo GetFundingTypeSupportedCurrencies(int fTypeId); 

        [OperationContract]
        void SetFundingTypeDeposits(int FundingTypeID, int DepositID);
    }

    [DataContract]
    public class FundingInfo
    {
        [DataMember]
        public string FundingTypeName { get; set; }

        [DataMember]
        public decimal MinDeposit { get; set; }

        [DataMember]
        public decimal MaxDeposit { get; set; }

        [DataMember]
        public decimal MonthlyQuote { get; set; }
    }


    [DataContract]
    public class FundingCurrencyInfo
    {
        [DataMember]
        public string FundingTypeName { get; set; }

        [DataMember]
        public decimal MinDeposit { get; set; }

        [DataMember]
        public decimal MaxDeposit { get; set; }
        
        [DataMember]
        public List<string> SupportedCurrencies { get; set; }
    }
}
