namespace rabota_v_klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 3 , 44, 12 };
            LinkedList<int> numbers = new LinkedList<int>(nums);
            SrednoAretmetichno(numbers);
            Console.WriteLine(numbers);

        }

        static void SrednoAretmetichno(LinkedList<int> numbers) 
        { 
             numbers.Average();
        }
    }
}
