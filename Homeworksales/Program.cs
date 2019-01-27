using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworksales
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 context = new Model1();
            string b;
            Console.WriteLine("Enter table name:1.customers\n2.Sellers\n3.sales");
            b=Console.ReadLine();
            int a = int.Parse(b);
            switch (a)
            {
                case 1:
                    List<Customers> customers = context.Customers.ToList();
                    for(int i = 0; i < customers.Count; i++)
                    {
                        Console.WriteLine(customers[i].Name);
                        Console.WriteLine(customers[i].SurName);

                    }
                    Console.ReadLine();
                    break;

                case 2:
                    List<Sellers> sellers = context.Sellers.ToList();
                    for (int i = 0; i < sellers.Count; i++)
                    {
                        Console.WriteLine(sellers[i].Name);
                        Console.WriteLine(sellers[i].SurName);

                    }
                    Console.ReadLine();
                    break;
                case 3:
                    List<Sale> sales = context.Sales.ToList();
                    for (int i = 0; i < sales.Count; i++)
                    {
                        Console.WriteLine(sales[i].IdCustomer);
                        Console.WriteLine(sales[i].IdDealer);
                         Console.WriteLine(sales[i].Summ);
                        Console.WriteLine(sales[i].Date);


                    }
                    Console.ReadLine();
                    break;
            }
        }
    }
}
            //var person1 = new Customers
            //{
            //    Name = "Artur",
            //    SurName = "Pirozhkov"


            //};
            //var seller = new Sellers
            //{
            //    Name = "Aleksey",
            //    SurName = "Popov"
            //};
            //var sell1 = new Sale
            //{
            //    IdCustomer = person1.ID,
            //    IdDealer = seller.ID,
            //    Summ = 12345,
            //    Date = DateTime.Now

            //};
            //person1.Sales.Add(sell1);
            //seller.Sales.Add(sell1);
            //using(var con=new Model1())
            //{
            //    con.Customers.Add(person1);
            //    con.Sales.Add(sell1);
            //    con.Sellers.Add(seller);
            //    con.SaveChanges();
            //}