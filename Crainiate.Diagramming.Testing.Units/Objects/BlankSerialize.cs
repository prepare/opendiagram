using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace Crainiate.Diagramming.Serialization
{
	public class BlankSerialize: ISerializationSurrogate
	{
		public virtual void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{ 
		}

		public virtual object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
            return obj;
		}
	}
}
