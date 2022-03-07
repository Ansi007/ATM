using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class User
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string LastWithDrawDate { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public string Status { get; set; }

    }

    public class UserLogin
    {
        public string Login { get; set; }
        public int Pin { get; set; }

    }
}
