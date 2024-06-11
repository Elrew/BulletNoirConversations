using ConversationTesting.Conversations;

namespace ConversationTesting
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine(ConversationTexts.Player.FindIndex(x => x.StartsWith("Good")));
            //Console.WriteLine(ConversationTexts.Player.FindIndex(x => x.StartsWith("Not")));
            ConversationStates.ConvoStates currentState = ConversationStates.ConvoStates.Idle;

            ConsoleKeyInfo keyInfo;

            bool running = true;
            bool convoStarted = false;
            Console.Write("Hello, how are you today?");
            while (running)
            {
                
                Console.SetCursorPosition(0, 20);

                if (!convoStarted)
                {
                    DrawText.DrawPlayerOptions(OpeningConversation.Player);
                }

                keyInfo = Console.ReadKey();


                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        currentState = ConversationStates.ConvoStates.Option1;
                        convoStarted = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        currentState = ConversationStates.ConvoStates.Option2;
                        convoStarted = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        currentState = ConversationStates.ConvoStates.Option3;
                        convoStarted = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        currentState = ConversationStates.ConvoStates.Option4;
                        convoStarted = true;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        currentState = ConversationStates.ConvoStates.Option5;
                        convoStarted = true;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        currentState = ConversationStates.ConvoStates.EndConversation;
                        convoStarted = true;
                        break;
                    default:
                        currentState = ConversationStates.ConvoStates.Idle;
                        DrawText.DrawPlayerOptions(OpeningConversation.Player);
                        break;

                }


                switch (currentState)
                {
                    case ConversationStates.ConvoStates.Idle:
                        break;
                    case ConversationStates.ConvoStates.EndConversation:
                        break;
                    case ConversationStates.ConvoStates.Option1:
                        Console.Clear();
                        Console.SetCursorPosition(10, 20);
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[0]);
                        break;
                    case ConversationStates.ConvoStates.Option2:
                        Console.Clear();
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[1]);
                        break;
                    case ConversationStates.ConvoStates.Option3:
                        Console.Clear();
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[2]);
                        break;
                    case ConversationStates.ConvoStates.Option4:
                        Console.Clear();
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[3]);
                        break;
                    case ConversationStates.ConvoStates.Option5:
                        Console.Clear();
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[4]);
                        
                        break;
                    case ConversationStates.ConvoStates.Option6:
                        Console.Clear();
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[5]);
                        break;


                }
            }

        }
    }
}
