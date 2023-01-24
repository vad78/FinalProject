namespace FinalProject
{
    class MyArray
    {
        private int size, count;
        private string[] initArray;
        private string[]resArray = new string[0];
        public MyArray(int num)
        {
            this.size = num;
            this.initArray = new string[size];
        }
        public int GetCountOfResArray()
        {
            return this.count;
        }
        public void PrintResultArray()
        {
            Console.WriteLine("Result array: "+String.Join(", ",this.resArray));
        }
        
        public string[] FillArray()
        {
            for(int i = 0;i<this.initArray.Length;i++)
            {
                this.initArray[i] = getString();
                if(this.initArray[i].Length<=3)
                {
                    this.resArray = this.resArray.Append(this.initArray[i]).ToArray();
                    this.count++;
                }

            }
            return initArray;
        }
        private string getString()
        {
            string str = null;
            while(String.IsNullOrEmpty(str))
            {
                Console.Write("Please, enter non-empty string: ");
                str = Console.ReadLine();
            }
            return str;
        }
        
    }
}