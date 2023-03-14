namespace DataStructure{

    class StringBuilder{
        private char[] data;
        private int length;
        private int capacity;

        public StringBuilder (int capacity = 16){
            this.data = new char[capacity];
            this.length = 0;
            this.capacity = capacity;
        } 

        public int Length{
            get { return this.length;}
        }

        public int Capacity {
            set{
                    if(value<length){
                        throw new ArgumentOutOfRangeException();
                    }
                    Array.Resize(ref data,value);
                    capacity = value;
                }
            get{ return this.capacity;}
        
        }
        public StringBuilder Append(string str){
            int newLength = length+ str.Length;
            if(newLength>capacity){
                Array.Resize(ref data, newLength);
                capacity = newLength;
            }

            for (int i = 0; i< str.Length ;i++){
                data[i+length] = str[i]; 
            }

            length = newLength;
            return this;
        }

        public override string ToString()
        {
            return new string(data,0,length);
        }




    }


}