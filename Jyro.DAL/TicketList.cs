using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.DAL
{
    public class TicketList
    {
        public List<Ticket> GetAllTickets()
        {
            return new TicketManager().GetAll();
        }


        public List<Ticket> Sort(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Priority:
                    return GetAllTickets().OrderBy(a => a.Priority).ToList();
                case ByAttribute.Status:
                    return GetAllTickets().OrderBy(a => a.Status).ToList();
            }

            //if we are here - something went wrong
            return null;
        }

        public List<Ticket> Search(int value)
        {
            return GetAllTickets().Where(a => a.Id == value).ToList();
        }

    }
}
