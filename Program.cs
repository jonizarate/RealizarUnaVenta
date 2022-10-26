string codIngresad = "";
int sumaTotal = 0;
int unidades = 0;

do
{
    selecDeCodigo();
    sumaDePreciosXCodigo(unidades);

} while (codIngresad != "FIN");

void selecDeCodigo()
{
    Console.WriteLine("Ingrese codigo de compra: ");
    codIngresad = Console.ReadLine();
    if (codIngresad != "FIN")
    {
        Console.WriteLine("Cuantas unidades desea comprar?");
        unidades = int.Parse(Console.ReadLine());
    }
}

void sumaDePreciosXCodigo(int cantidad)
{
    if (codIngresad == "DES")
    {
        sumaTotal += 200 * cantidad;
    }
    else if (codIngresad == "JP")
    {
        sumaTotal += 300*cantidad;
    }
    else if (codIngresad == "DET")
    {
        sumaTotal += 250*cantidad;
    }
    else if (codIngresad == "FIN")
    {
        Console.WriteLine("Valor total de la cuenta: {0}",sumaTotal);
        Console.WriteLine("Desea confirmar la compra? YES/NO");
        string rspuesta = Console.ReadLine();
        if (rspuesta == "YES")
        {
            Console.WriteLine("Gracias por comprar en nuestra tienda");
        }
    }
}