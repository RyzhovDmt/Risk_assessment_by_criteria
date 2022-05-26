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
    static class Area
    {
        static List<area> arList = new List<area>();
        public static bool isSuccAdd = false;
        public static string currName = "";
        internal static bool isSuccEd = false;
        internal static bool isSuccDel = false;
        internal static Dictionary<string, float> arRisk = new Dictionary<string, float>();

        public struct area
        {
            public string title;
            public float riskCr;
            public string location;
            public string resp;
            //public List<string> threats;
        }
        public static List<area> getArList()
        {

            return arList;
        }
        public static string makeNewName(string l)
        {
            //readFromFile();
            int count = 0;
            //формируем имя R + номер локации + число областей в локации +1
            count = arList.Count(s => s.location == l);
            string loc_num = l.Substring(1);
            string result = $"R{loc_num}.{count+1}";
            return result;
        }

        internal static string changeName(string old, string l)
        {
            string arNum = old.Substring(old.IndexOf('.'));
            string result = $"R{l}.{arNum}";
            return result;
        }

        internal static bool changeArea(string text, float r, string l)
        {
            XDocument xdoc = XDocument.Load("Areas.xml");

            // получим элемент person с name = "Tom"
            var ar = xdoc.Element("areas")
                .Elements("area")
                .FirstOrDefault(p => p.Attribute("name").Value == currName);
            var c = Area.getArList();
            var chAr = c.Find((p => p.title == Area.currName));
            chAr.title = text;
            chAr.riskCr = r;
            chAr.location = l;
            if (ar != null)
            {
                //  меняем атрибут name
                isSuccEd = true;

                var risk = ar.Element("risk");
                if (risk != null) risk.Value = r.ToString();

                //  меняем вложенный элемент age
                var loc = ar.Element("loc");
                if (loc != null) loc.Value = l;

                var name = ar.Attribute("name");
                if (name != null) name.Value = text;

                xdoc.Save("Areas.xml");
            }
            arList.RemoveAll(x => x.title == text);
            arList.Add(chAr);
            return true;
        }

        internal static float riskForArea(string title)
        {
            var areaComp = Component.getCompList().FindAll(x => x.area == title);
            int compCnt = 0;
            float sum = 0;

            foreach (var t in Threat.getThrList())
            {
                foreach (var c in areaComp)
                {
                    if (t.components.Contains(c.title))
                        if ((t.s * t.v) / 3 > Threat.riskCritValue)
                        {
                            compCnt++;
                            sum += ((t.s * t.v) / 3) * calcRiskCr(title);
                        }
                }
                if (double.IsNaN(compCnt))
                    sum /= compCnt;
            }
            return sum;
        }
        public static float calcRiskCr(string title)
        {
            var area = getArList().Find(x => x.title == title);
            if (area.resp == "Приложения + БД")
            {
                if (Component.infrType == "SaaS")
                    return area.riskCr * (float)1.5;
                if (Component.infrType == "PaaS")
                    return area.riskCr * (float)1.25;
                if (Component.infrType == "IaaS")
                    return area.riskCr;
            }
            if (area.resp == "Базы данных")
            {
                if (Component.infrType == "SaaS")
                    return area.riskCr * (float)1.25;
                if (Component.infrType == "PaaS")
                    return area.riskCr * (float)1.25;
                if (Component.infrType == "IaaS")
                    return area.riskCr;
            }
            if (area.resp == "Другая")
            {
                return area.riskCr;
            }
            return area.riskCr;
        }

        internal static Dictionary<string, float> riskForAllAreas(string title)
        {
            foreach (var t in Threat.getThrList())
            {
                foreach (var x in t.components)
                {
                    var c = Component.getCompList();
                    var currComp = c.Find((p => p.title == x));
                    var currArea = Area.getArList().Find((p => p.title == currComp.area));
                    //if ((t.s * t.v)/3 > Threat.riskCritValue)

                }
            }
            return null;
        }

        public static bool addToFile(string name, float k, string loc, string resp)
        {
            if (!arList.Exists((p => p.title == name)))
            {
                isSuccAdd = true;
                area c = new area();
                c.title = name;
                c.riskCr = k;
                c.location = loc;
                c.resp = resp;
                //xRoot.AppendChild(personElem);
                // сохраняем изменения xml-документа в файл
                XDocument xdoc = XDocument.Load("Areas.xml");
                XElement root = xdoc.Element("areas");
                //XElement children = new XElement("children");
                if (root != null)
                {
                    // добавляем новый элемент
                    root.Add(new XElement("area",
                                new XAttribute("name", c.title),
                                new XElement("risk", c.riskCr),
                                new XElement("loc", c.location),
                                new XElement("resp", c.resp)
                                ));



                    xdoc.Save("Areas.xml");
                    arList.Add(c);
                    
                }
                return true;
            }
            return false;
        }
        public static void readFromFile()
        {
            //List<string> emp = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Areas.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    area c = new area();
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    c.title = attr.Value;
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {

                        //component.Threats = childnode.InnerText;

                        if (childnode.Name == "risk")
                            c.riskCr = float.Parse(childnode.InnerText);
                        if (childnode.Name == "loc")
                            c.location = childnode.InnerText;
                        if (childnode.Name == "resp")
                            c.resp = childnode.InnerText;
                    }
                    arList.Add(c);
                }

            }
        }

        internal static bool deleteArea(string text)
        {
            XDocument xdoc = XDocument.Load("Areas.xml");
            var elToRemove = xdoc.Root.Elements().Where(p => p.Attribute("name").Value == text).FirstOrDefault();
            if (elToRemove != null)
            {
                elToRemove.Remove();
                xdoc.Save("Areas.xml");
                var affectedComps = Component.getCompList().FindAll((p => p.area == text));
                foreach (var c in affectedComps)
                    Component.changeComp(c.title, "");
                return true;
            }
            else
                return false;
        }
    }
}
