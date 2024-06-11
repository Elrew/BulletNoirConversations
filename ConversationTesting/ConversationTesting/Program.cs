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
            while(running)
            {
                ConversationTexts.DrawPlayerOptions(ConversationTexts.Player);
                keyInfo = Console.ReadKey();
                
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        currentState = ConversationStates.ConvoStates.Option1;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        currentState = ConversationStates.ConvoStates.Option2;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        currentState = ConversationStates.ConvoStates.Option3;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        currentState = ConversationStates.ConvoStates.Option4;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        currentState = ConversationStates.ConvoStates.Option5;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        currentState = ConversationStates.ConvoStates.EndConversation;
                        break;
                    default:
                        currentState = ConversationStates.ConvoStates.Idle; break;

                }


                switch (currentState)
                {
                    case ConversationStates.ConvoStates.Idle:
                        break;
                    case ConversationStates.ConvoStates.EndConversation:
                        break;
                    case ConversationStates.ConvoStates.Option1:
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(10, 20);
                        Console.WriteLine(ConversationTexts.Player[0]);
                        break;
                    case ConversationStates.ConvoStates.Option2:
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(10, 20);
                        Console.WriteLine(ConversationTexts.Player[1]);
                        break;
                    case ConversationStates.ConvoStates.Option3:
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(10, 20);
                        Console.WriteLine(ConversationTexts.Player[2]);
                        break;
                    case ConversationStates.ConvoStates.Option4:
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(10, 20);
                        Console.WriteLine(ConversationTexts.Player[3]);
                        break;
                    case ConversationStates.ConvoStates.Option5:
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(10, 20);
                        Console.WriteLine(ConversationTexts.Player[4]);
                        break;
                    case ConversationStates.ConvoStates.Option6:
                        Console.SetCursorPosition(10, 20);
                        Console.Write("                              ");
                        Console.SetCursorPosition(10, 20);
                        Console.WriteLine(ConversationTexts.Player[5]);
                        break;

                }
            }

        }
    }
}
