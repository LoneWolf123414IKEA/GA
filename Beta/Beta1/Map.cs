namespace Beta1
{
    public class Vector
    {
        public int x;
        public int y;
        public Vector(int a, int b)
        {
            x = a;
            y = b;
        }
    }
    
    public class Map
    {
        Room?[,] rooms = new Room?[8,8];
        Random rand = new Random();
        public Map()
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    rooms[i, j] = null;
                }      
            }
            List<Vector> vectors = new List<Vector>();
            int x = rand.Next(8);
            int y = 0;
            int scource;
            rooms[x, y] = new Room();
            vectors.Add(new Vector(x, y));
            int err = 0;
            
            while(vectors.Count < 30)
            {
                if (vectors.Count < 3) scource = rand.Next(vectors.Count);
                else scource = rand.Next(((int)Math.Floor(vectors.Count * 0.9)),vectors.Count);
                x = vectors[scource].x;
                y = vectors[scource].y;
                switch(rand.Next(4))
                {
                    case 0:
                        if(x!=7) x++;
                        break;
                    case 1:
                        if(x!=0) x--;
                        break;
                    case 2:
                        if(y!=7) y++;
                        break;
                    case 3:
                        if(y!=0) y--;
                        break;
                }
                if(object.Equals(rooms[x, y], null))
                {
                    rooms[x, y] = new Room();
                    vectors.Add(new Vector(x, y));
                    Console.WriteLine("room generated");
                    err = 0;
                }
                else 
                {
                    err++;
                }
                if(err>100)
                {
                    for(int i = 0; i < 8; i++)
                    {
                        for(int j = 0; j < 8; j++)
                        {
                            rooms[i, j] = null;
                        }      
                    }
                    vectors = new List<Vector>();
                    x = rand.Next(8);
                    y = 0;
                    rooms[x, y] = new Room();
                    vectors.Add(new Vector(x, y));
                    err = 0;
                    Console.Clear();
                    Console.WriteLine("Error, Loop encouterd, restarting generation");
                }
            }
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(object.Equals(rooms[i, j], null))
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                } 
                Console.Write("\n");
            }
        }
        public class Room
        {
            Cell[,] cells = new Cell[5,5];

            public class Cell
            {

            }
            public class Enemy
            {

            }
        }
    }
}