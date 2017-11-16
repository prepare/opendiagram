using System;
using System.Runtime.Serialization;
using Crainiate.ERM4;

namespace WindowsApplication1
{
	public class CustomDiagram: Model
	{
		public CustomDiagram(): base()
		{
			CustomRender render = new CustomRender();
			SetRender(render);

			Watermark = "Watermark";
		}

		//Properties
		public virtual string Watermark
		{
			get
			{
				CustomRender render = (CustomRender) Render;
				return render.Watermark;
			}
			set
			{
				CustomRender render = (CustomRender) Render;
				render.Watermark = value;
			}
		}

		//Overrides
		protected override void OnSerialize(IFormatter formatter, SurrogateSelector selector)
		{
			selector.AddSurrogate(typeof(CustomDiagram),new StreamingContext(StreamingContextStates.All), new CustomDiagramSerialize());
			base.OnSerialize (formatter, selector);
		}

		protected override void OnDeserialize(System.Runtime.Serialization.IFormatter formatter, System.Runtime.Serialization.SurrogateSelector selector)
		{
			selector.AddSurrogate(typeof(CustomDiagram),new StreamingContext(StreamingContextStates.All), new CustomDiagramSerialize());
			base.OnDeserialize (formatter, selector);
		}

		protected override void OnDeserializeComplete(object graph, IFormatter formatter, SurrogateSelector selector)
		{
			CustomDiagramSerialize surrogate = (CustomDiagramSerialize) Crainiate.ERM4.Serialization.Serialize.GetSurrogate(graph,selector);
			CustomDiagram custom = (CustomDiagram) graph;

			//Apply surrogate settings
			SuspendEvents = true;
			Suspend();

			Watermark = custom.Watermark;

			Resume();
			SuspendEvents = false;

			base.OnDeserializeComplete (graph, formatter, selector);
		}
	}
}
