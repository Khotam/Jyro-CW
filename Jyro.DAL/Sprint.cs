using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.DAL
{
    public class Sprint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfDevelopers { get; set; }
        public string Status { get; set; }
    }
}
