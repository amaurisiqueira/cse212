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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        
        double [] myarray = new double[length]; // reserve the momory side to allocate all datada, based in the length of data series. 
        for(int a=0;a<length;a++) myarray[a]=( number) * ((double)(a+1)) ; // iterate de serie fron 0 to lenght of data serie minus one.  while iterate, strore in the array of data current position the current position plus one and multiply for variable multiple.
        return myarray; // replace this return statement with your own
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
        int count = data.Count; // determine the lenght of data array serie
        int positions = amount % count; // determine the module of  position
        Console.WriteLine(positions );

        if (positions == 0) return; // check if is posible ratate, if module is 0, its don't possible
        int initial=count - positions; //determine a fist position to rotate
        
        Console.WriteLine(initial );
        
        var temp = data.GetRange(initial, positions); // obtain data to rotate, from start to end range
        data.RemoveRange(initial, positions); //remove the range of data, from original data serie.  
        data.InsertRange(0, temp); // add in the first position of serie, the data removed from oringal range.
        
    }
}
