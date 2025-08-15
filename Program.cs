using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace solv_assignment_linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task in session
            //var names = new List<string> { "Ahmed", "Youssef", "Mohamed", "Sara", "Omar", "Samir" };
            // var numbers = new List<int> { 10, 2, 3, 7, 15, 22, 5, 6, 30 };
            /*فلترة(Filtration): 
             * استخراج الأسماء التي تبدأ بحرف S.
             * استخراج الأرقام الأكبر من 10. */

            //var namesStartingWidth=names.Where(name=>name.StartsWith("S")).ToList();

            //foreach (var name in namesStartingWidth)
            //{
            //    Console.WriteLine(name);
            //}

            //var NumbersGraterThan10=numbers.Where(n=>n>10).ToList();

            //foreach(var number in NumbersGraterThan10)
            //    Console.WriteLine(number);
            /*(Element):
             * عرض أول اسم في القائمة.
             * اعرض اخر رقم في قائمه الارقام 
             * اعرض اول رقم اكبر ممن 20 او -1 اذا لم يوجد */
            //var firstName=names.FirstOrDefault();

            //var lastName=names.LastOrDefault();

            //var FirstGraterThan20 = numbers.FirstOrDefault(n => n > 20);
            //if(FirstGraterThan20 == 0)
            //{
            //    FirstGraterThan20 = -1;
            //}
            /* Casting 
             * • حوّل قائمة ArrayList فيها أرقام int) mixed types و double) لقائمة أرقام double باستخدام Cast أو OfType. مثال بيانات: ArrayList mixedNumbers - new ArrayList() { 1, 2.5, 3, 4.75, 5 ); */
            //ArrayList mixedNumbers = new ArrayList { 1, 2.5, 3, 4.75, 5 };
            //var CastedNumbers = mixedNumbers.OfType<double>().ToList();

            /*Generation
             *أنشى قائمة من أول 5 أعداد زوجية باستخدام Enumerable.Range أو Repeat.*/
            //var evenNumbers=Enumerable.Range(1,10).
            //   Where(n=>n%2==0).Take(5).ToList();

            /*  Ordering
             *  رتب الأسماء تصاعديا
             *  رتب الأرقام تنازلة
             */
            //var sortedNames = names.OrderBy(name => name).ToList();
            //foreach ( var name in sortedNames) 
            //    Console.WriteLine(name);

            //var sortedNumbersDescending = numbers.OrderByDescending(n => n).ToList();
            //foreach (var n in sortedNumbersDescending) 
            //     Console.WriteLine(n);
            #endregion

            #region Solv Assignment linq2
            var products = ListGenerator.ProductsList;
            var customers = ListGenerator.CustomersList;
            var dictionary = File.ReadAllLines("dictionary_english.txt");
            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock    
            // var firstOutOfStock = products.FirstOrDefault(p => p.UnitsInStock == 0);
            // Console.WriteLine($"First out of stock: {firstOutOfStock}");
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            // var expensiveProduct = products.FirstOrDefault(p => p.UnitPrice > 1000);
            //if (expensiveProduct != null)
            //     Console.WriteLine($"First price > 1000: {expensiveProduct.ProductName} - {expensiveProduct.UnitPrice}");
            // else
            //     Console.WriteLine("First price > 1000: null");

            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondGreaterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine($"Second > 5: {secondGreaterThan5}");
            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine($"Odd count: {oddCount}");

            #endregion
            #region 2.Return a list of customers and how many orders each has.
            //var custOrdersCount = customers.Select(c => new
            //{
            //    c.CustomerName,
            //    OrdersCount = c.Orders.Length
            //});
            //foreach (var c in custOrdersCount)
            //    Console.WriteLine($"{c.CustomerName} - {c.OrdersCount} orders");
            #endregion
            #region 3. Return a list of categories and how many products each has
            //var catProdCount = products.GroupBy(p => p.Category)
            //                      .Select(g => new { Category = g.Key, Count = g.Count() });
            //foreach (var cat in catProdCount)
            //    Console.WriteLine($"{cat.Category} - {cat.Count}");
            #endregion
            #region 4. Get the total of the numbers in an array. 
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var totalArr = Arr.Sum();
            // Console.WriteLine($"Sum of array: {totalArr}");
            #endregion
            // string[] dictWords = File.ReadAllLines("dictionary_english.txt");
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            // Console.WriteLine($"Total chars: {dictWords.Sum(w => w.Length)}");
            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //  Console.WriteLine($"Shortest word length: {dictWords.Min(w => w.Length)}");
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            // Console.WriteLine($"Longest word length: {dictWords.Max(w => w.Length)}");
            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            // Console.WriteLine($"Average word length: {dictWords.Average(w => w.Length):F2}");
            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //  var sortedByName = products.OrderBy(p => p.ProductName);
            #endregion
            #region 2.Uses a custom comparer to do a case -insensitive sort of the words in an array. 
            // string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // var caseInsensitive = arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            // var stockDesc = products.OrderByDescending(p => p.UnitsInStock);
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // var sortDigits = digitNames.OrderBy(w => w.Length).ThenBy(w => w);
            #endregion
            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            // String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            //var lengthCase = Arr.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            // var catPriceDesc = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            #endregion
            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            // String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var lengthCaseDesc = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array. 
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
           // var secondLetterI = Arr.Where(w => w.Length > 1 && w[1] == 'i').Reverse();

            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            // var prodNames = products.Select(p => p.ProductName);
            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            // string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            // var upperLower = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type. 
            // var prodWithPrice = products.Select(p => new { p.ProductName, Price = p.UnitPrice });
            #endregion
            #region 4. Determine if the value of int in an array matches their position in the array.
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var matchesPos = Arr.Select((n, i) => new { Number = n, Index = i, Match = (n == i) });
            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB. 
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { a, b };
            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            //var smallOrders = customers.SelectMany(c => c.Orders)
            //                    .Where(o => o.Total < 500);
            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.
            //var orders1998 = customers.SelectMany(c => c.Orders)
            //                      .Where(o => o.OrderDate.Year >= 1998);

            #endregion
            #endregion
            #endregion

        }
    }
}
