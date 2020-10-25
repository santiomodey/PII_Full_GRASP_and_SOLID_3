using System;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Este es un ejemplo de la implementación de la interfaz IPrinter
    /// donde se ve que utiliza la misma firma para la función y permite
    /// imprimir por pantalla con su implementación
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}