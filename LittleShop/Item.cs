﻿using System;
using System.Collections.Generic;

namespace LittleShop
{
    public class Item
    {
        public string Name;
        public int Price;

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
