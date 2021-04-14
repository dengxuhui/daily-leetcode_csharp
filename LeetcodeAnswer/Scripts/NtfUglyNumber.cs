using System;

namespace LeetcodeAnswer.Scripts
{
    public class NtfUglyNumber
    {
        public static void Entry()
        {
            var i = Cal(11);
            Console.WriteLine("ugly is =>" + i.ToString());
        }

        private static int Cal(int n) {
            int[] dp = new int[n + 1];        
            dp[1] = 1;
            int p2 = 1,p3 = 1,p5 = 1;
            for(var i = 2;i <= n;i++){
                int num2 = dp[p2] * 2,num3 = dp[p3] * 3 ,num5 = dp[p5] * 5;
                var min = Math.Min(num2,Math.Min(num3,num5));         
                if(min == num2){
                    p2++;
                }
                else if(min == num3){
                    p3++;
                }
                else if(min == num5){
                    p5++;
                }
                dp[i] = min;
            }
            return dp[n];
        }
    }
}