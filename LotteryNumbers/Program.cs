// See https://aka.ms/new-console-template for more information


//var result = Console.ReadLine();
for (var i = 0; i < 5; i++)
{
    var nums = Lottery.GetLotteryNumbers(1);
    Lottery.PrintArray("Mega Millions Numbers: ", nums);
}
Console.WriteLine();
for (var i = 0; i < 5; i++)
{
    var nums = Lottery.GetLotteryNumbers(2);
    Lottery.PrintArray("Power Ball Numbers: ", nums);
}



public static class Lottery
{
    public static int[] GetLotteryNumbers(int lotteryType)
    {
        var maxNum = (lotteryType == 1) ? 70 : 69;
        var maxMegaNum = (lotteryType == 1) ? 21 : 26;
        var nums = new HashSet<int>(); 
        Random random = new Random();
        while (nums.Count < 5)
        {
            var num = random.Next(1, maxNum);
            if(!nums.Contains(num))
                nums.Add(num);
        }
        while (nums.Count < 6)
        {
            var megaBall = random.Next(1, maxMegaNum);
            if (!nums.Contains(megaBall))
                nums.Add(megaBall);
        }
        return nums.ToArray();
    }
    public static void PrintArray(string title, int[] p)
    {
        Console.Write(title);
        for (int i = 0; i < p.Length; i++)
        {
            if (i < p.Length - 1)
                Console.Write(p[i] + ",");
            else
            {
                Console.Write(p[i]);
                Console.WriteLine();
            }
        }
    }
}
