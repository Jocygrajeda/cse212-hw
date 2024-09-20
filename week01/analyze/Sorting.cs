public static class Sorting {
    public static void Run() { //method named run
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };//sort them from lowest to highest
        SortArray(numbers); //sorting the var nums from lowest to highest
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //printing the new order which is int[]{1, 2, 3, 4, 6, 8, 9} 
    }

    private static void SortArray(int[] data) { //Big O performance is O(n^2)
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--) { //outer loop - this loop runs n times - n is the lenght of the array - runs from the end to beginning - it helps keep track of where you are in sorting
            for (var swapPos = 0; swapPos < sortPos; ++swapPos) { //inner loop - runs fewer times as sortPos decreases
                if (data[swapPos] > data[swapPos + 1]) { // if one num is higher than the next one it swaps their place to sort them properly
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
}