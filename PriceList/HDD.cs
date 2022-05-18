using System;

namespace PriceList
{
    class HDD : BaseDataStorageDevice
    {
        public int capacity { get; set; }
        public double speed { get; set; }
        public new string path = @"C:\temp\HDDDataStorage.txt";

        public HDD() : base()
        {
            this.capacity = 500;
            this.speed = 80;
        }
        public HDD(string name) : base()
        {
            this.name = name;
            this.capacity = 2000;
            this.speed = 130;
        }
        public HDD(string name, string manufacturer, string model) : base()
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.model = model;
            this.capacity = 800;
            this.speed = 60;
        }
        public HDD(string name, string manufacturer, string model, int amount, int price, int capacity, double speed)
                           : base(name, manufacturer, model, amount, price)
        {
            this.capacity = capacity;
            this.speed = speed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Capacity: " + capacity);
            Console.WriteLine("Speed: " + speed);
        }
        public override void Load()
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("HDDDataStorage.txt does not exist in this path!");
            }
        }
        public override void Save()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("HDDDataStorageText ");
                }
            }
            else
            {
                File.AppendAllText(path, "HDDDataStorageText ");
            }
        }
    }
}
