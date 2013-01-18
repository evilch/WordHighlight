using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using EvilchUtil.WordHighlight.Matcher.Forms;
using EvilchUtil.WordHighlight.Matcher.Statistics;
using HtmlAgilityPack;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.OneNote;
using EvilchUtil.WordHighlight.Matcher;
using Application = Microsoft.Office.Interop.OneNote.Application;

namespace EvilchUtil.OneNoteHighlight
{

    #region Read me for Add-in installation and setup information.
    // When run, the Add-in wizard prepared the registry for the Add-in.
    // At a later time, if the Add-in becomes unavailable for reasons such as:
    //   1) You moved this project to a computer other than which is was originally created on.
    //   2) You chose 'Yes' when presented with a message asking if you wish to remove the Add-in.
    //   3) Registry corruption.
    // you will need to re-register the Add-in by building the OneNoteHighlightSetup project, 
    // right click the project in the Solution Explorer, then choose install.
    #endregion
    
    /// <summary>
    ///   The object for implementing an Add-in.
    /// </summary>
    /// <seealso class='IDTExtensibility2' />
    [GuidAttribute("37B403C4-A4DA-4330-A222-07B556F5EBAF"), ProgId("EvilchUtil.OneNoteHighlight.OneNoteConnect")]
    public class OneNoteConnect : Object, Extensibility.IDTExtensibility2, IRibbonExtensibility 
    {
        public const string AppRegKey = @"Software\Microsoft\Office\OneNote\AddIns\Evilch.OneNoteHighlight.OneNoteConnect";
        public const string EventLogSource = "OneNoteHightlight";
        /// <summary>
        ///		Implements the constructor for the Add-in object.
        ///		Place your initialization code within this method.
        /// </summary>
        public OneNoteConnect()
        {
            Debug.WriteLine("OneNoteConnect.#ctor");
        }

        /// <summary>
        ///      Implements the OnConnection method of the IDTExtensibility2 interface.
        ///      Receives notification that the Add-in is being loaded.
        /// </summary>
        /// <param name='application'>
        ///      Root object of the host application.
        /// </param>
        /// <param name='connectMode'>
        ///      Describes how the Add-in is being loaded.
        /// </param>
        /// <param name='addInInst'>
        ///      Object representing this Add-in.
        /// </param>
        /// <param name="custom"></param>
        /// <seealso class='IDTExtensibility2' />
        public void OnConnection(object application, Extensibility.ext_ConnectMode connectMode, object addInInst, ref System.Array custom)
        {
            Debug.WriteLine("OnConnection");
            applicationObject = application;
            addInInstance = addInInst;

            //frmStatistics = new FormStatistics();
        }

        /// <summary>
        ///     Implements the OnDisconnection method of the IDTExtensibility2 interface.
        ///     Receives notification that the Add-in is being unloaded.
        /// </summary>
        /// <param name='disconnectMode'>
        ///      Describes how the Add-in is being unloaded.
        /// </param>
        /// <param name='custom'>
        ///      Array of parameters that are host application specific.
        /// </param>
        /// <seealso class='IDTExtensibility2' />
        public void OnDisconnection(Extensibility.ext_DisconnectMode disconnectMode, ref System.Array custom)
        {
            Debug.WriteLine("OnDisconnection");

            #region clean up
            //================ IMPORTANT ================
            // if the application(OneNote.exe) still be referenced by the assemble, 
            // application will not exit correct. Next the add-in will not be loaded.
            applicationObject = null;
            addInInstance = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            #endregion
        }

        /// <summary>
        ///      Implements the OnAddInsUpdate method of the IDTExtensibility2 interface.
        ///      Receives notification that the collection of Add-ins has changed.
        /// </summary>
        /// <param name='custom'>
        ///      Array of parameters that are host application specific.
        /// </param>
        /// <seealso class='IDTExtensibility2' />
        public void OnAddInsUpdate(ref System.Array custom)
        {
            Debug.WriteLine("OnAddInsUpdate");
        }

        /// <summary>
        ///      Implements the OnStartupComplete method of the IDTExtensibility2 interface.
        ///      Receives notification that the host application has completed loading.
        /// </summary>
        /// <param name='custom'>
        ///      Array of parameters that are host application specific.
        /// </param>
        /// <seealso class='IDTExtensibility2' />
        public void OnStartupComplete(ref System.Array custom)
        {
            Debug.WriteLine("OnStartupComplete");
        }

        /// <summary>
        ///      Implements the OnBeginShutdown method of the IDTExtensibility2 interface.
        ///      Receives notification that the host application is being unloaded.
        /// </summary>
        /// <param name='custom'>
        ///      Array of parameters that are host application specific.
        /// </param>
        /// <seealso class='IDTExtensibility2' />
        public void OnBeginShutdown(ref System.Array custom)
        {
            Debug.WriteLine("OnBeginShutdown");
            //frmStatistics.Close();
            //frmStatistics.Dispose();
            //frmStatistics = null;
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //GC.Collect();
        }
        

        public string GetCustomUI(string ribbonID)
        {
            Debug.WriteLine("GetCustomUI: ribbonId = " + ribbonID);
            return Properties.Resources.customUI;
        }

        public IStream OnGetImage(string imageName)
        {
            Debug.WriteLine("OnGetImage: imageName = " + imageName);
            MemoryStream stream = new MemoryStream();
            if (imageName == "HighlightWords.png")
            {
                Properties.Resources.HighlightWords.Save(stream, ImageFormat.Png);
            }
            else if (imageName == "SpecialNames.png")
            {
                Properties.Resources.SpecialNames.Save(stream, ImageFormat.Png);
            }
            Debug.WriteLine("  stream length = {0}", stream.Length);
            return new ReadOnlyIStreamWrapper(stream);
        }

        private void HighlightPage(Application application, string pageId, WordMatcher matcher)
        {
            string pageXml;
            application.GetPageContent(pageId, out pageXml);
            Debug.WriteLine(pageXml);
            XElement page = XElement.Parse(pageXml);
            XNamespace oneNS = page.Name.Namespace;
            XElement title = page.Element(oneNS + "Title");
            XElement titleOE = title.Element(oneNS + "OE");
            Debug.WriteLine("page:{0} by {1}", titleOE.Element(oneNS + "T").Value, titleOE.Attribute("author"));

            StatisticsDataSet.HighlightStatisticsRow statRow = null; // frmStatistics.BeforeProcessing();

            foreach (XElement outline in page.Elements(oneNS + "Outline"))
            {
                foreach (XElement oeChildren in outline.Elements(oneNS + "OEChildren"))
                {
                    foreach (XElement oe in oeChildren.Elements(oneNS + "OE"))
                    {
                        foreach (XElement t in oe.Elements(oneNS + "T"))
                        {
                            //Debug.WriteLine("before:  ");
                            //Debug.WriteLine(t.Value);

                            string process = ProcessingWords(t.Value, matcher, statRow);

                            t.RemoveNodes();
                            t.Add(new XCData(process));

                        }
                    }
                }
            }

            //frmStatistics.AfterProcessing();
            application.UpdatePageContent(page.ToString(SaveOptions.None));
        }


        private string ProcessingWords(string textContent, WordMatcher matcher, StatisticsDataSet.HighlightStatisticsRow statisticsRow = null)
        {
            StringBuilder word = new StringBuilder();


            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(textContent);


            HtmlAgilityPack.HtmlDocument newDoc = new HtmlAgilityPack.HtmlDocument();

            foreach (HtmlNode htmlNode in doc.DocumentNode.ChildNodes)
            {
                if (htmlNode.Name.Equals("#text", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (char c in htmlNode.InnerText)
                    {
                        if (char.IsLetterOrDigit(c))
                        {
                            word.Append(c);
                        }
                        else
                        {
                            if (word.Length > 0)
                            {
                                AppendNewWord(ref newDoc, word.ToString(), matcher, statisticsRow);
                                word.Clear();
                            }

                            AppendSimpleWord(ref newDoc, c.ToString());
                        }
                    }
                }
                else
                {
                    if (word.Length > 0)
                    {
                        AppendNewWord(ref newDoc, word.ToString(), matcher, statisticsRow);
                        word.Clear();
                    }

                    HtmlNode otherNode = htmlNode.CloneNode(true);
                    newDoc.DocumentNode.ChildNodes.Add(otherNode);
                }
            }

            if (word.Length > 0)
            {
                AppendNewWord(ref newDoc, word.ToString(), matcher);
            }

            return GetDocContent(newDoc);
        }

        private static string GetDocContent(HtmlAgilityPack.HtmlDocument doc)
        {
            string rtv = null;
            using (MemoryStream mem = new MemoryStream())
            using (StreamWriter sw = new StreamWriter(mem))
            {
                doc.Save(sw);

                mem.Seek(0, SeekOrigin.Begin);
                using (StreamReader sr = new StreamReader(mem))
                {
                    rtv = sr.ReadToEnd();
                }
            }
            return rtv;
        }

        private static void AppendSimpleWord(ref HtmlAgilityPack.HtmlDocument newDoc, string word)
        {
            if (!newDoc.DocumentNode.HasChildNodes)
            {
                newDoc.DocumentNode.ChildNodes.Append(newDoc.CreateTextNode(word));
            }
            else if (newDoc.DocumentNode.LastChild.Name.Equals("#text", StringComparison.OrdinalIgnoreCase))
            {
                newDoc.DocumentNode.LastChild.InnerHtml += word;
            }
            else
            {
                newDoc.DocumentNode.ChildNodes.Append(newDoc.CreateTextNode(word));
            }
        }

        private void AppendNewWord(ref HtmlAgilityPack.HtmlDocument newDoc, string word, WordMatcher matcher, StatisticsDataSet.HighlightStatisticsRow statisticsRow = null)
        {
            HighlightWord matchedWord = null;
            if (matcher.Match(word, out matchedWord))
            {
                HtmlNode span = newDoc.CreateElement("span");
                span.SetAttributeValue("style", matchedWord.Style);
                span.InnerHtml = word;
                newDoc.DocumentNode.ChildNodes.Append(span);

                //if (statisticsRow != null)
                //{
                //    frmStatistics.HighlightStaticsticIncrease(statisticsRow, matchedWord);
                //}
            }
            else
            {
                AppendSimpleWord(ref newDoc, word);
            }
        }

        //private FormStatistics frmStatistics;
        public void StatisticForm(IRibbonControl control)
        {
            //OneNote.Window context = control.Context as OneNote.Window;
            //CWin32WindowWrapper owner =
            //    new CWin32WindowWrapper((IntPtr)context.WindowHandle);
            //frmStatistics.Show(owner);
        }

        public void SpecialNames(IRibbonControl control)
        {
            Window context = control.Context as Window;
            CWin32WindowWrapper owner =
                new CWin32WindowWrapper((IntPtr)context.WindowHandle);
            SpecialNamesForm form = null;
            try
            {
                using (form = new SpecialNamesForm())
                {
                    if (form.ShowDialog(owner) == DialogResult.OK)
                    {
                        WordMatcher matcher = form.Matcher;

                        string pageId = OneNoteHelper.HierarchyHelper.GetActiveObjectID(context.Application, OneNoteHelper.HierarchyHelper._ObjectType.Page);

                        HighlightPage(context.Application, pageId, matcher);
                        //OneNoteHelper.HierarchyHelper.GoThoughHierarchy(context.Application, (application, pageId) => HighlightPage(application, pageId, matcher));
                    }

                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString(), "Error");
                EventLog.WriteEntry(EventLogSource, ex.ToString());
            }
            finally
            {
                form = null;
                owner = null;
                context = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        public void HighlightWords(IRibbonControl control)
        {
            Window context = control.Context as Window;

            try
            {
                WordMatcher matcher = new WordMatcher(AppRegKey);
                matcher.LoadHightlightDefineFile(null);

                string pageId = OneNoteHelper.HierarchyHelper.GetActiveObjectID(context.Application, OneNoteHelper.HierarchyHelper._ObjectType.Page);
                HighlightPage(context.Application, pageId, matcher);
                //OneNoteHelper.HierarchyHelper.GoThoughHierarchy(context.Application, (application, pageId) => HighlightPage(application, pageId, matcher));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString(), "Error");
                EventLog.WriteEntry(EventLogSource, ex.ToString());
            }
            finally
            {
                context = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        private object applicationObject;
        private object addInInstance;
    }
}