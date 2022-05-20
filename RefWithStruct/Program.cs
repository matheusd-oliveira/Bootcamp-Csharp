using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Matheus";
p1.Idade = 21;
p1.EnderecoPessoa = new Endereco(){

    Logradouro = "Rua teste",
    CEP = "000000",
    Cidade = "Feira de Santana",
    Numero = 300,
};

WriteLine("Fim");
