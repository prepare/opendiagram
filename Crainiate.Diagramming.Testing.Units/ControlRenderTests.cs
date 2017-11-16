using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Crainiate.Diagramming.Forms;
using Crainiate.Diagramming.Forms.Rendering;

namespace Crainiate.Diagramming.Testing.Units
{
    /// <summary>
    /// Summary description for RenderTest
    /// </summary>
    [TestClass]
    public class ControlRenderTests
    {
        [TestMethod]
        public void TestSimpleRender()
        {
            Model model = new Model();

            Shape shape = new Shape();
            model.Shapes.Add("Shape1", shape);

            ControlRender render = new ControlRender();

            render.Layers = model.Layers;
            render.Elements = model.Elements;
            render.RenderDiagram(new Rectangle(0, 0, 500, 500), new Paging());
        }
    }
}
