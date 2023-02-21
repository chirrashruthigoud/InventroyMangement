namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\Admin\\source\\repos\\214\\InventoryMangement\\InventoryMangement\\inventory.json";
            FetchInvertory fetchInvertory = new FetchInvertory();

            InventoryDetails data = fetchInvertory.Read(path);
           

                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
        }   
    }
}
