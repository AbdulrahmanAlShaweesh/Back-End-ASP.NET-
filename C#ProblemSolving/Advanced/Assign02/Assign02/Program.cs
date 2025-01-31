using System.Collections;

namespace Assign02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            ArrayList arr = new ArrayList() { 11, 5, 3 };

            Console.WriteLine(CountGreater(arr , 1));   // 3

            Console.WriteLine(CountGreater(arr, 5));    // 1

            Console.WriteLine(CountGreater(arr , 13));  // 0
            #endregion
            Console.WriteLine($"{new string('*', 40)}");
            #region Question 02  
            Console.WriteLine($"{IsPalindrome(new List<int>() { 1 , 3 , 2 , 3 , 1})}"); // True 
            Console.WriteLine($"{IsPalindrome(new List<int>() { 1 , 3 , 2 , 3 , 2})}"); // False
            #endregion
            Console.WriteLine($"{new string('*', 40)}");
            #region Question 03 
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            Console.WriteLine($"Orignal Queue");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            ReverseQueue(queue);

            Console.WriteLine("Reverse Queue");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
            #endregion
            Console.WriteLine($"{new string('*', 40)}");
            #region Question 04 
            Console.WriteLine(IsBalanced("{[]()}"));
            #endregion
            Console.WriteLine($"{new string('*', 40)}");
            #region Question 05 
            List<int> result = RemoveDuplicate(new List<int>() { 1, 2, 3, 4, 3, 2, 5, 1 });
            foreach (int i in result)
            {
                Console.Write($"{i}, ");
            }
            #endregion
            Console.WriteLine($"\n{new string('*', 40)}");
            #region Question 06 
            Queue<object> queues = new Queue<object>();

            QueueAcceDiffDataTypes(queues, 23);
            QueueAcceDiffDataTypes(queues, "C#");
            QueueAcceDiffDataTypes(queues, 199);
            QueueAcceDiffDataTypes(queues, "Python");
            foreach(var i in queues)
            {
                Console.Write($"{i}, ");
            }
            #endregion
            Console.WriteLine($"\n{new string('*', 40)}");
            #region Question 08 : 
            Stack<int> stack = new Stack<int>();
            stack.Push(12);
            stack.Push(1);
            stack.Push(2);
            stack.Push(4);
            stack.Push(15);
            stack.Push(23);
            stack.Push(44);
            stack.Push(19);
            Console.Write("Enter the target value? ");
            bool Flag = int.TryParse(Console.ReadLine(), out int value);
            findTargetValue(stack, value);
            #endregion
            Console.WriteLine($"\n{new string('*', 40)}");
            #region Question 09 
            int[] arr01 = { 1, 2, 3, 4, 5, 6 };
            int[] arr02 = { 1, 2, 6, 7, 8, 6 };
            int[] inters = intersectionOfTwoArraies(arr01 , arr02);
            foreach(int item in  inters)
            {
                Console.Write($"{item} ");
            }
            #endregion
            Console.WriteLine($"\n{new string('*', 40)}");
            #region Question 10 
            List<int> arr03 = new List<int> { 1, 2, 3, 7, 5 };
            int target = 12;
            List<int> result01 = FindOfSum(arr03, target);

            if (result.Count > 0)
            {
                Console.WriteLine("Sublist with sum " + target + ": [" + string.Join(", ", result) + "]");
            }
            else
            {
                Console.WriteLine("No sublist found with sum " + target);
            }
            #endregion
            #region Question 11
            Queue<int> queue01 = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            int k = 3;

            Queue<int> result03 = ReverseFirstKElement(queue01, k);

            Console.WriteLine("Resulting Queue: [" + string.Join(", ", result03) + "]");

            #endregion
        }

        #region Question 01 : Numbers of element that greater than X
        public static int CountGreater(ArrayList lst, int x)
        {

            lst.Sort();

            int index = lst.BinarySearch(x);

            if (index < 0)
            {
                index = ~index;
            }
            else
            {
                index++;
            }

            return lst.Count - index;
        }
        #endregion

        #region Question 02 : check if the array is IsPalindrome
        public static bool IsPalindrome(List<int> lst)
        {
            int startIndex = 0;
            int endIndex = lst.Count - 1;

            while (startIndex < endIndex)
            {
                if(lst[startIndex] != lst[endIndex])
                {
                    return false;
                }
                startIndex++;
                endIndex--;
            }

            return true;
        }
        #endregion

        #region Question 03 :  Reverse element of queue using stack
        public static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        #endregion

        #region Question 04 : check if parantheses is balanced
        static bool IsBalanced(string str)
        {
            
            Stack<char> stack = new Stack<char>();

            
            foreach (char ch in str)
            {
                
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                 
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    
                    char top = stack.Pop();
                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            
            return stack.Count == 0;
        }
        #endregion

        #region Question 05 : remove duplicate element
        public static List<int> RemoveDuplicate(List<int> list) {

            HashSet<int> result = new HashSet<int>();

            foreach (int item in list)
            {
                result.Add(item);
            }

            return new List<int>(result).ToList();
        }
        #endregion

        #region Question 07 : Queue accessbte diff data types
        public static void QueueAcceDiffDataTypes<T>(Queue<object> queue, T item)
        {
            queue.Enqueue(item!);
        }
        #endregion
        
        #region Question 08 : Find Target of a given number 
        public static void findTargetValue(Stack<int> Stack ,int target)
        {
             

            int counter = 0;
            bool Flag = false;

            foreach (int item in Stack)
            {
                counter++;
                if(item == target)
                {
                    Flag = true;
                    break;
                }
            }

            if(Flag)
            {
                Console.WriteLine($"The Target was found after checking {counter} elements");
            }else
            {
                Console.WriteLine("The taget was not found");
            }
        }


        #endregion

        #region Question 09 : Find Intersection Of two arraies 
        public static int[] intersectionOfTwoArraies(int[] numbers01 , int[] number02)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            
            foreach(var item in numbers01)
            {
                if(count.ContainsKey(item))
                {
                    count[item]++;
                }else
                {
                    count[item] = 1;
                }
            }
            List<int> result = new List<int>();
            foreach(var num in number02)
            {
                if (count.ContainsKey(num) && count[num] > 0)
                {
                    result.Add(num);
                    count[num]--;
                }
            }

            return result.ToArray();
        }
        #endregion

        #region Question 10 : Find sum of list 
        public static List<int> FindOfSum(List<int> lst, int target)
        {
            int start = 0, currentSum = 0;

            // Loop through the array with the 'end' pointer
            for (int end = 0; end < lst.Count; end++)
            {
                // Add the current element to the current sum
                currentSum += lst[end];

                // If the current sum exceeds the target, shrink the window by moving 'start'
                while (currentSum > target && start < end)
                {
                    currentSum -= lst[start];
                    start++;
                }

                // If we find a sum equal to the target, return the sublist
                if (currentSum == target)
                {
                    return lst.GetRange(start, end - start + 1);
                }
            }
            return new List<int>();
        }
        #endregion

        #region Question 11 : Reverse element of queue 
        public static Queue<int> ReverseFirstKElement(Queue<int> queue , int k)
        {
            if (k > queue.Count)
            {
                return queue;
            }

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue;
        }
        #endregion

    }
}
