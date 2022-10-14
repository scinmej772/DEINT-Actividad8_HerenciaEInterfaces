// See https://aka.ms/new-console-template for more information

using DEINT_Actividad8_HerenciaEInterfaces.Ejercicio1;
using DEINT_Actividad8_HerenciaEInterfaces.Ejercicio2;

//Ejercicio1
Console.WriteLine("Ejercicio1");

Empleado empleado = new Empleado("Rafa");
Directivo directivo = new Directivo("Mario");
Operario operario = new Operario("Alfonso");
Oficial oficial = new Oficial("Luis");
Tecnico tecnico = new Tecnico("Pablo");

Console.WriteLine(empleado.ToString());
Console.WriteLine(directivo.ToString());
Console.WriteLine(operario.ToString());
Console.WriteLine(oficial.ToString());
Console.WriteLine(tecnico.ToString());

Console.WriteLine();

//Ejercicio2
Console.WriteLine("Ejercicio2");

Electrodomestico[] electrodomesticos = new Electrodomestico[10];

Console.WriteLine();