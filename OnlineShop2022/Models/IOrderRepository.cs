﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop2022.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(OrderModel order);
    }
}
