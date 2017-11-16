using System;
using Crainiate.ERM4;

public class CustomAnimation:Animation
{
	public CustomAnimation()
	{
		FramesPerSecond = 2;
		TotalFrames = 8;
	}

	protected override void OnAnimateElement(Element e)
	{
		//Keep the base call so that the event is raised
		base.OnAnimateElement (e);

		Shape shape = (Shape) e;
		shape.Rotation = shape.Animation.CurrentFrame * 45F;
	}

}
