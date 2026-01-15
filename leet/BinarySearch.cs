namespace leet;

public class BinarySearch
{
    public int Search(int[] nums, int target) {
        return SearchGeneric<int>(nums, target);
    }

    int SearchGeneric<T>(T[] nums, T target) 
        where T : IComparable<T>
    {
        var left = 0;
        var right = nums.Length - 1;

        while (right - left > 1)
        {
            var mid = (left + right) / 2;

            var cmp = nums[mid].CompareTo(target);
            if (cmp == 0)
            {
                return mid;
            }
            if (cmp < 0)
            {
                left = mid;
            }
            else
            {
                right = mid;
            }
            
        }
        
        return -1;
    }

}