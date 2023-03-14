namespace DataStructure{
    class Test{
        public void ArrayList(){
            ArrayList test = new ArrayList();
            test.Add(3.16);
            test.Add(5);
            test.Add("String");
            Console.WriteLine(test.Get(1));
            test.RemoveAt(1);
            Console.WriteLine(test.Get(1));
        }

        public void StringBuilder(){

            StringBuilder sb = new StringBuilder(50);
            sb.Append("ABC");
            sb.Append("CDF");
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.ToString());
        }
    }

}