using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void Series1()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
        public void Series2()
        {
            double mul = 1;
            for (int i = 0; i < 10; i++)
            {
                mul *= double.Parse(Console.ReadLine());
            }
            Console.WriteLine(mul);
        }
        public void Series3()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum / 10.0);
        }
        public void Series4()
        {
            double mul = 1, sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double val = double.Parse(Console.ReadLine());
                mul *= val;
                sum += val;
            }
            Console.WriteLine("{0} {1}", mul, sum);
        }
        public void Series5()
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double val = double.Parse(Console.ReadLine());
                Console.WriteLine((int)val);
                sum += (int)val;
            }
            Console.WriteLine(sum);
        }
        public void Series6()
        {
            double mul = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double val = double.Parse(Console.ReadLine());
                Console.WriteLine(val % 1.0);
                mul *= (val % 1.0);
            }
            Console.WriteLine(mul);
        }
        public void Series7()
        {
            double mul = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double val = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(val));
                mul += Math.Round(val);
            }
            Console.WriteLine(mul - 1);
        }
        public void Series8()
        {
            int k = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (val % 2 == 0)
                {
                    Console.WriteLine(i+1);
                    k++;
                }
            }
            Console.WriteLine(k);

        }
        public void Series9()
        {
            int k = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (val % 2 == 1)
                {
                    Console.WriteLine(i+1);
                    k++;
                }
            }
            Console.WriteLine(k);
        }
        public void Series10()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double val = double.Parse(Console.ReadLine());
                if (val > 0)
                {
                    Console.WriteLine(true);
                    return;
                }
            }
            Console.WriteLine(false);
        }
        public void Series11()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (val < k)
                {
                    Console.WriteLine(true);
                    return;
                }
            }
            Console.WriteLine(false);
        }
        public void Series12()
        {
            int counter = 0;
            for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
            {
                counter++;
            }
            Console.WriteLine(counter);
        }
        public void Series13()
        {
            int sum = 0;
            for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
            {
                if (val > 0 && val % 2 == 0)
                    sum += val;
            }
            Console.WriteLine(sum);
        }
        public void Series14()
        {
            int sum = 0;
            int k = int.Parse(Console.ReadLine());
            for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
            {
                if (val < k)
                    sum++;
            }
            Console.WriteLine(sum);
        }
        public void Series15()
        {
            int counter = 0;
            bool isMet = false;
            int k = int.Parse(Console.ReadLine());
            for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
            {
                counter++;
                if (val > k)
                {
                    isMet = true;
                    break;
                }
            }
            Console.WriteLine(isMet ? counter : 0);
        }
        public void Series16()
        {
            int counter = 0;
            int ans = 0;
            int k = int.Parse(Console.ReadLine());
            for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
            {
                counter++;
                if (val > k)
                {
                    ans = counter;
                }
            }
            Console.WriteLine(ans);
        }
        public void Series17()
        {
            double b = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double val = double.Parse(Console.ReadLine());
                if (val < b)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(val);
                    b = double.MinValue;
                }
                else
                    Console.WriteLine(val);
            }
        }
        public void Series18()
        {
            int n = int.Parse(Console.ReadLine());
            double prev = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double val = int.Parse(Console.ReadLine());
                if (val != prev)
                {
                    Console.WriteLine(val);
                    prev = val;
                }

            }
        }
        public void Series19()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int prev = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (val < prev)
                {
                    Console.WriteLine(val);
                    counter++;
                }
                prev = val;

            }
            Console.WriteLine(counter);
        }
        public void Series20()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int prev = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (val > prev)
                {
                    Console.WriteLine(prev);
                    counter++;
                }
                prev = val;

            }
            Console.WriteLine(counter);
        }
        public void Series21()
        {
            int n = int.Parse(Console.ReadLine());
            int prev = int.Parse(Console.ReadLine());
            bool flag = true;
            for (int i = 0; i < n - 1; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (val <= prev)
                {
                    flag = false;
                    break;
                }
                prev = val;

            }
            Console.WriteLine(flag);
        }
        public void Series22()
        {
            int n = int.Parse(Console.ReadLine());
            int prev = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (val >= prev)
                {
                    Console.WriteLine(i + 2);
                    return;
                }
                prev = val;

            }
            Console.WriteLine(0);
        }
        public void Series23()
        {
            int n = int.Parse(Console.ReadLine());
            double prevprev = double.Parse(Console.ReadLine());
            double prev = double.Parse(Console.ReadLine());
            for (int i = 0; i < n - 2; i++)
            {
                int cur = int.Parse(Console.ReadLine());
                if (!((prev > prevprev && prev > cur) || (prev < prevprev && prev < cur)))
                {
                    Console.WriteLine(i + 3);
                    return;
                }
                prevprev = prev;
                prev = cur;

            }
            Console.WriteLine(0);
        }
        public void Series24()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            int Zero_count = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n - 1; i > -1; i--)
            {
                if (array[i] == 0) Zero_count++;

                if (Zero_count == 1) sum += array[i];
            }
            Console.WriteLine(sum);
        }
        public void Series25()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            int Zero_count = 0, all_zeros = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] == 0) all_zeros++;
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0) Zero_count++;

                if (Zero_count >= 1 && Zero_count < all_zeros) sum += array[i];
            }
            Console.WriteLine(sum);
        }
        public void Series26()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(double.Parse(Console.ReadLine()), k));
            }
        }
        public void Series27()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(double.Parse(Console.ReadLine()), (i + 1)));
            }
        }
        public void Series28()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(double.Parse(Console.ReadLine()), (n - i)));
            }
        }
        public void Series29()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(sum);
        }
        public void Series30()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += int.Parse(Console.ReadLine());
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
        public void Series31()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            bool flag = false;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (int.Parse(Console.ReadLine()) == 2)
                        flag = true;
                }
                if (flag)
                {
                    sum++;
                    flag = false;
                }
            }
            Console.WriteLine(sum);
        }
        public void Series32()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (int.Parse(Console.ReadLine()) == 2)
                    {
                        Console.WriteLine(j + 1);
                        break;
                    }
                    if (j == n - 1) Console.WriteLine(0);
                }
            }
        }
        public void Series33()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int index = 0;
                for (int j = 0; j < n; j++)
                {
                    if (int.Parse(Console.ReadLine()) == 2)
                    {
                        index = j;
                    }
                }
                Console.WriteLine(index + 1);
            }
        }
        public void Series34()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int index = -1;
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    int val = int.Parse(Console.ReadLine());
                    sum += val;
                    if (val == 2) index = j;
                }

                Console.WriteLine(index == -1 ? 0 : sum);
            }
        }
        public void Series35()
        {
            int k = int.Parse(Console.ReadLine());
            int allCounter = 0;
            for (int i = 0; i < k; i++)
            {
                int sum = 0;
                for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
                {
                    sum++;
                }
                allCounter += sum;
                Console.WriteLine(sum);
            }
            Console.WriteLine(allCounter);
        }
        public void Series36()
        {
            int k = int.Parse(Console.ReadLine());
            int allCounter = 0;
            for (int i = 0; i < k; i++)
            {
                int prev = int.Parse(Console.ReadLine());
                bool flag = true;
                for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
                {
                    if (prev >= val)
                    {
                        flag = false;
                        break;
                    }
                    prev = val;
                }
                if (flag)
                    allCounter++;
            }
            Console.WriteLine(allCounter);
        }
        public void Series37()
        {
            int k = int.Parse(Console.ReadLine());
            int allCounter = 0;
            for (int i = 0; i < k; i++)
            {
                int prev = int.Parse(Console.ReadLine());
                bool flagUp = true, flagDown = true;
                for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
                {
                    if (prev >= val)
                    {
                        flagUp = false;
                    }
                    if (prev <= val)
                    {
                        flagDown = false;
                    }
                    prev = val;
                }
                if (flagUp || flagDown)
                    allCounter++;
            }
            Console.WriteLine(allCounter);
        }
        public void Series38()
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int prev = int.Parse(Console.ReadLine());
                bool flagUp = true, flagDown = true;
                for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
                {
                    if (prev >= val)
                    {
                        flagUp = false;
                    }
                    if (prev <= val)
                    {
                        flagDown = false;
                    }
                    prev = val;
                }
                if (flagDown) Console.WriteLine(-1);
                else if (flagUp) Console.WriteLine(1);
                else Console.WriteLine(0);
            }
        }
        public void Series39()
        {
            int k = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < k; i++)
            {
                int prevprev = int.Parse(Console.ReadLine());
                int prev = int.Parse(Console.ReadLine());
                bool flag = true;
                for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
                {
                    if (!((prev < prevprev && prev < val) || (prev > prevprev && prev > val)))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) counter++;
            }
            Console.WriteLine(counter);
        }
        public void Series40()
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int prevprev = int.Parse(Console.ReadLine());
                int prev = int.Parse(Console.ReadLine());
                int index = 2;
                bool flag = true;
                for (int val = int.Parse(Console.ReadLine()); val != 0; val = int.Parse(Console.ReadLine()))
                {
                    index++;
                    if (!((prev < prevprev && prev < val) || (prev > prevprev && prev > val)))
                    {
                        flag = false;                      
                        break;
                    }
                }
                if (flag) Console.WriteLine(index); 
                else
                {
                    Console.WriteLine(index-1);
                }
            }
        }
    }
}
