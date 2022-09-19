public class MinMax {
    public static void MinMaxSolution() {
        int[] values = new int[3];

        Console.WriteLine("Please Enter Three Integers: ");

        for (int i = 0; i < values.Length; i++) {
            // We assume that Console.ReadLine always returns an int
            values[i] = Int32.Parse(Console.ReadLine());
        }

        int min = values.Min();
        int max = values.Max();

        Console.WriteLine($"Highest value is {max} and Lowest value is {min}");
    }
}