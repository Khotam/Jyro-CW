using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.DAL
{
    public class Sprint
    {
        private int _id; 
        public string Name;

        public int Id
        {
            get => _id;
            set
            {
                if (_id < 0)
                    throw new Exception("ID cannot be negative");
                _id = value;
            }
        }

        public Sprint()
        {

        }

        public Sprint(int _id)
        {
            Id = _id;
        }

        public override string ToString()
        {
            return Convert.ToString(Id);
        }

        public DateTime Date { get; set; }
        public int NumberOfDevelopers { get; set; }
        public string Status { get; set; }
    }

    
}
