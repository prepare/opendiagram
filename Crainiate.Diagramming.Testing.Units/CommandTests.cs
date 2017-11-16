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
    public class CommandTests
    {
        [TestMethod]
        public void CommandTestTranslate()
        {
            //Set up the model
            Model model = new Model();
            model.SetSize(new SizeF(1000, 1000)); //Set the container size so that the shape can be moved

            //Set up the shape element
            Shape shape = new Shape();
            shape.Location = new PointF(100, 100);
            model.Shapes.Add("Shape1", shape);

            //Set up the controller 
            Controller controller = new Controller(model);

            //Set up the action
            shape.ActionElement = controller.CloneElement(shape);

            //Set up the command
            TranslateCommand command = controller.CommandFactory.CreateTranslateCommand();

            command.Elements = new ElementList(true);
            command.Elements.Add(shape);
            command.Dx = 20;
            command.Dy = 30;
            
            //Translate the action and execute the command
            command.Translate();
            command.Execute();
            Assert.IsTrue(shape.Location == new PointF(120,130), "Translate command not applied correctly to shape.");

            command.Undo();
            Assert.IsTrue(shape.Location == new PointF(100, 100), "Translate command not undone correctly for shape.");

            command.Redo();
            Assert.IsTrue(shape.Location == new PointF(120, 130), "Translate command not redone correctly to shape.");
        }

        [TestMethod]
        public void CommandTestScale()
        {
            //Set up the model
            Model model = new Model();
            model.SetSize(new SizeF(1000, 1000)); //Set the container size so that the shape can be moved

            //Set up the shape element
            Shape shape = new Shape();
            shape.Location = new PointF(100, 100);
            shape.Size = new SizeF(50, 50);
            model.Shapes.Add("Shape1", shape);

            //Set up the controller 
            Controller controller = new Controller(model);

            //Set up the action
            shape.ActionElement = controller.CloneElement(shape);

            //Set up the command
            ScaleCommand command = controller.CommandFactory.CreateScaleCommand();

            command.Elements = new ElementList(true);
            command.Elements.Add(shape);
            command.MouseElements = new MouseElements();
            command.MouseElements.MouseHandle = new Handle(HandleType.BottomRight);
            command.Dx = 10;
            command.Dy = 20;

            //Translate the action and execute the command
            command.Scale();
            command.Execute();
            Assert.IsTrue(shape.Size == new SizeF(60, 70), "Scale command not applied correctly to shape.");

            command.Undo();
            Assert.IsTrue(shape.Size == new SizeF(50, 50), "Scale command not undone correctly for shape.");

            command.Redo();
            Assert.IsTrue(shape.Size == new SizeF(60, 70), "Scale command not redone correctly for shape.");
        }

        [TestMethod]
        public void CommandTestRotate()
        {
            //Set up the model
            Model model = new Model();
            model.SetSize(new SizeF(1000, 1000)); //Set the container size so that the shape can be moved

            //Set up the shape element
            Shape shape = new Shape();
            shape.AllowRotate = true;
            shape.Location = new PointF(100, 100);
            model.Shapes.Add("Shape1", shape);

            //Set up the controller 
            Controller controller = new Controller(model);

            //Set up the action
            shape.ActionElement = controller.CloneElement(shape);

            //Set up the command
            RotateCommand command = controller.CommandFactory.CreateRotateCommand();

            command.Elements = new ElementList(true);
            command.Elements.Add(shape);
            command.Degrees = 90;

            //Translate the action and execute the command
            command.Rotate();
            command.Execute();
            Assert.IsTrue(shape.Rotation == 90, "Rotate command not applied correctly to shape.");

            command.Undo();
            Assert.IsTrue(shape.Rotation == 0, "Rotate command not undone correctly for shape.");

            command.Redo();
            Assert.IsTrue(shape.Rotation == 90, "Rotate command not redone correctly to shape.");
        }

        [TestMethod]
        public void CommandTestProperty()
        {
            //Set up the model
            Model model = new Model();
            model.SetSize(new SizeF(1000, 1000)); //Set the container size so that the shape can be moved

            //Set up the shape element
            Shape shape = new Shape();
            shape.Location = new PointF(100, 100);
            shape.BackColor = Color.White;
            model.Shapes.Add("Shape1", shape);

            //Set up the controller 
            Controller controller = new Controller(model);

            //Set up the command, this stores any values of the shape in a momento
            PropertyCommand command = controller.CommandFactory.CreatePropertyCommand(shape);

            shape.BackColor = Color.Blue;

            //Execute the command
            command.Execute();

            Assert.IsTrue(shape.BackColor.ToArgb()  == Color.Blue.ToArgb(), "Property command not executed correctly.");

            command.Undo();
            Assert.IsTrue(shape.BackColor.ToArgb() == Color.White.ToArgb(), "Property command undo not executed correctly.");

            command.Redo();
            Assert.IsTrue(shape.BackColor.ToArgb() == Color.Blue.ToArgb(), "Property command redo not executed correctly.");
        }

        [TestMethod]
        public void CommandTestText()
        {
            //Set up the model
            Model model = new Model();

            //Set up the shape element
            Label label = new Label("Hello world");

            //Set up the controller 
            Controller controller = new Controller(model);

            //Set up the command, this stores any values of the shape in a momento
            TextCommand command = controller.CommandFactory.CreateTextCommand();
            command.CommandText = "bold";
            command.Labels.Add(label);
        
            //Execute the command
            command.Execute();

            Assert.IsTrue(label.Bold, "Text command not executed correctly.");

            command.Undo();
            Assert.IsTrue(!label.Bold, "Textcommand undo not executed correctly.");

            command.Redo();
            Assert.IsTrue(label.Bold, "Text command redo not executed correctly.");
        }
    }
}
