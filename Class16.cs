using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringmanipulationex1
{
    class Class16
    {
        public static void Main(string[] args)
        {
            var originalString = "Ram is a good boy";

            Console.WriteLine($"Original String: {originalString}");

            Console.WriteLine($"\nReversed string: {ReverseString(originalString)}");
            Console.WriteLine($"\nWith the order of the words reversed: \n{ReversedOrderOfWordsInAString(originalString)}");
            Console.WriteLine($"\nWith each word reversed: \n{ReverseWordsInAString(originalString)}");

            Console.WriteLine();
            Console.ReadKey();

        }

        static string ReverseString(string source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            var len = GetLength(source);

            if (len == 0) return source;

            var target = new char[len];

            for (int start = 0, end = len - 1; start <= end; start++, end--)
            {
                target[end] = source[start];
                target[start] = source[end];
            }

            return new String(target);
        }

        private static int GetLength(string source)
        {
            var len = 0;

            while (true)
            {
                try
                {
                    var temp = source[len++];
                }
                catch (IndexOutOfRangeException e)
                {
                    len--;
                    break;
                }
            }

            return len;
        }

        static string ReversedOrderOfWordsInAString(string source)
        {
            return string.Concat(GetWordsInReverseOrder(source));
        }

        static IEnumerable<string> GetWordsInReverseOrder(string source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            int len = GetLength(source);

            if (len == 0)
            {
                yield return source;
                yield break;
            }

            var stack = new Stack<string>();
            int wordStart = 0, wordEnd = 0;

            for (int i = 0; i < len; i++)
            {
                if (WordBoundaries.Contains(source[i]))
                {
                    if (wordEnd > 0)
                    {
                        // Push the previous word into the stack
                        var previousWord = new char[wordEnd - wordStart + 1];

                        for (int j = 0; j <= wordEnd - wordStart; j++)
                        {
                            previousWord[j] = source[j + wordStart];
                        }

                        stack.Push(new String(previousWord));
                    }

                    stack.Push(source[i].ToString());
                    wordStart = i + 1;
                    wordEnd = wordStart;
                }
                else
                {
                    wordEnd = i;
                }
            }

            if (stack.Count == 0)
            {
                yield return source;
                yield break;
            }
            else
            {
                while (stack.Count > 0)
                    yield return stack.Pop();
            }
        }

        static string ReverseWordsInAString(string source)
        {
            return string.Concat(GetStringWithEachWordReversed(source, ReverseString));
        }

        static IEnumerable<string> GetStringWithEachWordReversed(string source,
            Func<string, string> reverser)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            int len = GetLength(source);

            if (len == 0)
            {
                yield return source;
                yield break;
            }

            var queue = new Queue<string>();
            int wordStart = 0, wordEnd = 0;

            for (int i = 0; i < len; i++)
            {
                if (WordBoundaries.Contains(source[i]))
                {
                    if (wordEnd > 0)
                    {
                        // Push the previous word into the stack
                        var previousWord = new char[wordEnd - wordStart + 1];

                        for (int j = 0; j <= wordEnd - wordStart; j++)
                        {
                            previousWord[j] = source[j + wordStart];
                        }

                        queue.Enqueue(new String(previousWord));
                    }

                    queue.Enqueue(source[i].ToString());
                    wordStart = i + 1;
                    wordEnd = wordStart;
                }
                else
                {
                    wordEnd = i;
                }
            }

            if (queue.Count == 0)
            {
                yield return source;
                yield break;
            }
            else
            {
                while (queue.Count > 0)
                    yield return reverser(queue.Dequeue());
            }
        }
    }

    static class WordBoundaries
    {
        private static List<char> _list;

        static WordBoundaries()
        {
            _list = new List<char>("., !-?");
        }

        public static void Add(char c)
        {
            if (!_list.Contains(c))
                _list.Add(c);
        }

        public static void Remove(char c)
        {
            _list.Remove(c);
        }

        public static void Redefine(IEnumerable<char> coll)
        {
            if (coll == null)
                throw new ArgumentNullException("coll");

            _list = new List<char>(coll);
        }

        public static bool Contains(char c)
        {
            return _list.Contains(c);
        }
    }
}
