using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillingRepository
    {        
        public List<FundingType> GetAllSupportedFundingTypes()
        {
            using (BillingEntities context = new BillingEntities())
            {
                return context.FundingType.ToList();
            }
        }
        public FundingType GetFindingTypeById(int fTypeId)
        {
            using (BillingEntities context = new BillingEntities())
            {
                return context.FundingType.FirstOrDefault(ft => ft.Id == fTypeId);
            }
        }
        public List<Currency>  GetFundingTypeSupportedCurrencies(int fTypeId)
        {
            using (BillingEntities context = new BillingEntities())
            {
                return context.FundingTypeCurrency.Where(ftc => ftc.FundingTypeID == fTypeId).Select(ftc => ftc.Currency).ToList();
            }
        }

        public void SetDepositStatus(int depositId, int fundingTypeID)
        {
            using (BillingEntities context = new BillingEntities())
            {
                context.SetFundingTypeDeposits(fundingTypeID, depositId);
            }
        }
    }
}
