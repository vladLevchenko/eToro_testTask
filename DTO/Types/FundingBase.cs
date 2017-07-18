using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Types
{
    public abstract class FundingBase
    {
        public string FundingTypeName { get; set; }

        public decimal MinDeposit { get; set; }

        public decimal MaxDeposit { get; set; }

    }
}
