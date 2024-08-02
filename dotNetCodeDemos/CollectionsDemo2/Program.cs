
namespace CollectionsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client Dev 1: need to store n number of ints and display
            DynamicArray<int> array = new DynamicArray<int>();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Add(6);
            array.Add(7);
            array.Add(8);
            array.Add(9);
            array.Add(10);
            array.Add(11);
            array.Add(12);
            array.Add(13);
            array.Add(14);
            array.Add(15);

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array.Get(i));
            }


        }
    }


    // Developer
    class DynamicArray<T>
    {

        private T[] data = new T[10];
        private int index = 0;
        internal void Add(T number)
        {
            // add number into static collection
            if(index < data.Length) 
            {
                data[index++] = number;
            }
            else
            {
                //int[] temp = new int[data.Length * 2];
                // copy old data into new array
                //data.CopyTo(temp, 0);
                //data = temp;

                Array.Resize(ref data, data.Length*2);

                data[index++] = number;
            }

        }

        internal T Get(int i)
        {
            //if(i <  data.Length)
                return data[i];
        }

        public int Count 
        {
            get { return index; }
        }
    }


    //class DynamicDoubleArray
    //{

    //    private double[] data = new double[10];
    //    private int index = 0;
    //    internal void Add(double number)
    //    {
    //        // add number into static collection
    //        if (index < data.Length)
    //        {
    //            data[index++] = number;
    //        }
    //        else
    //        {
    //            //int[] temp = new int[data.Length * 2];
    //            // copy old data into new array
    //            //data.CopyTo(temp, 0);
    //            //data = temp;

    //            Array.Resize(ref data, data.Length * 2);

    //            data[index++] = number;
    //        }

    //    }

    //    internal double Get(int i)
    //    {
    //        //if(i <  data.Length)
    //        return data[i];
    //    }

    //    public int Count
    //    {
    //        get { return index; }
    //    }
    //}
}
