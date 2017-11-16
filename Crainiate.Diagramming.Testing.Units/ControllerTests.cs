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
    public class ControllerTests
    {
        [TestMethod]
        public void ControllerCommandUndoRedo()
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
            controller.ExecuteCommand(command);
            
            Assert.IsTrue(shape.Location == new PointF(120,130), "Translate command not applied correctly to controller.");
            Assert.IsTrue(controller.UndoStack.Count == 1, "Controller undo stack is not correct.");

            controller.UndoCommand();

            Assert.IsTrue(shape.Location == new PointF(100, 100), "Command Undo not applied correctly to controller.");
            Assert.IsTrue(controller.RedoStack.Count == 1, "Controller redo stack is not correct.");

            controller.RedoCommand();

            Assert.IsTrue(shape.Location == new PointF(120, 130), "Translate command not redone correctly on controller.");
            Assert.IsTrue(controller.UndoStack.Count == 1, "Controller undo stack is not correct after redo.");
            Assert.IsTrue(controller.RedoStack.Count == 0, "Controller redo stack is not correct after redo.");
        }
    }
}
