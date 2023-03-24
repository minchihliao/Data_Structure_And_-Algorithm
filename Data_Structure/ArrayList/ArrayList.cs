namespace DataStructure{
    public class ArrayList{
        private object[] data;
        private int count;

        public ArrayList(){
            this.data = new object[10];
            this.count = 0;
        }

        public void Add(object newData){
            if(this.count==this.data.Length){
                Resize();
            }
            this.count++;
            this.data[count] = newData;            
        }

         public void Set(int index, object element)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException();
            }

            data[index] = element;
        }

        public object Get(int index){
            if(index<0 || index>= this.count){
                new IndexOutOfRangeException();
            } 
            return this.data[index];
        }

        public void RemoveAt(int index){
             if(index<0 || index>= this.count){
                new IndexOutOfRangeException();
            } 
            for(int i = index ; i< this.count;i++){
                this.data[i] = data[i+1];
            }
            this.count--;
        }

         public int Count{
            get { return this.count; }
        }

         private void Resize(){
            object[] newArray = new object[this.data.Length*2];
            Array.Copy(this.data,newArray,this.data.Length);
            this.data = newArray;
        }

    }

}