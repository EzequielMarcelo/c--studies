var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var filePath = Path.Combine(docPath, "Projects\\Studies\\C#\\uncomplicating-the-csharp\\1 - How to read files\\text-file.txt");


//read part of the file
//recommended for large files
Console.WriteLine("\n==== StreamReader ====");
using var file = new StreamReader(filePath);
string? line;

while ((line = file.ReadLine()) != null)
    Console.WriteLine(line);

file.Close();