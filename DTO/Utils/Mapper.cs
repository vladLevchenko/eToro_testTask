using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class Mapper
    {

        public static FundingType FromDALFundingTypeToDTO(DAL.FundingType from)
        {
            return new FundingType
            {
                FundingTypeName = from.FundingTypeName,
                MaxDeposit = from.MaxDeposit,
                MinDeposit = from.MinDeposit,
                MonthlyQuote = from.MonthlyQuote
            };
        }
    }
}
