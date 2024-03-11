using System;

    public class Robot
    {
        private Tuple<int, int> coordinates;
        private string name;
        private string direction { get; set; }

        public Robot(int x, int y, string name, string direction) //конструктор класса робот
        {
            coordinates = new Tuple<int, int>(x, y);
            this.name = name;
            this.direction = direction;
        }

        public void Move()
        {
            Random rand = new Random();
            int movement = rand.Next(0, 4);

            switch (movement)
            {                
                case 0:
                    coordinates = new Tuple<int, int>(coordinates.Item1, coordinates.Item2 + 1); //Вперед
                    direction = "Вперед";
                    Console.WriteLine(GetInfo());
                    break;
                case 1:
                    coordinates = new Tuple<int, int>(coordinates.Item1, coordinates.Item2 - 1); //Назад
                    direction = "Назад";
                    Console.WriteLine(GetInfo());
                    break;
                case 2:
                    coordinates = new Tuple<int, int>(coordinates.Item1 + 1, coordinates.Item2); //Направо
                    direction = "Направо";
                    Console.WriteLine(GetInfo());
                    break;
                case 3:
                    coordinates = new Tuple<int, int>(coordinates.Item1 - 1, coordinates.Item2); //Налево
                    direction = "Налево";
                    Console.WriteLine(GetInfo());
                    break;
                default:
                    break;
            }
        }
        public string GetInfo()
        {
            return $"{name} {direction} ({coordinates.Item1}, {coordinates.Item2})";
        }
    }