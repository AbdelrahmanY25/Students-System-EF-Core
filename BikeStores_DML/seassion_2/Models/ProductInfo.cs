﻿using System;
using System.Collections.Generic;

namespace seassion_2.Models;

public partial class ProductInfo
{
    public string ProductName { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public decimal ListPrice { get; set; }
}
