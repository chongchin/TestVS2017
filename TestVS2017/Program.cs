using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TestVS2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(" C1", "Inecom Pte Ltd", "12, Tannery Road");
            MessageBox.Show(customer.DisplayCustomer(customer));
        }
    }
}
