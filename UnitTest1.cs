using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPenUp()
        {
            Turtle turtle = new Turtle();

            turtle.PenUp();

            Assert.IsFalse(turtle.PenDown, "Pen should be up after calling PenUp.");
        }

        [TestMethod]
        public void TestPenDown()
        {
            Turtle turtle = new Turtle();

            turtle.PenDown();

            Assert.IsTrue(turtle.PenDown, "Pen should be down after calling PenDown.");
        }
    }
    public class DotTests
    {
        [TestMethod]
        public void TestEquals_SameDotInstance_ShouldBeEqual()
        {
            // Arrange
            Dot dot = new Dot(1.0f, 2.0f);

            // Act & Assert
            Assert.AreEqual(dot, dot, "Same Dot instance should be equal.");
        }

        [TestMethod]
        public void TestEquals_EqualDots_ShouldBeEqual()
        {
            // Arrange
            Dot dot1 = new Dot(1.0f, 2.0f);
            Dot dot2 = new Dot(1.0f, 2.0f);

            // Act & Assert
            Assert.AreEqual(dot1, dot2, "Equal Dots should be equal.");
        }

        [TestMethod]
        public void TestEquals_DifferentDots_ShouldNotBeEqual()
        {
            // Arrange
            Dot dot1 = new Dot(1.0f, 2.0f);
            Dot dot2 = new Dot(3.0f, 4.0f);

            // Act & Assert
            Assert.AreNotEqual(dot1, dot2, "Different Dots should not be equal.");
        }

        [TestMethod]
        public void TestEquals_NullObject_ShouldNotBeEqual()
        {
            // Arrange
            Dot dot = new Dot(1.0f, 2.0f);

            // Act & Assert
            Assert.AreNotEqual(dot, null, "Dot should not be equal to null.");
        }

        [TestMethod]
        public void TestGetHashCode_EqualDots_ShouldHaveSameHashCode()
        {
            // Arrange
            Dot dot1 = new Dot(1.0f, 2.0f);
            Dot dot2 = new Dot(1.0f, 2.0f);

            // Act & Assert
            Assert.AreEqual(dot1.GetHashCode(), dot2.GetHashCode(), "Equal Dots should have the same hash code.");
        }

        [TestMethod]
        public void TestGetHashCode_DifferentDots_ShouldHaveDifferentHashCodes()
        {
            // Arrange
            Dot dot1 = new Dot(1.0f, 2.0f);
            Dot dot2 = new Dot(3.0f, 4.0f);

            // Act & Assert
            Assert.AreNotEqual(dot1.GetHashCode(), dot2.GetHashCode(), "Different Dots should have different hash codes.");
        }
    }
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void TestEquals_SameFigureInstance_ShouldBeEqual()
        {
            // Arrange
            Figure figure = new Figure();

            // Act & Assert
            Assert.AreEqual(figure, figure, "Same Figure instance should be equal.");
        }

        [TestMethod]
        public void TestEquals_EqualFigures_ShouldBeEqual()
        {
            // Arrange
            Figure figure1 = new Figure();
            Figure figure2 = new Figure();

            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black");

            figure1.AddLine(line1);
            figure1.AddLine(line2);

            figure2.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure2.AddLine(new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black"));

            // Act & Assert
            Assert.AreEqual(figure1, figure2, "Equal Figures should be equal.");
        }

        [TestMethod]
        public void TestEquals_DifferentFigures_ShouldNotBeEqual()
        {
            // Arrange
            Figure figure1 = new Figure();
            Figure figure2 = new Figure();

            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black");

            figure1.AddLine(line1);
            figure1.AddLine(line2);

            figure2.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            // Different line in figure2
            figure2.AddLine(new Line(new Dot(9.0f, 10.0f), new Dot(11.0f, 12.0f), "black"));

            // Act & Assert
            Assert.AreNotEqual(figure1, figure2, "Different Figures should not be equal.");
        }

        [TestMethod]
        public void TestGetHashCode_EqualFigures_ShouldHaveSameHashCode()
        {
            // Arrange
            Figure figure1 = new Figure();
            Figure figure2 = new Figure();

            figure1.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure1.AddLine(new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black"));

            figure2.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure2.AddLine(new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black"));

            // Act & Assert
            Assert.AreEqual(figure1.GetHashCode(), figure2.GetHashCode(), "Equal Figures should have the same hash code.");
        }

        [TestMethod]
        public void TestGetHashCode_DifferentFigures_ShouldHaveDifferentHashCodes()
        {
            // Arrange
            Figure figure1 = new Figure();
            Figure figure2 = new Figure();

            figure1.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure1.AddLine(new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black"));

            figure2.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            // Different line in figure2
            figure2.AddLine(new Line(new Dot(9.0f, 10.0f), new Dot(11.0f, 12.0f), "black"));

            // Act & Assert
            Assert.AreNotEqual(figure1.GetHashCode(), figure2.GetHashCode(), "Different Figures should have different hash codes.");
        }
    }
    [TestClass]
    public class LineTests
    {
        [TestMethod]
        public void TestEquals_SameLineInstance_ShouldBeEqual()
        {
            // Arrange
            Dot startDot = new Dot(1.0f, 2.0f);
            Dot endDot = new Dot(3.0f, 4.0f);
            Line line = new Line(startDot, endDot, "black");

            // Act & Assert
            Assert.AreEqual(line, line, "Same Line instance should be equal.");
        }

        [TestMethod]
        public void TestEquals_EqualLines_ShouldBeEqual()
        {
            // Arrange
            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");

            // Act & Assert
            Assert.AreEqual(line1, line2, "Equal Lines should be equal.");
        }

        [TestMethod]
        public void TestEquals_DifferentLines_ShouldNotBeEqual()
        {
            // Arrange
            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black");

            // Act & Assert
            Assert.AreNotEqual(line1, line2, "Different Lines should not be equal.");
        }

        [TestMethod]
        public void TestEquals_ReversedEndDots_ShouldBeEqual()
        {
            // Arrange
            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(3.0f, 4.0f), new Dot(1.0f, 2.0f), "black");

            // Act & Assert
            Assert.AreEqual(line1, line2, "Lines with reversed end dots should be equal.");
        }

        [TestMethod]
        public void TestGetHashCode_EqualLines_ShouldHaveSameHashCode()
        {
            // Arrange
            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");

            // Act & Assert
            Assert.AreEqual(line1.GetHashCode(), line2.GetHashCode(), "Equal Lines should have the same hash code.");
        }

        [TestMethod]
        public void TestGetHashCode_DifferentLines_ShouldHaveDifferentHashCodes()
        {
            // Arrange
            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black");

            // Act & Assert
            Assert.AreNotEqual(line1.GetHashCode(), line2.GetHashCode(), "Different Lines should have different hash codes.");
        }

        [TestMethod]
        public void TestToString_ShouldReturnFormattedString()
        {
            // Arrange
            Line line = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");

            // Act
            string result = line.ToString();

            // Assert
            Assert.AreEqual("(  1:  2)--->(  3:  4) | Color: black", result, "ToString should return a formatted string.");
        }
    }
}
