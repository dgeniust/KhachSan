﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan
{
    public class Search
    {
        public DateTime startday;
        public DateTime endday;
        public int spendnight;
        public string address;
        public int guest;


        /*public DateTime endday;*/

        /*public Search(DateTime startday, int spendnight, string address)
        {
            this.startday = startday;
            this.spendnight = spendnight;
            this.address = address;
        }*/

        public Search(DateTime startday, DateTime endday, int spendnight, string address, int guest)
        {
            this.startday = startday;
            this.endday = endday;
            this.spendnight = spendnight;
            this.address = address;
            this.guest = guest;
        }
    }
}
