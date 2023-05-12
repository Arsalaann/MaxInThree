namespace FindMax{
    class Program{


        public static void Main(string[] args){
            Console.WriteLine(GiveMax<int>.MaxNum(2,4,6));
            Console.WriteLine(GiveMax<string>.MaxNum("Hello","How","you"));
            Console.WriteLine(GiveMax<double>.MaxNum(2.34,5.34,3.12));
        }
    }
}