using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al Juego de Adivinanza de Números!");
        Console.WriteLine("Un número aleatorio entre 1 y 15 ha sido generado.");

            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(1, 16);
            int intentosRestantes = 3;

            Console.Write("Por favor, introduzca su primer intento para adivinar el número en cuestión: ");
            int numeroIntento = Convert.ToInt32(Console.ReadLine());
            while (intentosRestantes > 0)
            {
                if (numeroIntento == numeroAleatorio)
                {
                    Console.WriteLine("¡Felicidades, ha adivinado el número!");
                    return;
                }
                else if (numeroIntento < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor que {0}.", numeroIntento);
                }
                else
                {
                    Console.WriteLine("El número es menor que {0}.", numeroIntento);
                }

                intentosRestantes--;
                if (intentosRestantes > 0)
                {
                    Console.Write("Inténtelo otra vez ({0} intentos restantes): ", intentosRestantes);
                    numeroIntento = Convert.ToInt32(Console.ReadLine());
                }
            }

        Console.WriteLine("Has agotado todos sus intentos. El número era {0}.", numeroAleatorio);
    }
}