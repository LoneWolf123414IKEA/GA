namespace V1
{
    public class Config
    {
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
            defaul = new Member();
            members.Add(new Member());
            additional_profiles.Add(new Member());

        }

        public class Member
        {
            public string pofileName{get;set;}
            public string? set_name{get;set;}
            public string? set_avatar{get;set;}
            public Role? set_role{get;set;}
            public string? set_banner{get;set;}
            public string? set_bio{get;set;}
            public string? set_pronouns{get;set;}


            public Member()
            {
                set_role = new Role();
            }


            public class Role 
            {
                public int? guild{get;set;}
                public int? role{get;set;}
                public string? name{get;set;}
                public string? colour{get;set;}

                public Role()
                {
                }
            }
        }
    }
}