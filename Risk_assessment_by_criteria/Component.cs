using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace Risk_assessment_by_criteria
{
    public static class Component
    {
        static List<comp> compList = new List<comp>();
        public static bool isSuccAdd = false;
        public static string currName = "";
        internal static bool isSuccEd = false;
        internal static bool isSuccDel = false;
        public static string infrType;
        public struct comp
        {
            public string title;
            public string area;
            //public string location;
            //public List<string> threats;
        }
        public static List<comp> getCompList()
        {

            return compList;
        }
        public static void readFromFile()
        {
            //List<string> emp = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Components.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    comp c = new comp();
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    c.title = attr.Value;
                    //c.threats = new List<string>();
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "threats")
                        {
                            //XmlNode thr = xnode.Attributes.GetNamedItem("threats");
                            XmlNode thr = childnode;
                            foreach (XmlNode xn in thr)
                            {
                                // добавляем в список угроз
                                //c.threats.Add(xn.InnerText);
                            }

                        }
                        
                        //component.Threats = childnode.InnerText;


                        if (childnode.Name == "area")
                            c.area = childnode.InnerText;

                    }
                    compList.Add(c);
                }
                
            }
        }

        public static bool changeComp(string name, string a)
        {
            XDocument xdoc = XDocument.Load("Components.xml");

            var cmp = xdoc.Element("components")
                .Elements("component")
                .FirstOrDefault(p => p.Attribute("name").Value == currName);
            var c = Component.getCompList();
            var chComp = c.Find((p => p.title == Component.currName));
            chComp.title = name;
            chComp.area = a;
            //chComp.location = loc;
            //chComp.threats = threats;
            if (cmp != null)
            {
                isSuccEd = true;

                var area = cmp.Element("area"); 
                if (area != null) area.Value = a.ToString();

                var title = cmp.Attribute("name");
                if (title != null) title.Value = name;
                
                //цикл по threats

                xdoc.Save("Components.xml");
            }
            compList.RemoveAll(x => x.title == name);
            compList.Add(chComp);
            return true;
        }

        internal static float riskForComponentByName(string title, string ar)
        {
            var c = Component.getCompList();
            var currComps = c.FindAll((p => p.title == title && p.area == ar));
            float sum = 0;
            var affectedThreats = Threat.getThrList().FindAll(p => p.components.Exists(x => x == title));
            foreach (var t in affectedThreats)
                if (t.components.Exists(x => x == currComps.Find(p => p.title == x).title))
                    sum += Threat.riskForComponent(t.s, t.v);
            return sum;
        }

        public static bool addToFile(string name, string area)
        {
            var compsInArea = Component.getCompList().FindAll(x => x.area == area);
            if (!compsInArea.Exists((p => p.title == name)))
            {
                isSuccAdd = true;
                comp c = new comp();
                c.title = name;
                c.area = area;
                //c.location = location;
                //c.threats = threats;
                //xRoot.AppendChild(personElem);
                // сохраняем изменения xml-документа в файл
                //xDoc.Save("people.xml");
                // --------------------------------------------------------------------start
                XDocument xdoc = XDocument.Load("Components.xml");
                XElement root = xdoc.Element("components");
                //XElement children = new XElement("children");
                if (root != null)
                {
                    // добавляем новый элемент
                    root.Add(new XElement("component",
                                new XAttribute("name", c.title),
                                new XElement("area", c.area)
                                //new XElement("location", c.location),
                                ));



                    xdoc.Save("Components.xml");
                    compList.Add(c);
                }
                return true;
            }
            else
            {
                return false;
            }
           

        }

        internal static bool deleteComponent(string text)
        {
            XDocument xdoc = XDocument.Load("Components.xml");
            var elToRemove = xdoc.Root.Elements().Where(p => p.Attribute("name").Value == text).FirstOrDefault();
            if (elToRemove != null)
            {
                elToRemove.Remove();
                xdoc.Save("Components.xml");
                var affectedThreats = Threat.getThrList().FindAll(p => p.components.Exists(x => x == text));
                foreach (var thr in affectedThreats)
                {
                    thr.components.Remove(text);
                    Threat.changeThreat(thr.title, thr.weakness, thr.v, thr.s, thr.components);
                }
                return true;
            }
            else
                return false;
        }
    }
}
