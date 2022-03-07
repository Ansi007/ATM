using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class ATMDAL
    {
        SqlConnection conn = @"";
        public int userLogin(string name, int pin)
        {

            return 0;
        }

        public bool adminLogin()
        {
            return false;
        }
    }
}
