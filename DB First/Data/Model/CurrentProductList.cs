﻿using System;
using System.Collections.Generic;

namespace DB_First.Data.Model;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
