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
electrodomesticos[0] = new Electrodomestico();
electrodomesticos[1] = new Electrodomestico(200, 49);
electrodomesticos[2] = new Electrodomestico();
electrodomesticos[3] = new Lavadora();
electrodomesticos[4] = new Lavadora(140, 30);
electrodomesticos[5] = new Lavadora();
electrodomesticos[6] = new Television();
electrodomesticos[7] = new Television(500, 90);
electrodomesticos[8] = new Television();

for(int i = 0; i < electrodomesticos.Length - 1; i++) {

    electrodomesticos[i].precioFinal();

    if (electrodomesticos[i] is Electrodomestico) {

        Electrodomestico e = electrodomesticos[i];
        Console.WriteLine($"Electrodomestico{i} -> Color: {e.Color.ToString()}, Consumo: {e.Consumo}, Precio: {e.Precio_base}E, Peso: {e.Peso}Kg");
    
    } else if (electrodomesticos[i] is Lavadora) {

        Electrodomestico e = electrodomesticos[i];
        Console.WriteLine($"Lavadora{i} -> ");
    
    } else if (electrodomesticos[i] is Television) {

        Electrodomestico e = electrodomesticos[i];
        Console.WriteLine($"Television{i} -> ");
    
    }

}

Console.WriteLine();