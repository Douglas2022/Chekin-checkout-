using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write(" Chek-in- data (dd/mm/yyyy) ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write(" Chek-out data (dd/mm/yyyy) ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine(" Erro in resevation: Chek Out must date be after chekin date");
            }
            else
            {
                Resevation resevation = new Resevation(number, checkin, checkout);
                Console.WriteLine(" Resevation: " + resevation);

                Console.WriteLine();
                Console.WriteLine(" Enter date to update the resevation: ");
                Console.Write(" Chek-in- data (dd/mm/yyyy) ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write(" Chek-out data (dd/mm/yyyy) ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkin < now || checkout < now)
                {
                    Console.WriteLine(" Erro in resevation: resevation dates for update must be future dates");
                }
                else if (checkout <= checkin)
                {
                    Console.WriteLine(" Erro in resevation: Chek Out must date be after chekin date");
                }
                else
                {
                    resevation.UpdateDates(checkin, checkout);
                    Console.WriteLine(" resvation: " + resevation);
                }
            }

        }

    }
}
