using System.Xml.Linq;

namespace EvilchUtil.OneNoteHighlight
{
    internal static class XElementExtension
    {
        public static bool BoolAttribute(this XElement element, XName attributeName, bool defaultValue = false)
        {
            return (element.Attribute(attributeName) == null) ? defaultValue : (bool)element.Attribute(attributeName);
        }
    }
}
