using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin( string username , string password , bool superAdmin , string section ):base( username,password )
        {
            IsSuperAdmin = superAdmin;
            Section = section;
        }

        public void Information()
        {
            if (IsSuperAdmin)
            {
                Console.WriteLine("Super Admin: " + IsSuperAdmin + " , " + "Section: " + Section);
            }
            else
            {
                Console.WriteLine("Super Admin:  " + IsSuperAdmin + " , " + "Section: " + Section);

            }
        }

        public void allinformation()
        {
            if (IsSuperAdmin)
            {
                Console.WriteLine("Username: " + setUsername + " | Password: " + setPassword + "| Super Admin: " + IsSuperAdmin + "| Section: " + Section);
            }
            else
            {
                Console.WriteLine("Username: " + setUsername + " | Password: " + setPassword + " | Super Admin: " + IsSuperAdmin +  " | Section: " + Section);

            }
        }

    }
}
