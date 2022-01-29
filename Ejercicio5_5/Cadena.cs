namespace Ejercicio5_5
{
    public class Cadena
    {
        public static string Numeros(int num)
        {
            string numeroPalabra = "";

            switch(num)
            {
                case 0:
                    numeroPalabra = "Cero";
                    break;
                case 1:
                    numeroPalabra = "Uno";
                    break;
                case 2:
                    numeroPalabra = "Dos";
                    break;
                case 3:
                    numeroPalabra = "Tres";
                    break;
                case 4:
                    numeroPalabra = "Cuatro";
                    break;
                case 5:
                    numeroPalabra = "Cinco";
                    break;
                case 6:
                    numeroPalabra = "Seis";
                    break;
                case 7:
                    numeroPalabra = "Siete";
                    break;
                case 8:
                    numeroPalabra = "Ocho";
                    break;
                case 9:
                    numeroPalabra = "Nueve";
                    break;
                case 10:
                    numeroPalabra = "Diez";
                    break;
            }

            return numeroPalabra;
        }
    }
}