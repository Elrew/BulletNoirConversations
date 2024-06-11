using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConversationTesting.ConversationStates;

namespace ConversationTesting.Conversations
{

    internal class OpeningConversation
    {
        static ConversationStates.ConvoStates currentState = ConversationStates.ConvoStates.Idle;
        static ConsoleKeyInfo keyInfo;
        static bool Tier2 = false;
        static bool Tier3 = false;
        static bool Tier4 = false;
        static bool Tier5 = false;
        static bool Tier6 = false;
        static bool Tier7 = false;
        static bool Tier8 = false;
        static bool Tier9 = false;
        static bool Tier10 = false;
        static int dialogueOption = 0;
        static bool classRunning = true;

        public static List<string> NPC1 = new List<string>
        {
            "Hello, how are you?",
            "Good! Glad to hear it. Listen, I have been having some trouble lately. Do you think you can help me out?",
            "Oh? I'm sorry to hear that. I hope things get better for you. Well, I best be going.\n Leave me alone",
            "Well! I never! Fine I will leave you alone! Good day!",
            "Yes, fine weather we are having. Say would you mind helping me with a task?",
            "Batter up!",
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

        

        public static List<string> Player2 = new List<string>
        {
            "1)Of course",
            "2)I don't have time",
            "3)I'd rather not",
            "4)How much am I getting paid?",
            "5)Basketball",
            ""
        };

        public static void KeyInfo()
        {
            keyInfo = Console.ReadKey();
        }
  

        public static void Conversation()
        {
            do {
                
                
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        if (Tier2 || Tier3 || Tier4 || Tier5 || Tier6 || Tier7 || Tier8 || Tier9 || Tier10) { break; }
                        currentState = ConversationStates.ConvoStates.Option1;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        if (Tier2 || Tier3 || Tier4 || Tier5 || Tier6 || Tier7 || Tier8 || Tier9 || Tier10) { break; }
                        currentState = ConversationStates.ConvoStates.Option2;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        if (Tier2 || Tier3 || Tier4 || Tier5 || Tier6 || Tier7 || Tier8 || Tier9 || Tier10) { break; }
                        currentState = ConversationStates.ConvoStates.Option3;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        if (Tier2 || Tier3 || Tier4 || Tier5 || Tier6 || Tier7 || Tier8 || Tier9 || Tier10) { break; }
                        currentState = ConversationStates.ConvoStates.Option4;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        if (Tier2 || Tier3 || Tier4 || Tier5 || Tier6 || Tier7 || Tier8 || Tier9 || Tier10) { break; }
                        currentState = ConversationStates.ConvoStates.Option5;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        if (Tier2 || Tier3 || Tier4 || Tier5 || Tier6 || Tier7 || Tier8 || Tier9 || Tier10) { break; }
                        currentState = ConversationStates.ConvoStates.EndConversation;
                        break;


                }

                
                switch (currentState)
                {
                    case ConversationStates.ConvoStates.Idle:
                        Console.WriteLine(OpeningConversation.NPC1[0]);
                        DrawText.DrawPlayerOptions(Player, 10, 20);
                        DrawText.DrawPlayerOptions(OpeningConversation.Player, 10, 20);
                        KeyInfo();
                        break;
                    case ConversationStates.ConvoStates.EndConversation:
                        break;
                    case ConversationStates.ConvoStates.Option1:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(Player[0]);
                        currentState = ConversationStates.ConvoStates.Tier2;
                        dialogueOption = 1;
                        break;
                    case ConversationStates.ConvoStates.Option2:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        currentState = ConversationStates.ConvoStates.Tier2;
                        dialogueOption = 2;
                        break;
                    case ConversationStates.ConvoStates.Option3:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[2]);

                        break;
                    case ConversationStates.ConvoStates.Option4:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[3]);
                        break;
                    case ConversationStates.ConvoStates.Option5:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[4]);
                        break;
                    case ConversationStates.ConvoStates.Option6:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[5]);
                        break;
                    default:
                        break;

                }
                
                switch (currentState)
                {
                    case ConversationStates.ConvoStates.Tier2:
                        Console.Clear();
                        if (dialogueOption == 1)
                        {
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC1[1]);
                            DrawText.DrawPlayerOptions(Player2, 10, 35);
                            KeyInfo();
                            Tier2 = true;
                        }
                        else if (dialogueOption == 2)
                        {
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC1[2]);
                            KeyInfo();
                            Tier2 = true;
                            classRunning = false;
                        }

                        break;
                }
            }while (classRunning);
            //return Program.hadFirstConversation = true;

        }
    }
}
