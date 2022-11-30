using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp1
{
    internal class User
    {
        private string _username;
        private string _password;

        public string setUsername 
        {
            

            get 
            {
                return _username;
            } 

            set 
            { 
                Label2: // that is for entering username again

                if ( value.Length >6 ) // Check username condition
                {
                    _username = value;
                    
                }
                else
                {
                    Console.WriteLine("Your username is not valid , please enter username again");

                    value = Console.ReadLine(); // enter username again

                    goto Label2; // that is for entering username again
                }
            } 
        }

        public string setPassword
        {
            get
            {
                return _password;
            }
            set
            {
                Label1: // that is for entering password again

                int num = 0;
                int uppercase = 0;

                for (int i = 0; i < value.Length; i++)
                {
                    char v = value[i];
                    
                    if ( v=='1' || v == '2' || v == '3' || v == '4' || v == '5' || v == '6' || v == '7' || v == '8' || v == '9') // Check condition 1
                    {
                        num++;
                    }

                    bool A = char.IsUpper(v); // check uppercase letter

                    if( A) // Check condition 2
                    {
                        uppercase++;
                    }
                }

                if (num > 0 & uppercase > 0)
                {
                    _password = value;
                    Console.WriteLine("\nPlease wait...\n");
                }
                else
                {
                    Console.WriteLine("Your password is not valid , please enter password again. Password must contains one number and one uppercase letter ");

                    value = Console.ReadLine(); // enter password again

                    goto Label1; // that is for entering password again
                }
            }
        }

        public User( string username , string password )
        {
            setUsername = username;
            setPassword = password;
        }

        
    }
}
