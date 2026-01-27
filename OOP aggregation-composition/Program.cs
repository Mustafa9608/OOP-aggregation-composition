namespace OOP_aggregation_composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room Room1 = new Room(22, 44, 21, "Break Room");
            Console.WriteLine(Room1.GetArea());
            Console.WriteLine(Room1.GetVolume());
        }
    }

    class Room
    {
        private double width, length, height;
        private string Type;

        public Room(double width, double length, double height, string type) // Constructor must have the datatype before variable
        {
            this.width = width;
            this.length = length;
            this.height = height;
            this.Type = type;


        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetVolume()
        {
            return width * length * height;

        }


    }

    class resident
    {
        private string name, type;

        public resident(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string GetName()
        {
            return name;
        }

        public string GetType()
        {
            return type;
        }

    }
    class building
    {
        protected List<Room> rooms;
        protected List<resident> residents;

        public building(int numRooms)
        {
            rooms = new List<Room>();                   //always create within a constructor
            residents = new List<resident>();
            for (int i = 0; i < numRooms; i++)
            {
                double width, height, length;
                string type;
                Console.WriteLine("Enter room width");
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter room length");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter room height");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter room type");
                type = Console.ReadLine();
                Room room = new Room(width, height, length, type); // composition - room cannot exist outside of building
                rooms.Add(room);


            }
        }
    }
}
