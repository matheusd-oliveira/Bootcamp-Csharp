using static System.Console;

CriarCsv();
WriteLine("\n\nPressione [ENTER] para finalizar...");
ReadLine();


static void CriarCsv()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Saida");

    var pessoas = new List<Pessoa>();

    var thegas = new Pessoa(
        "Matheus",
        "matheus@gmail.com",
        123456,
        new DateOnly(year: 2000, month: 8, day: 6)
    );

    var felipe = new Pessoa(
        "Felipe",
        "felipe@gmail.com",
        3213123,
        new DateOnly(year: 1993, month: 8, day: 10)
);

    var davi = new Pessoa(
        "Davi",
        "davi@gmail.com",
        76564,
        new DateOnly(year: 2000, month: 2, day: 14)
    );

    var jeiel = new Pessoa(
        "Jeiel",
        "jeiel@gmail.com",
        5653334,
        new DateOnly(year: 1998, month: 5, day: 5)
    );

    pessoas.Add(thegas);
    pessoas.Add(felipe);
    pessoas.Add(davi);
    pessoas.Add(jeiel);

    var diretorioInfo = new DirectoryInfo(path);
    if (!diretorioInfo.Exists)
    {
        diretorioInfo.Create();
        path = Path.Combine(path, "usuarios.csv");
    }

    using var sw = new StreamWriter(path);
    sw.WriteLine("nome, email, telefone, nascimento");
    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }



}


static void LerCsv()

{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "usuarios-exportacao.csv");

    if (File.Exists(path))
    {
        using var sr = new StreamReader(path);
        var cabecalho = sr.ReadLine()?.Split(',');

        while (true)
        {
            var registro = sr.ReadLine()?.Split(',');
            if (registro == null)
                break;
            if (cabecalho.Length != registro.Length)
            {
                WriteLine("Arquivo fora do padrão.");
                break;
            }
            for (int i = 0; i < registro.Length; i++)
            {
                WriteLine($"{cabecalho?[i]}: {registro[i]}");
            }
            WriteLine("---------------");
        }
    }
    else
        WriteLine($"O arquivo {path} não existe");


}


class Pessoa
{
    public string Nome { get; set; }

    public string Email { get; set; }

    public int Telefone { get; set; }

    public DateOnly Nascimento { get; set; }


    public Pessoa(string nome, string email, int telefone, DateOnly nascimento)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Nascimento = nascimento;
    }
}