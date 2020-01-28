using BMVE.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE
{
    class Code : Runnable
    {
        public override void Main()
        {
            int previous = 0;
            System_SetBufferedDrawingMode();
            Stopwatch_Start(1);
            while (!Input_UpArrowKeyPressed())
            {

                if (Stopwatch_GetMillisecondsElapsed(1) - previous > 40)
                {
                    Screen_Clear();

                    Console_WriteLine("Hello, Guys");
                    Console_WriteLine("Hello, Guys");
                    Console_WriteLine("Hello, Guys");
                    Console_WriteLine("Hello, Guys");
                    Console_WriteLine("Hello, Guys");
                    Text_Write(String_Format("X={0} Y={1}", Input_GetMousePositionX(), Input_GetMousePositionY()), 100, 20, RGB(255,0,0));

                    Draw_Line(0, 0, Input_GetMousePositionX(), Input_GetMousePositionY(), RGB(0, 255, 0));
                    Screen_Render();
                    previous = Stopwatch_GetMillisecondsElapsed(1);
                }
            }
        }

    }
}
