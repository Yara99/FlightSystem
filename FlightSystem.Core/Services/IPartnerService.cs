using FlightSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.Services
{
    public interface IPartnerService
    {
        void CreatePartner(PartnerDTO partnerDTO);
        List<PartnerDTO> GetPartnersByUser(int userId);
    }
}
