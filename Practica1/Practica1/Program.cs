using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio_I();

            Ejercicio_II();
            Ejercicio_II_I();
            Ejercicio_II_II();
            Ejercicio_II_III();
            Ejercicio_II_IV();
            Ejercicio_II_V();

            Ejercicio_III_I();
            Ejercicio_III_II();
            Ejercicio_III_III();
            Ejercicio_III_IV();

            Ejercicio_IV_I();
            Ejercicio_IV_II();
            Ejercicio_IV_III();
            Ejercicio_IV_IV();
            Ejercicio_IV_V();

            Ejercicio_V_I();
            Ejercicio_V_II();

            Ejercicio_VI_I();
            Ejercicio_VI_II();
            Ejercicio_VI_III();
            Ejercicio_VI_IV();
        }

        /// <summary>
        /// este metodo se encarga de recibir datos del teclado como el nombre del usuario y una ciudad para luego
        /// darle la bienvenida y mostrar toda su informacion personal
        /// </summary>
        static void Ejercicio_I()
        {
            String nombre, apellido, apodo, fechaNacimiento, telefono, movil, pais, ciudad, direccion, lugarNacimiento, sueldo;
            Console.WriteLine("===> PROGRAMA PARA MOSTRAR INFORMACION DEL USUARIO <===");
            Console.WriteLine("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Escribe tu apodo: ");
            apodo = Console.ReadLine();
            Console.WriteLine("Escribe tu fecha de nacimiento: ");
            fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Escribe tu telefono: ");
            telefono = Console.ReadLine();
            Console.WriteLine("Escribe tu movil: ");
            movil = Console.ReadLine();
            Console.WriteLine("Escribe tu pais: ");
            pais = Console.ReadLine();
            Console.WriteLine("Escribe tu ciudad: ");
            ciudad = Console.ReadLine();
            Console.WriteLine("Escribe tu direccion: ");
            direccion = Console.ReadLine();
            Console.WriteLine("Escribe tu lugar de nacimiento: ");
            lugarNacimiento = Console.ReadLine();
            Console.WriteLine("Escribe tu sueldo: ");
            sueldo = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Apellido: {0}", apellido);
            Console.WriteLine("Apodo: {0}", apodo);
            Console.WriteLine("Fecha de Nacimiento: {0}", fechaNacimiento);
            Console.WriteLine("Telefono: {0}", telefono);
            Console.WriteLine("Movil: {0}", movil);
            Console.WriteLine("Pais: {0}", pais);
            Console.WriteLine("Ciudad: {0}", ciudad);
            Console.WriteLine("Direccion: {0}", direccion);
            Console.WriteLine("Lugar de Nacimiento: {0}", lugarNacimiento);
            Console.WriteLine("Sueldo: {0}", sueldo);

            Console.ReadLine();
        }

        /// <summary>
        /// este metodo se encarga de sumar dos numeros
        /// </summary>
        static void Ejercicio_II()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            double valor1 = 0, valor2 = 0, resultado = 0;
            Console.WriteLine("==============> PROGRAMA QUE SUME DOS NUMEROS <==============");
            Console.WriteLine("Ingrese el primer valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            resultado = valor1 + valor2;
            Console.WriteLine("El resultado es: {0}", resultado);
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de saludar al usuario
        /// </summary>
        static void Ejercicio_II_I()
        {
            Console.Clear();
            Console.WriteLine("===> PROGRAMA PARA SALUDAR <===");
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("\nHola {0}", nombre);
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de calcular el promedio de cuatro notas
        /// </summary>
        static void Ejercicio_II_II()
        {
            Console.Clear();
            int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, promedio = 0;
            Console.WriteLine("===> PROGRAMA QUE CALCULE EL PROMEDIO DE CUATRO NOTAS <===");
            Console.Write("Ingrese la primera nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la tercera nota: ");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cuarta nota: ");
            nota4 = Convert.ToInt32(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("El promedio es de : " + promedio);
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de calcular itbis
        /// </summary>
        static void Ejercicio_II_III()
        {
            Console.Clear();
            Console.WriteLine("===> PROGRAMA QUE CALCULE ITBIS <===");
            Console.Write("Ingrese el nombre de un producto: ");
            string producto = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la cantidad de productos: ");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            double subtotal = precio * cantidad;
            Console.WriteLine("El subtotal es de {0}", subtotal);

            double itbis = subtotal * 0.18;
            Console.WriteLine("El itbis es de {0}", itbis);

            double total = subtotal + itbis;
            Console.WriteLine("Total de {0}", total);

            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de calcular el sueldo bruto
        /// </summary>
        static void Ejercicio_II_IV()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("===> PROGRAMA QUE CALCULE EL SUELDO BRUTO <===");
            double sueldobruto = 0, sueldoneto = 0, descuento = 0, tarifasporhora = 0, horastrabajadas = 0;

            Console.Write("Ingrese las horas trabajadas: ");
            horastrabajadas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese las la tarifa por hora: ");
            tarifasporhora = Convert.ToDouble(Console.ReadLine());

            sueldobruto = tarifasporhora * horastrabajadas;
            Console.WriteLine("El sueldo bruto es de: {0}", sueldobruto);

            descuento = sueldobruto * 0.10;
            sueldoneto = sueldobruto - descuento;
            Console.WriteLine("El sueldo neto es de: {0}", sueldoneto);

            Console.WriteLine("El descuento es de: " + descuento);
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de convertir centimetros en pulgadas
        /// </summary>
        static void Ejercicio_II_V()
        {
            Console.Clear();
            Console.WriteLine("===> PROGRAMA PARA CONVERTIR DE CENTIMETROS A PULGADAS <===");
            const double pulgada = 2.54;
            Console.Write("Ingrese la cantidad de centimetros: ");
            double centimetros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado es: {0}", (centimetros * pulgada));
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de calcular cuotas de un prestamo simple
        /// </summary>
        static void Ejercicio_II_VI()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("===> PROGRAMA QUE CALCULE CUOTAS DE PRESTAMMO SIMPLE <===");
            Console.Write("Ingrese el monto del prestamo: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el interes del prestamo: ");
            double interes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el tiempo del prestamo: ");
            double tiempo = Convert.ToDouble(Console.ReadLine());
            double cuota = ((monto * interes) / tiempo) + (monto / tiempo);
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de calcular sueldo bruto con condiciones
        /// </summary>
        static void Ejercicio_III_I()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.WriteLine("===> PROGRAMA QUE CALCULE EL SUELDO BRUTO <===");
            double sueldobruto = 0, sueldoneto = 0, descuento = 0, tarifasporhora = 0, horastrabajadas = 0;
            Console.Write("Ingrese las horas trabajadas: ");
            horastrabajadas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la tarifa por horas trabajadas: ");
            tarifasporhora = Convert.ToDouble(Console.ReadLine());

            sueldobruto = tarifasporhora * horastrabajadas;

            if (sueldobruto > 5000)
                descuento = sueldobruto * 0.10;
            else
                descuento = sueldobruto * 0.05;
                    
            Console.WriteLine("El sueldo bruto es de: {0}", sueldobruto);

            sueldoneto = sueldobruto - descuento;
            Console.WriteLine("El sueldo neto es de: {0}", sueldoneto);

            Console.WriteLine("El descuento es de: " + descuento);
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar una tabla de calculo de notas
        /// </summary>
        static void Ejercicio_III_II()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            Console.WriteLine("===> PROGRAMA QUE CALCULA NOTAS <===");
            int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, promedio = 0;
            Console.Write("Ingrese la primera nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la tercera nota: ");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cuarta nota: ");
            nota4 = Convert.ToInt32(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio < 65) Console.WriteLine("Reprobado");
            if (promedio > 65 && promedio < 75) Console.WriteLine("Aprobado");
            if (promedio > 75 && promedio < 85) Console.WriteLine("Muy bueno");
            if (promedio > 85 && promedio < 90) Console.WriteLine("Sobresaliente");
            if (promedio > 90 && promedio < 100) Console.WriteLine("Excelente");

            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar datos con la edad de la persona
        /// </summary>
        static void Ejercicio_III_III()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.WriteLine("===> PROGRAMA QUE CALCULE LA EDAD DE LA PERSONA <===");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad == 0 && edad == 1) Console.WriteLine("Bebé");
            else if (edad >= 2 && edad <= 12) Console.WriteLine("Niño");
            else if (edad >= 13 && edad <= 17) Console.WriteLine("Adolescente");
            else if (edad >= 18 && edad <= 30) Console.WriteLine("Joven");
            else if (edad >= 31 && edad <= 64) Console.WriteLine("Adulto");
            else if (edad >= 65 && edad <= 120) Console.WriteLine("Anciano");
            else Console.WriteLine("Error");

            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de nombre del dia de la semana
        /// </summary>
        static void Ejercicio_III_IV()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("===> PROGRAMA QUE MUESTRE EL DIA DE LA SEMANA <===");
            Console.WriteLine("Ingrese un numero del 1 al 7: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sabado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: break;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar los numeros del 1 al 10
        /// </summary>
        static void Ejercicio_IV_I()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("===> NUMEROS DEL 1 AL 10 <===");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar numeros del 100 a 105
        /// </summary>
        static void Ejercicio_IV_II()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("===> PROGRAMA QUE MUESTRE NUMEROS DEL 100 AL 105 <===");
            for (int i = 1; i < 106; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }

        /// <summary>
        /// este metodo se encarga de mostrar numeros del 3 al 20 con su cubo
        /// </summary>
        static void Ejercicio_IV_III()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("===> PROGRAMA QUE MUESTRE NUMEROS DEL 3 AL 20 CON SU CUBO <===");
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i + " : " + (i * i * i));
            }
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar la tabla de multiplicar del 4
        /// </summary>
        static void Ejercicio_IV_IV()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.WriteLine("===> TABLA DE MULTIPLICAR DEL 4 <===");

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(4 + " X " + i + " = " + (4 * i));
            }

            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar tablas del 1 al 12
        /// </summary>
        static void Ejercicio_IV_V()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("===> TABLA DE MULTIPLICAR DEL 1 AL 12 <===");

            for (int i = 1; i < 13; i++)
            {
                for (int n = 1; n < 13; n++)
                {
                    Console.WriteLine(i + " X " + n + " = " + (i * n));
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar la tabla del 4 con while
        /// </summary>
        static void Ejercicio_V_I()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("===> TABLA DE MULTIPLICAR DEL 4 CON [WHILE] <===");

            // Uso del ciclo del while

            int a = 1;
            while (a < 13)
            {
                Console.WriteLine(4 + " X " + a + " = " + (4 * a));
                a++;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar un menu
        /// </summary>
        static void Ejercicio_V_II()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("===> MENU DE OPCIONES <===");
                Console.WriteLine("[1] Tabla del 4");
                Console.WriteLine("[2] Calcular promedio");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("------------------------");
                Console.Write("Elija una opcion: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        for (int i = 1; i < 13; i++)
                        {
                            Console.WriteLine(4 + " X " + i + " = " + (4 * i));
                        }
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, promedio = 0;
                        Console.WriteLine("===> PROGRAMA QUE CALCULE EL PROMEDIO DE CUATRO NOTAS <===");
                        Console.Write("Ingrese la primera nota: ");
                        nota1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese la segunda nota: ");
                        nota2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese la tercera nota: ");
                        nota3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese la cuarta nota: ");
                        nota4 = Convert.ToInt32(Console.ReadLine());
                        promedio = (nota1 + nota2 + nota3 + nota4) / 4;
                        Console.WriteLine("El promedio es de : {0}", promedio);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default: break;
                }
            } while (opc > 0);
        }

        /// <summary>
        /// este metodo se encarga de mostrar un vector con 5 codigos
        /// </summary>
        static void Ejercicio_VI_I()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("===> SUMATORIA DE 5 VECTORES <===");

            int[] vector = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar sumatoria de numeros de un vector
        /// </summary>
        static void Ejercicio_VI_II()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("===> SUMATORIA DE NUMEROS DE UN VECTOR <===");

            // Declaracion de variables
            int[,] tabla = new int[2,3];
            int sumatoria = 0;

            // Asignacion de valores
            tabla[0, 0] = 10;
            tabla[0, 1] = 20;
            tabla[0, 2] = 30;

            tabla[1, 0] = 40;
            tabla[1, 1] = 50;
            tabla[1, 2] = 60;

            // Desplegar todo el contenido de la tabla
            for (int i = 0; i < 2; i++)
            {
                for (int n = 0; n < 3; n++)
                {
                    sumatoria += tabla[i, n];
                }
            }

            Console.WriteLine(sumatoria);
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de llenar nombres en tablas
        /// </summary>
        static void Ejercicio_VI_III()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("===> LLENAR TABLA CON NOMBRES DE PERSONAS <===");

            // Declaracion del arreglo
            string[,] personas = new string[2,2];

            // Asignacion de valores
            for (int i = 0; i < 2; i++)
            {
                for (int n = 0; n < 2; n++)
                {
                    Console.Write("Ingrese un nombre de una persona: ");
                    personas[i, n] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int n = 0; n < 2; n++)
                {
                    Console.Write(personas[i,n]+" ");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// este metodo se encarga de sumar dos matrices
        /// </summary>
        static void Ejercicio_VI_IV()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.WriteLine("===> SUMA DE MATRICES <===");
            // Declaracion de matrices
            int[,] A = new int[2,2], B = new int[2,2], C = new int[2,2];

            // Asignacion de valores
            A[0, 0] = 70;
            A[0, 1] = 60;
            A[1, 0] = 80;
            A[1, 1] = 70;

            B[0, 0] = 68;
            B[0, 1] = 90;
            B[1, 0] = 80;
            B[1, 1] = 70;

            // Suma de matrices
            for (int i = 0; i < 2; i++)
            {
                for (int n = 0; n < 2; n++)
                {
                    C[i, n] = A[i, n] + B[i, n];
                    Console.Write(C[i,n]+ " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
