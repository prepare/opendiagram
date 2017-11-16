using System;
using System.Windows.Forms;
using Crainiate.ERM4;

namespace WindowsApplication1
{
	[Serializable]
	public class CustomRuntime: Runtime
	{
		public override void SetFeedback(HandleType mouseHandleType)
		{
			//Only change feedback if the diagram is a model and if we are moving a shape
			if (mouseHandleType == HandleType.Move && Diagram is Model)
			{
				//Get a model reference from the IDiagram property
				Model model = (Model) Diagram;
				
				if (model.RenderDesign.Actions != null)
				{
					foreach (Element element in model.RenderDesign.Actions)
					{
						if (element.ActionElement == model.CurrentMouseElements.MouseStartElement)
						{
							if (element is Shape)
							{
								int percent = Convert.ToInt32(element.Rectangle.Location.X / model.DiagramSize.Width * 100);
								model.RenderDesign.Feedback = percent.ToString() + "%";
							}
						}
					}
				}
			}
			else
			{
				base.SetFeedback (mouseHandleType);
			}
		}


		public override ComplexShape CreateComplexShape(System.Drawing.PointF start, System.Drawing.SizeF size)
		{
			Server server = new Server();
			
			server.Location = start;
			server.Size = size;
			server.ServerType = ServerType.Business;
			
			return server;
		}
	}
}
