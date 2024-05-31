using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class MovieSelection
    {
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }

        public int SelectionId { get; set; }
        public Selection? Selection { get; set; }
    }

}
