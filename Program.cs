namespace CashRegApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var app = new StoreApp();
            //StoreApp.UserItemMenu();

            var app = new ItemTextFile();
            ItemTextFile.UserItemMenu();
            ItemTextFile.WriteItems();
        }
    }
}
