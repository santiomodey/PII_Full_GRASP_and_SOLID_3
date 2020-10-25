using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Este es un ejemplo de la implementación de la interfaz IPrinter
    /// donde se ve que utiliza la misma firma para la función y permite
    /// imprimir en un archivo con su implementación
    /// </summary>
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}