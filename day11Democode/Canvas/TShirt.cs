﻿
namespace day11Democode.Canvas
{

    class TShirt : ICanvas
    {


        public void Draw(IDrawTool drawTool)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n Plane Drawing using{drawTool.Drawaltools()}");
            Console.ResetColor();
        }

        public void Undo()
        {

        }
    }


}






