Console.Write("Ejercicio a ejecutar [1,2,3,4] : ");
switch (Convert.ToInt16(Console.ReadLine())) {
    case 1:
        Ejercicio01();
    break;
    case 2:
        Ejercicio02();
    break;
    case 3:
        Ejercicio03();
    break;
    case 4:
        Ejercicio04();
    break;
    default:
        Console.WriteLine("Opcion Invalida");
    break;
}

static void Ejercicio01 () {
    int numero;
    Console.Write("Ingrese un numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero == 0) {
        Console.WriteLine("El numero es igual a 0");
    } else if (numero > 0) {
        Console.WriteLine("El numero es Positivo");
    } else {
        Console.WriteLine("El numero es Negativo");
    }
}
static void Ejercicio02 () { }
static void Ejercicio03 () { } 
static void Ejercicio04 () {
    int cobro,
        pago,
        cambio,
        cambioDisplay;

    Console.Write("Ingrese el tiempo de su estadia en horas: ");
    cobro = 10 * Convert.ToInt32(Console.ReadLine());
    Console.Write($"Debe pagar {cobro}. \nIngrese el/los billete/s: ");
    pago = Convert.ToInt32(Console.ReadLine());

    if (pago < cobro) {
        Console.WriteLine("ERROR: El pago es incompleto");
    } else if (pago == cobro) {
        Console.WriteLine("Pago completado, sin cambio");
    } else {
        cambio = pago - cobro;
        Console.WriteLine("Cambio de ");
        if (cambio >= 100) {
            cambioDisplay = cambio / 100;
            cambio = cambio % 100;
            Console.WriteLine($"{cambioDisplay} billete/s de 100"); 
        }
        if (cambio >= 50) {
            cambioDisplay = cambio / 50;
            cambio = cambio % 50;
            Console.WriteLine($"{cambioDisplay} billete/s de 50"); 
        }
        if (cambio >= 20) {
            cambioDisplay = cambio / 20;
            cambio = cambio % 20;
            Console.WriteLine($"{cambioDisplay} billete/s de 20"); 
        }
        if (cambio >= 10) {
            cambioDisplay = cambio / 10;
            cambio = cambio % 10;
            Console.WriteLine($"{cambioDisplay} billete/s de 10"); 
        }
        if (cambio >= 5) {
            cambioDisplay = cambio / 5;
            cambio = cambio % 5;
            Console.WriteLine($"{cambioDisplay} billete/s de 5"); 
        }
        if (cambio >= 1) {
            cambioDisplay = cambio / 1;
            cambio = cambio % 1;
            Console.WriteLine($"{cambioDisplay} billete/s de 1"); 
        }
    }
}
