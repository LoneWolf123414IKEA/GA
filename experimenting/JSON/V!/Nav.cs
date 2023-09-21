namespace V1
{
    public class Nav
    {
        public void mainMenu()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            Console.Write('>');
            int pos = 1;
            while (true)
            {
                Console.SetCursorPosition(3, 1);
                Console.Write("edit config");
                Console.SetCursorPosition(3, 2);
                Console.Write("edit default profile");
                Console.SetCursorPosition(3, 3);
                Console.Write("edit member");
                Console.SetCursorPosition(3, 4);
                Console.Write("edit additional profile");
                Console.SetCursorPosition(3, 5);
                Console.Write("exit program");
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.UpArrow:
                        if (pos != 1)
                        {
                            Console.SetCursorPosition(1, pos);
                            Console.Write(' ');
                            pos--;
                            Console.SetCursorPosition(1, pos);
                            Console.Write('>');
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (pos != 5)
                        {
                            Console.SetCursorPosition(1, pos);
                            Console.Write(' ');
                            pos++;
                            Console.SetCursorPosition(1, pos);
                            Console.Write('>');
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (pos)
                        {
                            case 1:
                                Program.config.editConfig();
                                break;
                            case 2:
                                Program.config.editDefault();
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            default: 
                                Console.Clear();
                                return;
                        }
                        break;
                }
            }
        }
    }
}