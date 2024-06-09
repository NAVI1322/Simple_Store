using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Assignment_1_Navneet_4531978
{
    public class Category
    {
        public int CategoryID { get; set; }
        public String? CategoryName { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }

   
}
