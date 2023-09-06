// See https://aka.ms/new-console-template for more information

//Una agencia turística, hace reservaciones en hoteles a los viajeros,
//dependiendo lacategoría que deseen del hotel y la cantidad de días que se dure la estadía,
//el costo quese muestra en la tabla es por día
//Adicional a ello todos tienen que pagar S/.7.00 por cada día por el desayuno.
//Calcular el pago que debe realizar un turista por el hospedaje que requiere.

Console.WriteLine("1) TresEstrellas");
Console.WriteLine("2) CincoEstrellas");


Console.WriteLine("Indique la clase del Hotel");
int Hotel = int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione dias de Alojamiento ");
int Dia = int.Parse(Console.ReadLine());

double TresEstrellas, CincoEstrellas, Desayuno, Adicional;


switch (Hotel)
{
    case 1:
        if (Dia >= 1 && Dia <= 5)
        {
            TresEstrellas = Dia * 100;
            Desayuno = (Dia * 7);
            Adicional = TresEstrellas + Desayuno;
            Console.WriteLine("El pago total por los dias de Estadia es: " + Adicional);
        }
        else if (Dia >= 6 && Dia <= 10)
        {
            TresEstrellas = Dia * 85;
            Desayuno = (Dia * 7);
            Adicional = TresEstrellas + Desayuno;
            Console.WriteLine("El pago total por los dias de Estadia es: " + Adicional);
        }
        else if (Dia >= 11 && Dia <= 364)
        {
            TresEstrellas = Dia * 70;
            Desayuno = (Dia * 7);
            Adicional = TresEstrellas + Desayuno;
            Console.WriteLine("El pago total por los dias de Estadia es: " + Adicional);
        }
        break;
    case 2:
        if (Dia >= 1 && Dia <= 5)
        {
            CincoEstrellas = Dia * 300;
            Desayuno = (Dia * 7);
            Adicional = CincoEstrellas + Desayuno;
            Console.WriteLine("El pago total por los dias de Estadia es: " + Adicional);
        }
        else if (Dia >= 6 && Dia <= 10)
        {
            CincoEstrellas = Dia * 270;
            Desayuno = (Dia * 7);
            Adicional = CincoEstrellas + Desayuno;
            Console.WriteLine("El pago total por los dias de Estadia es: " + Adicional);
        }
        else if (Dia >= 11 && Dia <= 364)
        {
            CincoEstrellas = Dia * 250;
            Desayuno = (Dia * 7);
            Adicional = CincoEstrellas + Desayuno;
            Console.WriteLine("El pago total por los dias de Estadia es: " + Adicional);
        }
        break;
    default:
        Console.WriteLine("Ingrese la clase de Hotel");
        break;
}
