
namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Esta interfaz fue creada debido a la violacion al Polimorfismo generada por la clase AllInOnePrinter
    /// la cual preguntaba por el destino de la impresión y hacia algo distinto en cada caso. Para resolver esto, la IPrinter
    /// permite que cada tipo de printer distinto la implemente y se pueda crear nuevas clases sin necesidad de cambiar
    /// el código.
    /// </summary>
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}