using System;
using System.Drawing;
using System.Drawing.Drawing2D;

using Crainiate.ERM4;

namespace WindowsApplication1
{
	public enum ArrowType
	{
		Left = 0,
		Up = 1,
		Down = 2,
		Right = 3
	}

	public class CustomStencil: Stencil
	{
		public CustomStencil()
		{
			CreateStencilItems();
		}

		public virtual StencilItem this[ArrowType type]  
		{
			get  
			{
				string key = type.ToString();
				return (StencilItem) Dictionary[key];
			}
		}

		//Adds a stencil item for each enumeration value to the stencil collection
		private void CreateStencilItems()
		{
			SetModifiable(true);

			//Loop through each enumeration and add as a stencil item
			foreach (string key in Enum.GetNames(typeof(ArrowType)))
			{
				StencilItem item = new StencilItem();
				item.DrawShape +=new DrawShapeEventHandler(StencilItem_DrawShape);

				Add(key, item);
			}

			SetModifiable(false);
		}

		//Handles the DrawShape event
		private void StencilItem_DrawShape(object sender, DrawShapeEventArgs e)
		{
			//Get the stencil item to draw on, and the type of arrow from the key
			StencilItem stencil = (StencilItem) sender;
			ArrowType arrowType = (ArrowType) Enum.Parse(typeof(ArrowType),stencil.Key); 

			//Draw the arrow using a 100x100 grid 
			e.Path.AddLine(0,30,60,30);
			e.Path.AddLine(60,30,60,0);
			e.Path.AddLine(60,0,100,50);
			e.Path.AddLine(100,50,60,100);
			e.Path.AddLine(60,100,60,70);
			e.Path.AddLine(60,70,0,70);
			
			//Close the figure
			e.Path.CloseFigure(); 

			//Rotate the path depending on the type of arrow
			Matrix translateMatrix = new Matrix();
			if (arrowType == ArrowType.Right) translateMatrix.RotateAt(180,new PointF(50,50));
			if (arrowType == ArrowType.Up) translateMatrix.RotateAt(-90,new PointF(50,50));
			if (arrowType == ArrowType.Down) translateMatrix.RotateAt(90,new PointF(50,50));

			//Scale the matrix and apply it back to the path
			translateMatrix.Scale(e.Width / 100, e.Height / 100);
			e.Path.Transform(translateMatrix);
		}
	}
}
