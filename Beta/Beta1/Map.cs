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
        Room?[,] rooms = new Room?[50,50];
        Random rand = new Random();
        public Map()
        {
            for(int i = 0; i < 50; i++)
            {
                for(int j = 0; j < 50; j++)
                {
                    rooms[i, j] = null;
                }      
            }
            List<Vector> vectors = new List<Vector>();
            int x = rand.Next(50);
            int y = 0;
            int scource;
            rooms[x, y] = new Room();
            vectors.Add(new Vector(x, y));
            while(vectors.Count < 1000)
            {
                scource = rand.Next(vectors.Count);
                x = vectors[scource].x;
                y = vectors[scource].y;
                switch(rand.Next(4))
                {
                    case 0:
                        if(x!=49) x++;
                        break;
                    case 1:
                        if(x!=0) x--;
                        break;
                    case 2:
                        if(y!=49) y++;
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
                }
                else Console.WriteLine("err");
            }
            for(int i = 0; i < 50; i++)
            {
                for(int j = 0; j < 50; j++)
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