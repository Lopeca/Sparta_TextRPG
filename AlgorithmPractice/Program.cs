

namespace AlgorithmPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 6, 7, 9, 4, 10, 5, 6 };

            int result = LengthOfLIS(nums);
            Console.WriteLine(result);
        }

        public static int LengthOfLIS(int[] nums)
        {
            int maxLength = 1;

            int[] lengthMemo = new int[nums.Length];

            lengthMemo[0] = 1;
           

            for (int i = 1; i < nums.Length; i++)
            {


                    PrintArray(nums);
                    // 이전 칸보다 작은 수가 나오면 더 앞에서 자신보다 작은 수가 있는 곳의 최대 length를 가져옴
                    // 자신보다 작은 수를 발견하지 못하면 자신 위치부터 길이 1
                    int j;

                    for (j = i - 1; j >= 0; j--)
                    {
                        if (nums[j] < nums[i] && lengthMemo[i] <= lengthMemo[j])
                        {
                            lengthMemo[i] = lengthMemo[j] + 1;
                            PrintArray(lengthMemo);
                            Console.WriteLine();
                        }
                    }

                    if(j == - 1 && lengthMemo[i] == 0)
                    {
                        lengthMemo[i] = 1;
                    }
                    
                    PrintArray(nums);
                    PrintArray(lengthMemo);
                    Console.WriteLine("==================");
                    
                
            }

            //마지막에 한바퀴 순회해서 최대값 건지기. 반복문 속에서 매번 확인하는 것보다 효율적일 거라 판단
            for (int i = 0; i < lengthMemo.Length; i++)
            {
                if (lengthMemo[i] > maxLength)
                {
                    maxLength = lengthMemo[i];
                }
            }
            Console.Clear();
            PrintArray(nums);
            PrintArray(lengthMemo);

            return maxLength;
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }

}

