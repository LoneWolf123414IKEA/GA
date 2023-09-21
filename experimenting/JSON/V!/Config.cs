using System.Drawing;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;
namespace V1

{
    public class Config
    {
        public int version{get;set;} = 1;
        public string? token{get; set;}
        public string? identity{get;set;}
        public string? bot_ip{get;set;}
        public int? bot_port{get;set;}
        public long? owner{get;set;}
        public string? owner_name{get;set;}
        public int? cooldown_period{get;set;}
        public Default defaul{get;set;}
        public List<Member?>? members{get;set;} = new List<Member?>();
        public List<Member?>? additional_profiles{get;set;} = new List<Member?>();

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
                        Console.Clear();
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
                                        owner = long.Parse(tryNum);
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
                                Console.Write("please enter passcode(ideentity): ");
                                identity = Console.ReadLine();
                                Console.Clear();
                                return;
                        }
                        break;
                }
            }
        }
        public void editDefault()
        {
            string tryNum;
            int num = 0;
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            Console.Write('>');
            int pos = 1;
            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(3, 1);
                Console.Write("Usn(2-32):");
                Console.SetCursorPosition(3, 2);
                Console.Write("Pfp url:");
                Console.SetCursorPosition(3, 3);
                Console.Write("Banner colour(currently only hex):");
                Console.SetCursorPosition(3, 4);
                Console.Write("Bio(190):");
                Console.SetCursorPosition(3, 5);
                Console.Write("Pronouns(40):");
                Console.SetCursorPosition(3, 6);
                Console.Write("Servers");
                Console.SetCursorPosition(3, 7);
                Console.Write("return to menu");


                Console.SetCursorPosition(14,1);
                if(defaul.display_name != null) Console.Write(defaul.display_name);
                Console.SetCursorPosition(12,2);
                if(defaul.avatar != null) Console.Write(defaul.avatar);
                Console.SetCursorPosition(37,3);
                if(defaul.banner_colour != null) Console.Write(defaul.banner_colour);
                Console.SetCursorPosition(13,4);
                if(defaul.bio != null) Console.Write(defaul.bio);
                Console.SetCursorPosition(17,5);
                if(defaul.pronouns != null) Console.Write(defaul.pronouns);
                Console.SetCursorPosition(1, pos);
                Console.Write('>');

                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Escape:
                        Console.Clear();
                        if(defaul.avatar == null) defaul.avatar = "url; https://avatarfiles.alphacoders.com/894/89415.jpg";
                        if(defaul.banner_colour == null) defaul.banner_colour = "AACCEE";
                        if(defaul.display_name == null) defaul.display_name = "Abe Sentmind";
                        if(defaul.bio == null) defaul.bio = "";
                        if(defaul.pronouns == null) defaul.pronouns = "";
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
                                while(true)
                                {
                                    if(defaul.display_name != null)
                                    {
                                        Console.SetCursorPosition(14, 1);
                                        for(int i = defaul.display_name.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }

                                    }
                                    Console.SetCursorPosition(14, 1);
                                    tryNum = Console.ReadLine();
                                    if(tryNum.Length <= 32 && tryNum.Length >= 2)
                                    {
                                        
                                        defaul.display_name = tryNum;
                                        break;
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(14, 1);
                                        for(int i = tryNum.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }
                                    }

                                }
                                break;
                            case 2:
                                Console.CursorVisible = true;
                                while(true)
                                {
                                    if(defaul.avatar != null)
                                    {
                                        Console.SetCursorPosition(12, 2);
                                        for(int i = defaul.avatar.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }

                                    }
                                    Console.SetCursorPosition(12, 2);
                                    tryNum = Console.ReadLine();
                                    if(tryNum.Length > -1)
                                    {
                                        
                                        defaul.avatar = tryNum;
                                        break;
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(12, 2);
                                        for(int i = tryNum.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }
                                    }

                                }
                                break;
                            case 3:
                                Console.CursorVisible = true;
                                while(true)
                                {
                                    if(defaul.banner_colour != null)
                                    {
                                        Console.SetCursorPosition(37, 3);
                                        for(int i = defaul.banner_colour.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }

                                    }
                                    Console.SetCursorPosition(37, 3);
                                    tryNum = Console.ReadLine();
                                    if(tryNum.Length == 6 && Nav.contains(tryNum, "1234567890abcdefABCDEF"))
                                    {
                                        defaul.banner_colour = tryNum;
                                        break;
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(37, 3);
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
                                    if(defaul.bio != null)
                                    {
                                        Console.SetCursorPosition(13, 4);
                                        for(int i = defaul.bio.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }

                                    }
                                    Console.SetCursorPosition(13, 4);
                                    tryNum = Console.ReadLine().Replace("\\n", "\n");
                                    if(tryNum.Length < 191)
                                    {
                                        
                                        defaul.bio = tryNum;
                                        break;
                                    }
                                    Console.SetCursorPosition(13, 4);
                                    for(int i = tryNum.Length; i > 0; i--)
                                    {
                                        Console.Write(" ");
                                    }

                                }
                                break;
                            case 5:
                                Console.CursorVisible = true;
                                while(true)
                                {
                                    if(defaul.pronouns != null)
                                    {
                                        Console.SetCursorPosition(17, 5);
                                        for(int i = defaul.pronouns.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }

                                    }
                                    Console.SetCursorPosition(17, 5);
                                    tryNum = Console.ReadLine();
                                    if(tryNum.Length < 41)
                                    {
                                        
                                        defaul.pronouns = tryNum;
                                        break;
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(17, 5);
                                        for(int i = tryNum.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }
                                    }

                                }
                                break;
                            case 6:
                                defaul.servers();
                                break;
                            default:
                                Console.Clear();
                                if(defaul.avatar == null) defaul.avatar = "url; https://avatarfiles.alphacoders.com/894/89415.jpg";
                                if(defaul.banner_colour == null) defaul.banner_colour = "AACCEE";
                                if(defaul.display_name == null) defaul.display_name = "Abe Sentmind";
                                if(defaul.bio == null) defaul.bio = "";
                                if(defaul.pronouns == null) defaul.pronouns = "";
                                return;
                        }
                        Console.Clear();
                        break;
                }
            }
        }
        public Config()
        {
            defaul = new Default();

        }
        public class Member : Default
        {
            public string profileName{get;set;}
            public static void Members()
            {
                Console.Clear();
                int pos = 1;
                int count = 1;
                while(true)
                {
                    count = 1;
                    Console.CursorVisible = false;
                    foreach(Member i in Program.config.members)
                    {
                        Console.SetCursorPosition(3, count);
                        Console.Write(i.profileName);
                        count++;
                    }
                    Console.SetCursorPosition(3, count);
                    Console.Write("New");
                    Console.SetCursorPosition(3, count+1);
                    Console.Write("Return");
                    Console.SetCursorPosition(1, pos);
                    Console.Write('>');
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
                            if (pos != count+1)
                            {
                                Console.SetCursorPosition(1, pos);
                                Console.Write(' ');
                                pos++;
                                Console.SetCursorPosition(1, pos);
                                Console.Write('>');
                            }
                            break;
                        case ConsoleKey.Enter:
                            if (pos == count)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(1, 1);
                                Console.Write("please input profile name:");
                                Console.SetCursorPosition(1, 2);
                                Program.config.members.Add(new Member(Console.ReadLine()));
                            }
                            else if(pos == count+1) return;
                            else
                            {
                                Program.config.members[pos-1].editMember();
                            }
                            Console.Clear();
                            Console.SetCursorPosition(1, pos);
                            Console.Write('>');
                            break;
                    }
                }
                
            }
            public void editMember()
            {

                string tryNum;
                int num = 0;
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(1, 1);
                Console.Write('>');
                int pos = 1;
                while (true)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(3, 1);
                    Console.Write("Usn(2-32):");
                    Console.SetCursorPosition(3, 2);
                    Console.Write("Pfp url:");
                    Console.SetCursorPosition(3, 3);
                    Console.Write("Banner colour(currently only hex):");
                    Console.SetCursorPosition(3, 4);
                    Console.Write("Bio(190):");
                    Console.SetCursorPosition(3, 5);
                    Console.Write("Pronouns(40):");
                    Console.SetCursorPosition(3, 6);
                    Console.Write("Servers");
                    Console.SetCursorPosition(3, 7);
                    Console.Write("return to menu");


                    Console.SetCursorPosition(14,1);
                    if(display_name != null) Console.Write(display_name);
                    Console.SetCursorPosition(12,2);
                    if(avatar != null) Console.Write(avatar);
                    Console.SetCursorPosition(37,3);
                    if(banner_colour != null) Console.Write(banner_colour);
                    Console.SetCursorPosition(13,4);
                    if(bio != null) Console.Write(bio);
                    Console.SetCursorPosition(17,5);
                    if(pronouns != null) Console.Write(pronouns);
                    Console.SetCursorPosition(1, pos);
                    Console.Write('>');

                    switch (Console.ReadKey(false).Key)
                    {
                        case ConsoleKey.Escape:
                            Console.Clear();
                            if(avatar == null) avatar = "url; https://avatarfiles.alphacoders.com/894/89415.jpg";
                            if(banner_colour == null) banner_colour = "AACCEE";
                            if(display_name == null) display_name = "Abe Sentmind";
                            if(bio == null) bio = "";
                            if(pronouns == null) pronouns = "";
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
                                    while(true)
                                    {
                                        if(display_name != null)
                                        {
                                            Console.SetCursorPosition(14, 1);
                                            for(int i = display_name.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }

                                        }
                                        Console.SetCursorPosition(14, 1);
                                        tryNum = Console.ReadLine();
                                        if(tryNum.Length <= 32 && tryNum.Length >= 2)
                                        {
                                            
                                            display_name = tryNum;
                                            break;
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(14, 1);
                                            for(int i = tryNum.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }
                                        }

                                    }
                                    break;
                                case 2:
                                    Console.CursorVisible = true;
                                    while(true)
                                    {
                                        if(avatar != null)
                                        {
                                            Console.SetCursorPosition(12, 2);
                                            for(int i = avatar.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }

                                        }
                                        Console.SetCursorPosition(12, 2);
                                        tryNum = Console.ReadLine();
                                        if(tryNum.Length > -1)
                                        {
                                            
                                            avatar = tryNum;
                                            break;
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(12, 2);
                                            for(int i = tryNum.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }
                                        }

                                    }
                                    break;
                                case 3:
                                    Console.CursorVisible = true;
                                    while(true)
                                    {
                                        if(banner_colour != null)
                                        {
                                            Console.SetCursorPosition(37, 3);
                                            for(int i = banner_colour.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }

                                        }
                                        Console.SetCursorPosition(37, 3);
                                        tryNum = Console.ReadLine();
                                        if(tryNum.Length == 6 && Nav.contains(tryNum, "1234567890abcdefABCDEF"))
                                        {
                                            banner_colour = tryNum;
                                            break;
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(37, 3);
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
                                        if(bio != null)
                                        {
                                            Console.SetCursorPosition(13, 4);
                                            for(int i = bio.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }

                                        }
                                        Console.SetCursorPosition(13, 4);
                                        tryNum = Console.ReadLine().Replace("\\n", "\n");
                                        if(tryNum.Length < 191)
                                        {
                                            
                                            bio = tryNum;
                                            break;
                                        }
                                        Console.SetCursorPosition(13, 4);
                                        for(int i = tryNum.Length; i > 0; i--)
                                        {
                                            Console.Write(" ");
                                        }

                                    }
                                    break;
                                case 5:
                                    Console.CursorVisible = true;
                                    while(true)
                                    {
                                        if(pronouns != null)
                                        {
                                            Console.SetCursorPosition(17, 5);
                                            for(int i = pronouns.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }

                                        }
                                        Console.SetCursorPosition(17, 5);
                                        tryNum = Console.ReadLine();
                                        if(tryNum.Length < 41)
                                        {
                                            
                                            pronouns = tryNum;
                                            break;
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(17, 5);
                                            for(int i = tryNum.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }
                                        }

                                    }
                                    break;
                                case 6:
                                    servers();
                                    break;
                                default:
                                    Console.Clear();
                                    if(avatar == null) avatar = "url; https://avatarfiles.alphacoders.com/894/89415.jpg";
                                    if(banner_colour == null) banner_colour = "AACCEE";
                                    if(display_name == null) display_name = "Abe Sentmind";
                                    if(bio == null) bio = "";
                                    if(pronouns == null) pronouns = "";
                                    return;
                            }
                            Console.Clear();
                            break;
                    }
                }
            }
            public Member(string name)
            {
                this.profileName = name;
            }

        }
        public class Default
        {
            public string? display_name{get;set;}
            public string? avatar{get;set;}
            public string? banner_colour{get;set;}
            public string? bio{get;set;}
            public string? pronouns{get;set;}
            public List<Guild> guild_overrides{get;set;} = new List<Guild>();
            public void servers()
            {
                Console.Clear();
                int pos = 1;
                int count = 1;
                while(true)
                {
                    count = 1;
                    Console.CursorVisible = false;
                    foreach(Guild i in guild_overrides)
                    {
                        Console.SetCursorPosition(3, count);
                        Console.Write(i.guild);
                        count++;
                    }
                    Console.SetCursorPosition(3, count);
                    Console.Write("New");
                    Console.SetCursorPosition(3, count+1);
                    Console.Write("Return");
                    Console.SetCursorPosition(1, pos);
                    Console.Write('>');
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
                            if (pos != count+1)
                            {
                                Console.SetCursorPosition(1, pos);
                                Console.Write(' ');
                                pos++;
                                Console.SetCursorPosition(1, pos);
                                Console.Write('>');
                            }
                            break;
                        case ConsoleKey.Enter:
                            if (pos == count)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(1, 1);
                                Console.Write("please input server id:");
                                Console.SetCursorPosition(1, 2);
                                while(true)
                                {
                                    try
                                    {
                                        
                                        guild_overrides.Add(new Guild(long.Parse(Console.ReadLine())));
                                        break;
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.Write("Err0001");
                                        Console.Read();
                                        break;
                                    }
                                }
                            }
                            else if(pos == count+1) return;
                            else
                            {
                                guild_overrides[pos-1].setGuild();
                            }
                            Console.Clear();
                            Console.SetCursorPosition(1, pos);
                            Console.Write('>');
                            break;
                    }
                }
                
            }


            public class Guild
            {
                public long guild{get;set;}
                public Role? role{get;set;}
                public string? display_name{get;set;}
                public string? pronouns{get;set;}
                public Guild(long name)
                {
                    this.guild = name;
                }
                public void setGuild()
                {
                    int pos = 1;
                    string tryNum;
                    while (true)
                    {
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(3, 1);
                        Console.Write("nickname(32):");
                        Console.SetCursorPosition(3, 2);
                        Console.Write("Pronouns(40):");
                        Console.SetCursorPosition(3, 3);
                        Console.Write("Role");
                        Console.SetCursorPosition(3, 4);
                        Console.Write("return to menu");


                        Console.SetCursorPosition(17,1);
                        if(display_name != null) Console.Write(display_name);
                        Console.SetCursorPosition(17,2);
                        if(pronouns != null) Console.Write(pronouns);
                        Console.SetCursorPosition(1, pos);
                        Console.Write('>');
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
                                if (pos != 4)
                                {
                                    Console.SetCursorPosition(1, pos);
                                    Console.Write(' ');
                                    pos++;
                                    Console.SetCursorPosition(1, pos);
                                    Console.Write('>');
                                }
                                break;
                            case ConsoleKey.Enter:
                                switch(pos)
                                {
                                    case 1:
                                        Console.CursorVisible = true;
                                        while(true)
                                        {
                                            if(display_name != null)
                                            {
                                                Console.SetCursorPosition(17, 1);
                                                for(int i = display_name.Length; i > 0; i--)
                                                {
                                                    Console.Write(" ");
                                                }

                                            }
                                            Console.SetCursorPosition(17, 1);
                                            tryNum = Console.ReadLine().Replace("\\n", "\n");
                                            if(tryNum.Length < 33)
                                            {
                                                
                                                display_name = tryNum;
                                                break;
                                            }
                                            Console.SetCursorPosition(17, 1);
                                            for(int i = tryNum.Length; i > 0; i--)
                                            {
                                                Console.Write(" ");
                                            }

                                        }
                                        break;
                                    case 2:
                                        Console.CursorVisible = true;
                                        while(true)
                                        {
                                            if(pronouns != null)
                                            {
                                                Console.SetCursorPosition(17, 2);
                                                for(int i = pronouns.Length; i > 0; i--)
                                                {
                                                    Console.Write(" ");
                                                }

                                            }
                                            Console.SetCursorPosition(17, 2);
                                            tryNum = Console.ReadLine();
                                            if(tryNum.Length < 41)
                                            {
                                                
                                                pronouns = tryNum;
                                                break;
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(17, 2);
                                                for(int i = tryNum.Length; i > 0; i--)
                                                {
                                                    Console.Write(" ");
                                                }
                                            }

                                        }
                                        break;
                                    case 3:
                                        if(role == null)
                                        {
                                            Console.Clear();
                                            Console.SetCursorPosition(1,1);
                                            Console.Write("input role id: ");
                                            try
                                            {
                                                role = new Role(long.Parse(Console.ReadLine()));
                                            }
                                            catch{}
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.SetCursorPosition(1,1);
                                            Console.Write("input role name: ");
                                            role.name="";
                                            while (role.name.Length < 1) 
                                            {
                                                Console.SetCursorPosition(18, 1);
                                                role.name = Console.ReadLine();
                                            }
                                            Console.SetCursorPosition(1, 2);
                                            Console.Write("input role hex: ");
                                            while (true)
                                            {
                                                Console.SetCursorPosition(17, 2);
                                                tryNum = Console.ReadLine();
                                                if((tryNum.Length == 6 && Nav.contains(tryNum, "1234567890abcdefABCDEF")) || tryNum.Length == 0)
                                                {
                                                    role.colour = tryNum;
                                                    break;
                                                }
                                            }

                                        }
                                        Console.Clear();
                                        break;

                                    default:
                                        if(display_name == null) display_name = "";
                                        if(pronouns == null) pronouns = "";
                                        if(role != null)
                                        {
                                            if(role.name == null) role.name = "forgetfull";
                                            if(role.colour == null) role.colour = "AACCEE";
                                        }
                                        return;
                                }
                                break;
                        }
                    }
                }
                public class Role 
                {
                    public long role{get;set;}
                    public string name{get;set;}
                    public string colour{get;set;}
                    public Role(long id)
                    {
                        role = id;
                    }
                }
            }
        }
    }
}