namespace HtmlAgilityPack
{
    public static class HtmlNodeExtensions
    {
        public static IEnumerable<HtmlNode> ChildNodes(this HtmlNode node, string name) =>
            node.ChildNodes.Where(n => n.Name == name);

        /// <summary>
        /// Same as ChildNodes[name].
        /// </summary>
        public static HtmlNode ChildNode(this HtmlNode node, string name) =>
            node.ChildNodes[name];

        public static void AppendChildren(this HtmlNode node, params HtmlNode[] children)
        {
            foreach(var child in children)
                node.AppendChild(child);
        }
    }
}