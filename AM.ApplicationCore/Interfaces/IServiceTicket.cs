using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
   public interface IServiceTicket: IService<Ticket>
    {
        IEnumerable <Ticket> GetTicketByPrice(string Prix);

        IEnumerable<Ticket> GetTicketByPriceAndChair(string? prix, string? chairNbre);
    }
}
