﻿using System.Collections.Generic;
using SelectionCommittee.BLL.DataTransferObject;

namespace SelectionCommittee.BLL.Interfaces
{
    public interface ICityService
    {
        IEnumerable<CityDTO> GetCities();
    }
}