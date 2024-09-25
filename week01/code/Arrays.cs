public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //create a new array of doubles w the size of "length"
        //the array will hold multiples of the number
        double[] multiplesArray = new double[length];

        //use a loop to fill the array
        //interate from 0 to length to populate each element
        for (int i = 0; i < length; i++)
        {
            //valculate the value from each position
            // 1st element is "number" and the 2nd is "number*2" and so on
            //(i + 1) is used to ensure that the first multiple corresponds to be "number" itself 
            multiplesArray[i] = number * (i + 1);
        }

        //return the filled array. 
        //after the loop, the return variable will contain multiples of the giving #
        return multiplesArray; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
