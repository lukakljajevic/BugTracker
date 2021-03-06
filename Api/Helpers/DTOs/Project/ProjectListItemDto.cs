﻿using Api.Helpers.DTOs.Phase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Helpers.DTOs
{
    public class ProjectListItemDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public UserDto CreatedBy { get; set; }
        public string Description { get; set; }
		public ICollection<PhaseMinimalDto> Phases { get; set; }
		public ICollection<ProjectUserDto> ProjectUsers { get; set; }
	}
}
