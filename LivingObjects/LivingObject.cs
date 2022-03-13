using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingObjects
{ 
    //abstraktni trida kvuli spojeni interfacu
    internal abstract class LivingObject : IDrawable, IClickable
    {

        

        public abstract int ClickCount { get; set; }

        public Point Poisiton { get; set; }
        public Point Position { get; internal set; }

        public abstract void Click(Point mousePos);

        public abstract void Draw(Graphics g);

        public abstract bool IsMouseOver(Point mousePos);

    }
}
