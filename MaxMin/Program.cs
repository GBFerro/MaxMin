internal class Program
{
    private static void Main(string[] args)
    {
        int i , j;
        float[] numeros = new float[15];
        float max, min;

        for (i = 0; i < 15; i++)
        {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = float.Parse(Console.ReadLine());
        }

        i = 1;
        max = numeros[0];
        while (i < 15)
        {
            if (numeros[i] > max)
            {
                max = numeros[i];
            }
            i++;
        }

        min = numeros[0];
        j = 1;
        do
        {
            if (numeros[j] < min)
            {
                min = numeros[j];
            }
            j++;
        } while (j < 15);

        Console.WriteLine("Maior e menor numero: " + max + " e " + min);
    }
}