﻿using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiciuAlinaLab7.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(250), Unique]
        public string Description {  get; set; }
        public DateTime Date {  get; set; }
    }
}
