public class IsOdd {
    public static void IsOddSolution() {
        int[] array = {2, 4, 7, 8, 6};
        boolean hasTrue = false;

        for(int i = 0; i < array.length; i++) {
            hasTrue = array[i]%2 =! 0; 
        }

        Console.WriteLine(hasTrue);
    }
}