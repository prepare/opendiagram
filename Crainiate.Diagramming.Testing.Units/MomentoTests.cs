using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Crainiate.Diagramming;
using Crainiate.Diagramming.Serialization;

namespace Crainiate.Diagramming.Testing.Units
{
    [TestClass]
    public class MomentoTests
    {
        [TestMethod]
        public void MomentoElementCreateTest()
        {
            Element element = new Element();
            ElementMomento momento = new ElementMomento(element);
            Element element2 = momento.CreateItem();
        }

        [TestMethod]
        public void MomentoElementWriteTest()
        {
            Element element = new Element();
            ElementMomento momento = new ElementMomento(element);
            momento.WriteItem(element);
        }

        [TestMethod]
        public void MomentoElementSubclassTest()
        {
            Shape shape = new Shape();
            shape.MinimumSize = new SizeF(8, 8);

            ElementMomento momento = new ElementMomento(shape);
            shape.MinimumSize = new SizeF(0, 0);
            momento.WriteItem(shape);

            Assert.IsTrue(shape.MinimumSize == new SizeF(8, 8), "Subclassed type not recorded by memento.");
        }

        [TestMethod]
        public void MomentoLabelCreateTest()
        {
            Label label = new Label();
            LabelMomento momento = new LabelMomento(label);
            Label label2 = momento.CreateItem();
        }

        [TestMethod]
        public void MomentoModelCreateTest()
        {
            Model model = new Model();

            //Set up a shape element
            Shape shape = new Shape();
            shape.Location = new PointF(100, 100);
            model.Shapes.Add("Shape1", shape);

            //Set up another shape element
            Shape shape2 = new Shape();
            shape2.Location = new PointF(200, 200);
            model.Shapes.Add("Shape2", shape2);

            //Connect with a line
            Link line = new Link(shape, shape2);
            model.Lines.Add("Line1", line);

            ModelMomento momento = new ModelMomento(model);
            Model model2 = momento.CreateItem();

            Assert.IsTrue(model2.Shapes != null, "Model shapes not created.");
            Assert.IsTrue(model2.Shapes.Count == 2, "Model shapes count not correct.");
            Assert.IsTrue(model2.Lines != null, "Model lines not created.");
            Assert.IsTrue(model2.Lines.Count == 1, "Model lines count not correct.");
        }
    }
}
