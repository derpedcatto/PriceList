using System;

namespace PriceList
{
    class FlashMemory : BaseDataStorageDevice
    {
        public int capacity { get; set; }
        public double speed { get; set; }
        public new string path = @"C:\temp\FlashMemoryDataStorage.txt";

        public FlashMemory() : base()
        {
            this.capacity = 64;
            this.speed = 1.4;
        }
        public FlashMemory(string name) : base()
        {
            this.name = name;
            this.capacity = 32;
            this.speed = 1.0;
        }
        public FlashMemory(string name, string manufacturer, string model) : base()
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.model = model;
            this.capacity = 32;
            this.speed = 1.0;
        }
        public FlashMemory(string name, string manufacturer, string model, int amount, int price, int capacity, double speed) 
                           : base (name, manufacturer, model, amount, price)
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
                Console.WriteLine("FlashMemoryDataStorage.txt does not exist in this path!");
            }
        }
        public override void Save()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("FlashMemoryDataStorageText ");
                }
            }
            else
            {
                File.AppendAllText(path, "FlashMemoryDataStorageText ");
            }
        }
    }
}
