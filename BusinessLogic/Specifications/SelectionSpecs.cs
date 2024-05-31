using Ardalis.Specification;
using BusinessLogic.Entities;

namespace BusinessLogic.Specifications
{
    public static class SelectionSpecs
    {
        public class All : Specification<Selection>
        {
            public All()
            {
                Query.Include(x => x.MovieSelection);
            }
        }
        public class ById : Specification<Selection>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.MovieSelection);
            }
        }
        public class ByIds : Specification<Selection>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.MovieSelection);
            }
        }
    }
}
