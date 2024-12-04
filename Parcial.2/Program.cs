namespace Parcial._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* El pueblito “Todos somos cantantes” quiere crear su propia disquería digital. Aquellos que deseen
               enviar su demo pueden hacerlo, pero tienen ciertos requisitos que cumplir:
               A. Se deben enviar 5 canciones.
               B. Solo versiones demo, por lo que como máximo cada canción debe durar 120 segundos.
               C. Por cada canción aceptada se debe pagar $500 para que sea considerada.
                */

            int[] Canciones = { 110, 120, 130, 105, 115 };
            /* Se pide:
                1. (2 puntos) Sabiendo que la lista entregada es: 110, 120, 130, 105 y 115(en segundos),
                recorrer la lista y rechazar aquellas que no cumplen con el requisito
               Nota: Rechazado quiere decir que registra en esa posición 0 segundos.*/

            for (int i = 0; i < Canciones.Length; i++)
            {
                if (Canciones[i] > 120)
                {
                    Canciones[i] = 0;

                }

            }
            /*Luego genere un menú para las siguientes 3 opciones.
             * 2. (3 puntos) Recorrer la lista y obtener:
             * a. La canción más larga. Solo indique los segundos, no es importante quién es.
             * b. Cuántas fueron rechazadas.
             * c. Cuánto se tuvo que abonar.*/
            int opcion, maximo = 0;
            do
            {
                Console.WriteLine(" MENU ");
                Console.WriteLine(" OPCION 1 Para ver la canción mas larga ");
                Console.WriteLine(" OPCION 2 Para ver cuantas canciones fueron rechazadas");
                Console.WriteLine(" OPCION 3 Para ver la cantidad total que se tuvo que abonar ");
                Console.WriteLine(" OPCION 4 Para salir del menu ");
                Console.WriteLine(" Ingrese una opción");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        // La canción más larga. ---> maximo//
                        for (int i = 0; i < Canciones.Length; i++)
                        {
                            if (i == 0)
                            {
                                maximo = Canciones[i];
                            }
                            else if (Canciones[i] > maximo)
                                maximo = Canciones[i];


                        }
                        Console.WriteLine($"La canción mas larga es {maximo}");
                        break;
                    case 2:
                        // Cuántas fueron rechazadas --> rechazada = 0 seg //
                        int CancionRechazada = 0;
                        for (int i = 0; i < Canciones.Length; i++)
                        {
                            if (Canciones[i] == 0)
                            { CancionRechazada++; }

                        }
                        Console.WriteLine($"Se rechazaron {CancionRechazada} canciones");
                        break;

                    case 3:
                        //Por cada canción aceptada se debe pagar $500 para que sea considerada.//
                        int CancionAceptada = 0, CantidadAbonar;
                        for (int i = 0; i < Canciones.Length; i++)
                        {
                            if (Canciones[i] > 0)
                            { CancionAceptada++; }

                        }
                        CantidadAbonar = CancionAceptada * 500;
                        Console.WriteLine($"Se tuvo que abonar {CantidadAbonar}");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                //    Console.WriteLine();
            } while (opcion != 4); // lo hago para que se repita el ciclo hasta que me digan que quieren salir pulsando 4//


            //3. (3 puntos) Suponiendo que el compilado demo de máxima calidad de todos los temas incluidos soporte 6 minutos por cada CD. 
            //    a.Imprima por pantalla el listado completo de canciones indicando número de posición, duración en segundos y a qué disco pertenece(disco 1 o - en caso de corresponder - disco 2,
            //        ¿cómo sabe que ya tiene que pasar al disco 2 ?).

            //    Nota: Incluya en el listado las posiciones con 0 segundos y ocuparán un lugar.Sobre el número
            //    de posición: numere desde 1 y aunque cambie de disco, la numeración continúa.Ejemplo: cuando
            //    arranque el disco 2, si en el anterior entraron 3 canciones, siga con el número 4.

            int DuracionMax = 360; // Duración máxima del disco en segundos


            Console.WriteLine("Lista de canciones:");
            int NumCancion = 1;
            int NumDisco = 1;
            int DuracionDisco = 0;



            for (int i = 0; i < Canciones.Length; i++)
            {

                if (Canciones[i] > 0)
                {
                    DuracionDisco += Canciones[i];

                    if (DuracionDisco > DuracionMax)
                    {
                        NumDisco++;
                        DuracionDisco = Canciones[i];
                    }
                }
                NumCancion++;
                Console.Write($"Canción {i + 1} - Duración: {Canciones[i]} seg. - Disco {NumDisco}\n"); // /n = enter, para ir abajo//

            }





            //4. (2 puntos) Mostrar por pantalla las 3 canciones más largas ordenadas de forma decreciente.

            // Ordena las canciones en orden descendente
            Array.Sort(Canciones);
            Array.Reverse(Canciones);

            // Muestra las tres primeras canciones mas largas
            int j = 0;
            Console.WriteLine("Las 3 Canciones mas largas son:");
            for (int i = 0; i < Canciones.Length && j < 3/*porque solo queremos las primeras 3*/; i++)
            {

                if (Canciones[i] > 0)
                {
                    Console.WriteLine($"Posición {j + 1} duración: {Canciones[i]} segundos");
                    j++;
                }
            }


        }


    }


}

        