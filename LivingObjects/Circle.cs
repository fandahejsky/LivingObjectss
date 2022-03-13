using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingObjects
{
    internal class Circle : LivingObject
    {
        public override int ClickCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Click(Point mousePos)
        {
            throw new NotImplementedException();
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override bool IsMouseOver(Point mousePos)
        {
            throw new NotImplementedException();
        }
    }
}

