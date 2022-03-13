using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingObjects
{
    internal interface IClickable
    {

        void Click(Point mousePos);

        int ClickCount { get; set; } //cte se a chceme ji i nastavovat // vlastnost

        bool IsMouseOver(Point mousePos);


    }
}
