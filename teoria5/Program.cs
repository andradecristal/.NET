using teoria5;


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ejercicio 1~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
/*Cuenta c1 = new Cuenta();
c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
Cuenta c2 = new Cuenta();
c2.Depositar(200).Depositar(800);
new Cuenta().Depositar(20).Extraer(20);
c2.Extraer(1000).Extraer(1);
Console.WriteLine("\nDETALLE");
Cuenta.ImprimirDetalle();*/


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ejercicio 2~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
/*new Cuenta();
new Cuenta();
List<Cuenta> cuentas = Cuenta.GetCuentas();
// se recuperó la lista de cuentas creadas
cuentas[0].Depositar(50);
// se depositó 50 en la primera cuenta de la lista devuelta
cuentas.RemoveAt(0);
Console.WriteLine(cuentas.Count);
// se borró un elemento de la lista devuelta
// pero la clase Cuenta sigue manteniendo todos
// los datos "La cuenta id: 1 tiene 50 de saldo"
cuentas = Cuenta.GetCuentas();
// se recuperó nuevamente la lista de cuentas
Console.WriteLine(cuentas.Count);
cuentas[0].Extraer(30);
//se extrajo 30 de la cuenta id: 1 que tenía 50 de saldo*/


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ejercicio 12~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Caso A:
Libro libro1 = new Libro();
// Caso B:
Libro libro2 = new Libro
{
Titulo = "C# Moderno",
FechaPublicacion = new DateTime(2026, 1, 1),
Precio = 4500.0,
ISBN = "978-3-16-148410-0"
};
// Caso C:
Libro libro3 = new Libro("978-3-16-148410-0") {Titulo="C# Moderno"};
libro3.Precio=4500.0;
// Caso D:
libro3.ISBN = "978-3-16-148410-9";
libro3.FechaPublicacion = DateTime.Now;
libro3.Titulo=".NET Moderno";