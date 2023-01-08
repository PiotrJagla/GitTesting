namespace QuickDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CellBuyingable cell = new CellThatCanBeBought(40);
            cell.BayingLogic().SetCost(146);

            Console.WriteLine(cell.BayingLogic().GetCost());
        }
    }
}