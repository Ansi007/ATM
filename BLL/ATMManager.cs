using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DAL;

namespace BLL
{
    public class ATMManager
    {
        public void Menu(ConsoleKey k)
        {
            switch (k)
            {
                case ConsoleKey.D1:
                    {
                        userLogin();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        adminLogin();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("Exiting...");
                        break;
                    }
            }
        }

        public void userLogin(string name, int pinI)
        {
            ATMDAL aTMDAL = new ATMDAL();
            int values = 0;
            values = aTMDAL.userLogin(name, pinI);
            if (values != 0)
            {
                //further menu
            }
            else
            {
                //Wrong id or password
            }
        }

        void adminLogin()
        {

        }
    }
}
