using System;

namespace PriceList
{
    class DVD : BaseDataStorageDevice
    {
        public double readspeed { get; set; }
        public double writespeed { get; set; }
        public new string path = @"C:\temp\DVDDataStorage.txt";

        public DVD() : base()
        {
            this.readspeed = 1.3;
            this.writespeed = 1.3;
        }
        public DVD(string name) : base()
        {
            this.name = name;
            this.readspeed = 2.3;
            this.writespeed = 2.3;
        }
        public DVD(string name, string manufacturer, string model) : base()
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.model = model;
            this.readspeed = 5.4;
            this.writespeed = 5.4;
        }
        public DVD(string name, string manufacturer, string model, int amount, int price, double readspeed, double writespeed)
                           : base(name, manufacturer, model, amount, price)
        {
            this.readspeed = readspeed;
            this.writespeed = writespeed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Read speed: " + readspeed);
            Console.WriteLine("Write speed: " + writespeed);
        }
        public override void Load()
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("DVDDataStorage.txt does not exist in this path!");
            }
        }
        public override void Save()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("DVDDataStorageText ");
                }
            }
            else
            {
                File.AppendAllText(path, "DVDDataStorageText ");
            }
        }
    }
}
