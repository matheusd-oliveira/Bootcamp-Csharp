string textReaderText =
                    "Perguntas de um Operário Letrado" +
                    "Quem construiu Tebas, a das sete portas?" +
                    "Nos livros vem o nome dos reis," +
                    "Mas foram os reis que transportaram as pedras?\n\n" +

                    "Babilónia, tantas vezes destruída," +
                    "Quem outras tantas a reconstruiu? Em que casas" +
                    "Da Lima Dourada moravam seus obreiros?" +

                    "No dia em que ficou pronta a Muralha da China para onde" +
                    "Foram os seus pedreiros? A grande Roma" +
                    "Está cheia de arcos de triunfo. Quem os ergueu? Sobre quem\n\n";


string linha, paragrafo = null;

var sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if (linha != null)
        paragrafo += linha + " ";
    else
    {
        paragrafo += '\n';
        break;
    }

}

