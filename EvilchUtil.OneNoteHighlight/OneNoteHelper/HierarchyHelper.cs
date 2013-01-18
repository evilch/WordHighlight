using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using Microsoft.Office.Interop.OneNote;

namespace EvilchUtil.OneNoteHighlight.OneNoteHelper
{
    public class HierarchyHelper
    {
        /// <summary>
        /// Get the title of the page
        /// </summary>
        /// <returns>string</returns>
        public static string GetPageTitle(IApplication oneNoteApp)
        {
            string pageXmlOut = GetActivePageContent(oneNoteApp);
            var doc = XDocument.Parse(pageXmlOut);
            string pageTitle = "";
            pageTitle = doc.Descendants().FirstOrDefault().Attribute("ID").NextAttribute.Value;

            return pageTitle;
        }

        /// <summary>
        /// Get active page content and output the xml string
        /// </summary>
        /// <returns>string</returns>
        public static string GetActivePageContent(IApplication oneNoteApp)
        {
            string activeObjectID = GetActiveObjectID(oneNoteApp, _ObjectType.Page);
            string pageXmlOut = "";
            oneNoteApp.GetPageContent(activeObjectID, out pageXmlOut);

            return pageXmlOut;
        }

        /// <summary>
        /// Get ID of current page 
        /// </summary>
        /// <param name="obj">_Object Type</param>
        /// <returns>current page Id</returns>
        public static string GetActiveObjectID(IApplication oneNoteApp, _ObjectType obj)
        {
            string currentPageId = "";
            uint count = oneNoteApp.Windows.Count;
            foreach (Window window in oneNoteApp.Windows)
            {
                if (window.Active)
                {
                    switch (obj)
                    {
                        case _ObjectType.Notebook:
                            currentPageId = window.CurrentNotebookId;
                            break;
                        case _ObjectType.Section:
                            currentPageId = window.CurrentSectionId;
                            break;
                        case _ObjectType.SectionGroup:
                            currentPageId = window.CurrentSectionGroupId;
                            break;
                    }

                    currentPageId = window.CurrentPageId;
                }
            }

            return currentPageId;

        }

        /// <summary>
        /// Nested types
        /// </summary>
        public enum _ObjectType
        {
            Notebook,
            Section,
            SectionGroup,
            Page,
            SelectedPages,
            PageObject
        }

        public static void GoThoughHierarchy(Application application, Action<Application, string> pageFunction)
        {
            string hierarchyXml;
            application.GetHierarchy(null, HierarchyScope.hsPages, out hierarchyXml);
            XElement hierarchy = XElement.Parse(hierarchyXml);
            XNamespace oneNS = hierarchy.Name.Namespace;

            foreach (XElement notebook in hierarchy.Elements(oneNS + "Notebook"))
            {
                Debug.Indent();
                GoThoughNotebook(application, notebook, oneNS, pageFunction);
                Debug.Unindent();
            }
        }

        public static void GoThoughNotebook(Application application, XElement notebook, XNamespace oneNS, Action<Application, string> pageFunction)
        {
            //Debug.WriteLine("Notebook>> {0} : id={1}, currentlyViewed={2}",
            //        notebook.Attribute("name"),
            //        notebook.Attribute("ID"),
            //        notebook.BoolAttribute("isCurrentlyViewed"));

            if (notebook.BoolAttribute("isInRecycleBin"))
            {
                Debug.WriteLine("In recycle bin, skip this");
            }
            else
            {
                foreach (XElement section in notebook.Elements(oneNS + "Section"))
                {
                    Debug.Indent();
                    GoThoughSection(application, section, oneNS, pageFunction);
                    Debug.Unindent();
                }

                foreach (XElement sectionGroup in notebook.Elements(oneNS + "SectionGroup"))
                {
                    Debug.Indent();
                    GoThoughSectionGroup(application, sectionGroup, oneNS, pageFunction);
                    Debug.Unindent();
                }
            }
        }

        public static void GoThoughSectionGroup(Application application, XElement sectionGroup, XNamespace oneNS, Action<Application, string> pageFunction)
        {
            //Debug.WriteLine(
            //        "SectionGroup>> {0} : id = {1}, currentlyViewed={2}",
            //        sectionGroup.Attribute("name"),
            //        sectionGroup.Attribute("ID"),
            //        sectionGroup.BoolAttribute("isCurrentlyViewed"));
            if (sectionGroup.BoolAttribute("isInRecycleBin"))
            {
                Debug.WriteLine("In recycle bin, skip this");
            }
            else
            {
                foreach (XElement section in sectionGroup.Elements(oneNS + "Section"))
                {
                    Debug.Indent();
                    GoThoughSection(application, section, oneNS, pageFunction);
                    Debug.Unindent();
                }
            }
        }

        public static void GoThoughSection(Application application, XElement section, XNamespace oneNS, Action<Application, string> pageFunction)
        {
            //Debug.WriteLine(
            //        "Section>> {0} : id = {1}, currentlyViewed={2}",
            //        section.Attribute("name"),
            //        section.Attribute("ID"),
            //        section.BoolAttribute("isCurrentlyViewed"));
            if (section.BoolAttribute("isInRecycleBin"))
            {
                //Debug.WriteLine("In recycle bin, skip this");
            }
            else
            {
                foreach (XElement page in section.Elements(oneNS + "Page"))
                {
                    Debug.Indent();
                    GoThoughPage(application, page, oneNS, pageFunction);
                    Debug.Unindent();
                }
            }
        }

        public static void GoThoughPage(Application application, XElement page, XNamespace oneNS, Action<Application, string> pageFunction)
        {
            //Debug.WriteLine(
            //        "Page>> {0} : id = {1}, currentlyViewed={2}",
            //        page.Attribute("name"),
            //        page.Attribute("ID"),
            //        page.BoolAttribute("isCurrentlyViewed"));
            if (page.BoolAttribute("isInRecycleBin"))
            {
                //Debug.WriteLine("In recycle bin, skip this");
            }
            if (!page.BoolAttribute("isCurrentlyViewed"))
            {
                //Debug.WriteLine("Not currently viewed page, skip this");
            }
            else
            {
                pageFunction(application, (string)page.Attribute("ID"));
            }
        }
    }
}
