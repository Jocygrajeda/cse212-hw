/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation { //class sd and method run
    public static void Run() {
        var numbers = new[] { 600, 470, 170, 430, 300 }; //creating a list of #s
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

    private static double StandardDeviation1(int[] numbers) {
        var total = 0.0;
        var count = 0;
        foreach (var number in numbers) { // loops goes through each # in the array - each iteration does constant time work adding to total and increasing count so the complexity is O(n) 
            total += number;
            count += 1;
        }

        var avg = total / count; //single division operationg, it doesn't depend on the size of the input, making it O(1)
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) { //this loop goes through each number in the array  like the other line - calculates the ^ difference and adding it to sumQuaredDifferences, making it O(n)
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count; //div and square root calculation, both are constant time, making it O(1)
        return Math.Sqrt(variance);
    }

    private static double StandardDeviation2(int[] numbers) { //takes the array of integers(numbers) and returns them double
        var sumSquaredDifferences = 0.0;//adds thes squared difference to count how many #s are processed
        var countNumbers = 0;
        foreach (var number in numbers) {
            var total = 0;
            var count = 0;
            foreach (var value in numbers) {
                total += value;
                count += 1;
            }

            var avg = total / count; // constant time, O(1)
            sumSquaredDifferences += Math.Pow(number - avg, 2); //constant time, O(1)
            countNumbers += 1; //constant time, O(1)
        }

        var variance = sumSquaredDifferences / countNumbers; //O(1)
        return Math.Sqrt(variance); //O(1)
    }//O(n) x  0(n) = O(n^2)

    private static double StandardDeviation3(int[] numbers) {
        var count = numbers.Length; //O(1)
        var avg = (double)numbers.Sum() / count;//O(n)
        var sumSquaredDifferences = 0.0;//O(1)
        foreach (var number in numbers) {//O(n)
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;//O(1)
        return Math.Sqrt(variance);//O(1)
    }
}//O(1)+O(n)+O(n)+O(1)+O(1) = O(2n+3) = O(n)