using static System.Console;
using System;

public class OperacoesArray
{


    public void OrdenarBubbleSort(ref int[] array)
    {   
        int maior = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if(array[j] > array[j + 1]){
                    maior = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = maior;
                }
            }
        }
    }
    public void ImprimirArray(int[] array)
    {   
        var linha = string.Join(", ", array);
        WriteLine(linha);
        // for (int i = 0; i < array.Length; i++)
        // {
        //     WriteLine(array[i]);
        // }
    }

    public void Ordenar(ref int[] array){
        Array.Sort(array);
    }

    public void Copiar(ref int[] array, ref int[] arrayDestino){
        Array.Copy(array, arrayDestino, array.Length);
    }

    public bool Existe(int[] array, int valor){
        return Array.Exists(array, elemento => elemento == valor);
    }

    public bool TodosMaiorQue(int[] array, int valor){
        return Array.TrueForAll(array, elemento => elemento > valor);
    }

    public int ObterValor(int[] array, int valor){
        return Array.Find(array, element => element == valor);
    }

    public int ObterIndice(int[] array, int valor){
        return Array.IndexOf(array, valor);
    }

    public void RedimensionarArray(ref int[] array, int novoTamanho){
        Array.Resize(ref array, novoTamanho);
    }

    public string[] ConverterArrayParaString(int[] array){

        return Array.ConvertAll(array, elemento => elemento.ToString());
    }
}