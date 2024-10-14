namespace Rectangle.Test
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Rectangle_CorrectVertices_AssignsValues()
        {
            double x1 = 1.1, y1 = 1, x2 = 4, y2 = 9999.99;

            Rectangle r = new Rectangle(x1, y1, x2, y2);

            Assert.AreEqual(x1, r.X1);
            Assert.AreEqual(y1, r.Y1);
            Assert.AreEqual(x2, r.X2);
            Assert.AreEqual(y2, r.Y2);
        }

        [TestMethod]
        public void Constructor_SameVertices_ShouldThrowArgumentException()
        {
            double x1 = 1, y1 = 1, x2 = 1, y2 = 1;
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(x1, y1, x2, y2));
        }

        [TestMethod]
        public void Constructor_VerticesOnSameAxis_ShouldThrowArgumentException()
        {
            double x1 = 1, y1 = 1, x2 = 1, y2 = 5;
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(x1, y1, x2, y2));
        }

        [TestMethod]
        public void Perimeter_CorrectValues_ShouldReturnPerimeter()
        {
            var rectangle = new Rectangle(0, 0, 1, 9);
            double perimeter = rectangle.Perimeter();

            Assert.AreEqual(20, perimeter);
        }

        [TestMethod]
        public void Indexer_InvalidIndex_ShouldThrowIndexOutOfRangeException()
        {
            Rectangle rectangle = new Rectangle(1, 1, 4, 5);
            Assert.ThrowsException<IndexOutOfRangeException>(() => { var side = rectangle[2]; });
        }
    }
}