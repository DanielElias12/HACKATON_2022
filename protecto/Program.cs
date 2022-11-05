using System;

namespace protecto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir) { 

                int num1 = 0;
            int num2 = 0;
            int res = 0;
            int sobrante = 0;
            string binario = "";
            string numfact = "";
            string hexadecimal = "";
            Console.WriteLine("Escoga el problema ");
            Console.WriteLine("1. Calculadora");

            Console.WriteLine("2. Contador de vocales");
            Console.WriteLine("3. Factorial");
            Console.WriteLine("4. Repartido de porciones");
            Console.WriteLine("5. Salir");
            int opciones = Convert.ToInt32(Console.ReadLine());
                switch (opciones)
                {
                    case 1:

                        Console.WriteLine("Ingrese el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Opción sumar");
                        Console.WriteLine("2. Opción restar");

                        Console.WriteLine("4. Salir");
                        Console.WriteLine("Elige una de las opciones");

                        int opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Has elegido la opción de sumar");

                                res = num1 + num2;
                                int res2 = res;
                                while (res2 > 0)
                                {
                                    sobrante = res2 % 2;
                                    res2 /= 2;
                                    binario = sobrante.ToString() + binario;
                                }

                                Console.WriteLine("Resultado en decimal: " + Convert.ToString(res));
                                Console.WriteLine("Resultado en binario: " + binario);
                                hexadecimal = res.ToString("X");
                                Console.WriteLine("Resultado en  hexadecimal: " + hexadecimal);

                                break;

                            case 2:
                                Console.WriteLine("Has elegido la opción de restar ");
                                res = num1 - num2;
                                res2 = res;
                                while (res2 > 0)
                                {
                                    sobrante = res2 % 2;
                                    res2 /= 2;
                                    binario = sobrante.ToString() + binario;
                                }

                                Console.WriteLine("Resultado en decimal: " + Convert.ToString(res));
                                Console.WriteLine("Resultado en binario: " + binario);
                                hexadecimal = res.ToString("X");
                                Console.WriteLine("Resultado en  hexadecimal: " + hexadecimal);
                                break;



                                break;
                            default:
                                Console.WriteLine("Elige una opcion entre 1 y 4");
                                break;
                        }
                        Console.WriteLine("Presione ente para continuar");
                        Console.ReadLine();
                        break;
                    case 3:
                    donde:
                        Console.WriteLine("Ingrese un numero seguido del caracter '!' para calcular su factorial: ");

                        numfact = Convert.ToString(Console.ReadLine());
                        if (numfact.Substring(numfact.Length - 1, 1) == "!")
                        {
                            numfact = numfact.Remove(numfact.Length - 1);

                            int fact = Convert.ToInt32(numfact);

                            int fact2 = 1;
                            for (int j = 1; j <= fact; j++)
                            {
                                fact2 *= j;
                            }
                            Console.WriteLine("El factorial es: " + Convert.ToString(fact2));



                        }
                        else
                        {
                            Console.WriteLine("ERROR: Ingrese el numero seguido del caracter '!'");
                            goto donde;
                        }
                        Console.WriteLine("Presione ente para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        string cadena;
                        Console.WriteLine("Ingrese la cadena: ");
                        cadena = Convert.ToString(Console.ReadLine());

                        int a = 0;
                        int e = 0;
                        int i = 0;
                        int o = 0;
                        int u = 0;
                        int total = 0;

                        foreach (char c in cadena)  //Convierte de "string" a "char"
                        {
                            if (c == 'a' || c == 'A')
                            {
                                a++;
                            }
                            else if (c == 'e' || c == 'E')
                            {
                                e++;
                            }
                            else if (c == 'i' || c == 'I')
                            {
                                i++;
                            }
                            else if (c == 'o' || c == 'O')
                            {
                                o++;
                            }
                            else if (c == 'u' || c == 'U')
                            {
                                u++;
                            }
                        }

                        Console.WriteLine("El total de A-a es de: " + a);
                        Console.WriteLine("El total de E-e es de: " + e);
                        Console.WriteLine("El total de I-i es de: " + i);
                        Console.WriteLine("El total de O-o es de: " + o);
                        Console.WriteLine("El total de U-u es de: " + u);
                        total = a + e + i + o + u;
                        Console.WriteLine("El total de vocales es de " + total);
                        Console.WriteLine("Presione ente para continuar");
                        Console.ReadLine();
                        break;




                    case 4:
                        bool entero = true;
                        string pastelestotales;
                        double pastel = 4;
                        double contador_amigos = 0;
                        double porciones = 0;
                        double contadorporciones = 0;
                        double cantidad_pasteles = 0;
                        int f = 0;
                        int persona = 0;
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(" BIENVENIDOS A LA PASTELERIA ");
                        Console.WriteLine("-----------------------------");

                        Console.WriteLine(" Ingrese el numero de personas que van a comprar pasteles ");
                        contador_amigos = Convert.ToInt32(Console.ReadLine());

                        for (f = 1; f <= contador_amigos; f++)
                        {
                            persona++;
                            Console.Write(" Cuantas porciones desea de pasteles la personsa " + persona + ": ");
                            porciones = Convert.ToInt32(Console.ReadLine());
                            contadorporciones += porciones;
                        }
                        Console.WriteLine(" La cantidad de porciones solicitadas es de: " + contadorporciones);
                        cantidad_pasteles = contadorporciones / pastel;
                        pastelestotales = Convert.ToString(cantidad_pasteles);
                        char[] test = pastelestotales.ToCharArray();

                        for (int x = 0; x < test.Length; x++)
                        {
                            if (test[x] == '.')
                            {
                                entero = false;
                            }
                        }

                        if (entero)
                        {

                        }
                        else
                        {
                            cantidad_pasteles += 1;
                        }

                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine(" LA CANTIDAD DE PASTELES NECESARIOS ES DE: " + Math.Floor(cantidad_pasteles));
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("Presione ente para continuar");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Has elegido salir de la aplicación");

                        salir = true;
                    
                        break; 
                }
        }
     
        }





    }
}
