using Cosmos.System.ExtendedASCII;
using System;
using System.Text;
using Sys = Cosmos.System;


namespace Swan
{
    public class Kernel : Sys.Kernel
    {
        private int min = 4;
        private int sec = 30;
        private String totalString = "";
        private String stringFailure = "";
        private double wait;
        private bool hieroglyphs = false;
        private int systemFailureCont = 30;
        private bool waltChat = false;
        private int chatSession = 0;
        private bool firstTime = true;

        //In the original script the word "north" writed by walt int second chat session
        //was non present in the episode, but we can infer it from the third chat session.
        String[] waltScript = new String[]
            {"Hello?", "Who is this?", "Dad?",                                      //first chat session
            "Yes.\nAre you alone?",                                                //second chat session
            "Can't talk long. They're coming back soon...",
            "You need to come north.",
            "ok. no time. come soon?",                                              //third chat session
            "when they take me out. there's huge rocks with a" +
            " big HOLE in the middle by the beach. you'll know when you see."};

        // each micheal's line is preced by ">:" instead, walt's line are not

        String[] michealScript = new String[]
            {"Hello?",                                                              //first chat session
            "This is Micheal. Who is this?",
            "Are you OK?", "Yes.", "Where are you?",                                //second chat session
            "You ok?", "I'm ready. Coming NOW. You said north -- north WHERE?",     //third chat session
            "It's gonna be okay. I'm coming."};


        private bool stringComparison(String a, String b)
        {
            a = a.Trim().ToLower().Replace(".", "")
                .Replace(",", "").Replace("?", "")
                .Replace(" ", "").Replace("'", "").Replace("-", "");
            b = b.Trim().ToLower().Replace(".", "")
                .Replace(",", "").Replace("?", "")
                .Replace(" ", "").Replace("'", "").Replace("-", "");

            return a.Equals(b);
        }

        private int beep()
        {
            if (min == 0 && sec <= 10)
            {
                Console.Beep(880, 300);
                return 1;
            }
            else if (min == 0 && sec % 2 == 0)
            {
                Console.Beep(880, 300);
                return 1;
            }
            else if (min <= 3 && sec % 2 == 0)
            {
                Console.Beep(680, 52);
                return 2;
            }
            return 0;
        }

        protected override void BeforeRun()
        {
            Encoding.RegisterProvider(CosmosEncodingProvider.Instance);

            Console.InputEncoding = Encoding.GetEncoding(437);
            Console.OutputEncoding = Encoding.GetEncoding(437);

            var arr = new[]
            {"               STATION 3 - THE SWAN - 1978 - VER 6.14         " };

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorSize = 100;


            foreach (string line in arr)
                Console.WriteLine(line);
            Console.WriteLine("\n");

            for (int i = 0; i < 7; i++)
            {
                Console.Write("\rInitializing system");
                for (int j = i; j > 0; j--)
                    Console.Write(".");

                System.Threading.Thread.Sleep(750);
            }

            Console.Beep(680, 52);
        }

        protected override void Run()
        {   //Cosmos os don't support multithreading
            //so, we have to write all coding logic into a giant
            //while true, until the swan station explode :)
            while (true)
            {
                ////////////////////////////////////////////
                /// TIMER'S LOGIC
                ///////////////////////////////////////////

                string minString = min.ToString().PadLeft(3, '0');
                string secString = sec.ToString().PadLeft(2, '0');
                Console.Clear();

                //hieroglyphs
                if (min == 0 && sec == 0)
                {
                    hieroglyphs = true;

                    /////line 0
                    Console.Write("             ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i000i00i");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();

                    /////line 1
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("             ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write((char)244);
                    Console.Write((char)64);
                    Console.Write((char)33);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write((char)168);
                    Console.Write((char)92);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();

                    /////line 2
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("             ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i000i00i");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }

                //normal execution
                else
                {
                    /////line 0
                    Console.Write("             ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i000i00i");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();

                    /////line 1
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("             ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(minString);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(secString);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();

                    /////linea 2
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("             ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("i000i00i");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.Write(totalString);


                ////////////////////////////////////////////
                /// INPUT LOGIC
                ///////////////////////////////////////////

                if (hieroglyphs)
                {
                    Console.WriteLine();
                    stringFailure += "System Failure";
                    Console.Write(stringFailure);
                    Console.SetCursorPosition(totalString.Length, 4);

                    systemFailureCont--;

                    if (systemFailureCont == 0)
                        Cosmos.System.Power.Shutdown();
                }

                if (!hieroglyphs)
                {
                    systemFailureCont = 30;
                    if (sec == 0)
                    {
                        min--;
                        sec = 59;
                    }
                    else sec--;
                }



                //writing code routine.
                //the code can only be input when the minute is
                //less or equal than 3
                if (min <= 3)
                {
                    if (firstTime)
                    {
                        totalString = ">:";
                        waltChat = false;
                        firstTime = false;
                    }

                    switch (beep())
                    {
                        case 0:
                            wait = 1000;
                            break;
                        case 1:
                            wait = 700;
                            break;
                        case 2:
                            wait = 948;
                            break;
                    }

                    DateTime timeoutvalue = DateTime.Now;
                    while (wait > 0)
                    {
                        ConsoleKeyInfo appo = ReadKeyWithTimeOut((int)wait);

                        if (appo.Key == ConsoleKey.Backspace)
                        {
                            if (totalString.Length > 2)
                                totalString = totalString.Substring(0, totalString.Length - 1);
                        }
                        else if (appo.Key == ConsoleKey.Enter)
                        {
                            if (totalString.Substring(2).Equals("4 8 15 16 23 42"))
                            {
                                totalString = "";
                                min = 108;
                                sec = 0;
                                hieroglyphs = false;
                                firstTime = true;
                            }
                        }
                        else if (appo.KeyChar != (char)36)
                        {
                            totalString += appo.KeyChar;
                        }


                        wait -= DateTime.Now.Subtract(timeoutvalue).TotalMilliseconds;
                    }
                }
                //when minutes is greater than 3 
                //we can have a chat with Walt,
                //the special charachers to start the chat
                //is "ESC", locate in the upper left corner
                else
                {
                    wait = 1000;
                    DateTime timeoutvalue = DateTime.Now;
                    while (wait > 0)
                    {
                        if (!waltChat)
                        {
                            ConsoleKeyInfo appo = ReadKeyWithTimeOut((int)wait);

                            if (appo.Key == ConsoleKey.Escape)//chat with walt routine started
                            {
                                waltChat = true;

                                totalString = waltScript[chatSession] + "\n>:";
                            }
                        }
                        else
                        {
                            ConsoleKeyInfo appo = ReadKeyWithTimeOut((int)wait);

                            if (appo.Key == ConsoleKey.Escape)//chat with walt routine ended
                            {
                                waltChat = false;

                                totalString = "";
                            }
                            if (appo.Key == ConsoleKey.Backspace)
                            {
                                if (totalString[totalString.Length - 1] != ':')
                                    totalString = totalString.Substring(0, totalString.Length - 1);
                            }
                            else if (appo.Key == ConsoleKey.Enter)
                            {
                                if (stringComparison(totalString.Substring(totalString.LastIndexOf(">:") + 2), michealScript[chatSession]))
                                {
                                    if (++chatSession == 8)
                                    {
                                        waltChat = false;
                                        chatSession = 0;
                                        totalString = "";
                                    }
                                    else
                                        totalString += "\n" + waltScript[chatSession] + "\n>:";
                                }
                            }
                            else if (appo.KeyChar != (char)36)
                            {
                                totalString += appo.KeyChar;
                            }
                        }

                        wait -= DateTime.Now.Subtract(timeoutvalue).TotalMilliseconds;
                    }
                }
            }
        }


        //auxiliary function for getting input
        public ConsoleKeyInfo ReadKeyWithTimeOut(int timeOutMS)
        {
            DateTime timeoutvalue = DateTime.Now.AddMilliseconds(timeOutMS);

            while (DateTime.Now < timeoutvalue)
            {
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo cki = Console.ReadKey();
                    return cki;

                }
                else
                    System.Threading.Thread.Sleep(25);
            }

            return new ConsoleKeyInfo((char)36, ConsoleKey.Home, false, false, false);
        }
    }
}