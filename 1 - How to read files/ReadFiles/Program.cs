var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var filePath = Path.Combine(docPath, "Projects\\Studies\\C#\\uncomplicating-the-csharp\\1 - How to read files\\text-file.txt");


Console.WriteLine("\n==== Read AllLines ====");
var lines = File.ReadAllLines(filePath);
int count = 0;
foreach (var line in lines)
{
    count++;
    Console.WriteLine($"Line: {count} - {line}");
}