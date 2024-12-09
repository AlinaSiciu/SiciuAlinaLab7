using System;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiciuAlinaLab7.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Description {  get; set; }
        [OneToMany]
        public List<ListProduct> ListProducts { get; set; }
    }
}
