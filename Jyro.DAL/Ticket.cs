using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.DAL
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public int Estimation { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public Sprint SprintId { get; set; }
    }
}
