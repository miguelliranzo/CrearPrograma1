

namespace CrearPrograma4.Class
{
    public class Calcular
    {
        public void CalcularCuadro() {
            int lado = 0;

            Console.WriteLine("Inserte la carga del lado del cuadrado: ");
            lado= Convert.ToInt32(Console.ReadLine());

            var perimetro = lado * 4;

            Console.WriteLine($"El perimetro del cuadrado es: {perimetro}");

        
        
        }
    }
}
