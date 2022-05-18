using System;

namespace PriceList
{
    public static class ListExtensions
    {
        public static void Print(this List<BaseDataStorageDevice> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("=================================");
                Console.WriteLine(list[i] + "\n");
                list[i].Print();
                Console.WriteLine("=================================\n");
            }
        }
    }
}