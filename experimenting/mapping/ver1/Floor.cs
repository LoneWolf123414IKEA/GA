using System;
namespace ver1
{
    public class FloorRoom
    {
        public int x
        {
            get;set;
        }
        public int y
        {
            get;set;
        }
        public FloorRoom(int a, int b)
        {
            x = a;
            y = b;
        }
    }
    public class Floor
    {
        private List<FloorRoom> flRooms = new List<FloorRoom>();
        private Room[,] rooms;
        Random rand = new Random();
        public Floor(int a)
        {
            if (a < 2) a = 2;
            a = 5;
            rooms = new Room[a, a];
            int maxSize = (a*a/2);
            int x = rand.Next(a);
            int y = 0;
            int scource;
            rooms[x, y] = new Room();
            flRooms.Add(new FloorRoom(x, y));
            while(flRooms.Count < maxSize)
            {
                scource = rand.Next(flRooms.Count);
                x = flRooms[scource].x;
                y = flRooms[scource].y;
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
                    rooms[x, y] = new Room();
                }
            }
            for(int i; i < a; i++)
            {
                for(int j; j < a; j++)
                {
                    if(object.Equals(rooms[i, j], null))
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