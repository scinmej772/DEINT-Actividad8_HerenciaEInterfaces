// See https://aka.ms/new-console-template for more information

using DEINT_Actividad8_HerenciaEInterfaces.Ejercicio1;
using DEINT_Actividad8_HerenciaEInterfaces.Ejercicio2;
using DEINT_Actividad8_HerenciaEInterfaces.Ejercicio3;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

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
electrodomesticos[2] = new Electrodomestico("Rojo", 'A', 100, 70);
electrodomesticos[3] = new Lavadora();
electrodomesticos[4] = new Lavadora(140, 30);
electrodomesticos[5] = new Lavadora("Gris", 'A', 630, 400, 8);
electrodomesticos[6] = new Television();
electrodomesticos[7] = new Television(500, 90);
electrodomesticos[8] = new Television("Negro", 'D', 700, 60, 55, true);
electrodomesticos[9] = new Television("Azul", 'E', 200, 8, 27, false);

for (int i = 0; i < electrodomesticos.Length; i++) {

    electrodomesticos[i].precioFinal();

    if (electrodomesticos[i].GetType() == typeof(Electrodomestico))
    {
        Console.WriteLine($"Index-{i} -- {electrodomesticos[i].ToStringElec()}");
    }
    else {
        Console.WriteLine($"Index-{i} -- {electrodomesticos[i].ToString()}");
    }
    
}

Console.WriteLine();

//Ejercicio3
Console.WriteLine("Ejercicio3");

Serie[] series = new Serie[5];
Videojuego[] videojuegos = new Videojuego[5];

series[0] = new Serie();
series[1] = new Serie("She Hulk", "Marvel");
series[2] = new Serie("Loky", 1, "Accion", "Marvel");
series[3] = new Serie("How to get away with a murderer", "ShondaLand");
series[4] = new Serie("The umbrella academy", 3, "Accion", "Netflix");

videojuegos[0] = new Videojuego();
videojuegos[1] = new Videojuego("Valorant", "Riot Games");
videojuegos[2] = new Videojuego("COD:MW2 2019", 7, "Shooter", "Activision");
videojuegos[3] = new Videojuego("CS:GO", "Valve");
videojuegos[4] = new Videojuego("It takes two", 14, "Aventuras", "EA Games");

series[1].entregar();
series[3].entregar();
series[4].entregar();

videojuegos[2].entregar();
videojuegos[4].entregar();

Int16 contSer = 0;
foreach (var s in series) {
    Console.WriteLine(s.ToString());
    if (s.isEntregado()) {
        contSer++;
        s.devolver();
    }
}

Int16 contVJ = 0;
foreach (var vj in videojuegos) {
    Console.WriteLine(vj.ToString());
    if (vj.isEntregado()) {
        contVJ++;
        vj.devolver();
    }
}

Console.WriteLine($"Series entregadas: {contSer}, Videojuegos entregados: {contVJ}");