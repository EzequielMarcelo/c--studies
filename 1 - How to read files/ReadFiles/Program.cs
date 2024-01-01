var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var filePath = Path.Combine(docPath, "Projects\\Studies\\C#\\uncomplicating-the-csharp\\1 - How to read files\\text-file.txt");

var allText = File.ReadAllText(filePath);
Console.WriteLine("==== Read AllText ====");
Console.WriteLine(allText);

