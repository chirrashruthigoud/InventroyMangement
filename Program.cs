
namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\Admin\\source\\repos\\214\\InventoryMangement\\InventoryMangement\\inventory.json";
            FetchInvertory fetchInvertory = new FetchInvertory();

            InventoryDetails data = fetchInvertory.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
            }
        }
    }
}
