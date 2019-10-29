using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class ScreenStack
    {
        int count;
        Screen[] screens;

        public ScreenStack(int amountOfScreens)
        {
            screens = new Screen[amountOfScreens];
        }

        public void Push(Screen screen)
        {
            screens[count] = screen;
            count++;
        }

        public void Pop()
        {
            count--;
        }

        public Screen Peek()
        {
            return screens[count-1];
        }

        public Screen BackPeek()
        {
            return screens[count-2];
        }

    }
}
