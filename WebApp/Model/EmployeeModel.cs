﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class EmployeeModel
    {
        public int EmployeeId {  get; set; }
        public string? LastName {  get; set; }
        public string? FirstName { get; set; }
        public string? BirthDate {  get; set; }
        public string? Photo {  get; set; }
        public string? Notes {  get; set; }

    }
}
