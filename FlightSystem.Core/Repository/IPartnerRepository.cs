﻿using FlightSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.Repository
{
   public interface IPartnerRepository
    {
        void CreatePartner(PartnerDTO partnerDTO);
        List<PartnerDTO> GetPartnersByUser(int userId);
    }
}