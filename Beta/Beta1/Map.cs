namespace Beta1
{
    public class Vector
    {
        private int x
        {
            get
            {
                return x;
            }
        }
        private int y
        {
            get
            {
                return y;
            }
        }
        public void FloorRoom(int a, int b)
        {
            x = a;
            y = b;
        }
    }
    
    public class Map
    {
        Room?[,] rooms = new Room?[5,5];
        Random rand = new Random();
        public Map()
        {
            List<Vector> vectors = new List<Vector>();
            int x = rand.Next(5);
            int y = 0;
            int scource;
            rooms[x, y] = new Room();
            vectors.Add(new Vector(x, y));
            while(vectors.length < maxsize)
            {
                scource = rand.Next(flRooms.length);
                x = vectors[scource].getx;
                y = vectors[scource].gety;
                switch(rand.Next(4))
                {
                    case 0:
                        if(x!=a-1) x++;
                        break;
                    case 1:
                        if(x!=0) x--;
                        break;
                    case 2:
                        if(y!=a-1) y++;
                        break;
                    case 3:
                        if(y!=0) y--;
                        break;
                }
                if(object.Equals(rooms[x, y], null))
                {
                    rooms[x, y] = new Room(0);
                }
            }
            for(int i; i < 5; i++)
            {
                for(int j; j < 5; j++)
                {
                    if(object.Equals(rooms[x, y], null))
                    {
                        Console.Write("y");
                    }
                    else
                    {
                        Console.Write("n");
                    }
                }

                    
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