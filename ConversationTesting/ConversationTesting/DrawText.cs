using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationTesting
{
    internal class DrawText
    {

       

        public static void DrawPlayerOptions(List<string> i, int x, int y )
        {
            foreach ( var line in i )
            {
                Console.SetCursorPosition( x, y );
                Console.WriteLine( line );
                y++;
            }
        }
    }
}
