﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int orderItemId;
        public int orderId;
        public int menuItemId;
        public int amount;
        public string comment;
    }
}