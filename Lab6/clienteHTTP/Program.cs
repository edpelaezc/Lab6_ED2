using System;

namespace clienteHTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            Console.WriteLine("Menu\n1.Ingresar claves\n2.Cifrar\n");
            option = Console.ReadLine();

            while (option != "x")
            {
                if (option == "1")
                {
                    Console.WriteLine("Ingresa la clave \"a\":");
                    int a;
                    bool success = Int32.TryParse(Console.ReadLine(), out a);
                    if (success)
                    {

                    }
                }



                Console.WriteLine("Menu\n1.Ingresar claves\n2.Cifrar\n");
                option = Console.ReadLine();
            }

        }
    }
}
