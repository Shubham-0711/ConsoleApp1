using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICustomer
    {
        string Display();
    }  
    public interface IOrders
    {
        string Display();
    }
    public class Transaction:ICustomer,IOrders
    {
        string ICustomer.Display()
        {
            return "Customer Details";
        }
        string IOrders.Display()
        {
            return "Order Details ";
        }
    }
}
