
const string path = @"C:\wamp64\www\.Net\Section_10\Exofichiers\data";

string? saisie = " ";
while (string.IsNullOrWhiteSpace(saisie))
{
    System.Console.WriteLine("Veuillez saisir votre nom et votre prénom");
    saisie = Console.ReadLine();
}

if(!Directory.Exists(path)){
    Directory.CreateDirectory(path);
}

if(!File.Exists($"{path}\\identite.txt"))
{
    File.Create($"{path}\\identite.txt");
}    

var text = File.ReadAllText($"{path}\\identite.txt");
// var bytes = File.ReadAllBytes(@"C:\wamp64\www\.Net\Section_10\Exofichiers\data\identite.bin");

if(!saisie.Equals(text, StringComparison.OrdinalIgnoreCase))
    {
        File.WriteAllText($"{path}\\identite.txt", saisie); 
    }





