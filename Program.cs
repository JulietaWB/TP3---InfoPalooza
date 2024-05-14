namespace TP3___InfoPalooza;

class Program
{
    static void Main(string[] args)
    {
        const int MIN_MENU=1, MAX_MENU=5;
        int rta=0;

         do{
    
            Console.WriteLine("ELija una de las siguientes funciones:");
            Console.WriteLine();
            Console.WriteLine(">'1': Nueva Inscripción");
            Console.WriteLine(">'2': Obtener Estadísticas del Evento");
            Console.WriteLine(">'3':  Buscar Cliente");
            Console.WriteLine(">'4':  Cambiar entrada de un Cliente");
            Console.WriteLine(">'5':  Salir");

            
            rta= int.Parse(Console.ReadLine());
            
            rta= ValidarNum(rta, MIN_MENU, MAX_MENU);
            Console.WriteLine();

            //switch ()

         }while(rta!=MAX_MENU);
    }



    static int ValidarNum (int num, int min, int max)
    {
        while (num<min || num>max){
            Console.WriteLine("Número ingresado incorrecto. Ingrese un número entre " + min + " y " + max);
            num=int.Parse(Console.ReadLine());
        }

        return num;
    }


    }