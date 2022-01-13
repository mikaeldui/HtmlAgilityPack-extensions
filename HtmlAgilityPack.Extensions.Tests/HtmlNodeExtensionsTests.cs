using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlAgilityPack.Tests
{
    [TestClass]
    public class HtmlNodeExtensionsTests
    {
        [TestMethod]
        public void ChildNodes()
        {
            var parentNode = _parentNode();

            var result = parentNode.ChildNodes("div").Single();

            Assert.AreEqual(parentNode.ChildNode("div"), result);
        }

        private static HtmlNode _parentNode()
        {
            HtmlDocument document = new();
            HtmlNode parent = new(HtmlNodeType.Element, document, 0);
            HtmlNode targetChild = new(HtmlNodeType.Element, document, 1);
            targetChild.Name = "div";
            HtmlNode wrongChild = new(HtmlNodeType.Element, document, 2);
            wrongChild.Name = "a";
            parent.AppendChildren(targetChild, wrongChild);
            return parent;
        }
    }
}
