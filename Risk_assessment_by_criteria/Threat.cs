using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Globalization;
using System.Drawing;

namespace Risk_assessment_by_criteria
{
    static class Threat
    {
        static List<threat> thrList = new List<threat>();
        public static bool isSuccAdd = false;
        public static string currName = "";
        internal static bool isSuccEd = false;
        public static bool isSuccDel = false;
        public static float riskCritValue;
        public static string sourceFile = "ThreatsISO27005.xml";
        public struct threat
        {
            public string title;
            public string weakness;
            public float v;
            public int s;
            public List<string> components;
        }
        static public List<threat> getThrList()
        {

            return thrList;
        }
        static public void readFromFile()
        {
            thrList.Clear();
            //List<string> emp = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Threat.sourceFile);
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    threat c = new threat();
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    c.title = attr.Value;
                    c.components = new List<string>();
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "components")
                        {
                            //XmlNode thr = xnode.Attributes.GetNamedItem("threats");
                            XmlNode thr = childnode;
                            foreach (XmlNode xn in thr)
                            {
                                // добавляем в спсок угроз
                                c.components.Add(xn.InnerText);
                            }

                        }

                        //component.Threats = childnode.InnerText;


                        if (childnode.Name == "weakness")
                            c.weakness = childnode.InnerText;
                        if (childnode.Name == "v")
                        {
                            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                            c.v = float.Parse(childnode.InnerText, formatter);
                        }
                        if (childnode.Name == "s")
                            c.s = int.Parse(childnode.InnerText);
                    }
                    thrList.Add(c);
                }

            }
        }

        static public void addToList(string name, string weakness, float v, int s, List<string> components)
        {
            threat c = new threat();
            c.title = name;
            c.weakness = weakness;
            c.s = s;
            c.v = v;
            c.components = components;
            thrList.Add(c);
        }

        static public bool addToFile(string name, string weakness, float v, int s, List<string> components)
        {
            if (!thrList.Exists((p => p.title == name)))
            {
                threat c = new threat();
                c.title = name;
                c.weakness = weakness;
                c.v = v;
                c.s = s;
                c.components = components;
                XDocument xdoc = XDocument.Load(Threat.sourceFile);
                XElement root = xdoc.Element("threats");
                if (root != null)
                {
                    // добавляем новый элемент
                    root.Add(new XElement("threat",
                                new XAttribute("name", c.title),
                                new XElement("weakness", c.weakness),
                                new XElement("v", c.v),
                                new XElement("s", c.s),
                                new XElement("components",
                                from x in c.components
                                select new XElement("component",
                                new XElement("title", x))
                                )));



                    xdoc.Save(Threat.sourceFile);
                    thrList.Add(c);
                }
                return true;
            }
            else
                return false;
        }

        internal static Color defineRiskColor(object value)
        {
            if ((float)value > riskCritValue)
                return Color.OrangeRed;
            else
                return Color.LightGreen;
        }

        internal static bool deleteThreat(string text)
        {
            XDocument xdoc = XDocument.Load(Threat.sourceFile);
            var elToRemove = xdoc.Root.Elements().Where(p => p.Attribute("name").Value == text).FirstOrDefault();
            if (elToRemove != null)
            {
                elToRemove.Remove();
                xdoc.Save(Threat.sourceFile);
                thrList.RemoveAll(x=>x.title==text);
                return true;
            }
            else 
                return false;
        }
        internal static bool changeThreat(string text, string w, float v, int s, List<string> compList)
        {
            XDocument xdoc = XDocument.Load(Threat.sourceFile);

            
            var c = Threat.getThrList();
            var chThr = c.Find((p => p.title == Threat.currName));
            chThr.title = text;
            chThr.weakness = w;
            chThr.v = v;
            chThr.s = s;
            chThr.components = compList;
            isSuccEd = true;
            var elToRemove = xdoc.Root.Elements().Where(p => p.Attribute("name").Value == currName).FirstOrDefault();
            if (elToRemove != null)
            {
                elToRemove.Remove();
            }


            XElement root = xdoc.Element("threats");

            // добавляем новый элемент
            root.Add(new XElement("threat",
                        new XAttribute("name", chThr.title),
                        new XElement("weakness", chThr.weakness),
                        new XElement("v", chThr.v),
                        new XElement("s", chThr.s),
                        new XElement("components",
                        from x in chThr.components
                        select new XElement("component",
                        new XElement("title", x))
                        )));


            xdoc.Save(Threat.sourceFile);
            thrList.RemoveAll(x => x.title == text);
            thrList.Add(chThr);
            return true;
        }


        internal static float riskForComponent(int s, float v)
        {
            return v * s/10;
        }

    }
}
