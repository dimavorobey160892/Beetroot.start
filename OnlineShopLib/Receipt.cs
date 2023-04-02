﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    public class Receipt
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public IProduct product { get; set; }
        public Buyer buyer { get; set; }

    }
}
