using System;

namespace PriceList
{
    public abstract class BaseDataStorageDevice
    {
        public string name { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public string path = @"C:\temp\DefaultDataStorage.txt";

        public BaseDataStorageDevice()
        {
            name = "BaseName";
            manufacturer = "BaseManufacturer";
            model = "BaseModel";
            amount = 1000;
            price = 120;
        }
        public BaseDataStorageDevice(string name)
        {
            this.name = name;
            manufacturer = "BaseManufacturer";
            model = "BaseModel";
            amount = 150;
            price = 250;
        }
        public BaseDataStorageDevice(string name, string manufacturer, string model)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.model = model;
            amount = 599;
            price = 199;
        }
        public BaseDataStorageDevice(string name, string manufacturer, string model, int amount, int price)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.model = model;
            this.amount = amount;
            this.price = price;
        }

        public virtual void Print() 
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Manufacturer: " + manufacturer);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Price: " + price);
        }
        public virtual void Load()
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("DefaultDataStorage.txt does not exist in this path!");
            }
        }
        public virtual void Save()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("DefaultDataStorageText ");
                }
            }
            else
            {
                File.AppendAllText(path, "DefaultDataStorageText ");
            }
        }
    }
}

/*
Поля: 
- имя носителя
- имя производителя
- модель
- количество
- цена

Виртуальные методы:
- печать
- загрузка из файла
- сохранения в файл.
*/