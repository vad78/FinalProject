namespace FinalProject
{
    class Program
    {
        public static void Main()
        {
           Input myArraySize = new Input();
           int arrayLenght = myArraySize.ArraySize();
           MyArray array = new MyArray(arrayLenght);
           string[] initArray = array.FillArray();
           Console.WriteLine("Initial array: "+String.Join(", ",initArray));
           int count = array.GetCountOfResArray();
           if(count!=0){array.PrintResultArray();}
           else {Console.WriteLine("Result array is empty");}
           

         
           
           


        }
    }
}