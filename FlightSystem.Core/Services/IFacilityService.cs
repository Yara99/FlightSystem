﻿using FlightSystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.Services
{
    public interface IFacilityService
    {
        public List<Facility> GetAllFacility();
        public void CreateFacility(Facility facility);
        public void UpdateFacility(Facility facility);
        public void DeleteFacility(int id);

    }
}
