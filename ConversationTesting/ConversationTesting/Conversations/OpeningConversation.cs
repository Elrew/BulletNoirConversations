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

        // If the program has hit this tier of conversation, it flags it as true. This is NOT used as a marker for the next tier. 
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
        public static bool classRunning = true;

        public static List<string> NPC1 = new List<string>
        {
            "Hello, how are you?",
        };

        public static List<string> NPC2 = new List<string>
        {
            "Good! Glad to hear it. Listen, I have been having some trouble lately. Do you think you can help me out?",
            "Oh? I'm sorry to hear that. I hope things get better for you. Well, I best be going.\n Leave me alone",
            "Well! I never! Fine I will leave you alone! Good day!",
            "Yes, fine weather we are having. Say would you mind helping me with a task?",
            "Batter up!",
        };

        public static List<string> NPC3 = new List<string>
        {
            "Well, you see I have some large rats in my basement and I was wondering if you could go smash their brains in with this tiny hammer",
            "Oh! Not a problem. Have a great day!",
            "Well, you see I have some large rats in my basement and I was wondering if you could go smash their brains in with this tiny hammer.I am pretty poor, so not much. About 1 million pennies, paid in full, in bags weighing 1000lbs each.You can also keep any money the rats have in their wallets. "

        };
        public static List<string> NPC4 = new List<string>
        {
            "Sounds great! Here's the hammer, get to work. I'll lock the door behind you to make sure you...uh they can't escape.",
            "Oh, think you're too good smash a small creatures brains out? I don't need your help anyways! Get outta here!",

        };

        public static List<string> Player = new List<string>
        {
            "1)Good, thank you",
            "2)Not great",
            "3)Leave me alone",
            "4)It's a wonderful day outside, isn't it?",

        };

        

        public static List<string> Player2 = new List<string>
        {
            "1)Of course",
            "2)I don't have time",
            "3)I'd rather not",
            "4)How much am I getting paid?",

        };

        public static List<string> Player3 = new List<string>
        {
            "1) Sounds disgusting. I'll do it.",
            "2) I'd rather not",
            "3) End Conversation"
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
                        if (Tier2) { currentState = ConversationStates.ConvoStates.Tier3; dialogueOption = 1; break; }
                        if (Tier3) { currentState = ConversationStates.ConvoStates.Tier4; dialogueOption = 1; break; }
                        if (Tier4) { currentState = ConversationStates.ConvoStates.Tier5; dialogueOption = 1; break; }
                        currentState = ConversationStates.ConvoStates.Option1;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        if (Tier2) { currentState = ConversationStates.ConvoStates.Tier3; dialogueOption = 2; break; }
                        if (Tier3) { currentState = ConversationStates.ConvoStates.Tier4; dialogueOption = 2; break; }
                        if (Tier4) { currentState = ConversationStates.ConvoStates.Tier5; dialogueOption = 2; break; }
                        currentState = ConversationStates.ConvoStates.Option2;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        if (Tier2) { currentState = ConversationStates.ConvoStates.Tier3; dialogueOption = 3; break; }
                        if (Tier3) { currentState = ConversationStates.ConvoStates.Tier4; dialogueOption = 3; break; }
                        if (Tier4) { currentState = ConversationStates.ConvoStates.Tier5; dialogueOption = 3; break; }
                        currentState = ConversationStates.ConvoStates.Option3;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        if (Tier2) { currentState = ConversationStates.ConvoStates.Tier3; dialogueOption = 4; break; }
                        if (Tier3) { currentState = ConversationStates.ConvoStates.Tier4; dialogueOption = 4; break; }
                        if (Tier4) { currentState = ConversationStates.ConvoStates.Tier5; dialogueOption = 4; break; }
                        currentState = ConversationStates.ConvoStates.Option4;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        if (Tier2) { currentState = ConversationStates.ConvoStates.Tier3; dialogueOption = 5; break; }
                        if (Tier3) { currentState = ConversationStates.ConvoStates.Tier4; dialogueOption = 5; break; }
                        if (Tier4) { currentState = ConversationStates.ConvoStates.Tier5; dialogueOption = 5; break; }
                        currentState = ConversationStates.ConvoStates.Option5;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        if (Tier2) { currentState = ConversationStates.ConvoStates.Tier3; dialogueOption = 6; break; }
                        if (Tier3) { currentState = ConversationStates.ConvoStates.Tier4; dialogueOption = 6; break; }
                        if (Tier4) { currentState = ConversationStates.ConvoStates.Tier5; dialogueOption = 6; break; }
                        currentState = ConversationStates.ConvoStates.EndConversation;
                        break;


                }

                
                switch (currentState)
                {
                    case ConversationStates.ConvoStates.Idle:
                        Console.SetCursorPosition(10, 20);
                        Console.Write(OpeningConversation.NPC1[0]);
                        DrawText.DrawPlayerOptions(OpeningConversation.Player, 10, 35);
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
                        Console.SetCursorPosition(10, 20);
                        Console.WriteLine(NPC2[3]);
                        dialogueOption = 3;
                        break;
                    case ConversationStates.ConvoStates.Option4:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[3]);
                        currentState = ConversationStates.ConvoStates.Tier2;
                        dialogueOption = 4;
                        break;
                    case ConversationStates.ConvoStates.Option5:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[4]);
                        currentState = ConversationStates.ConvoStates.Tier2;
                        dialogueOption = 5;
                        break;
                    case ConversationStates.ConvoStates.Option6:
                        Console.Clear();
                        Console.SetCursorPosition(50, 20);
                        Console.WriteLine(OpeningConversation.Player[5]);
                        currentState = ConversationStates.ConvoStates.Tier2;
                        dialogueOption = 6;
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
                            Console.WriteLine(NPC2[0]);
                            DrawText.DrawPlayerOptions(Player2, 10, 35);
                            KeyInfo();
                            Tier2 = true;
                        }
                        else if (dialogueOption == 2)
                        {
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC2[1]);
                            KeyInfo();
                            Tier2 = true;
                        }
                        else if (dialogueOption == 3)
                        {
                            KeyInfo();
                            classRunning = false;
                        }
                        else if (dialogueOption == 4)
                        {
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC2[3]);
                            DrawText.DrawPlayerOptions(Player2, 10, 35);
                            KeyInfo();
                            Tier2 = true;
                            dialogueOption = 1;
                        }
                        else if (dialogueOption == 5)
                        {
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC2[4]);
                            KeyInfo();
                            Tier2 = true;
                        }
                        break;
                    case ConversationStates.ConvoStates.Tier3:
                        if (dialogueOption == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC3[0]);
                            DrawText.DrawPlayerOptions(Player3, 10, 35);
                            KeyInfo();
                            Tier3 = true;
                            Tier2 = false;
                        }
                        else if(dialogueOption == 2)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC3[1]);
                            KeyInfo();
                            classRunning = false;
                        }
                        else if(dialogueOption == 3)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC3[1]);
                            KeyInfo();
                            classRunning = false;
                        }
                        else if(dialogueOption == 4)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC3[2]);
                            Console.SetCursorPosition(10, 35);
                            DrawText.DrawPlayerOptions(Player3, 10, 35);
                            KeyInfo();
                            Tier3 = true;
                            Tier2 = false;

                        }
                        else if(dialogueOption == 5)
                        {

                        }

                        break;

                    case ConversationStates.ConvoStates.Tier4:
                        if (dialogueOption == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC4[0]);
                            KeyInfo();
                            Tier4 = true;
                            Tier3 = false;
                            classRunning = false;
                        }
                        else if (dialogueOption == 2)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(10, 20);
                            Console.WriteLine(NPC4[1]);
                            KeyInfo();
                            Tier4 = true;
                            Tier3 = false;
                            classRunning = false;
                        }
                        break;
                }
            }while (classRunning);
            //return Program.hadFirstConversation = true;

        }
    }
}
