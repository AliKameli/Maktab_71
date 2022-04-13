var sourceFilePath = "file.txt";
var endFilePath = "Archive/" + sourceFilePath;
try
{
    File.Copy(sourceFilePath, endFilePath);
}
catch (FileNotFoundException a)
{
    Console.WriteLine("File Peyda Nashod");
}
catch (DirectoryNotFoundException b)
{
    Console.WriteLine("Poshe Maghsad Vojood nadarad");
}
catch (IOException c)
{
    Console.WriteLine("file vojood dashte");
}
catch (UnauthorizedAccessException d)
catch (Exception e)
{
    Console.WriteLine(e);
}
Console.ReadKey();