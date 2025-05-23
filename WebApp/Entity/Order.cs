﻿using System;
using System.Collections.Generic;

namespace WebApp.Entity;

public partial class Order
{
    public int OrderId { get; set; }

    public string? OrderDate { get; set; }

    public int? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ShipperId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Shipper? Shipper { get; set; }
}
