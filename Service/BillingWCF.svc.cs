using DTO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BillingWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BillingWCF.svc or BillingWCF.svc.cs at the Solution Explorer and start debugging.
    public class BillingWCF:IBillingWCF
    {
        private readonly BillingService _service;
        public BillingWCF()
        {
            _service = new BillingService();
        }
        public List<FundingInfo> GetAllSupportedFundingTypes()
        {
            var dtoResults = _service.GetAllSupportedFundingTypes();
            return dtoResults.Select(res => new FundingInfo
            {
                FundingTypeName = res.FundingTypeName,
                MaxDeposit = res.MaxDeposit,
                MinDeposit = res.MinDeposit,
                MonthlyQuote = res.MonthlyQuote
            }).ToList();
        }

        public FundingCurrencyInfo GetFundingTypeSupportedCurrencies(int fTypeId)
        {
            var dtoResult = _service.GetFundingTypeSupportedCurrencies(fTypeId);
            return new FundingCurrencyInfo
            {
                FundingTypeName = dtoResult.FundingTypeName,
                MaxDeposit = dtoResult.MaxDeposit,
                MinDeposit = dtoResult.MinDeposit,
                SupportedCurrencies = dtoResult.SupportedCurrencies
            };

        }


        public void SetFundingTypeDeposits(int FundingTypeID, int DepositID)
        {
            _service.SetFundingTypeDeposits(FundingTypeID, DepositID);
        }
    }
}
