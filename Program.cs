Console.Clear();
Console.WriteLine("=== Forca ===");

string secretWord, letter;

do
{
    Console.Write("Qual a palavra secreta?: ");
    secretWord = Console.ReadLine()!;
    Console.Write("Qual a letra?: ");
    letter = Console.ReadLine()!;
    if (string.IsNullOrEmpty(secretWord) || string.IsNullOrEmpty(letter.ToString()))
    {
        Console.Write("Por favor digite algo válido!");
        Thread.Sleep(1000);
        Console.Clear();
    }
    else if (!secretWord.Any(char.IsLetter) || !letter.Any(char.IsLetter))
    {
        Console.Write("Por favor insira apenas letras!");
        Thread.Sleep(1000);
        Console.Clear();
    }
} while (string.IsNullOrEmpty(secretWord) || !secretWord.Any(char.IsLetter) || string.IsNullOrEmpty(letter) || !letter.Any(char.IsLetter));

bool containsLetter = secretWord.Contains(letter);
string containsLetterResult = containsLetter ? "Verdadeiro" : "Falso";
Console.WriteLine($"A letra \"{letter}\" existe na palavra secreta? => {containsLetterResult}");
Console.WriteLine("=============");