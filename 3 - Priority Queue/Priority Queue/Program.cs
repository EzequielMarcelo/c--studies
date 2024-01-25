using Priority_Queue;

var queue = new PriorityQueue<Student, string>(new RoleComparer());


queue.Enqueue(new Student("Zezin"), "student");
queue.Enqueue(new Student("Tiao"),  "premium");
queue.Enqueue(new Student("Junin"), "admin");

while (queue.TryDequeue(out Student? item, out string? priority))
    Console.WriteLine($"Item: {item.name} Priority: {priority}");

public record Student(string name);