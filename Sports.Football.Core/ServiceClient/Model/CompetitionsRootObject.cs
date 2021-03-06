﻿using System.Collections.Generic;
using Sports.Football.Core.ServiceClient.Model.DTOs;
using Sports.Football.Data.Model;

namespace Sports.Football.Core.ServiceClient.Model
{
    public class CompetitionsRootObject
    {
        public int Count { get; set; }
        public List<CompetitionDto> Competitions { get; set; }
    }
}