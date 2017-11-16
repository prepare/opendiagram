using Microsoft.VisualStudio.TestTools.UnitTesting;

using Crainiate.Diagramming.Layouts;

namespace Crainiate.Diagramming.Testing.Units
{
    [TestClass]
    public class LayoutTests
    {
        [TestMethod]
        public void LayoutListFactoryCreateTest()
        {
            GridNode node;
            ListFactory<GridNode> list = new ListFactory<GridNode>();
            
            node = list.Create();
            node.X = 1;
            node.Y = 1;

            Assert.IsTrue(list.InnerList.Count == 1, "Inner list not created correctly");

            list.Clear();

            Assert.IsTrue(list.InnerList.Count == 1, "Inner list not cleared correctly");
            Assert.IsTrue(list.Count == 0, "List pointer not reset correctly");
        }

        [TestMethod()] 
        public void LayoutListFactoryCreateMultipleTest()
        {
            GridNode node;
            ListFactory<GridNode> list = new ListFactory<GridNode>();
            
            node = list.Create();
            node.X = 1;
            node.Y = 1;

            node = list.Create();
            node.X = 2;
            node.Y = 2;
            
            list.Clear();

            Assert.IsTrue(list.InnerList.Count == 2, "Inner list not cleared correctly");

            node = list.Create();
            Assert.IsTrue(node.X == 0 && node.Y == 0, "Node has not been cleared");

            Assert.IsTrue(list.InnerList.Count == 2, "Inner list not recycled correctly");
        }
    }
}
