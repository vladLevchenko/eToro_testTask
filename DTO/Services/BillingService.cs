using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Services
{
    public class BillingService 
    {
        private readonly BillingRepository _repo;

        public BillingService()
        {
            _repo = new BillingRepository();
        }
        public List<FundingType> GetAllSupportedFundingTypes()
        {
            return _repo.GetAllSupportedFundingTypes().Select(sft => Mapper.FromDALFundingTypeToDTO(sft)).ToList();
        }

        public FundingTypeCurrencyInfo GetFundingTypeSupportedCurrencies(int fTypeId)
        {
            var fType = _repo.GetFindingTypeById(fTypeId);
            var supportedCurrencies = _repo.GetFundingTypeSupportedCurrencies(fTypeId).Select(sc => sc.Name).ToList();
            return new FundingTypeCurrencyInfo
            {
                FundingTypeName = fType.FundingTypeName,
                MaxDeposit = fType.MaxDeposit,
                MinDeposit = fType.MinDeposit,
                SupportedCurrencies = supportedCurrencies.Count > 0 ? supportedCurrencies : new List<string> { "-1" } 
            };
        }


        public void SetFundingTypeDeposits(int FundingTypeID, int DepositID)
        {
            _repo.SetDepositStatus(DepositID, FundingTypeID);
        }

    }
}
