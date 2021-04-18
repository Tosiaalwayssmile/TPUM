using LogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Message : EventArgs
    {
        public DiscountCodeDTO DiscountCode { get; private set; }

        public Message(DiscountCodeDTO code)
        {
            DiscountCode = code;
        }
    }
}
