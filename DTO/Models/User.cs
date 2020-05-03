﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string PassWord { get; set; }
        public int RoleID { get; set; }
        public Role Roles { get; set; }
        public List<Materiel> Materiels { get; set; }


    }
}
