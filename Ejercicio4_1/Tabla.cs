namespace Ejercicio4_1
{
    public class Tabla
    {
        public static string Multiplicar(int num)
        {
            string tabla = "";

            for (int i = 1; i <= 10; i++)
            {
                tabla += $"{i} X {num} = {num*i}\n";
            }

            return tabla;
        }
    }
}