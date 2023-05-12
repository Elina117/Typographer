using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Typographer;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var form = new Form1();
            var expected = "This is a test";

            // Act
            form.richTextBox_enter.Text = "This  is    a  test";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var form = new Form1();
            var expected = "Hello, World!";

            // Act
            form.richTextBox_enter.Text = "Hello, World";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var form = new Form1();
            var expected = "Book — a source of knowledge.";

            // Act
            form.richTextBox_enter.Text = "Book - a source of knowledge";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            var form = new Form1();
            var expected = "Vasya Pupkin said: «My hacker nickname „Neo“!»";

            // Act
            form.richTextBox_enter.Text = "Vasya Pupkin said: «My hacker nickname \"Neo\"!»";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            var form = new Form1();
            var expected = "1 + 2 = ±3";

            // Act
            form.richTextBox_enter.Text = "1 + 2 = (+,-)3";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            var form = new Form1();
            var expected = "This is a sample text.";

            // Act
            form.richTextBox_enter.Text = "This is a sample text";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            // Arrange
            var form = new Form1();
            var expected = "12345.";

            // Act
            form.richTextBox_enter.Text = "12345";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            // Arrange
            var form = new Form1();
            var expected = "No leading spaces.";

            // Act
            form.richTextBox_enter.Text = "   No leading spaces.";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod9()
        {
            // Arrange
            var form = new Form1();
            var expected = "No leading spaces.";

            // Act
            form.richTextBox_enter.Text = "   No leading spaces.";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod10()
        {
            // Arrange
            var form = new Form1();
            var expected = "Lorem ipsum dolor sit amet.";

            // Act
            form.richTextBox_enter.Text = "<font size=\"4\">Lorem ipsum dolor sit amet</font>.";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod11()
        {
            // Arrange
            var form = new Form1();
            var expected = "The text ends with a period.";

            // Act
            form.richTextBox_enter.Text = "The text ends with a period";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod12()
        {
            // Arrange
            var form = new Form1();
            var expected = "No trailing spaces.";

            // Act
            form.richTextBox_enter.Text = "No trailing spaces.     ";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod13()
        {
            // Arrange
            var form = new Form1();
            var expected = "Lorem ipsum—dolor sit amet.";

            // Act
            form.richTextBox_enter.Text = "Lorem ipsum-dolor sit amet.";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod14()
        {
            // Arrange
            var form = new Form1();
            var expected = "«Quoted text»";

            // Act
            form.richTextBox_enter.Text = "\"Quoted text\"";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod15()
        {
            // Arrange
            var form = new Form1();
            var expected = "Text with ± plus-minus sign.";

            // Act
            form.richTextBox_enter.Text = "Text with (+,-) plus-minus sign.";
            form.button1_Click(null, null);
            var actual = form.richTextBox_exit.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
