﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.DTO
{
    public class ModifyUserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int StatusId { get; set; }
    }
}
