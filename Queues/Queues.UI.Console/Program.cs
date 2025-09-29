using QueueArray;

var queue = new QueueUsingArray<int>(5);
var option = "0";
do
{
    option = Menu();
    switch (option)
    {
        case "1":
            try
            {
                Console.WriteLine("Enter a number");
                var number = int.Parse(Console.ReadLine()!);
                queue.Enqueue(number);
                break;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "2":
            try
            {
                var item = queue.Dequeue();
                Console.WriteLine($"Item dequeued: {item}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "3":
            try
            {
                Console.WriteLine($"Item in peak: {queue.Peek()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Enqueue");
    Console.WriteLine("2. Dequeue");
    Console.WriteLine("3. Peek");
    Console.WriteLine("0. Exit");
    Console.WriteLine("Choose your option: ");
    return Console.ReadLine()!;
}