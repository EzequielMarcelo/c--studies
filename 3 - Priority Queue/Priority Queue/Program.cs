var queue = new PriorityQueue<string, int>();

queue.Enqueue("Item 1", 0);
queue.Enqueue("Item 2", 4);
queue.Enqueue("Item 3", 2);
queue.Enqueue("Item 4", 1);

while(queue.TryDequeue(out string? item, out int priority))
    Console.WriteLine($"Item: {item} Priority: {priority}");