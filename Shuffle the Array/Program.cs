// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// https://leetcode.com/problems/shuffle-the-array/


public class Solution
{
  public int[] Shuffle(int[] nums, int n)
  {
    var length = nums.Length;
    var half = length / 2;
    var ans = new int[length];
    int i = 0;
    int j = n;
    int k = 0;
    while (i < half && j < length)
    {
      ans[k++] = nums[i];
      ans[k++] = nums[j];
      i++; j++;
    }

    return ans;
  }
}