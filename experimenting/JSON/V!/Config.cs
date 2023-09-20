using Microsoft.VisualBasic;

namespace V1
{
    public class Config
    {
        public int version = 1;
        public string? token{get; set;}
        public string? identity{get;set;}
        public string? bot_ip{get;set;}
        public int? bot_port{get;set;}
        public int? owner{get;set;}
        public string? owner_name{get;set;}
        public int? cooldown_period{get;set;}
        public Member defaul{get;set;}
        public List<Member?> members{get;set;} = new List<Member?>();
        public List<Member?> additional_profiles{get;set;} = new List<Member?>();

        public void editConfig()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            Console.Write('>');
            int pos = 1;
            string tryNum;
            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(3, 1);
                Console.Write("Token:");
                Console.SetCursorPosition(3, 2);
                Console.Write("IP (you shuld never have to change this):");
                Console.SetCursorPosition(3, 3);
                Console.Write("Port (you shuld never have to change this):");
                Console.SetCursorPosition(3, 4);
                Console.Write("Account ID:");
                Console.SetCursorPosition(3, 5);
                Console.Write("System Name:");
                Console.SetCursorPosition(3, 6);
                Console.Write("Default time(min):");
                Console.SetCursorPosition(3, 7);
                Console.Write("return to menu");


                Console.SetCursorPosition(10,1);
                if(token != null) Console.Write(token);
                Console.SetCursorPosition(45,2);
                if(bot_ip != null) Console.Write(bot_ip);
                Console.SetCursorPosition(47,3);
                if(bot_port != null) Console.Write(bot_port);
                Console.SetCursorPosition(15,4);
                if(owner != null) Console.Write(owner);
                Console.SetCursorPosition(16,5);
                if(owner_name != null) Console.Write(owner_name);
                Console.SetCursorPosition(22,6);
                if(cooldown_period != null) Console.Write(cooldown_period);

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
                        if (pos != 7)
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
                                Console.CursorVisible = true;
                                if(token != null)
                                {
                                    Console.SetCursorPosition(10,1);
                                    for(int i = token.Length; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.SetCursorPosition(10,1);
                                token = Console.ReadLine();
                                break;
                            case 2:
                                Console.CursorVisible = true;
                                if(bot_ip != null)
                                {
                                    Console.SetCursorPosition(45,2);
                                    for(int i = bot_ip.Length; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.SetCursorPosition(45, 2);
                                bot_ip = Console.ReadLine();
                                break;
                            case 3:
                                Console.CursorVisible = true;
                                while(true)
                                {
                                    Console.SetCursorPosition(47,3);
                                    for(int i = bot_port.ToString().Length; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.SetCursorPosition(47,3);
                                    tryNum = Console.ReadLine();
                                    try
                                    {
                                        bot_port = int.Parse(tryNum);
                                        break;
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(47,3);
                                        for(int i = tryNum.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }
                                    }

                                }
                                break;
                            case 4:
                                Console.CursorVisible = true;
                                while(true)
                                {
                                    Console.SetCursorPosition(15, 4);
                                    for(int i = owner.ToString().Length; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.SetCursorPosition(15, 4);
                                    tryNum = Console.ReadLine();
                                    try
                                    {
                                        owner = int.Parse(tryNum);
                                        break;
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(15, 4);
                                        for(int i = tryNum.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }
                                    }

                                }
                                break;
                            case 5:
                                Console.CursorVisible = true;
                                if(owner_name != null)
                                {
                                    Console.SetCursorPosition(16, 5);
                                    for(int i = owner_name.Length; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }

                                }
                                Console.SetCursorPosition(16, 5);
                                owner_name = Console.ReadLine();
                                break;
                            case 6:
                                Console.CursorVisible = true;
                                while(true)
                                {
                                    Console.SetCursorPosition(22, 6);
                                    for(int i = cooldown_period.ToString().Length; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.SetCursorPosition(22,6);
                                    tryNum = Console.ReadLine();
                                    try
                                    {
                                        cooldown_period = int.Parse(tryNum);
                                        break;
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(22, 6);
                                        for(int i = tryNum.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }
                                    }

                                }
                                break;
                            default:
                                Console.Clear();
                                return;
                        }
                        break;
                }
            }
        }
        public void editDefault()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            Console.Write('>');
            int pos = 1;
            while (true)
            {
                Console.SetCursorPosition(3, 1);
                Console.Write("Token:");
                Console.SetCursorPosition(3, 2);
                Console.Write("IP (you shuld never have to change this):");
                Console.SetCursorPosition(3, 3);
                Console.Write("Port (you shuld never have to change this):");
                Console.SetCursorPosition(3, 4);
                Console.Write("Account ID:");
                Console.SetCursorPosition(3, 5);
                Console.Write("System Name:");
                Console.SetCursorPosition(3, 6);
                Console.Write("Default time(min):");
                Console.SetCursorPosition(3, 7);
                Console.Write("return to menu");
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
                        if (pos != 7)
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
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            default:
                                Console.Clear();
                                return;
                        }
                        break;
                }
            }
        }
        public Config()
        {
            token = "test";
            defaul = new Member();
            members.Add(new Member());
            additional_profiles.Add(new Member());

        }

        public class Member
        {
            public string profileName{get;set;}
            public string? display_name{get;set;}
            public string? avatar{get;set;}
            public string? banner_colour{get;set;}
            public string? bio{get;set;}
            public string? pronouns{get;set;}
            public Guild? guild_overrides{get;set;}


            public Member()
            {
                
            }
            public class Guild
            {
                public int guild{get;set;}
                public Role? roles{get;set;}
                public string? display_name{get;set;}
                public string? pronouns{get;set;}
                public class Role 
                {
                    public int role{get;set;}
                    public string name{get;set;}
                    public string colour{get;set;}
                }
            }
        }
    }
}