using system;
namespace ver1
{
    public class FloorRoom
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
    public class Floor
    {
        private list<FloorRoom> flRooms = new list<FloorRoom>();
        private Room[,] rooms;
        Random rand = new Random();
        public void Floor(int a)
        {
            if (a < 1) a = 2;
            a = Math.Pow(2, a);
            rooms = new Room[a, a];
            int maxSize = (a*a/2)
            int x = rand.Next(a);
            int y = 0;
            int scource;
            rooms[x, y]("start");
            flRooms.Add(new FloorRoom(x, y));
            while(flRooms.length < maxsize)
            {
                scource = rand.Next(flRooms.length);
                x = flRooms[scource].x
                y = flRooms[scource].y
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
                if(object.Equals(rooms[x, y], mull))
                {
                    rooms[x, y] = new Room(0);
                }
            }
            for(int i; i < a; i++)
            {
                for(int j; j < a; j++)
                {
                    if(object.Equals(rooms[x, y], mull))
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
    }
}