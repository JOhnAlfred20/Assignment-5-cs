using System;

namespace Assignment_5_Cs
{
    internal class Program
    {

        

        static void Main(string[] args)
                    
        {
            Console.WriteLine("Hello World!");
            //Example1();
            //Example2();
            //Example3();
            //Example4();
            Example5();




            //--------------------------------------------------------------------------------   






            #region Question 20 :  Find the sum of all elements of the array
            ////
            //Console.Write("Enter the number of elements in the array: ");
            //int arraySize = int.Parse(Console.ReadLine());
            //int[] arr = new int[arraySize];
            //int sum = 0;

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arraySize; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}

            //Console.WriteLine("The sum of all elements is: " + sum);
            #endregion











            //// --------------------------------------------------------------------------------
            #region Question 21 : Write a program in C# Sharp to merge two arrays
            ////
            //// قراءة المصفوفة الأولى
            //Console.Write("Enter the number of elements in the first array: ");
            //int size1 = int.Parse(Console.ReadLine());
            //int[] array1 = new int[size1];
            //Console.WriteLine("Enter the elements of the first array (sorted in ascending order): ");
            //for (int index1 = 0; index1 < size1; index1++)
            //{
            //    array1[index1] = int.Parse(Console.ReadLine());
            //}

            //// قراءة المصفوفة الثانية
            //Console.Write("Enter the number of elements in the second array: ");
            //int size2 = int.Parse(Console.ReadLine());
            //int[] array2 = new int[size2];
            //Console.WriteLine("Enter the elements of the second array (sorted in ascending order): ");
            //for (int index2 = 0; index2 < size2; index2++)
            //{
            //    array2[index2] = int.Parse(Console.ReadLine());
            //}

            //// دمج المصفوفات
            //int[] mergedArray = new int[size1 + size2];
            //int i1 = 0, i2 = 0, mergedIndex = 0;

            //// دمج المصفوفات عن طريق مقارنة العناصر واحدة واحدة
            //while (i1 < size1 && i2 < size2)
            //{
            //    if (array1[i1] < array2[i2])
            //    {
            //        mergedArray[mergedIndex++] = array1[i1++];
            //    }
            //    else
            //    {
            //        mergedArray[mergedIndex++] = array2[i2++];
            //    }
            //}

            //// لو في عناصر متبقية في المصفوفة الأولى
            //while (i1 < size1)
            //{
            //    mergedArray[mergedIndex++] = array1[i1++];
            //}

            //// لو في عناصر متبقية في المصفوفة الثانية
            //while (i2 < size2)
            //{
            //    mergedArray[mergedIndex++] = array2[i2++];
            //}

            //// طباعة المصفوفة المدموجة
            //Console.WriteLine("The merged array is: ");
            //foreach (int item in mergedArray)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine(); // إضافة سطر جديد بعد طباعة المصفوفة المدموجة.
            #endregion




            //// --------------------------------------------------------------------------------




            #region Question 22 : Write a program in C# Sharp to count the frequency of each element of an array.
            ////
            //// طلب عدد العناصر في المصفوفة
            //Console.Write("Enter the number of elements in the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //// طلب إدخال العناصر
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //// حساب التكرار لكل عنصر بدون استخدام Dictionary
            //for (int i = 0; i < size; i++)
            //{
            //    int count = 1;
            //    // التأكد من إن العنصر مش اتحسب قبل كده
            //    if (array[i] != -1) // إحنا بنستخدم -1 كعلامة للعنصر اللي اتحسب
            //    {
            //        for (int j = i + 1; j < size; j++)
            //        {
            //            if (array[i] == array[j])
            //            {
            //                count++;
            //                array[j] = -1; // وضع علامة على العنصر عشان مايحسبش تاني
            //            }
            //        }
            //        Console.WriteLine($"Element {array[i]} occurs {count} time(s)");
            //    }
            //}
            #endregion






            //// --------------------------------------------------------------------------------




            #region Question 23 : Write a program in C# Sharp to find maximum and minimum element in an array.
            ////
            //// طلب عدد العناصر في المصفوفة
            //Console.Write("Enter the number of elements in the array: ");
            //int array_Size = int.Parse(Console.ReadLine());  // تم تغيير الاسم هنا

            //int[] numbersArray = new int[array_Size];  // تغيير الاسم هنا إلى numbersArray

            //// طلب إدخال العناصر
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < array_Size; i++)  // استخدمنا الاسم الجديد هنا
            //{
            //    numbersArray[i] = int.Parse(Console.ReadLine());  // استخدمنا الاسم الجديد هنا
            //}

            //// إيجاد أكبر وأصغر عنصر في المصفوفة
            //int max = numbersArray[0];  // استخدمنا الاسم الجديد هنا
            //int min = numbersArray[0];  // استخدمنا الاسم الجديد هنا

            //for (int i = 1; i < array_Size; i++)  // استخدمنا الاسم الجديد هنا
            //{
            //    if (numbersArray[i] > max)
            //    {
            //        max = numbersArray[i];
            //    }
            //    if (numbersArray[i] < min)
            //    {
            //        min = numbersArray[i];
            //    }
            //}

            //// طباعة النتيجة
            //Console.WriteLine("The maximum element is: " + max);
            //Console.WriteLine("The minimum element is: " + min);
            #endregion





            // --------------------------------------------------------------------------------
            #region Question 24: Write a program to find the second largest element in an array.

            //
            //Console.Write("Enter the number of elements in the array: ");
            //int arraySize = int.Parse(Console.ReadLine());
            //int[] array = new int[arraySize];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arraySize; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int firstMax = int.MinValue;
            //int secondMax = int.MinValue;

            //for (int i = 0; i < arraySize; i++)
            //{
            //    if (array[i] > firstMax)
            //    {
            //        secondMax = firstMax;
            //        firstMax = array[i];
            //    }
            //    else if (array[i] > secondMax && array[i] != firstMax)
            //    {
            //        secondMax = array[i];
            //    }
            //}

            //Console.WriteLine("The second largest element is: " + secondMax);
            #endregion









            // --------------------------------------------------------------------------------
            #region Question 25: Find the longest distance between two equal cells in an array.
            ////
            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] values = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    values[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (values[i] == values[j])
            //        {
            //            int distance = j - i - 1;
            //            maxDistance = Math.Max(maxDistance, distance);
            //        }
            //    }
            //}

            //Console.WriteLine("The longest distance between two equal cells is: " + maxDistance);
            #endregion







            // --------------------------------------------------------------------------------
            #region Question 26: Reverse the order of words in a list.
            //
            //Console.Write("Enter a list of space-separated words: ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');

            //Array.Reverse(words);

            //Console.WriteLine("Reversed order of words: ");
            //foreach (string word in words)
            //{
            //    Console.Write(word + " ");
            //}
            //Console.WriteLine();
            #endregion






            // --------------------------------------------------------------------------------
            #region Question 27: Create two multidimensional arrays of the same size, copy elements and print.
            //
            //Console.Write("Enter the number of rows and columns for the multidimensional arrays: ");
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());

            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Copy elements from firstArray to secondArray
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            // Print secondArray
            //Console.WriteLine("The second array is:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion







            // --------------------------------------------------------------------------------
            #region Question 28: Print a One Dimensional Array in Reverse Order.
            //
            //Console.Write("Enter the number of elements in the array: ");
            //int arraySize2 = int.Parse(Console.ReadLine());
            //int[] array2 = new int[arraySize2];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arraySize2; i++)
            //{
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("The array in reverse order:");
            //for (int i = arraySize2 - 1; i >= 0; i--)
            //{
            //    Console.Write(array2[i] + " ");
            //}
            //Console.WriteLine();
            #endregion



















            // --------------------------------------------------------------------------------
            #region Function 1: Explain the difference between passing by value and by reference.



            //// Example of passing by value:
            //static void ModifyByValue(int value)
            //{
            //    value = 140; // تعديل نسخة المتغير
            //}

            //// Example of passing by reference:
            //static void ModifyByReference(ref int value)
            //{
            //    value = 140; // تعديل القيمة الأصلية
            //}

            //static void Example1()
            //{
            //    int num = 70;
            //    Console.WriteLine("Original value: " + num);

            //    ModifyByValue(num);
            //    Console.WriteLine("After ModifyByValue: " + num);

            //    ModifyByReference(ref num);
            //    Console.WriteLine("After ModifyByReference: " + num);
            //}
            #endregion

            //-------------------------------------------------

            #region Function 2: Sum of Digits

            // This function calculates the sum of the individual digits of a given number.
            //static int SumOfDigits(int number)
            //{
            //    int sum = 0;
            //    while (number > 0)
            //    {
            //        sum += number % 10; // استخراج الرقم الأخير وإضافته
            //        number /= 10; // إزالة الرقم الأخير
            //    }
            //    return sum;
            //}

            //static void Example2()
            //{
            //    Console.Write("Enter a number: ");
            //    int sumNum = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"The sum of the digits of the number {sumNum} is: {SumOfDigits(sumNum)}");
            //}
            #endregion

            ////-------------------------------------------------

            #region Function 3: Check if a Number is Prime


            //static bool IsPrime(int number)
            //{
            //    if (number < 2)
            //        return false;

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }
            //    return true;
            //}

            //static void Example3()
            //{
            //    Console.Write("Enter a number: ");
            //    int primeNum = int.Parse(Console.ReadLine());
            //    Console.WriteLine(IsPrime(primeNum) ? "The number is prime." : "The number is not prime.");
            //}
            #endregion

            ////-------------------------------------------------

            #region Function 4: Calculate Factorial
            //دا المضروب بتاع الرقم اللي هيدخل 
            //static long Factorial(int number)
            //{
            //    long result = 1;
            //    for (int i = 1; i <= number; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;
            //}

            //static void Example4()
            //{
            //    Console.Write("Enter a number: ");
            //    int factNum = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Factorial of {factNum} is: {Factorial(factNum)}");
            //}
            #endregion

            ////-------------------------------------------------

            #region Function 5: Change Character in String


            static string ChangeChar(string input, int position, char newChar)
            {
                if (position < 0 || position >= input.Length)
                    throw new ArgumentOutOfRangeException("Position is out of range.");

                char[] chars = input.ToCharArray();
                chars[position] = newChar;
                return new string(chars);
            }

            static void Example5()
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                Console.Write("Enter position to modify (0-number of charachters): ");
                int position = int.Parse(Console.ReadLine());

                Console.Write("Enter the new character: ");
                char newChar = Console.ReadLine()[0];

                try
                {
                    string result = ChangeChar(input, position, newChar);
                    Console.WriteLine($"Modified string: {result}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            #endregion
        }
    }
}
