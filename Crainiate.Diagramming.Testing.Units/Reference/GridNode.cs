using System;
using System.Drawing;
using System.Collections;

namespace Crainiate.Diagramming.Layouts
{
	internal class GridNode: IDisposable
	{
		public int X; 
		public int Y; 

		public GridNode()
		{

		}

		public GridNode(int x, int y)
		{
			X = x;
			Y = y;
		}

        public void Dispose()
        {
            X = 0;
            Y = 0;
        }
	}
}