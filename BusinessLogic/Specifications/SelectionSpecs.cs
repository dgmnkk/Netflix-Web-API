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
    public static class SelectionSpecs
    {
        public class All : Specification<Selection>
        {
            public All()
            {
                Query.Include(x => x.Movies);
            }
        }
        public class ById : Specification<Selection>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.Movies);
            }
        }
        public class ByIds : Specification<Selection>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Movies);
            }
        }
    }
}
