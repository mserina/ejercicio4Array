namespace ejercicio4Array
{
    class Program 
    {
        static void Main(string[] args)
        {
            int tamaño;
            Console.WriteLine("Indice el tamaño del vector");
            tamaño = Convert.ToInt32(Console.ReadLine());
            
            //Creacion de la Array
            int[] numeros = new int[tamaño];
            Random numerosRandom = new Random();

            //Asignar numeros enteros aleatorios a cada posicion del Array
            for (int i = 0;i < numeros.Length;i++)
            {
                numeros[i] = numerosRandom.Next(1, 100);
                Console.WriteLine(numeros[i]);
            }

            Array.Sort(numeros);
            Console.WriteLine("Ascendente");
            foreach (int listaNumeros in numeros)
            {
                Console.WriteLine(listaNumeros);
            }
           
           
        }
    }
}