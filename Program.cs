using System.Runtime.CompilerServices;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> notebookList = new List<Product>();

            while (true)
            {
                Console.WriteLine("Zehmet olmasa notebook qeyd edin:");
                Console.Write("Marka: ");
                string brand = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("RAM (0-128 arası): ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yaddas (0 ve usdu): ");
                int storage = Convert.ToInt32(Console.ReadLine());
                Console.Write("miqdari: ");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qiymet (0 ve usdu): ");
                double price = Convert.ToDouble(Console.ReadLine());
                if
                {
                    Notebook notebook = new Notebook(brand, model, ram, storage, count, price);
                    notebooks.Add(notebook);
                    Console.WriteLine("Notebook sisteme elave olundu.");
                }
                else 
                {
                    Console.WriteLine("xeta: " + );
                }
            }

            Console.WriteLine("Sistemde olan notebooklar:");
            foreach (var notebook in notebooks)
            {
                Console.WriteLine($"Marka: {notebook.Brand}, Model: {notebook.Model}, RAM: {notebook.RAM}, Yaddas: {notebook.Storage}, Miqdar: {notebook.Count}, Qiymet: {notebook.Price}");
            }
        }
        }
      

        
    }
