using System;

namespace PriceList
{
    class Program
    {
        static void Main()
        {
            List<BaseDataStorageDevice> device = new();
            device.Add(new FlashMemory("A"));
            device.Add(new HDD("B"));
            device.Add(new DVD("C"));
            device.Add(new FlashMemory("D"));
            device.Add(new HDD("E"));

            for (int i = 0; i < device.Count; i++)
            {

            }

            device.Print();
        }
    }
}