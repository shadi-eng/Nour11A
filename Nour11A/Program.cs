namespace Nour11A
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //SayHi(5);
            //Magic(10, 5);
            //SayHi(10);
            //SendMessageToWhatsapp("Hello, how are you?", "+1234567890");
            ////23/6/2010
            //int[] arr = new int[3];
            //arr[0] = 23;
            //arr[1] = 6;
            //arr[2] = 2010;
            //SumArray(arr);
            //int[] arr2 = { 6, 6, 1981 };
            //SumArray(arr2);
            //int number = 12345454;
            //int x=CountDigits(number);
            //Console.WriteLine(x);
            //CountDigits(123);
            //Console.WriteLine(CountDigits(121121));
            //int[] arr3 = { 5, 7, 12, 30 };//BuildRandomArray(10, 1, 100);
            //PrintArray(arr3);
            //Add10ToArray(arr3);
            //PrintArray(arr3);
            int x = 100;
            Console.WriteLine(x);
            Add10ToX(x); //نرسل قيمة المتغير x الى العملية، ولكن العملية لا تعيد قيمة، لذلك لن تتغير قيمة x
            Console.WriteLine(x);
        }

        public static void SayHi(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Hi");
            }
        }

        public static void Magic(int x, int y)
        {
            Console.WriteLine("x:{0} y:{1}", x, y);
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
        }

        public static void SendMessageToWhatsapp(string message, string phone)
        {
            Console.WriteLine("Sending message to WhatsApp: " + message);
        }

        public static void SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of array: " + sum);
        }

        public static int CountDigits(int number)
        {
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        //عملية تتلقى ثلاث بارامترات: وتقوم ببناء واعادة مصفوفة طولها حسب القيمة الاولى، وقيمها عشوائية بين الثاني والثالث
        public static int[] BuildRandomArray(int size, int minValue, int maxValue)
        {
            int[] arr = new int[size];
            Random noor = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = noor.Next(minValue, maxValue + 1);
            }
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Add10ToArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;
            }
        }

        public static void Add10ToX(int x)
        {
            x += 10;
        }
    }
}
