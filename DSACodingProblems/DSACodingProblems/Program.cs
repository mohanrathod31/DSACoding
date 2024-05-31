
// Example input
using DSACodingProblems.ArrayProblems;

int[] nums = { 2, 7, 11, 15 };
int target = 9;

// Call and print results for each method
PrintTwoSumResult("BruteForce", TwoSum.TwoSumBruteForce(nums, target));
PrintTwoSumResult("Sorting", new TwoSum().TwoSumSorting(nums, target));
PrintTwoSumResult("Hashing", TwoSum.TwoSumHashing(nums, target));

// Helper method to print results of TwoSum methods
static void PrintTwoSumResult(string methodName, int[] result)
{
    if (result.Length == 2)
    {
        Console.WriteLine($"{methodName}: Indices {result[0]}, {result[1]}");
    }
    else
    {
        Console.WriteLine($"{methodName}: No two sum solution");
    }
}