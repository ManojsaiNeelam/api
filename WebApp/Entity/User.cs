﻿using System;
using System.Collections.Generic;

namespace WebApp.Entity;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? IsAdmin { get; set; }
}
