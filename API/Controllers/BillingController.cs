using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class BillingController : ApiController
    {
        [HttpPost, Route("api/v1/GetAllSupportedFundingTypes")]
        public List<BService.FundingInfo> GetAllSupportedFundingTypes()
        {
            using (var wcfService = new BService.BillingWCFClient())
            {
                return wcfService.GetAllSupportedFundingTypes().ToList();
            }
        }

        [HttpGet,Route("api/v1/GetFundingTypeSupportedCurrencies/{id}")]
        public BService.FundingCurrencyInfo GetFundingTypeSupportedCurrencies(int id)
        {
            using (var wcfService = new BService.BillingWCFClient())
            {
                return wcfService.GetFundingTypeSupportedCurrencies(id);
            }
        }
        [HttpPut,Route("api/v1/SetPaymentStatusOnQuote")]
        public void SetPaymentStatusOnQuote(int fTID,int dId)
        {
            using (var wcfService = new BService.BillingWCFClient())
            {
                wcfService.SetFundingTypeDeposits(fTID,dId);
            }
        }
    }
}
