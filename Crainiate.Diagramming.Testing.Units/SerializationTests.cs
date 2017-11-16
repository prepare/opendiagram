using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crainiate.Diagramming.Serialization;

namespace Crainiate.Diagramming.Testing.Units
{
    [TestClass]
    public class SerializationTests
    {
        private TestContext _testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }

        }

        [TestMethod]
        public void SerializationElementTest()
        {
            Element object1 = new Element();

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Element object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Element) serializer.Deserialize(stream2);
            }
        }

        [TestMethod]
        public void SerializationLineTest()
        {
            Link object1 = new Link();

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Link object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Link) serializer.Deserialize(stream2);
            }
        }

        [TestMethod]
        public void SerializationSolidTest()
        {
            Solid object1 = new Solid();

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Solid object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Solid) serializer.Deserialize(stream2);
            }
        }

        [TestMethod]
        public void SerializationShapeTest()
        {
            Shape object1 = new Shape();

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Shape object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Shape) serializer.Deserialize(stream2);
            }
        }

        [TestMethod]
        public void SerializationBlankTest()
        {
            //Serialize an element with a blank serializer
            Element object1 = new Element();

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            SurrogateSelector selector = new SurrogateSelector();
            StreamingContext context = new StreamingContext(StreamingContextStates.All); //Need to ensure a context is supplied
            selector.AddSurrogate(typeof(Element), context, new BlankSerialize());
            serializer.SurrogateSelector = selector;

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Element object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Element) serializer.Deserialize(stream2);
            }
        }

        [TestMethod]
        public void SerializationShapesTest()
        {
            Shapes object1 = new Shapes(new Model());
            Shape shape1 = new Shape();
            Shape shape2 = new Shape();

            shape1.Location = new PointF(10, 10);
            shape2.Location = new PointF(20, 20);

            object1.Add("shape1", shape1);
            object1.Add("shape2", shape2);

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Shapes object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Shapes) serializer.Deserialize(stream2);
            }

            Assert.IsTrue(object2.Count == 2, "Shapes collection does not contain 2 items.");
            Assert.IsTrue(object2.ContainsKey("shape1"), "Shapes collection does not contain key 'shape1'.");
            Assert.IsTrue(object2.ContainsKey("shape2"), "Shapes collection does not contain key 'shape2'.");
            Assert.IsTrue(object2["shape1"].Location == new PointF(10, 10), "Collection item 'shape1' location not deserialized correctly.");
            Assert.IsTrue(object2["shape2"].Location == new PointF(20, 20), "Collection item 'shape2' location not deserialized correctly.");
            Assert.IsTrue(object2.Model != null, "Shapes Model not deserialized correctly.");
        }

        [TestMethod]
        public void SerializationElementListTest()
        {
            ElementList object1 = new ElementList(true);
            Shape shape1 = new Shape();
            Shape shape2 = new Shape();

            shape1.Location = new PointF(10, 10);
            shape2.Location = new PointF(20, 20);

            object1.Add(shape1);
            object1.Add(shape2);

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            ElementList object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (ElementList) serializer.Deserialize(stream2);
            }

            Shape shape3 = object2[0] as Shape;
            Shape shape4 = object2[1] as Shape;

            Assert.IsTrue(object2.Count == 2, "ElementList collection does not contain 2 items.");
            Assert.IsTrue(shape3.Location == new PointF(10, 10), "Collection item 'shape1' location not deserialized correctly.");
            Assert.IsTrue(shape4.Location == new PointF(20, 20), "Collection item 'shape2' location not deserialized correctly.");
        }

        [TestMethod]
        public void SerializationModelTest()
        {
            Model model1 = new Model();

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, model1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Model model2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                model2 = (Model)serializer.Deserialize(stream2);
            }
        }

        [TestMethod]
        public void SerializationShallowLineTest()
        {
            Link object1 = new Link();

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Shallow = true;
            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2 using object 1 as the target
            Link object2;
            serializer.Target = object1;
            
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Link) serializer.Deserialize(stream2);
            }

            Assert.IsTrue(object1 == object2);
        }

        [TestMethod]
        public void SerializationExternalAssemblyTest()
        {
            SubElement object1 = new SubElement();

            SurrogateSelector selector = new SurrogateSelector();
            selector.AddSurrogate(typeof(SubElement), new StreamingContext(StreamingContextStates.All), new ElementSerialize());

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.SurrogateSelector = selector;
            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Element object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Element) serializer.Deserialize(stream2);
            }
        }

        [TestMethod]
        public void SerializationSubclassTest()
        {

            Link object1 = new Link(new Point(100,100), new Point(200,200));//Create a line with the same origin for testing

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Link object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Link )serializer.Deserialize(stream2);
            }

        }

        //Test that two identical objects are not serialized twice and are reserialized as the same reference
        [TestMethod]
        public void SerializationReferenceTest()
        {
            Origin origin = new Origin(new PointF(100, 100));
            Link object1 = new Link(origin, origin);

            //Serialize the object 
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Serialize(stream, object1);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Recreate the object in object 2
            Link object2;
            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                object2 = (Link)serializer.Deserialize(stream2);
            } 
            
            Assert.IsTrue(object2.Start == object2.End);
        }

        [TestMethod]
        public void SerializationDeepTargetTest()
        {
            //Set up the model
            Model model = new Model();
            model.SetSize(new SizeF(1000, 1000)); //Set the container size so that the shape can be moved

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

            //Serialize the model
            MemoryStream stream = new MemoryStream();
            XmlFormatter serializer = new XmlFormatter();

            serializer.Shallow = false;

            serializer.Serialize(stream, model);
            stream.Position = 0; // reset the stream to the beginning
            SqlXml xml = new SqlXml(stream);

            //Stream the data back into the same model object
            serializer.Target = model;

            using (MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(xml.Value)))
            {
                serializer.Deserialize(stream2);
            }

            Assert.IsTrue(model.Shapes.Count == 2, "Shapes count not set back to 2.");
            Assert.IsTrue(model.Lines.Count == 1, "Line count not set back to 1.");


        }

        [TestMethod]
        public void SerializationDocumentTest()
        {
            //Set up the model
            Model model = new Model();
            model.SetSize(new SizeF(1000, 1000)); //Set the container size so that the shape can be moved

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

            Document document = new Document(model);
            document.Save(TestContext.TestDir + "\\model.odmx");

            Document document2 = new Document();
            document.Open(TestContext.TestDir + "\\model.odmx");
        }

        [TestMethod]
        public void SerializationResourceTest()
        {
            //Set up the model
            Model model = new Model();
            model.SetSize(new SizeF(1000, 1000)); //Set the container size so that the shape can be moved

            //Set up a shape element
            Shape shape = new Shape();
            shape.Location = new PointF(100, 100);
            model.Shapes.Add("Shape1", shape);

            //Set up an image
            Bitmap bitmap = new Bitmap(100, 100);
           
            //Draw a red square
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Red);
                graphics.DrawRectangle(new Pen(Color.Blue), new Rectangle(10, 10, 80, 80));
            }

            //Assign to shape
            shape.Image = new Image(bitmap);

            Document document = new Document(model);
            document.Save(TestContext.TestDir + "\\model2.odmx");

            Document document2 = new Document();
            document.Open(TestContext.TestDir + "\\model2.odmx");

            //Assert a resource was created
            Assert.IsTrue(document.Formatter.Resources.Count >= 1, "No output package image resource found.");
            Assert.IsTrue(document2.Formatter.Resources.Count >= 1, "No input package resource found.");
        }
    }
}
