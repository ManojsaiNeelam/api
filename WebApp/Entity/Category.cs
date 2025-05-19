using System;
using System.Collections.Generic;

namespace WebApp.Entity;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Descriptions { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
