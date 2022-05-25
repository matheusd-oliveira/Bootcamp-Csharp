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
}