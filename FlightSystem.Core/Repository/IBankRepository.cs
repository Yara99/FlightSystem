﻿using FlightSystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.Repository
{
    public interface IBankRepository
    {
        public bool PaymentCheck(Bank bank);
    }
}
