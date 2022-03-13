using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingObjects
{
    internal class LivingObjectSpawner
    {
        private List<Type> typesToGenerate = new List<Type>()
        {
            typeof(Circle), typeof(Square)
        };
        private Size size;
        private static Random random = new Random();

        public LivingObjectSpawner(Size size)
        {
            this.size = size;
        }

        private Point GetRandomPosition()
        {
            return new Point(random.Next(0, size.Width), random.Next(size.Height));
        }

        public LivingObject SpawnRandomObject()
        {
           var newObj =  Activator.CreateInstance(GetRandomObjectType() ) as LivingObject;
            newObj.Position = GetRandomPosition();
            return newObj;
        }

        private Type GetRandomObjectType()
        {
            return typesToGenerate[random.Next(0, typesToGenerate.Count)];
        }

    }
}
