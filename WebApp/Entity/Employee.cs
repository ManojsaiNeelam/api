using System;
using System.Collections.Generic;

namespace WebApp.Entity;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? BirthDate { get; set; }

    public string? Photo { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
