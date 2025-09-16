string[] palavras = new string[10] {
    "maçã",
    "banana",
    "laranja",
    "uva",
    "melancia",
    "abacaxi",
    "manga",
    "pera",
    "morango",
    "caju"
};

string forca = "";
string aleatorio()
{
    Random rnd = new Random();
    int indice = rnd.Next(palavras.Length);
    string forca = palavras[indice];
    return forca;
}
;

string sorteio = aleatorio();
int qtd = sorteio.Length * 2;


string underline()
{
    for (int i = 0; i < sorteio.Length; i++)
    {

        Console.Write("_");
    }
    return sorteio;
}
string letra = "";
string chutes()
{
    underline();
    for (int i = 0; i < qtd; i++)
    {
        Console.WriteLine();
        Console.WriteLine("Digite uma letra");
        String letra = Console.ReadLine();

        for (int j = 0; j < forca.Length; j++)
        {
            char[] letras = sorteio.ToArray();
            bool temLetra = sorteio.Contains(letra);
            if (temLetra = true)
            {

            };
        };
    };
    return letra;
}
;

chutes();


