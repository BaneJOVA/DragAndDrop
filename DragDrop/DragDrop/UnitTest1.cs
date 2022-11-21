using DragDrop.Page;
using WebDriver = DragDrop.Driver.WebDriver;

namespace DragAndDrop
{
    public class Tests
    {
        DragDropPage dragAndDrop;

        [SetUp]
        public void Setup()
        {
            WebDriver.Initialization();
            dragAndDrop = new DragDropPage();
        }

        [Test]
        public void Test1()
        {
            dragAndDrop.MoveObject();
        }
    }
}