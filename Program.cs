namespace priorityQueueArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue e = new Queue();
            e.enqueue(10, 2);
            e.enqueue(20, 3);
            e.enqueue(30, 3);
            e.enqueue(45, 4);
            e.enqueue(10, 4);
            e.enqueue(20, 5);

            int iPos = e.peek();
            Console.WriteLine(e.pr[iPos].value);
        }
    }
}
