using System;
using System.Collections.Generic;
using System.Text;

class DoorMachine
{
    enum State { TERKUNCI, TERBUKA };

    public static void Run()
    {
        State state = State.TERKUNCI;
        string[] screenName = { "TERKUNCI", "TERBUKA" };

        while (true)
        {

            Console.Write("Enter Command : ");
            string command = Console.ReadLine();
            Console.WriteLine();

            switch (state)
            {
                case State.TERKUNCI:
                    if (command == "Terbuka")
                    {
                        Console.WriteLine("Pintu tidak terkunci");
                        state = State.TERBUKA;
                    }
                    else
                    {
                        Console.WriteLine("Pintu terkunci");
                    }
                    break;

                case State.TERBUKA:
                    if (command == "Terkunci")
                    {
                        Console.WriteLine("Pintu terkunci");
                        state = State.TERKUNCI;
                    }
                    else
                    {
                        Console.WriteLine("Pintu tidak terkunci");
                    }
                    break;
            }
        }
    }
}   