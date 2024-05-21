using EspacioCalculadora;


Calculadora miCalculadora = new Calculadora();
int bandera = 1, operacion;
double numero;
do
{
    Console.Write("Calculadora Basica: escoja la operacion que desea realizar\n");
    Console.Write("1.Sumar\n");
    Console.Write("2.Restar\n");
    Console.Write("3.Multiplicar\n");
    Console.Write("4.Dividir\n");
    Console.Write("5.Limpiar\n");
     string operacionString = Console.ReadLine();
     if(int.TryParse(operacionString, out operacion))
    {
        Console.Write("Ingrese un numero\n");
         String numeroString =  Console.ReadLine();
           if(double.TryParse(numeroString, out numero))
        {
            switch(operacion)
            {
                case 1:
                     miCalculadora.Sumar(numero);
                     Console.WriteLine(miCalculadora.Resultado);                
                break;
                case 2:
                    miCalculadora.Restar(numero);
                    Console.WriteLine(miCalculadora.Resultado);   
                break;
                case 3:
                    miCalculadora.Multiplicar(numero);
                    Console.WriteLine(miCalculadora.Resultado);   
                break;
                case 4:
                    miCalculadora.Dividir(numero);
                    Console.WriteLine(miCalculadora.Resultado);   
                break;
                case 5:
                    miCalculadora.Limpiar();
                    Console.WriteLine(miCalculadora.Resultado);   
                break;
            }
        }
       
    }
    Console.Write("Desea realizar otra operacion? (0=no, 1=si)\n");
    string banderaO = Console.ReadLine();
    if(int.TryParse(banderaO, out bandera))
    {
        if(bandera == 0 )
        {
            break;
        }
    }
} while (bandera != 0);

