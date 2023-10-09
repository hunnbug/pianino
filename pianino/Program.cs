namespace pianino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор октавы F1 F2 F3 F4 F5\n");
            ConsoleKeyInfo key = Console.ReadKey();
            fono(octava(key));
        }
        public static int[] octava(ConsoleKeyInfo key)
        {
            int[] octava = new int[12];
            int[] numb = new int[0];

            if (key.Key == ConsoleKey.F1)
            {
                int[] oct1 = new int[12] { 37, 37, 37, 38, 41, 43, 46, 49, 51, 55, 58, 61 };
                for (int i = 0; i < oct1.Length; i++)
                {
                    octava[i] = oct1[i];
                }
                return octava;
            }
            if (key.Key == ConsoleKey.F2)
            {
                int[] oct2 = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
                for (int i = 0; i < oct2.Length; i++)
                {
                    octava[i] = oct2[i];
                }
                return octava;
            }
            if (key.Key == ConsoleKey.F3)
            {
                int[] oct3 = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                for (int i = 0; i < oct3.Length; i++)
                {
                    octava[i] = oct3[i];
                }
                return octava;
            }
            if (key.Key == ConsoleKey.F4)
            {
                int[] oct4 = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                for (int i = 0; i < oct4.Length; i++)
                {
                    octava[i] = oct4[i];
                }
                return octava;
            }
            if (key.Key == ConsoleKey.F5)
            {
                int[] oct5 = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                for (int i = 0; i < oct5.Length; i++)
                {
                    octava[i] = oct5[i];
                }
                return octava;               
            }
            return numb;
        }

        public static void fono(int[] octava)
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Q) // до
                {
                    Console.Beep(octava[0], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.D2) // до диез
                {
                    Console.Beep(octava[1], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.W) // ре
                {
                    Console.Beep(octava[2], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.D3) // ре диез
                {
                    Console.Beep(octava[3], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.E) // ми 
                {
                    Console.Beep(octava[4], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.R) // фа 
                {
                    Console.Beep(octava[5], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.D5) // фа диез
                {
                    Console.Beep(octava[6], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.T) // соль
                {
                    Console.Beep(octava[7], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.D6) // соль диез
                {
                    Console.Beep(octava[8], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.Y) // ля 
                {
                    Console.Beep(octava[9], 100);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.D7) // ля диез
                {
                    Console.Beep(octava[10], 10);
                    Console.Clear();
                }

                if (key.Key == ConsoleKey.U) // си
                {
                    Console.Beep(octava[11], 10);
                    Console.Clear();
                }
            }
        }
    }
}