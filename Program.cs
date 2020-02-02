using System;

namespace NumeroRandom
{
    class Program
    {
        static void Main(string[] args)
        {
			const int oportunidades = 10;
			int num, entrada;
			byte i, guess;
			string line;


			Random ran = new Random();
			num = Convert.ToInt32(ran.Next(100)) + 1;

			i = 1; guess = 0;
			do
			{
				Console.Write("Escribe un numero entre 1 y 100:");
				line = Console.ReadLine();
				entrada = int.Parse(line);

				if ((entrada == num))
				{
					Console.WriteLine("Has adivinado el numero");
					guess = 1;
				}
				else
				{
					if ((entrada > num))
					{
						Console.WriteLine("Frio ");
					}
					 else if (entrada < num)
					{
						Console.WriteLine("Caliente");
					}
					
				}
				i++;
			} while (((i <= oportunidades) & (guess == 0)));
			if ((guess == 0))
			{
				Console.Write("Has agotado los intentos, el numero fue: " + num);
			}

		
			Console.Write("Pulse una tecla:");
			Console.ReadLine();
		}
    }
}
