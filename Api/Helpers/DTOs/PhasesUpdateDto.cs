﻿using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Helpers.DTOs
{
    public class PhasesUpdateDto
    {
        public List<PhaseListItemDto> Phases { get; set; }
    }
}
