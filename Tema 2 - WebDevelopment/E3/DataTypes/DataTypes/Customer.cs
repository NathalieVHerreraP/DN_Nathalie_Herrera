using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Customer
    {
        static void Main(string[] Args) 
        {
            String dateNow = DateTime.Now.ToString();
            String[,] CustomerCollection = {{ "Hugo J.", dateNow  },
                                            { "Luis D.", dateNow  },
                                            { "Jorge A.", dateNow },
                                            { "Nath H.", dateNow  },
                                            { "Ness P.", dateNow  },
                                            { "Karen M.", dateNow },
                                            { "Luis U.", dateNow  },
                                            { "Marco E.", dateNow },
                                            { "Fred S.", dateNow  },
                                            { "Any F.", dateNow   }};

            Console.WriteLine("Foreach bucle");

            foreach (String customer in CustomerCollection)
            {
                Console.WriteLine($"{customer}");
            }

            Console.WriteLine("For bucle");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Name: " + CustomerCollection[i,0] + ", Join Date: " + CustomerCollection[i,1]);

            }

            Console.WriteLine("While bucle");

            int j = 0;

            while (j<10)
            {
                Console.WriteLine("Name: " + CustomerCollection[j, 0] + ", Join Date: " + CustomerCollection[j, 1]);
                j++;
            }

            Console.WriteLine("Do while bucle");

            j = 0;

            do
            {
                Console.WriteLine("Name: " + CustomerCollection[j, 0] + ", Join Date: " + CustomerCollection[j, 1]);
                j++;

            } while (j<10);


            Console.ReadKey();
        }
    }
}
