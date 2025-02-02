﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;
using System.Collections.ObjectModel;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {

                if (value >= 0) // Validate
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
