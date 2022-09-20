using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader
{
    public class BioData
    {
        string email;
        string password;
        string username;

        public BioData(string uEmail, string uPassword, string uUsername)
        {
            email = uEmail;
            password = uPassword;
            username = uUsername;
        }
    }
}
