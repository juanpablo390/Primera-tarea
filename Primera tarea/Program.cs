using System;

namespace Primera_tarea {
    class Program {
        static void Main(string[] args) {
            Menu();
        }
        public static void hola() { }
        public static void Menu() {
            int opcion;
            do {
                Console.Clear();
                Console.WriteLine("\t\t!!MENU!!");
                Console.WriteLine("Ejercicio_1 #1");
                Console.WriteLine("Ejercicio_2 #2");
                Console.WriteLine("Ejercicio_3 #3");
                Console.WriteLine("Salir #0");
                Console.Write("Elija una opcion : ");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion) {
                    case 1: ejercicio_1(); break;
                    case 2: ejercicio_2(); break;
                    case 3: ejercicio_3(); break;
                }
            } while (opcion != 0);
        }

        public static void ejercicio_1() {

            Console.Clear();
            Console.WriteLine("\tEjercicio 1");

            double notas,
                    suma = 0,
                    promedio,
                    contadorDeNota = 1;

            do {

                Console.Write($"ingrese la nota #{contadorDeNota} : ");
                notas = Convert.ToSingle(Console.ReadLine());

                if (notas > 5 || notas < 0) {

                    Console.WriteLine("Error...");

                } else {
                    suma += notas;
                    contadorDeNota++;
                }

            } while (contadorDeNota < 4);

            promedio = suma / 3;

            Console.WriteLine($"El promedio es de {promedio}");

            if (promedio >= 3) {
                Console.WriteLine($"\n\t!!Felicidades ha ganado la asignatura!! ");
            } else {
                Console.WriteLine($"\n\t!!Lo sentimos ha perdido la asignatura!!");
            }
            Console.ReadKey();
        }

        public static void ejercicio_2() {

            Console.Clear();

            string sexo;
            int edad;
            double pulsaciones;

            Console.Write("Ingrese su sexo (H) hombre o (M) mujer : ");
            do {
                sexo = Console.ReadLine();
                sexo = sexo.ToUpper();

                if (sexo != "H" && sexo != "M") {

                    Console.WriteLine("Error... ");
                    Console.Write("Ingrese su sexo (H) hombre o (M) mujer :");
                }

            } while (sexo != "H" && sexo != "M");

            Console.Write("Ingrese su edad :");
            do {

                edad = Convert.ToInt32(Console.ReadLine());

                if (edad < 1) {
                    Console.WriteLine("Error... no puede elejir un numero menor a 1");
                    Console.Write("Ingrese su edad :");
                }
            } while (edad < 1);

            if (sexo == "M") {

                pulsaciones = (double)(220 - edad) / 10;

            } else {
                pulsaciones = (double)(210 - edad) / 10;
            }

            Console.WriteLine($"El numero de pulsaciones por cada 10s es de : {pulsaciones}");
            Console.ReadKey();
        }

        public static void ejercicio_3() {

            Console.Clear();

            string nombre, tipo_cuenta;
            double saldo = 0;

            Console.WriteLine("\t!!Bienvenido!!");
            Console.Write("ingrese su nombre : ");
            nombre = Console.ReadLine();

            Console.Write("tipo de cuenta : ");
            tipo_cuenta = Console.ReadLine();

            Console.Write("Ingrese el saldo inicial : ");
            saldo = Convert.ToSingle(Console.ReadLine());

            int opcion;
            do {
                Console.Clear();
                Console.WriteLine("\t\t!!MENU!!");
                Console.WriteLine("consignar #1");
                Console.WriteLine("Retirar #2");
                Console.WriteLine("saldo total #3");
                Console.WriteLine("Salir #0");
                Console.Write("Elija una opcion : ");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion) {
                    case 1: saldo = consignar(saldo); break;
                    case 2: saldo = retirar(saldo); break;
                    case 3: Console.WriteLine("Saldo total : " + saldo); Console.ReadKey(); break;
                }
            } while (opcion != 0);

        }
        public static Double consignar(double saldo) {

            double ingreso;

            Console.Write("Digite la cantidad que quiere consignar : ");
            ingreso = Convert.ToSingle(Console.ReadLine());
            saldo += ingreso;

            return saldo;
        }
        public static double retirar(double saldo) {

            double retiro;

            Console.Write("Digite la cantidad que quiere retirar : ");
            retiro = Convert.ToSingle(Console.ReadLine());

            if (retiro > saldo) {
                Console.WriteLine("No tiene dinero sufucinte ");
                Console.ReadKey();
            } else {
                saldo -= retiro;
            }
            return saldo;
        }
    }
}
