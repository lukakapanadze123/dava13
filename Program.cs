namespace dava13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            int[] number = [20, 30, 603, 40, 50];
            string[] names = ["John", "James", "Jane"];

            ArrayHelper.PrintReverse(number);   //50 40 603 30 20
            names.PrintReverse();               //Jane James John

            Console.WriteLine(number.GetFirstElement());     //20
            Console.WriteLine(number.GetLastElement());      //50
            Console.WriteLine(names.GetFirstElement());      //John
            Console.WriteLine(names.GetLastElement());       //Jane

            Console.WriteLine(number.ContainsElement(603));  //true
            Console.WriteLine(names.ContainsElement("Bob")); //false

            Console.WriteLine(number.CountElements());       //5
            Console.WriteLine(names.CountElements());        //3

            Console.WriteLine(number.FindIndex(603));        //2
            Console.WriteLine(names.FindIndex("Bob"));       //-1

            number.Swap(0, 4);
            //50 30 603 40 20
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
















        }
    }
}
