﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Helpers.DTOs
{
    public class ProjectUserListItemDto
    {
        public string ProjectId { get; set; }
        public string UserId { get; set; }
        public string UserFullName { get; set; }
        public string UserRole { get; set; }
        public DateTime? LastActive { get; set; }
    }
}
