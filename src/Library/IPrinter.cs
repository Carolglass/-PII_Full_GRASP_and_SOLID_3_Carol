using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library

//Se define un tipo IPrinter y dos clases que lo implementan, ConsolePrinter y FilePrinter
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}