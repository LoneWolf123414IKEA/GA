using System.Security.AccessControl;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace V1
{
    public class Nav
    {
        public static bool contains(string input, string lim)
        {
            foreach(char i in input)
            {
                if(!lim.Contains(i)) return false;
            }
            return true;
        }
        public static List<string>? setvar(List<string> strings, string lim, int low = 0, int high = int.MaxValue)
        {
            int count;
            int pos = 1;
            string testvalue;
            Console.Clear();
            while(true)
            {
                count = 0;
                foreach (string i in strings)
                {
                    Console.SetCursorPosition(3, count + 1);
                    Console.Write(i);
                    count++;
                }
                Console.SetCursorPosition(3, count+1);
                Console.Write("new");
                Console.SetCursorPosition(3, count+2);
                Console.Write("return");
                Console.SetCursorPosition(1, pos);
                Console.Write('>');




                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        if(strings.Count == 0) return null;
                        return strings;
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
                        if (pos != count+2)
                        {
                            Console.SetCursorPosition(1, pos);
                            Console.Write(' ');
                            pos++;
                            Console.SetCursorPosition(1, pos);
                            Console.Write('>');
                        }
                        break;
                    case ConsoleKey.Enter:
                    {
                        if(pos <= count)
                        { 
                            testvalue = strings[pos-1];
                            while(true)
                            {
                                Console.SetCursorPosition(3, pos);
                                for(int i = testvalue.Length; i > 0; i--)
                                {
                                    Console.Write(" ");
                                }
                                Console.SetCursorPosition(3, pos);
                                testvalue = Console.ReadLine();
                                if(testvalue.Length <= high && testvalue.Length >= low && contains(testvalue, lim))
                                {
                                    strings[pos-1] = testvalue;
                                    break;
                                }

                            }
                        }
                        if(pos == count + 1)
                        {
                            testvalue = "new";
                            while(true)
                            {
                                Console.SetCursorPosition(3, pos);
                                for(int i = testvalue.Length; i > 0; i--)
                                {
                                    Console.Write(" ");
                                }
                                Console.SetCursorPosition(3, pos);
                                testvalue = Console.ReadLine();
                                if(testvalue.Length <= high && testvalue.Length >= low && contains(testvalue, lim))
                                {
                                    strings.Add(testvalue);
                                    break;
                                }

                            }
                            
                        }
                        else if(strings.Count == 0) return null;
                        else return strings;
                        Console.Clear();
                        break;
                        
                    }
                    case ConsoleKey.Backspace:
                    case ConsoleKey.Delete:
                    {
                        if(pos <= count) strings.RemoveAt(pos-1);
                        Console.Clear();
                        break;
                    }
                }
            }
        }
        public static List<string>? setvar(List<string> strings, int low = 0, int high = int.MaxValue, bool editor = false)
        {
            Console.Clear();
            ConsoleKeyInfo key;
            int count;
            int pos = 1;
            string testvalue;
            while(true)
            {
                count = 0;
                foreach (string i in strings)
                {
                    Console.SetCursorPosition(3, count + 1);
                    Console.Write(i.Replace("\n", "\\n"));
                    count++;
                }
                Console.SetCursorPosition(3, count+1);
                Console.Write("new");
                Console.SetCursorPosition(3, count+2);
                Console.Write("return");
                Console.SetCursorPosition(1, pos);
                Console.Write('>');




                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        if(strings.Count == 0) return null;
                        return strings;
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
                        if (pos != count+2)
                        {
                            Console.SetCursorPosition(1, pos);
                            Console.Write(' ');
                            pos++;
                            Console.SetCursorPosition(1, pos);
                            Console.Write('>');
                        }
                        break;
                    case ConsoleKey.Enter:
                    {
                        if(pos <= count && !editor)
                        { 
                            testvalue = strings[pos-1];
                            while(true)
                            {
                                Console.SetCursorPosition(3, pos);
                                for(int i = testvalue.Length; i > 0; i--)
                                {
                                    Console.Write(" ");
                                }
                                Console.SetCursorPosition(3, pos);
                                testvalue = Console.ReadLine();
                                if(testvalue.Length <= high && testvalue.Length >= low)
                                {
                                    strings[pos-1] = testvalue;
                                    break;
                                }

                            }
                        }
                        else if(pos == count + 1 && !editor)
                        {
                            testvalue = "new";
                            while(true)
                            {
                                Console.SetCursorPosition(3, pos);
                                for(int i = testvalue.Length; i > 0; i--)
                                {
                                    Console.Write(" ");
                                }
                                Console.SetCursorPosition(3, pos);
                                testvalue = Console.ReadLine();
                                if(testvalue.Length <= high && testvalue.Length >= low)
                                {
                                    strings.Add(testvalue);
                                    break;
                                }

                            }
                            
                        }
                        else if(pos <= count && editor)
                        { 
                            testvalue = strings[pos-1];
                            while(true)
                            {
                                Console.SetCursorPosition(3, 1);
                                Console.Clear();
                                while(true)
                                {
                                    Console.SetCursorPosition(Console.WindowWidth-3, Console.WindowHeight-1);
                                    Console.Write(testvalue.Length);
                                    Console.SetCursorPosition(0, 1);
                                    Console.Write(testvalue);
                                    key = Console.ReadKey(true);
                                    if((key.Modifiers == ConsoleModifiers.Shift) && (key.Key == ConsoleKey.Enter)) break;
                                    else if(key.Key == ConsoleKey.Backspace && testvalue.Length > 0) 
                                    {
                                        testvalue = testvalue.Remove(testvalue.Length - 1);
                                        Console.Clear();
                                    } 
                                    else if(testvalue.Length >= 190);
                                    else if(key.Key == ConsoleKey.Enter) testvalue += "\n";
                                    
                                    else testvalue = testvalue + key.KeyChar.ToString();
                                }
                                if(testvalue.Length <= high && testvalue.Length >= low)
                                {
                                    strings[pos-1] = testvalue;
                                    break;
                                }

                            }
                        }
                        else if(pos == count + 1 && editor)
                        {
                            testvalue = "";
                            while(true)
                            {
                                Console.SetCursorPosition(3, 1);
                                Console.Clear();
                                while(true)
                                {
                                    Console.SetCursorPosition(Console.WindowWidth-3, Console.WindowHeight-1);
                                    Console.Write(testvalue.Length);
                                    Console.SetCursorPosition(0, 1);
                                    Console.Write(testvalue);
                                    key = Console.ReadKey(true);
                                    if((key.Modifiers == ConsoleModifiers.Shift) && (key.Key == ConsoleKey.Enter)) break;
                                    else if(key.Key == ConsoleKey.Backspace && testvalue.Length > 0) 
                                    {
                                        testvalue = testvalue.Remove(testvalue.Length - 1);
                                        Console.Clear();
                                    } 
                                    else if(testvalue.Length >= 190);
                                    else if(key.Key == ConsoleKey.Enter) testvalue += "\n";
                                    
                                    else testvalue = testvalue + key.KeyChar.ToString();
                                }
                                if(testvalue.Length <= high && testvalue.Length >= low)
                                {
                                    strings.Add(testvalue);
                                    break;
                                }

                            }
                            
                        }
                        else if(strings.Count == 0) return null;
                        else return strings;
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.Backspace:
                    case ConsoleKey.Delete:
                    {
                        if(pos <= count) strings.RemoveAt(pos-1);
                        Console.Clear();
                        break;
                    }
                }
            }
        }
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
                switch (Console.ReadKey(true).Key)
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
                                Config.Member.Members(true);
                                break;
                            case 4:
                                Config.Member.Members(false);
                                break;
                            default: 
                                Console.Clear();
                                return;
                        }
                        break;
                }
            }
        }
        public static readonly int[] exitErrors = 
        {
            0000,
            0042
        };
        public static readonly string[] ints =
        {   
           "0011100200111002010111020101110211001112110011121100011211000112110011121100111211010112110101121110011211100112110001121100011211100112111001120111010201110102001110020011100",
           "0000100200001002000110020001100200111002001110020001100200011002000110020001100200011002000110020001100200011002000110020001100200011002000110020001100200011002001111020011110"
        };
        public static void Err(string code)
        {
            Console.Clear();
            Console.SetCursorPosition(6,0);
            foreach (char i in code)
            {
                switch (i)
                {
                    case '0':
                        foreach (char c in ints[0])
                        {
                            if (c == '0') Console.Write("    ");
                            else if (c == '1') Console.Write("[][]");
                            else Console.SetCursorPosition(Console.CursorLeft - 28, Console.CursorTop+1);
                        }
                        break;
                    case '1':
                        foreach (char c in ints[1])
                        {
                            if (c == '0') Console.Write("    ");
                            else if (c == '1') Console.Write("[][]");
                            else Console.SetCursorPosition(Console.CursorLeft - 28, Console.CursorTop+1);
                        }
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                }
                if (Console.cursorleft <  147) Console.SetCursorPosition(Console.CursorLeft + 12, 0);
            }
            Console.Read();
            return;
        }
    }
}