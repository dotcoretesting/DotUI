using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotUI.Core.Element;

namespace DotUI.Core.Test
{
    [TestClass]
    public class UnitTest_Element_Windows
    {
        [TestMethod]
        public void TestFindElement()
        {
            var element = new Element.Element_Windows();
            var target = element.FindElement();
            Assert.AreNotEqual(null, element);
        }
    }
}