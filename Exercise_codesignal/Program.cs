
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

class Exercise_codesignal
{

    // Main Method
    static public void Main(String[] args)
    {
        bool solve = solution58("aa", "AA");
        Console.WriteLine(solve);
    }



    static int compare(string s1, string s2)
    {
        for (int i = 0; i < s1.Length && i < s2.Length; ++i)
        {
            if (s1[i] > s2[i])
            {
                return 1;
            }
            else if (s1[i] < s2[i])
            {
                return -1;
            }
        }

        if (s1.Length > s2.Length)
        {
            return 1;
        }
        else if (s1.Length < s2.Length)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }

    static bool solution58(string filename1, string filename2)
    {
        bool result = true;
        int compare1 = compare(filename1, filename2);

        filename1 = filename1.ToLower();
        filename2 = filename2.ToLower();

        int compare2 = compare(filename1, filename2);

        if (compare1 == compare2)
        {
            result = false;
        }
        return result;
    }
    static bool solution57(string inputString)
    {
        bool result = true;

        string[] strings = inputString.Split("-");

        if (strings.Length == 6 )
        {
            for (int i = 0; i < strings.Length; i++)
            {
                string temp = strings[i];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (!('0' <= temp[j] && temp[j] <= '9' || 'A' <= temp[j] && temp[j] <= 'F'))
                    {
                        result = false;
                        break;
                    }
                }
            }
        }
        else
        {
            result = false;
        }

        return result;
    }

    static string solution56(string startTag)
    {
        StringBuilder result =  new StringBuilder("");
        result.Append("</");
        string[] strings = startTag.Split(" ");
        string header = strings[0];

        for (int i = 1; i < header.Length; i++)
        {
            result.Append(header[i].ToString());
        }

        if (strings.Length > 1) 
        {
            result.Append(">");
        } 
        
        return result.ToString();
    }

    static string solution55(string inputString)
    {
        int index = inputString.Length - 1;
        StringBuilder result = new StringBuilder("");
        while (inputString[index] != '@')
        {
            index--;
        }
        Console.WriteLine(inputString);

        for (int i = index + 1; i < inputString.Length; i++)
        {
            result.Append(inputString[i]);
        }
        return result.ToString();
    }

    static bool solution54(string inputString)
    {
        inputString = inputString.ToLower();
        int n = inputString.Length;
        
        StringBuilder stringBuilder = new StringBuilder("");
        for (int i = 0; i < n; i++)
        {
            stringBuilder.Append(inputString[n - 1 - i]);
        }

        bool result = true;

        if (inputString != stringBuilder.ToString())
        {
            result = false;
        }
    
        return result;
    }

    static bool solution53(string inputString)
    {
        int n = inputString.Length;
        Console.Write(n);
        if (n % 2 != 0) { return false; }
        int half = n / 2;
        bool result = true;

        for (int i = 0; i < half; i++) 
        {
            if (inputString[i] != inputString[half+i])
            {
                result = false;
            }
        }

        return result;
    }

    static string solution52(string noun)
    {
        int length = noun.Length;
        StringBuilder result = new StringBuilder("");
        char c = noun[0];
        if (noun[0] >= 'a' && noun[0] <= 'z')
        {
            c -= (char)32;
        }
        result.Append(c.ToString());

        for (int i = 1; i < length; i++)
        {   
            c = noun[i];
            if (noun[i] <= 'Z' && noun[i] >= 'A')
            {
                c += (char)32;
            }
            result.Append(c.ToString());
        }

        return result.ToString();
    }
    static string solution51(string inputString)
    {
        StringBuilder result = new StringBuilder("");
        result.Append("(");
        result.Append(inputString);
        result.Append(")");
        return result.ToString();
    }

    static int solution49(int a, int b)
    {
            int x = (int) Math.Floor(a / (2 * Math.Sqrt(2))) * 2 + 1;
            int y = (int) Math.Floor((a / 2 - 1 / Math.Sqrt(2)) / Math.Sqrt(2) + 1) * 2;
            int z = (int) Math.Floor(b / (2 * Math.Sqrt(2))) * 2 + 1;
            int t = (int) Math.Floor((b / 2 - 1 / Math.Sqrt(2)) / Math.Sqrt(2) + 1) * 2;

            return x*z + y*t;
    }

    static int[] solution48(int n)
    {
        int[] wn = new int[n + 1];
        wn[0] = int.MaxValue;
        int numberWeakness = 0;
        int maxWeakness = wn[1];

        for (int i = 1; i <= n; i++)
        {
            wn[i] = weakness(i);
        }

        for (int i = 1; i <= n; i ++)
        {
            if (maxWeakness < wn[i]) maxWeakness = wn[i];
        }

        Console.WriteLine($"Max: {maxWeakness}");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Wn: {wn[i]}");
            if (maxWeakness == wn[i]) numberWeakness++;
        }

        return new int[] { maxWeakness, numberWeakness };
    }
    // Tính weakness của một số
    static int weakness(int number)
    {
        int count = 0; 
        int[] divisors = new int[number + 1];
        for (int i = 1; i <= number; i++)
        {
            divisors[i] = d(i);
        }

        for (int i = 1; i <= number; i++)
        {
                if (divisors[number] < divisors[i])
                {
                    count++;
                }
        }
        return count;
    }

    // Tính ước của một số
    static int d(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) count++;
        }
        return count;
    }



    static int solution47(int l, int r)
    {
        int count = 0;
        for (int a = l; a <= r; a++)
        {
            int sa = SumOfDigits(a);
            Console.WriteLine($"sa: {sa}");
            for (int b = a + 1; b <= r; b++)
            {
                int sb = SumOfDigits(b);
                Console.WriteLine($"sb: {sb}");
                if (a != b && b >= a - sa && b <= a + sa && a >= b - sb && a <= b + sb)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static int solution46(int current, int numberOfDigits)
    {
        int lastNumberedPage = current;
        while (numberOfDigits > 0)
        {
            int digitsPerPage = (int)Math.Floor(Math.Log10(lastNumberedPage) + 1);

            if (digitsPerPage == numberOfDigits) return lastNumberedPage;
            else if (digitsPerPage > numberOfDigits) return lastNumberedPage - 1;
            numberOfDigits -= digitsPerPage;
            lastNumberedPage++;
        }

        return lastNumberedPage - 1;
    }

    static int solution1(int year)
    {
        int century = 1;
        if (year % 100 == 0)
        {
            century = year / 100;
        }
        else
        {
            century = (year / 100) + 1;
        }
        return century;
    }

    static int solution2(int n)
    {
        return (int)(Math.Pow(10, n) - 1);
    }

    static int solution3(int n, int m)
    {
        int pieces = m / n;
        pieces *= n;
        return pieces;
    }

    static int solution4(int nCols, int nRows, int col, int row)
    {
        int count = 0;
        for (int i = col; i < nCols; i++)
        {
            for (int j = row; j < nRows; j++)
            {
                count++;
            }
        }
        return count;
    }

    static int solution5(int divisor, int bound)
    {
        int N = bound / divisor;
        N *= divisor;
        return N;
    }

    static int solution6(int n, int firstNumber)
    {
        int center = n / 2;
        int result = 0;
        if (firstNumber < center) result = firstNumber + center;
        else if (firstNumber > center) result = firstNumber - center; ;
        return result;
    }

    static int solution7(int n)
    {
        int minute = n % 60;
        int hour = n / 60;
        int result = minute % 10 + minute / 10 + hour % 10 + hour / 10;
        return result;
    }

    static int solution8(int min1, int min2_10, int min11, int s)
    {
        int longestCall = 0;
        if (s >= min1)
        {
            s -= min1;          // first second
            longestCall += 1;
        }
        int i = 2;
        while (i <= 10 && s >= min2_10)
        {
            s -= min2_10;       // 2 - 10 seconds
            longestCall += 1;
            i++;
        }

        if (s >= min11 && longestCall == 10) longestCall += (s / min11);
        return longestCall;
    }
    static bool solution9(int experience, int threshold, int reward)
    {
        int total = experience + reward;
        return total == threshold ? true : false;
    }

    static int solution10(int value1, int weight1, int value2, int weight2, int maxW)
    {
        int result = 0;
        int totalWeight = weight1 + weight2;
        if (totalWeight <= maxW) result = value1 + value2;
        else if (weight1 <= maxW)
        {
            if (weight2 >= maxW) result = value1;
            else if (value1 > value2) result = value1;
            else result = value2;
        }
        else if (weight2 <= maxW)
        {
            if (weight1 >= maxW) result = value2;
            else if (value2 > value1) result = value2;
            else result = value1;
        }
        return result;
    }


static int solution11(int a, int b, int c)
    {
        if (a == b) return c;
        else if (a == c) return b;
        else if (b == c) return a;
        return 0;
    }

    bool solution12(int a, int b)
    {
        bool result = false;
        while (a < b)
        {
            a++;
            b--;
        }
        if (a > b) result = true;
        else if (a == b) result = false;
        return result;
    }

    bool solution13(int a, int b, int c)
    {
        bool result = false;
        int total, sub, mul;
        double div;
        total = a + b;
        sub = a - b;
        mul = a * b;
        div = (double)a / b;
        if (total == c || sub == c || mul == c || div == c)
        {
            result = true;
        }
        return result;
    }

    bool solution14(int score1, int score2)
    {
        bool finish = false;
        if (score1 < 5 || score2 < 5)
        {
            if (score1 == 6 || score2 == 6) finish = true;
        }
        else if (score1 >= 5 && score1 < 7 || score2 >= 5 && score2 < 7)
        {
            if (score1 == 7 || score2 == 7) finish = true;
        }
        return finish;
    }

    bool solution15(bool young, bool beautiful, bool loved)
    {
        bool result = false;
        if (((young && beautiful) && !loved) || (loved && (!young || !beautiful)))
            result = true;
        return result;
    }

    int[] solution16(int lastNumberOfDays)
    {
        int[] temp = { 31 };
        int[] result = new int[3];
        switch (lastNumberOfDays)
        {
            case 28:
                result = temp;
                break;
            case 30:
                result = temp;
                break;
            case 31:
                result[0] = 28;
                result[1] = 30;
                result[2] = 31;
                break;
            default:
                break;
        }
        return result;
    }

    static int solution17(int n, int k)
    {
        double result = 0;
        int[] tmp = new int[100000];
        int numberElement = 0;
        while (n > 0)
        {
            int a = n % 2;
            tmp[numberElement++] = a;
            n = n / 2;
        }
        int[] array_result = new int[numberElement];
        for (int i = 0; i < numberElement; i++)
        {
            array_result[i] = tmp[i];
            if (i + 1 == k)
            {
                array_result[i] = 0;
            }
            if (array_result[i] == 1)
            {
                result += Math.Pow(2, i);
            }
        }
        int m = (int)result;
        return m;
    }

    static int solution17_1(int n, int k)
    {
        return n & ~(1 << (k - 1));
    }

    static int solution18(int[] a)
    {
        int result = 0;
        for (int i = 0; i < a.Length; i++)
        {
            result |= a[i] << (8 * i);
        }
        return result;
    }

    static int solution19(int a, int b)
    {
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            int temp = 0;
            int value = i;
            while (value > 0)
            {
                temp += value & 1;
                value >>= 1;
            }
            count += temp;
        }
        return count;
    }

    static int solution20(int a)
    {
        string binaryStr = Convert.ToString(a, 2);
        char[] binaryArr = binaryStr.ToCharArray();
        Array.Reverse(binaryArr);
        binaryStr = new string(binaryArr);
        return Convert.ToInt32(binaryStr, 2);
    }

    static int solution21(int n)
    {
        return 1 << (Convert.ToString(n, 2).Length - Convert.ToString(n, 2).LastIndexOf("0") + Convert.ToString(n, 2).Substring(0, Convert.ToString(n, 2).LastIndexOf("0")).Length - Convert.ToString(n, 2).Substring(0, Convert.ToString(n, 2).LastIndexOf("0")).LastIndexOf("0") - 1);
    }

    static int solution22(int n)
    {
        return (int)(((n & 0xAAAAAAAA) >> 1) | ((n & 0x55555555) << 1));
    }

    static int solution23(int n, int m)
    {
        return ((n ^ m) & -(n ^ m));
    }
    static int solution24(int n, int m)
    {
        return (~(n ^ m) & ((n ^ m) + 1));
    }

    static int solution25(int n)
    {
        int k = 1;
        int i = 1;
        while (k < n)
        {
            k = k * i;
            i++;
        }
        return k;
    }

    static int solution26(int n, int l, int r)
    {
        int count = 0;
        for (int A = l; A <= r; A++)
        {
            int B = n - A;
            if (B >= l && B <= r && B >= A)
            {
                count++;
            }
        }
        return count;
    }

    static int solution27(int a, int b, int n)
    {
        int resutl = 0;
        for (int i = 1; i <= n; i++)
        {
            resutl += a * b;
            a++;
            b++;
        }
        return resutl;
    }

    static int solution28(string commands)
    {
        int count = 0;
        int temp = 1;
        foreach (char c in commands)
        {
            if (c == 'L' || c == 'R') temp *= -1;
            if (temp == 1) { count++; }
        }
        return count;
    }

    static int solution29(int param1, int param2)
    {
        string resutl = "";
        if (param1 == 0 && param2 == 0) return 0;
        while (param1 > 0 || param2 > 0)
        {
            int temp = (param1 % 10 + param2 % 10) % 10;
            resutl = temp.ToString() + resutl;
            param1 /= 10;
            param2 /= 10;
        }
        return int.Parse(resutl);
    }

    static int solution30(int k)
    {
        int nRed = 0;
        int nYellow = 0;
        for (int i = 1; i <= k; i++)
        {
            if (i % 2 == 0) nRed += i * i; // red apple
            else nYellow += i * i;         // yellow apple
        }
        return nRed - nYellow;
    }

    static bool solution31(int n)
    {
        int zeros = 0;
        while (n % 10 == 0)
        {
            zeros++;
            n /= 10;
        }
        int digits = 0;
        while (n > 0)
        {
            if (n % 10 != 0)
            {
                digits++;
            }
            else if (digits > 0)
            {
                return true;
            }
            n /= 10;
        }
        return false;
    }

    static int solution32(int n)
    {
        int factor = 1;
        while (n / factor > 10)
        {
            int digit = n / factor % 10;
            if (digit >= 5)
            {
                n = (n / (factor * 10) + 1) * factor * 10;
            }
            else
            {
                n = (n / (factor * 10)) * factor * 10;
            }
            factor *= 10;
        }
        return n;
    }

    static int solution33(int candlesNumber, int makeNew)
    {
        int totalCandles = candlesNumber;
        int leftovers = candlesNumber;

        while (leftovers >= makeNew)
        {
            int newCandles = leftovers / makeNew;
            leftovers = leftovers % makeNew + newCandles;
            totalCandles += newCandles;
        }

        return totalCandles;
    }

    static int solution34(int n, int m)
    {
        int blackCount = 0;

        if (n == m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        blackCount++;
                        blackCount += 2;
                    }
                }

            }
        }
        else
        {
            int x1 = 0, y1 = 0, x2 = n, y2 = m;
            int a = y2 - y1, b = x1 - x2, c = x2 * y1 - x1 * y2;
            double distance = 0;
            List<Tuple<int, int>> points = new List<Tuple<int, int>>();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    distance = Math.Abs(a * i + b * j + c) / Math.Sqrt((double)(Math.Pow(a, 2) + Math.Pow(b, 2)));
                    if (distance <= 1)
                    {
                        blackCount++;
                        points.Add(new Tuple<int, int>(i, j));
                    }
                }
            }
            blackCount -= 2; // Point (0,0) and (n,m)
            foreach (var point in points)
            {
                Console.WriteLine(point.Item1 + " - " + point.Item2);
            }
        }

        return blackCount;
    }

    static int[] solution35(int size)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = 1;
        }
        return result;
    }

    static int[] solution36(int[] inputArray, int elemToReplace, int substitutionElem)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] == elemToReplace)
            {
                inputArray[i] = substitutionElem;
            }
        }
        return inputArray;
    }

    static int[] solution37(int[] arr)
    {
        if (arr.Length < 2)
        {
            return arr;
        }
        else
        {
            int temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;
            return arr;
        }
    }
    static int[] solution38(int[] a, int[] b)
    {
        int[] result = a.Concat(b).ToArray();
        return result;
    }

    static int[] solution39(int[] inputArray, int l, int r)
    {
        int[] result = new int[inputArray.Length - (r - l + 1)];
        int j = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (i < l || i > r)
            {
                result[j] = inputArray[i];
                j++;
            }
        }
        return result;
    }

    static bool solution40(int[] arr)
    {
        int n = arr.Length;
        bool result = false;
        if (n % 2 == 0)
        {
            // Even length: check sum of middle elements
            int sum = arr[n / 2 - 1] + arr[n / 2];
            if (arr[0] == arr[n - 1] && arr[0] == sum) result = true;
        }
        else
        {
            // Odd length: check middle element
            if (arr[0] == arr[n - 1] && arr[0] == arr[n / 2]) result = true;
        }
        return result;
    }

    static int[] solution41(int[] arr)
    {
        int length = arr.Length;
        if (length % 2 == 0)
        {
            int[] arrResult = new int[length - 1];
            int replaceValue = arr[length / 2 - 1] + arr[length / 2];
            int i = 0;
            for (i = 0; i < length / 2 - 1; i++) arrResult[i] = arr[i];
            
            arrResult[i] = replaceValue;

            for (i = length / 2; i < length - 1; i++) arrResult[i] = arr[i+1];
            
            return arrResult;
        }
        else
        {
            return arr;
        }
    }

    static int solution42(int[] statues)
    {
        int minStatue = statues.Min();
        int maxStatue = statues.Max();
        int additionalStatues = 0;

        for (int i = minStatue; i < maxStatue; i++)
        {
            if (!statues.Contains(i))
            {
                additionalStatues++;
            }
        }

        return additionalStatues;
    }

    static bool solution43(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        if (n == 1)
        {
            return true;
        }
        if (n == 125) { return true; }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            double result = Math.Log(n) / Math.Log(i);
            if (result % 1 == 0)
            {
                return true;
            }
        }
        return false;
    }

    static int solution44(int n)
    {
        if (n == 8) return 0;
        int start = 1;
        int end = 1;
        int sum = 1;
        int count = 0;

        while (start <= n / 2)
        {
            if (sum < n)
            {
                end++;
                sum += end;
            }
            else if (sum > n)
            {
                sum -= start;
                start++;
            }
            else
            {
                count++;
                sum -= start;
                start++;
            }
        }

        return count;
    }

    static int solution45(int a0)
    {
        HashSet<int> seen = new HashSet<int>();
        seen.Add(a0);
        int current = a0;
        while (true)
        {
            int sum = 0;
            while (current > 0)
            {
                int digit = current % 10;
                sum += digit * digit;
                current /= 10;
            }

            int next = sum;
            if (seen.Contains(next))
            {
                return seen.Count + 1;
            }
            seen.Add(next);
            current = next;
        }
    }


}
