// Utilidad genérica para imprimir arreglos en consola
public static class ArrayUtils<T>
{
    public static void ImprimirArreglo(T[] arreglo)
    {
        if (arreglo == null || arreglo.Length == 0)
        {
            Console.WriteLine("No hay elementos para mostrar.");
            return;
        }
        foreach (var item in arreglo)
            Console.WriteLine(item?.ToString() ?? "Elemento nulo");
    }
}