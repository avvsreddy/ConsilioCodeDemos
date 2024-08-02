namespace CollectionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // value

            int[] arr; // declare int array ref
            arr = new int[10]; // allocate memory
            // int arr[]
            arr[0] = 10;
            a = arr[0];


            // read all 
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }




            int[] arr2 = new int[10];
            int[] arr3 = new int[a];
            int[] arr4 = new int[3] {1,2,3};
            int[] arr5 = new int[] { 1, 2, 4 };
            int[] arr6 = { 1, 2, 3 };


            int sum = arr6.Sum();

            Array.Sort(arr6);
            //Array.

            //2 dimentional
            // int twod[][]

            int[,] twoD = new int[7,4];
            twoD[0, 0] = 10;

            int[,] twoD2 = { { 1, 2 }, { 3, 5 } };


            //Jagged Arrays
            int[][] jagged = new int[4][];
            // first row - 3 col
            jagged[0] = new int[3];
            jagged[1] = new int[5];
            jagged[2] = new int[2];
            jagged[3] = new int[1];

            // write
            jagged[0][0] = 30;
        }
    }
}
