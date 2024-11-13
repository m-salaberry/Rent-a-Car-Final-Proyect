using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.model;

namespace Mapper
{
    public class InsuranceMapper
    {

        public static InsuranceEntity Map(Insurance insurance)
        {
            return new InsuranceEntity
            {
                Id = insurance.Id,
                TypeOfInsurance = insurance.TypeOfInsurance,
                Price = insurance.Price
            };
        }

        public static Insurance Map(InsuranceEntity insurance)
        {
            return new Insurance
            {
                Id = insurance.Id,
                TypeOfInsurance = insurance.TypeOfInsurance,
                Price = insurance.Price
            };
        }

    }
}
