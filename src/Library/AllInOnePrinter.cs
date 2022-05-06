//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------

//Clase del codigo inicial
//No cumple con patron polimorfismo
//El codigo varia segun el destino, deberia estar en diferentes clases. 
//Se tendra que definir IPrinter y dos clases que lo implementen.
//Estas clases serían ConsoleP (consola) y FileP (impresora)

using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination



    {
        Console,
        File
    }

    public class AllInOnePrinter



    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
            }
        }
    }
}
