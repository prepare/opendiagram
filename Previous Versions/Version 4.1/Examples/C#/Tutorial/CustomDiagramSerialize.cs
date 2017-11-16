using System;
using System.Runtime.Serialization;
using Crainiate.ERM4;

namespace WindowsApplication1
{
	public class CustomDiagramSerialize: Crainiate.ERM4.Serialization.ModelSerialize
	{
		public override void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(obj,info,context);

			CustomDiagram custom = (CustomDiagram) obj;
			
			info.AddValue("Watermark",custom.Watermark);
		}

		public override object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			base.SetObjectData(obj,info,context,selector);

			CustomDiagram custom = (CustomDiagram) obj;
			custom.SetRender(new CustomRender()); //Recreate custom render since no constructor is called
			
			custom.Suspend();
			custom.Watermark = info.GetString("Watermark");
			custom.Resume();
			
			return custom;
		}
	}
}
