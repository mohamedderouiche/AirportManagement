using AM.ApplicationCore.Services;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Domain;
using System.Text.RegularExpressions;

namespace AM.ApplicationCore.Interfaces
{

    public class ServiceTicket : Service<Ticket>, IServiceTicket
    {
       
        public ServiceTicket(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Ticket> GetTicketByPrice(string Prix)
        {
            return GetMany().Where(t => t.Prix >= float.Parse(Prix));
        }

        public IEnumerable<Ticket> GetTicketByPriceAndChair(string? prix, string? chairNbre)
        {
         
            if(prix != null && chairNbre != null)
            {
                return GetMany().Where(t => t.Prix >= float.Parse(prix) && t.Siege >= int.Parse(chairNbre));
            }
            if (prix != null && chairNbre == null)
            {
                return GetMany(t => t.Prix >= float.Parse(prix));
            }
            if(chairNbre != null && prix == null )
            {
                return GetMany().Where(t => t.Siege >= int.Parse(chairNbre));
            }
            else 
            {
                return GetMany();
            }
        }

        
    }
}
