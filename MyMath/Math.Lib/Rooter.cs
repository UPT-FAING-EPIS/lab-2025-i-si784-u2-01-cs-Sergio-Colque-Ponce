namespace Math.Lib
{
    /// <summary>
    /// Clase que proporciona operaciones matemáticas relacionadas con raíces cuadradas.
    /// </summary>
    public class Rooter
    {
        /// <summary>
        /// Calcula la raíz cuadrada de un número positivo usando el método de Newton-Raphson.
        /// </summary>
        /// <param name="input">Número del cual se desea calcular la raíz cuadrada. Debe ser positivo.</param>
        /// <returns>La raíz cuadrada del número ingresado.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Se lanza si el número ingresado es negativo o cero.</exception>
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(input), "El valor ingresado es invalido, solo se puede ingresar números positivos");

            double result = input;
            double previousResult = -input;
            while (System.Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }
            return result;
        }
    }
}