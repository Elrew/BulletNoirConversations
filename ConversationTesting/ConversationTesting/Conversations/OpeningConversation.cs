using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationTesting.Conversations
{
    internal class OpeningConversation
    {

        public static List<string> NPC1 = new List<string>
        {
            "Hello, how are you?",
            "Good! Glad to hear it. Listen, I have been having some trouble lately. Do you think you can help me out?"
        };

        public static List<string> Player = new List<string>
        {
            "1)Good, thank you",
            "2)Not great",
            "3)Leave me alone",
            "4)It's a wonderful day outside, isn't it?",
            "5)Baseball",
            ""
        };

        public static string NPC2 = "Glad to hear it. Can you I ask you to do me a small favor?";

        public static List<string> Player2 = new List<string>
        {
            "1)Of course",
            "2)I don't have time",
            "3)I'd rather not",
            "4)How much am I getting paid?",
            "5)Basketball",
            ""
        };
    }
}
