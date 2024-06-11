using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationTesting
{
    internal class DrawText
    {

       

        public static void DrawPlayerOptions(List<string> i )
        {
            foreach ( var line in i )
            {
                Console.WriteLine( line );
            }
        }
    }
}
