using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== TASk 1 =====
            //while (true)
            //{
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.Write(
            //        "============================\n" +
            //        " 1. All processes\n" +
            //        " 2. Process information\n" +
            //        " 3. Start process\n" +
            //        " 4. Close process\n" +
            //        " 0. Exit\n" +
            //        " > ");
            //    Console.ResetColor();
            //    string input = Console.ReadLine() ?? string.Empty;

            //    switch (input)
            //    {
            //        case "1":
            //            var processes = Process.GetProcesses().OrderByDescending(p => p.WorkingSet64);
            //            foreach (Process process in processes)
            //            {
            //                Console.WriteLine($"ID: {process.Id} / Name: {process.ProcessName} / Threads: {process.Threads.Count} / Memory: {process.WorkingSet64 / 1024 / 1024} MB");
            //            }
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            break;
            //        case "2":
            //            try
            //            {
            //                Console.Write("Enter process ID: ");
            //                int processId = int.Parse(Console.ReadLine() ?? string.Empty);
            //                Process processInfo = Process.GetProcessById(processId);
            //                Console.WriteLine($"ID: {processInfo.Id} / Name: {processInfo.ProcessName} / Threads: {processInfo.Threads.Count} / Memory: {processInfo.WorkingSet64 / 1024 / 1024} MB");
            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("Invalid process ID.");
            //            }
            //            finally
            //            {
            //                Console.WriteLine("Press any key to continue...");
            //                Console.ReadKey();
            //            }
            //            break;
            //        case "3":
            //            try
            //            {
            //                Console.Write("Enter process name to start: ");
            //                string processName = Console.ReadLine() ?? string.Empty;
            //                Process.Start(processName);
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine($"Error starting process: {ex.Message}");
            //            }
            //            finally
            //            {
            //                Console.WriteLine("Press any key to continue...");
            //                Console.ReadKey();
            //            }
            //            break;
            //        case "4":
            //            try
            //            {
            //                Console.Write("Enter process ID to close: ");
            //                int closeProcessId = int.Parse(Console.ReadLine() ?? string.Empty);
            //                Process closeProcess = Process.GetProcessById(closeProcessId);
            //                closeProcess.Kill();
            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("Invalid process ID.");
            //            }
            //            finally
            //            {
            //                Console.WriteLine("Press any key to continue...");
            //                Console.ReadKey();
            //            }
            //            break;
            //        case "0":
            //            return;
            //        default:
            //            Console.WriteLine("Invalid input. Please try again.");
            //            break;
            //    }
            //}




            //// ===== TASK 2 =====
            //Console.WriteLine("Enter range of numbers (e.g., 1-100): ");
            //string inputRange = Console.ReadLine() ?? "1-10";
            //string[] rangeParts = inputRange.Split('-');
            //if (rangeParts.Length != 2 || !int.TryParse(rangeParts[0], out int a) || !int.TryParse(rangeParts[1], out int b) || a > b)
            //{
            //    Console.WriteLine("Invalid range. Using default range 1-10.");
            //    a = 1;
            //    b = 10;
            //}

            //Stopwatch stopwatch = Stopwatch.StartNew();

            //Thread t1 = new Thread(() => FindPrimes(a, b)) { Name = "Primes" };

            //Thread t2 = new Thread(() => FindFibonacci(b)) { Name = "Fibonacci" };

            //Thread t3 = new Thread(() => FindMaxDigitSum(a, b)) { Name = "MaxDigitSum" };

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //t1.Join();
            //t2.Join();
            //t3.Join();

            //Console.WriteLine($"Total execution time: {stopwatch.ElapsedMilliseconds} ms");




            //// ===== TASK 3 =====
            //int n = 50000000;
            //int[] arr = new int[n];
            //Random rnd = new Random();
            //for (int i = 0; i < n; i++)
            //    arr[i] = rnd.Next(-100, 101);

            //Console.Write("Введіть кількість потоків K: ");
            //int k = int.Parse(Console.ReadLine());

            //long[] sums = new long[k];
            //int[] mins = new int[k];
            //int[] maxs = new int[k];
            //long[] evens = new long[k];

            //Thread[] threads = new Thread[k];
            //int size = n / k;

            //Stopwatch sw = Stopwatch.StartNew();

            //for (int i = 0; i < k; i++)
            //{
            //    int start = i * size;
            //    int end;
            //    if (i == k - 1)
            //        end = n;
            //    else
            //        end = start + size;

            //    int index = i;

            //    threads[i] = new Thread(() =>
            //    {
            //        long s = 0;
            //        int mn = int.MaxValue;
            //        int mx = int.MinValue;
            //        long ev = 0;

            //        for (int j = start; j < end; j++)
            //        {
            //            int val = arr[j];
            //            s += val;
            //            if (val < mn) mn = val;
            //            if (val > mx) mx = val;
            //            if (val % 2 == 0) ev++;
            //        }

            //        sums[index] = s;
            //        mins[index] = mn;
            //        maxs[index] = mx;
            //        evens[index] = ev;
            //    });

            //    threads[i].Start();
            //}

            //for (int i = 0; i < k; i++)
            //    threads[i].Join();

            //sw.Stop();

            //long totalSum = 0;
            //int globalMin = int.MaxValue;
            //int globalMax = int.MinValue;
            //long totalEvens = 0;

            //for (int i = 0; i < k; i++)
            //{
            //    totalSum += sums[i];
            //    if (mins[i] < globalMin) globalMin = mins[i];
            //    if (maxs[i] > globalMax) globalMax = maxs[i];
            //    totalEvens += evens[i];
            //}

            //double avg = (double)totalSum / n;

            //Console.WriteLine("\nРезультати для K = " + k + ":");
            //Console.WriteLine("Сума: " + totalSum);
            //Console.WriteLine("Мінімум: " + globalMin);
            //Console.WriteLine("Максимум: " + globalMax);
            //Console.WriteLine("Парних: " + totalEvens);
            //Console.WriteLine("Середнє: " + avg);
            //Console.WriteLine("Час виконання: " + sw.ElapsedMilliseconds + " мс\n");

            //int[] kList = { 1, 2, 4, 8 };
            //Console.WriteLine("Таблиця часу для K = 1, 2, 4, 8:");

            //for (int t = 0; t < kList.Length; t++)
            //{
            //    int currentK = kList[t];
            //    long[] bSums = new long[currentK];
            //    int[] bMins = new int[currentK];
            //    int[] bMaxs = new int[currentK];
            //    long[] bEvens = new long[currentK];
            //    Thread[] bThreads = new Thread[currentK];
            //    int bSize = n / currentK;

            //    Stopwatch bSw = Stopwatch.StartNew();

            //    for (int i = 0; i < currentK; i++)
            //    {
            //        int start = i * bSize;
            //        int end;
            //        if (i == currentK - 1) end = n;
            //        else end = start + bSize;
            //        int index = i;

            //        bThreads[i] = new Thread(() =>
            //        {
            //            long s = 0;
            //            int mn = int.MaxValue;
            //            int mx = int.MinValue;
            //            long ev = 0;

            //            for (int j = start; j < end; j++)
            //            {
            //                int val = arr[j];
            //                s += val;
            //                if (val < mn) mn = val;
            //                if (val > mx) mx = val;
            //                if (val % 2 == 0) ev++;
            //            }

            //            bSums[index] = s;
            //            bMins[index] = mn;
            //            bMaxs[index] = mx;
            //            bEvens[index] = ev;
            //        });

            //        bThreads[i].Start();
            //    }

            //    for (int i = 0; i < currentK; i++)
            //        bThreads[i].Join();

            //    bSw.Stop();
            //    Console.WriteLine("K = " + currentK + " | Час: " + bSw.ElapsedMilliseconds + " мс");
            //}




            //// ===== TASK 4 =====
            //Console.Write("Введіть кількість учасників (від 3 до 8): ");
            //if (!int.TryParse(Console.ReadLine(), out int count) || count < 3 || count > 8)
            //{
            //    Console.WriteLine("Некоректна кількість учасників");
            //    return;
            //}

            //Console.Write("Введіть довжину дистанції (у кроках): ");
            //if (!int.TryParse(Console.ReadLine(), out int distance) || distance <= 0)
            //{
            //    Console.WriteLine("Некоректна довжина дистанції");
            //    return;
            //}

            //Thread[] threads = new Thread[count];
            //long[] finishTimes = new long[count];
            //string[] names = new string[count];
            //int[] progress = new int[count];

            //Random rand = new Random();
            //Stopwatch sw = Stopwatch.StartNew();

            //for (int i = 0; i < count; i++)
            //{
            //    int index = i;
            //    names[i] = $"Учасник {i + 1}";
            //    threads[i] = new Thread(() =>
            //    {
            //        for (int step = 1; step <= distance; step++)
            //        {
            //            progress[index] = step;
            //            Console.WriteLine($"{names[index]}: {step}/{distance}");
            //            Thread.Sleep(rand.Next(50, 301));
            //        }
            //        finishTimes[index] = sw.ElapsedMilliseconds;
            //    });
            //    threads[i].Name = names[i];
            //    threads[i].Start();
            //}

            //Console.WriteLine("\nСтарт!!!\n");

            //while (threads.Any(t => t.IsAlive))
            //{
            //    Console.WriteLine("--- Стан потоків ---");
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.WriteLine($"{names[i]} | State: {threads[i].ThreadState} | IsAlive: {threads[i].IsAlive}");
            //    }
            //    Console.WriteLine();
            //    Thread.Sleep(500);
            //}

            //for (int i = 0; i < count; i++)
            //    threads[i].Join();

            //sw.Stop();

            //int[] sortedIndices = Enumerable.Range(0, count)
            //    .OrderBy(i => finishTimes[i])
            //    .ToArray();

            //Console.WriteLine("\n==============================");
            //Console.WriteLine("     ТАБЛИЦЯ РЕЗУЛЬТАТІВ       ");
            //Console.WriteLine("==============================");
            //for (int rank = 0; rank < count; rank++)
            //{
            //    int idx = sortedIndices[rank];
            //    Console.WriteLine($"{rank + 1} місце: {names[idx]} — час фінішу: {finishTimes[idx]} мс");
            //}
            //Console.WriteLine("==============================");




            // ===== TASK 5 =====

        }

        static void FindPrimes(long a, long b)
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine($"[{name}] Started");

            List<long> primes = new List<long>();
            for (long i = Math.Max(2, a); i <= b; i++)
            {
                if (IsPrime(i)) primes.Add(i);
            }

            Console.WriteLine($"[{name}] finished work");
        }

        static bool IsPrime(long number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            long boundary = (long)Math.Floor(Math.Sqrt(number));
            for (long i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void FindFibonacci(long b)
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine($"[{name}] Started");

            List<long> fibonacci = new List<long>();
            long f0 = 0, f1 = 1;

            if (f0 <= b) fibonacci.Add(f0);
            if (f1 <= b) fibonacci.Add(f1);

            while (true)
            {
                long next = f0 + f1;
                if (next > b || next < 0) break;
                fibonacci.Add(next);
                f0 = f1;
                f1 = next;
            }

            Console.WriteLine($"[{name}] finished work");
        }

        static void FindMaxDigitSum(long a, long b)
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine($"[{name}] Started");

            long numberWithMaxSum = a;
            int maxSum = -1;

            for (long i = a; i <= b; i++)
            {
                int currentSum = GetDigitSum(i);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    numberWithMaxSum = i;
                }
            }

            Console.WriteLine($"[{name}] finished work");
        }

        static int GetDigitSum(long number)
        {
            long n = Math.Abs(number);
            int sum = 0;
            while (n > 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            }
            return sum;
        }
    }
}
