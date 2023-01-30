using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealGUI
{
    public class Container : Items
    {
        List<ChildItems> items = new List<ChildItems>();

        public Container(string name, Vector2 pos, Vector2 sze, Color Background) : base(name, pos, sze, Background)
        {
            ChildItems.GetParent(this);
        }


        public override void init()
        {
            base.init();
        }

        public override void draw()
        {
            throw new NotImplementedException();
        }

        public override void update()
        {
            throw new NotImplementedException();
        }


        private class ChildItems
        {
            private static Container Container;

            private Vector2 position;

            private Vector2 size;
            public ChildItems(Vector2 pos, Vector2 size)
            {
                this.position = pos;
                this.size = size;
            }


            public static Container GetParent(Container container)
            {
               Container = container;

                return container;
            }
        }
    }

}
