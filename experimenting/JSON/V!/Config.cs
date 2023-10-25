using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;
namespace V1

{
    public class Config
    {
        public int version{get;set;} = 2;
        public string? token{get; set;}
        public string? identity{get;set;}
        public string? bot_ip{get;set;}
        public int? bot_port{get;set;}
        public long? owner{get;set;}
        public string? owner_name{get;set;}
        public int? cooldown_period{get;set;}
        public Default defaul{get;set;} = new();
        public Dictionary<string, Member?>? members{get;set;} = new Dictionary<string, Member?>();
        public Dictionary<string, Member?>? additional_profiles{get;set;} = new Dictionary<string, Member?>();

        public void editConfig()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Nav.Arrow(1);
            int pos = 1;
            string tryNum;
            while (true)
            {
                Console.CursorVisible = false;

                Nav.NotNull(3, 1, token, "Token:");
                Nav.NotNull(3, 2, bot_ip, "IP (you shuld never have to change this):");
                Nav.NotNull(3, 3, bot_port, "Port (you shuld never have to change this):");
                Nav.NotNull(3, 4, owner, "Account ID:");
                Nav.NotNull(3, 5, owner_name, "System Name:");
                Nav.NotNull(3, 6, cooldown_period, "Default time(min):");
                Nav.NotNull(3, 7, "", "return to menu");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        Console.Clear();
                        return;
                    case ConsoleKey.UpArrow:
                        Nav.ArrowUp(ref pos, 1);
                        break;
                    case ConsoleKey.DownArrow:
                        Nav.ArrowDown(ref pos, 7);
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
                Nav.Promt(3, 1, "Usn(2-32)");
                Nav.Promt(3, 2, "Pfp url");
                Nav.Promt(3, 3, "Banner colour(currently only hex)");
                Nav.Promt(3, 4, "Bio(190)");
                Nav.Promt(3, 5, "Pronouns(40)");
                Nav.Promt(3, 6, "Servers");
                Nav.Promt(3, 7, "return to menu");


                Nav.Arrow(pos);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        Console.Clear();
                        return;
                    case ConsoleKey.UpArrow:
                        Nav.ArrowUp(ref pos, 1);
                        break;
                    case ConsoleKey.DownArrow:
                        Nav.ArrowDown(ref pos, 7);
                        break;
                    case ConsoleKey.Enter:
                        switch (pos)
                        {
                            case 1:
                                if(defaul.display_name == null)
                                {
                                    defaul.display_name = new List<string>();
                                }
                                Console.CursorVisible = true;
                                defaul.display_name = Nav.setvar(defaul.display_name, 2, 32);
                                break;
                            case 2:
                                if(defaul.avatar == null)
                                {
                                    defaul.avatar = new List<string>();
                                }
                                Console.CursorVisible = true;
                                defaul.avatar = Nav.setvar(defaul.avatar);
                                break;
                            case 3:
                                if(defaul.banner_colour == null)
                                {
                                    defaul.banner_colour = new List<string>();
                                }
                                Console.CursorVisible = true;
                                defaul.banner_colour = Nav.setvar(defaul.banner_colour,"1234567890abcdefABCDEF", 6, 6);
                                break;
                            case 4:
                                if(defaul.bio == null)
                                {
                                    defaul.bio = new List<string>();
                                }
                                Console.CursorVisible = true;
                                defaul.bio = Nav.setvar(defaul.bio,0,190,true);
                                break;
                            case 5:
                                if(defaul.pronouns == null)
                                {
                                    defaul.pronouns = new List<string>();
                                }
                                Console.CursorVisible = true;
                                defaul.pronouns = Nav.setvar(defaul.pronouns,0,40);
                                break;
                            case 6:
                                defaul.servers();
                                break;
                            default:
                                Console.Clear();
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
            token = "RENAME THIS";
            bot_ip = "154.62.109.142";
            bot_port = 6893;
            identity = "RENAME THIS";
            owner = 1234;
            owner_name = "RENAME THIS AND ANY 1234";
            cooldown_period = 60;
        }
        public class Member : Default
        {
            public static void Members(bool mem)
            {
                Console.Clear();
                int pos = 1;
                int count;
                while(true)
                {
                    count = 1;
                    Console.CursorVisible = false;
                    if(mem)
                    {
                        foreach(string i in Program.config.members.Keys)
                        {
                            Console.SetCursorPosition(3, count);
                            Console.Write(i);
                            count++;
                        }
                    }
                    else
                    {
                        foreach(string i in Program.config.additional_profiles.Keys)
                        {
                            Console.SetCursorPosition(3, count);
                            Console.Write(i);
                            count++;
                        }
                        
                    }

                    Nav.Promt(3, count, "New");
                    Nav.Promt(3, count + 1, "Return");
                    Nav.Arrow(pos);


                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape:
                            return;
                        case ConsoleKey.UpArrow:
                            Nav.ArrowUp(ref pos, 1);
                            break;
                        case ConsoleKey.DownArrow:
                            Nav.ArrowDown(ref pos, count + 1);
                            break;
                        case ConsoleKey.Enter:
                            if (pos == count)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(1, 1);
                                Console.Write("please input profile name:");
                                Console.SetCursorPosition(1, 2);
                                if(mem)
                                {
                                    Program.config.members.Add(Console.ReadLine(), new Member());
                                }
                                else
                                {
                                    Program.config.additional_profiles.Add(Console.ReadLine(), new Member());
                                }
                            }
                            else if(pos == count+1) return;
                            else if(mem)
                            {
                                Program.config.members.Values.ElementAt(pos-1).editMember();
                            }
                            else
                            {
                                Program.config.additional_profiles.Values.ElementAt(pos-1).editMember();
                            }
                            Console.Clear();
                            Nav.Arrow(pos);
                            break;
                    }
                }
                
            }
            public void editMember()
            {

                string tryNum;
                int num;
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

                    Nav.Promt(3, 1, "Usn(2-32):");


                    Nav.Arrow(pos);

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape:
                            Console.Clear();
                            return;
                        case ConsoleKey.UpArrow:
                            Nav.ArrowUp(ref pos, 1);
                            break;
                        case ConsoleKey.DownArrow:
                            Nav.ArrowDown(ref pos, 7);
                            break;
                        case ConsoleKey.Enter:
                            switch (pos)
                            {
                            case 1:
                                if(display_name == null)
                                {
                                    display_name = new List<string>();
                                }
                                Console.CursorVisible = true;
                                display_name = Nav.setvar(display_name, 2, 32);
                                break;
                            case 2:
                                if(avatar == null)
                                {
                                    avatar = new List<string>();
                                }
                                Console.CursorVisible = true;
                                avatar = Nav.setvar(avatar);
                                break;
                            case 3:
                                if(banner_colour == null)
                                {
                                    banner_colour = new List<string>();
                                }
                                Console.CursorVisible = true;
                                banner_colour = Nav.setvar(banner_colour,"1234567890abcdefABCDEF", 6, 6);
                                break;
                            case 4:
                                if(bio == null)
                                {
                                    bio = new List<string>();
                                }
                                Console.CursorVisible = true;
                                bio = Nav.setvar(bio,0,190,true);
                                break;
                            case 5:
                                if(pronouns == null)
                                {
                                    pronouns = new List<string>();
                                }
                                Console.CursorVisible = true;
                                pronouns = Nav.setvar(pronouns,0,40);
                                break;
                                case 6:
                                    servers();
                                    break;
                                default:
                                    Console.Clear();
                                    return;
                            }
                            Console.Clear();
                            break;
                    }
                }
            }
            public Member()
            {
            }

        }
        public class Default
        {
            public List<string>? display_name{get;set;} = null;
            public List<string>? avatar{get;set;} = null;
            public List<string>? banner_colour{get;set;} = null;
            public List<string>? bio{get;set;} = null;
            public List<string>? pronouns{get;set;} = null;
            public Dictionary<long, Guild> guild_overrides{get;set;} = new Dictionary<long, Guild>();
            public void servers()
            {
                Console.Clear();
                int pos = 1;
                int count;
                while(true)
                {
                    count = 1;
                    Console.CursorVisible = false;
                    foreach(long i in guild_overrides.Keys)
                    {
                        Console.SetCursorPosition(3, count);
                        Console.Write(i);
                        count++;
                    }
                    Console.SetCursorPosition(3, count);
                    Console.Write("New");
                    Console.SetCursorPosition(3, count+1);
                    Console.Write("Return");
                    Nav.Arrow(pos);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape:
                            return;
                        case ConsoleKey.UpArrow:
                            Nav.ArrowUp(ref pos, 1);
                            break;
                        case ConsoleKey.DownArrow:
                            Nav.ArrowDown(ref pos, count + 1);
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
                                        
                                        guild_overrides.Add(long.Parse(Console.ReadLine()), new Guild());
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
                                guild_overrides.Values.ElementAt(pos-1).setGuild();
                            }
                            Console.Clear();
                            Nav.Arrow(pos);
                            break;
                    }
                }
                
            }


            public class Guild
            {
                public Dictionary<long, Role> roles{get;set;} = new Dictionary<long, Role>();
                public string? display_name{get;set;}
                public string? pronouns{get;set;}
                
                public Settings settings{get;set;} = new Settings();
                public Guild()
                {
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
                        Console.Write("Settongs");
                        Console.SetCursorPosition(3, 5);
                        Console.Write("return to menu");


                        Console.SetCursorPosition(17,1);
                        if(display_name != null) Console.Write(display_name);
                        Console.SetCursorPosition(17,2);
                        if(pronouns != null) Console.Write(pronouns);
                        Nav.Arrow(pos);
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.Escape:
                                return;
                            case ConsoleKey.UpArrow:
                            Nav.ArrowUp(ref pos, 1);
                                break;
                            case ConsoleKey.DownArrow:
                            Nav.ArrowDown(ref pos, 4);
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
                                        if(roles.Count == 0)
                                        {
                                            Console.Clear();
                                            Console.SetCursorPosition(1,1);
                                            Console.Write("input role id: ");
                                            try
                                            {
                                                roles.Add(long.Parse(Console.ReadLine()), new Role());
                                            }
                                            catch{}
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.SetCursorPosition(1,1);
                                            Console.Write("input role name: ");
                                            roles.Values.ElementAt(0).name="";
                                            while (roles.Values.ElementAt(0).name.Length < 1) 
                                            {
                                                Console.SetCursorPosition(18, 1);
                                                roles.Values.ElementAt(0).name = Console.ReadLine();
                                            }
                                            Console.SetCursorPosition(1, 2);
                                            Console.Write("input role hex: ");
                                            while (true)
                                            {
                                                Console.SetCursorPosition(17, 2);
                                                tryNum = Console.ReadLine();
                                                if((tryNum.Length == 6 && Nav.contains(tryNum, "1234567890abcdefABCDEF")) || tryNum.Length == 0)
                                                {
                                                    roles.Values.ElementAt(0).colour = tryNum;
                                                    break;
                                                }
                                            }

                                        }
                                        Console.Clear();
                                        break;
                                    case 4:
                                        int pos2 = 1;
                                        bool done;
                                        int pos3;
                                        int count;

                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.CursorVisible = false;
                                            Console.SetCursorPosition(7, 1);
                                            Console.Write("everyone pings");
                                            Console.SetCursorPosition(7, 2);
                                            Console.Write("role pings");
                                            Console.SetCursorPosition(7, 3);
                                            Console.Write("event notifications");
                                            Console.SetCursorPosition(7, 4);
                                            Console.Write("notifications");
                                            Console.SetCursorPosition(7, 5);
                                            Console.Write("mobile push notifs");
                                            Console.SetCursorPosition(7, 6);
                                            Console.Write("muted");
                                            Console.SetCursorPosition(7, 7);
                                            Console.Write("hide muted");
                                            Console.SetCursorPosition(7, 8);
                                            Console.Write("for you notifs");
                                            Console.SetCursorPosition(3, 9);
                                            Console.Write("channels");
                                            Console.SetCursorPosition(3, 10);
                                            Console.Write("return to menu");


                                            Console.SetCursorPosition(3,1);
                                            if(settings.supress_everyone) Console.Write(" X ");
                                            else Console.Write(" O ");
                                            Console.SetCursorPosition(3,2);
                                            if(settings.supress_roles) Console.Write(" X ");
                                            else Console.Write(" O ");
                                            Console.SetCursorPosition(3,3);
                                            if(settings.mute_scheduled_events) Console.Write(" X ");
                                            else Console.Write(" O ");
                                            Console.SetCursorPosition(3,4);
                                            if(settings.message_notifications == 0) Console.Write("ALL");
                                            else if(settings.message_notifications == 1) Console.Write(" @ ");
                                            else if(settings.message_notifications == 2) Console.Write("NON");
                                            else Console.Write("ERR");
                                            Console.SetCursorPosition(3,5);
                                            if(settings.mobile_push) Console.Write(" O ");
                                            else Console.Write(" X ");
                                            Console.SetCursorPosition(3,6);
                                            if(settings.muted) Console.Write(" O ");
                                            else Console.Write(" X ");
                                            Console.SetCursorPosition(3,7);
                                            if(settings.hide_muted_channels) Console.Write(" O ");
                                            else Console.Write(" X ");
                                            Console.SetCursorPosition(3,8);
                                            if(settings.notify_highlights == 0) Console.Write(" O ");
                                            else Console.Write(" X ");
                                            Console.SetCursorPosition(1, pos2);
                                            Console.Write('>');
                                            switch (Console.ReadKey(true).Key)
                                            {
                                                case ConsoleKey.Escape:
                                                    return;
                                                case ConsoleKey.UpArrow:
                                                    Nav.ArrowUp(ref pos2, 1);
                                                    break;
                                                case ConsoleKey.DownArrow:
                                                    Nav.ArrowDown(ref pos2, 9);
                                                    break;
                                                case ConsoleKey.Enter:
                                                    switch(pos2)
                                                    {
                                                        case 1:
                                                            if(settings.supress_everyone) settings.supress_everyone = false;
                                                            else settings.supress_everyone = true;
                                                            break;
                                                        case 2:
                                                            if(settings.supress_roles) settings.supress_roles = false;
                                                            else settings.supress_roles = true;
                                                            break;
                                                        case 3:
                                                            if(settings.mute_scheduled_events) settings.mute_scheduled_events = false;
                                                            else settings.mute_scheduled_events = true;
                                                            break;
                                                        case 4:
                                                            if(settings.message_notifications == 0) settings.message_notifications = 1;
                                                            else if(settings.message_notifications == 1) settings.message_notifications = 2;
                                                            else settings.message_notifications = 0;
                                                            break;
                                                        case 5:
                                                            if(settings.mobile_push) settings.mobile_push = false;
                                                            else settings.mobile_push = true;
                                                            break;
                                                        case 6:
                                                            if(settings.muted) settings.muted = false;
                                                            else settings.muted = true;
                                                            break;
                                                        case 7:
                                                            if(settings.hide_muted_channels) settings.hide_muted_channels = false;
                                                            else settings.hide_muted_channels = true;
                                                            break;
                                                        case 8:
                                                            if(settings.notify_highlights == 1) settings.notify_highlights = 0;
                                                            else settings.notify_highlights = 1;
                                                            break;
                                                        case 9:
                                                            done = true;
                                                            pos3 = 1;
                                                            while(done)
                                                            {
                                                                count = 0;
                                                                Console.Clear();
                                                                foreach (Settings.Ovr i in settings.channel_overrides)
                                                                {
                                                                    Console.SetCursorPosition(3, count + 1);
                                                                    Console.Write(i.channel_id);
                                                                    count++;
                                                                }
                                                                Console.SetCursorPosition(3, count+1);
                                                                Console.Write("new");
                                                                Console.SetCursorPosition(3, count+2);
                                                                Console.Write("return");
                                                                Nav.Arrow(pos3);




                                                                switch (Console.ReadKey(true).Key)
                                                                {
                                                                    case ConsoleKey.Escape:
                                                                        return;
                                                                    case ConsoleKey.UpArrow:
                                                                        Nav.ArrowUp(ref pos3, 1);
                                                                        break;
                                                                    case ConsoleKey.DownArrow:
                                                                        Nav.ArrowDown(ref pos3, count + 2);
                                                                        break;
                                                                    case ConsoleKey.Enter:
                                                                    {
                                                                        if(pos3 == count+2) return;
                                                                        else if(pos3 == count+1) settings.channel_overrides.Add(Settings.Ovr.edit(null));
                                                                        else
                                                                        {
                                                                            settings.channel_overrides[pos3-1] = Settings.Ovr.edit(settings.channel_overrides[pos3-1].channel_id);
                                                                        }
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        default:
                                                            
                                                            break;
                                                    }
                                                    break;
                                            }
                                        }
                                    default:
                                        if(display_name == null) display_name = "";
                                        if(pronouns == null) pronouns = "";
                                        if(roles.Count != 0)
                                        {
                                            if(roles.Values.ElementAt(0).name == null) roles.Values.ElementAt(0).name = "forgetfull";
                                            if(roles.Values.ElementAt(0).colour == null) roles.Values.ElementAt(0).colour = "AACCEE";
                                        }
                                        return;
                                }
                                break;
                        }
                    }
                }
                public class Settings
                {
                    public bool supress_everyone{get;set;}
                    public bool supress_roles{get;set;}
                    public bool mute_scheduled_events{get;set;}
                    public int message_notifications{get;set;}
                    public int flags{get;set;}
                    public bool mobile_push{get;set;}
                    public bool muted{get;set;}
                    public string? mute_config{get;set;}
                    public bool hide_muted_channels{get;set;}
                    public List<Ovr> channel_overrides{get;set;} = new List<Ovr>();
                    public int notify_highlights{get;set;}
                    public Settings()
                    {
                        supress_everyone = false;
                        supress_roles = false;
                        mute_scheduled_events = false;
                        message_notifications = 0;
                        flags = 0;
                        mobile_push = true;
                        muted = false;
                        mute_config = null;
                        hide_muted_channels = true;
                        notify_highlights = 0;
                    }
                    public class Ovr
                    {
                        public long channel_id{get;set;}
                        public bool collapsed{get;set;}
                        public int message_notifications{get;set;}
                        public string? mute_config{get;set;}
                        public bool muted{get;set;}
                        public Ovr(long id)
                        {
                            channel_id = id;
                            collapsed = false;
                            message_notifications = 0;
                            mute_config = null;
                            muted = false;
                        }
                        public static Ovr edit(long? n)
                        {
                            if(n == null)
                            {
                                while(n == null)
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition(1, 1);
                                        Console.Write("input ID;");
                                        Console.SetCursorPosition(1, 2);
                                        n = long.Parse(Console.ReadLine());
                                    }
                                    catch{}
                                }
                                return new Ovr(long.Parse(n.ToString()));
                            }
                            Ovr ret = new Ovr(long.Parse(n.ToString()));


                            int pos2 = 1;
                            while (true)
                            {
                                Console.Clear();
                                Console.CursorVisible = false;
                                Console.SetCursorPosition(7, 1);
                                Console.Write("collapsed");
                                Console.SetCursorPosition(7, 2);
                                Console.Write("notifs");
                                Console.SetCursorPosition(7, 3);
                                Console.Write("muted");
                                Console.SetCursorPosition(7, 4);
                                Console.Write("return");




                                Console.SetCursorPosition(3,1);
                                if(!ret.collapsed) Console.Write(" X ");
                                else Console.Write(" O ");
                                Console.SetCursorPosition(3,2);
                                if(ret.message_notifications == 0) Console.Write("ALL");
                                else if(ret.message_notifications == 1) Console.Write(" @ ");
                                else if(ret.message_notifications == 2) Console.Write("NON");
                                else Console.Write("ERR");
                                Console.SetCursorPosition(3,3);
                                if(ret.muted) Console.Write(" O ");
                                else Console.Write(" X ");
                                Nav.Arrow(pos2);




                                switch (Console.ReadKey(true).Key)
                                {
                                    case ConsoleKey.Escape:
                                        return ret;
                                    case ConsoleKey.UpArrow:
                                        Nav.ArrowUp(ref pos2, 1);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Nav.ArrowDown(ref pos2, 4);
                                        break;
                                    case ConsoleKey.Enter:
                                        switch(pos2)
                                        {
                                            case 1:
                                                if(ret.collapsed) ret.collapsed = false;
                                                else ret.collapsed = true;
                                                break;
                                            case 2:
                                                if(ret.message_notifications == 0) ret.message_notifications = 1;
                                                else if(ret.message_notifications == 1) ret.message_notifications = 2;
                                                else ret.message_notifications = 0;
                                                break;
                                            case 3:
                                                if(ret.muted) ret.muted = false;
                                                else ret.muted = true;
                                                break;
                                            default:
                                                return ret;
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
                public class Role 
                {
                    public string name{get;set;}
                    public string colour{get;set;}
                    public Role()
                    {
                    }
                }
            }
        }
    }
}