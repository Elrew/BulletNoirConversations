using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationTesting
{
    internal class ConversationTexts
    {

        public static List<string> NPC1 = new List<string>
        {
            "Hello, how are you?"

        };
        public static List<string> Player = new List<string>
        {
            "Good, thank you",
            "Not great",
            "Leave me alone",
            "It's a wonderful day outside, isn't it?",
            "Baseball",
            "Cowards!"


        };

        public static void DrawPlayerOptions(List<string> i )
        {
            foreach ( var item in i )
            {
                Console.WriteLine( item );
            }
        }
    }
}
