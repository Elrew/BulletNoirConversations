using ConversationTesting.Conversations;

namespace ConversationTesting
{
    internal class Program
    {
        public static bool hadFirstConversation = false;
        static void Main()
        {
            //Console.WriteLine(ConversationTexts.Player.FindIndex(x => x.StartsWith("Good")));
            //Console.WriteLine(ConversationTexts.Player.FindIndex(x => x.StartsWith("Not")));


            ConsoleKeyInfo keyInfo;

            bool running = true;
            
            while (running)
            {


                if (!hadFirstConversation)
                {
                    
                    OpeningConversation.Conversation();


                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Ending loop, going again");
            }

        }
    }
}
