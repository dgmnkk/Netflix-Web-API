using Ardalis.Specification;
using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLogic.Specifications
{
    public static class RefreshTokenSpecs
    {
        public class ByToken : Specification<RefreshToken>
        {
            public ByToken(string value)
            {
                Query.Where(x => x.Token == value);
            }
        }
        public class ByDate : Specification<RefreshToken>
        {
            public ByDate(DateTime date)
            {
                Query.Where(x => x.CreationDate < date);
            }
        }
    }
}
