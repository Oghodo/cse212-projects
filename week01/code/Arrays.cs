using System;
using System.Collections.Generic;

// The Arrays class contains both required methods that will be tested
public class Arrays
{
    // --------------------------------------------
    // Part 1: MultiplesOf Function using an Array
    // --------------------------------------------

    // Plan:
    // 1. Create a new array of doubles with a length equal to the number of multiples.
    // 2. Use a loop to go from 0 to the number of multiples - 1.
    // 3. On each loop iteration, calculate the multiple by multiplying the starting number by (i + 1).
    // 4. Store that value in the array at index i.
    // 5. After the loop is complete, return the array.

    public static double[] MultiplesOf(double startingNumber, int count)
    {
        double[] result = new double[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = startingNumber * (i + 1);
        }

        return result;
    }

    // ------------------------------------------------------
    // Part 2: RotateListRight Function using a List<T>
    // ------------------------------------------------------

    // Plan:
    // 1. The function takes a list and an amount to rotate to the right.
    // 2. First, use GetRange() to get the last 'amount' elements from the list.
    // 3. Then, use GetRange() again to get the remaining elements from the front.
    // 4. Clear the original list.
    // 5. Use AddRange() to add the two parts in rotated order: last part first, then the front part.
    // 6. This creates a rotated version of the list.

    public static void RotateListRight(List<int> data, int amount)
    {
        int count = data.Count;

        if (count <= 1 || amount <= 0 || amount == count)
            return;

        // Get the last 'amount' elements
        List<int> rightPart = data.GetRange(count - amount, amount);

        // Get the remaining elements from the beginning
        List<int> leftPart = data.GetRange(0, count - amount);

        // Clear the original list
        data.Clear();

        // Add the rotated parts
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
