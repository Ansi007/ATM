using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace PL
{
    public class ATMView
    {
        public void main()
        {
            /*            Console.Write("Press 1 to continue as User, Press 2 to continue as Administrator: ");
                        ConsoleKey k =  Console.ReadKey().Key;
                        ATMManager aTMManager = new ATMManager();
                        aTMManager.Menu(k);*/

            Console.Write("Enter login: ");
            string name = Console.ReadLine();
            int pinI = 0;
            while (true)
            {
                Console.Write("Enter 5 digit PIN: ");
                string pin = Console.ReadLine();
                if (pin.Length != 5)
                {
                    Console.WriteLine("ERROR P01, Please enter 5 digits.");
                }
                else if (!int.TryParse(pin, out pinI))
                {
                    Console.WriteLine("ERROR P02, Please enter digits only");
                }
                else break;
            }
            ATMManager aTMManager = new ATMManager();
            aTMManager.userLogin(name,pinI);
        }
    }
}
