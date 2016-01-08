using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class LoginKontroler
    {

        public bool zaloguj(String name, String password)
        {
            if (name.Equals("janusz"))
                return true;
            else return false;
        }
    }
}
