
namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\Admin\\source\\repos\\214\\InventoryMangement\\InventoryMangement\\inventory.json";
            FetchInvertory fetchInvertory = new FetchInvertory();

            InventoryDetails data = fetchInvertory.Read(path);
            for (int i = 0; i < data.typesofstock.Count; i++)
            {
                Console.WriteLine(data.typesofstock[i].stockname);
                Console.WriteLine(data.typesofstock[i].shareprice);
                Console.WriteLine(data.typesofstock[i].numberofshare);
            }

        }
    }
}