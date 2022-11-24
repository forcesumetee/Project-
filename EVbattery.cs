class EVbattery
{
        public static void Main (string[] args)
        {
            Console.WriteLine("Car Spec: 1 MG EP , 2 MG ZS , 3 Nissan Leaf , 4 Audi e-Tron ");
            Console.WriteLine("Input Car:");
            double Point = double.Parse(Console.ReadLine());

            if(Point == 1)
            {
                Console.WriteLine("Car: ME EP");
                Console.WriteLine("Battery: 50.3 kWh");
                Console.WriteLine("Time: 40 MIN");
                Console.WriteLine("Full Charge Price:211.26 Bath");

            }
            if(Point == 2)
            {
                Console.WriteLine("Car: ME ZS");
                Console.WriteLine("Battery: 44.5 kWh");
                Console.WriteLine("Time: 30 MIN");
                Console.WriteLine("Full Charge Price:186.9 Bath");
            }

            if(Point == 3)
            {
                Console.WriteLine("Car: Nissan Leaf");
                Console.WriteLine("Battery: 40 kWh");
                Console.WriteLine("Time: 30 MIN");
                Console.WriteLine("Full Charge Price:=168 Bath");
            }
            if(Point == 4)
            {
                Console.WriteLine("Car: Audi e-Tron");
                Console.WriteLine("Battery: 95 kWh");
                Console.WriteLine("Time: 30 MIN");
                Console.WriteLine("Full Charge Price:=400 Bath");
            }
        }

}