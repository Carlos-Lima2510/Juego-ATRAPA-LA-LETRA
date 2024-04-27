using System;
using System.Net.Http;
using System.Threading;

namespace Juego_ATRAPA_LA_LETRA
{
    class Program
    {
        int puntuacion = 0; int y = 0; int vidas = 3; 

        static void Main(string[] args)
        {
            Program programa = new Program();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            programa.MenuPrincipal();

        }
        public void MenuPrincipal()
        {
            y = 2;
            while (true)
            {
                Console.Clear();
                marcodeMenú();
                for (int x = 10; x <= 48; x++)
                {
                    Console.SetCursorPosition(x, 9);
                    Console.Write("  WORD RAIN REVOLUTION");
                    Console.SetCursorPosition(x, 11);
                    Console.Write("  (1) Jugar");
                    Console.SetCursorPosition(x, 12);
                    Console.Write("  (2) Instrucciones");
                    Console.SetCursorPosition(x, 13);
                    Console.Write("  (3) Puntuaciones");
                    Console.SetCursorPosition(x, 14);
                    Console.Write("  (4) Creditos");
                    Console.SetCursorPosition(x, 15);
                    Console.Write("  (5) Salir");
                }
                int ingreso = 0;
                try
                {
                    ingreso = int.Parse(Console.ReadLine());

                    switch (ingreso)
                    {
                        case 1:
                            Juego();
                            break;
                        case 2:
                            mostrarInstrucciones();
                            break;
                        case 3:
                            mostrarPuntuacion();
                            break;
                        case 4:
                            creditos();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (FormatException)
                {}
            }
        }
        public void marcodeMenú()
        {
            for (int x = 0; x <= 118; x++)
            {
                Random simbolo = new Random();
                int simb = simbolo.Next(35, 38);
                char ascii = Convert.ToChar(simb);
                Console.SetCursorPosition(x, 0);
                Console.Write(ascii);
            }
            for (int y = 0; y <= 29; y++)
            {
                Random simbolo = new Random();
                int simb = simbolo.Next(35, 38);
                char ascii = Convert.ToChar(simb);
                Console.SetCursorPosition(0, y);
                Console.Write(ascii);
            }
            for (int y = 0; y <= 29; y++)
            {
                Random simbolo = new Random();
                int simb = simbolo.Next(35, 38);
                char ascii = Convert.ToChar(simb);
                Console.SetCursorPosition(118, y);
                Console.Write(ascii);
            }
            for (int x = 0; x <= 118; x++)
            {
                Random simbolo = new Random();
                int simb = simbolo.Next(35, 38);
                char ascii = Convert.ToChar(simb);
                Console.SetCursorPosition(x, 29);
                Console.Write(ascii);
            }
        }
        public void cerrado()
        {
            ConsoleKeyInfo validacion = Console.ReadKey();
                
            if (validacion.Key == ConsoleKey.S)
            {
                Console.Clear();
                MenuPrincipal();
            }
            else if (validacion.Key == ConsoleKey.J)
            {
                Console.Clear();
                Juego();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public void Juego()
        {
            Console.Clear();
            vidas = 3;
            puntuacion = 0;
            menuJuego();
            for (int v = 0; v <= 15; v++)
            {
                y = 2;

                Random rand = new Random();
                int letra = rand.Next(97, 122);
                char ascii = Convert.ToChar(letra);

                Random rand1 = new Random();
                int NUM1 = rand1.Next(10, 20);
                char numero = Convert.ToChar(NUM1);
                do
                {
                    y++;
                    Console.SetCursorPosition(numero, y);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(numero, y + 1);
                    Console.WriteLine(ascii);
                    Thread.Sleep(140);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo tecla = Console.ReadKey(true);

                        if (tecla.KeyChar == ascii)
                        {
                            Console.SetCursorPosition(60, 2);
                            Console.WriteLine("Puntos: " + puntuacion);
                            Console.SetCursorPosition(60, 4);
                            Console.SetCursorPosition(numero, y + 1);
                            Console.WriteLine(" ");
                            puntuacion++;
                            y = 2;
                            rand = new Random();
                            letra = rand.Next(97, 122);
                            ascii = Convert.ToChar(letra);
                            Console.SetCursorPosition(60, 2);
                            Console.WriteLine("Puntuacion: " + puntuacion);
                            Console.SetCursorPosition(60, 4);
                            Console.WriteLine("Vidas: " + vidas);

                        }
                        else if (tecla.KeyChar != ascii)
                        {
                            vidas--;
                            Console.SetCursorPosition(60, 4);
                            Console.WriteLine("Vidas: " + vidas);
                            if (vidas <= 0)
                            {
                                final();
                            }
                        }
                    }
                    if (y == 20)
                    {
                        Console.Clear();
                        marcoJuego();
                        vidas--;
                        Console.SetCursorPosition(60, 4);
                        Console.WriteLine("Vida: " + vidas);
                        y = 2;

                        letra = rand.Next(97, 122);
                        ascii = Convert.ToChar(letra);
                        Console.SetCursorPosition(60, 2);
                        Console.WriteLine("Puntuacion: " + puntuacion);
                        Console.SetCursorPosition(60, 4);
                        Console.WriteLine("Vida: " + vidas);
                        if (vidas <= 0)
                        {
                            final();
                        }
                    }
                    if (puntuacion == 10)
                    {
                        Console.SetCursorPosition(3, 2);
                        Console.WriteLine("NIVEL 2");
                        do
                        {
                            y++;
                            Console.SetCursorPosition(numero, y);
                            Console.WriteLine(" ");
                            Console.SetCursorPosition(numero, y + 1);
                            Console.WriteLine(ascii);
                            Thread.Sleep(80);
                            if (Console.KeyAvailable)
                            {
                                ConsoleKeyInfo tecla = Console.ReadKey(true);

                                if (tecla.KeyChar == ascii)
                                {
                                    Console.SetCursorPosition(60, 2);
                                    Console.WriteLine("Puntos: " + puntuacion);
                                    Console.SetCursorPosition(60, 4);
                                    Console.SetCursorPosition(numero, y + 1);
                                    Console.WriteLine(" ");
                                    puntuacion++;
                                    y = 2;
                                    rand = new Random();
                                    letra = rand.Next(65, 90);
                                    ascii = Convert.ToChar(letra);
                                    Console.SetCursorPosition(60, 2);
                                    Console.WriteLine("Puntuacion: " + puntuacion);
                                    Console.SetCursorPosition(60, 4);
                                    Console.WriteLine("Vidas: " + vidas);

                                }
                                else if (tecla.KeyChar != ascii)
                                {
                                    vidas--;
                                    Console.SetCursorPosition(60, 4);
                                    Console.WriteLine("Vidas: " + vidas);
                                    if (vidas <= 0)
                                    {
                                        final();
                                    }
                                }
                            }
                            if (y == 20)
                            {
                                marcoJuego();
                                vidas--;
                                Console.SetCursorPosition(60, 4);
                                Console.WriteLine("Vida: " + vidas);
                                y = 2;

                                rand = new Random();
                                letra = rand.Next(97, 122);
                                ascii = Convert.ToChar(letra);
                                Console.SetCursorPosition(60, 2);
                                Console.WriteLine("Puntuacion: " + puntuacion);
                                Console.SetCursorPosition(60, 4);
                                Console.WriteLine("Vida: " + vidas);
                                if (vidas <= 0)
                                {
                                    final();
                                }
                            }
                            if (puntuacion == 20)
                            {
                                Console.Clear();
                                marcoJuego();
                                Console.SetCursorPosition(35, 9);
                                Console.WriteLine("FELICIDADES!! HAS GANADO!!");
                                Console.SetCursorPosition(35, 11);
                                Console.WriteLine("TU PUNTUACIÓN FUE DE: " + puntuacion);
                                Console.SetCursorPosition(20, 13);
                                Console.WriteLine("Jugar de Nuevo (J) Regresar al Menú (S) Salir del Juego (N)");
                                cerrado();
                            }
                        } while (vidas != 0);

                        if (vidas <= 0)
                        {
                            final();
                        }
                    }
                    if (vidas <= 0)
                    {
                        final();
                    }
                } while (vidas != 0);
            }
        }
        public void menuJuego()
        {
            for (int x = 0; x <= 118; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("I");
            }
            for (y = 0; y <= 29; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("I");
            }
            for (y = 0; y <= 29; y++)
            {
                Console.SetCursorPosition(118, y);
                Console.Write("I");
            }
            for (int x = 0; x <= 118; x++)
            {
                Console.SetCursorPosition(x, 29);
                Console.Write("I");
            }
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("Puntuacion: " + puntuacion);
            Console.SetCursorPosition(60, 4);
            Console.WriteLine("Vidas: " + vidas);
        }
        public void final()
        {
            y = 2;
            Console.Clear();
            marcodeMenú();
            for (int p = 0; p <= 38; p++)
            {
                Console.SetCursorPosition(p, 10);
                Console.WriteLine(" FIN DEL JUEGO!!");
                Console.SetCursorPosition(p, 11);
                Console.WriteLine(" TU PUNTUACIÓN FUE DE: " + puntuacion);
                Console.SetCursorPosition(p, 13);
                Console.WriteLine(" Desea Volver a Jugar?");
                Console.SetCursorPosition(p, 14);
                Console.WriteLine(" SI (S) NO (N)");
            }
            string resp = Console.ReadLine();
            if (resp == "s")
            {
                Juego();
            }
            else if (resp == "n")
            {
                Console.Clear();
                marcodeMenú();
                for (int p = 0; p <= 38; p++)
                {
                    Console.SetCursorPosition(p, 10);
                    Console.WriteLine(" Desea Regresar al Menú Principal?");
                    Console.SetCursorPosition(p, 11);
                    Console.WriteLine(" Aceptar (S) Cerrar Juego (N)");
                    Console.SetCursorPosition(p, 12);
                }
                cerrado();
            }
        }
        public void mostrarPuntuacion()
        {
            Console.Clear();
            marcodeMenú();
            for (int i = 10; i <= 45; i++)
            {
                Console.SetCursorPosition(i, 9);
                Console.WriteLine(" SU PUNTUACIÓN ACTUAL ES DE: " + puntuacion);
                Console.SetCursorPosition(i, 10);
                Console.WriteLine(" Regresar al Menú (S)");
                Console.SetCursorPosition(i, 11);
                Console.WriteLine(" Salir del Juego (N)");
            }
            cerrado();
        }
        public void mostrarInstrucciones()
        {
            Console.Clear();
            marcodeMenú();
            for (int x = 35; x <= 48; x++)
            {
                Console.SetCursorPosition(x, 9);
                Console.Write(" BIENVENIDO A WORD RAIN REVOLUTION:");
                Console.SetCursorPosition(x, 10);
                Console.Write(" - DEBES ESCRIBIR ANTES DE QUE LAS LETRAS DESAPAREZCAN");
                Console.SetCursorPosition(x, 11);
                Console.Write(" - SI UNA LETRA DESAPARECE, PIERDES 1 VIDA");
                Console.SetCursorPosition(x, 12);
                Console.Write(" - SI ESCRIBES MAL UNA LETRA, PIERDES OTRA VIDA");
                Console.SetCursorPosition(x, 13);
                Console.Write(" - ENTRE MAS LETRAS ACERTADAS, MAS PUNTAJE");
                Console.SetCursorPosition(x, 14);
                Console.Write(" - DIVIERTETE!!");
                Console.SetCursorPosition(x, 16);
                Console.WriteLine(" Jugar (J)");
                Console.SetCursorPosition(x, 17);
                Console.WriteLine(" Regresar al Menú (S)");
                Console.SetCursorPosition(x, 18);
                Console.WriteLine(" Salir del Juego (N)");
            }
            cerrado();
        }
        public void marcoJuego()
        {
            for (int x = 0; x <= 118; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("I");
            }
            for (y = 0; y <= 29; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("I");
            }
            for (y = 0; y <= 29; y++)
            {
                Console.SetCursorPosition(118, y);
                Console.Write("I");
            }
            for (int x = 0; x <= 118; x++)
            {
                Console.SetCursorPosition(x, 29);
                Console.Write("I");
            }
        }
        public void creditos()
        {
            Console.Clear();
            marcodeMenú();
            for (int x = 40; x <= 48; x++)
            {
                Console.SetCursorPosition(x, 9);
                Console.Write(" REALIZADO POR:");
                Console.SetCursorPosition(x, 10);
                Console.Write(" CARLOS ALVARADO LIMA");
                Console.SetCursorPosition(x, 11);
                Console.Write(" 11mo BYS Computación");
                Console.SetCursorPosition(x, 14);
                Console.WriteLine(" Jugar (J)");
                Console.SetCursorPosition(x, 15);
                Console.WriteLine(" Regresar al Menú (S)");
                Console.SetCursorPosition(x, 16);
                Console.WriteLine(" Salir del Juego (N)");
                cerrado();
            }
        }

    }
}
