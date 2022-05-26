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
    static class Loc
    {
        static List<string> locList = new List<string>();
        internal static bool isSuccDel = false;

        public static List<string> getLocList()
        {
            return locList;
        }

        public static string makeNewName()
        {
            int count = 0;
            count = locList.Count;
            string result = $"L{count + 1}";
            return result;
        }

        public static void addToFile(string name)
        {
            if (!locList.Exists((p => p == name)))
            {

                //xRoot.AppendChild(personElem);
                // сохраняем изменения xml-документа в файл
                //xDoc.Save("people.xml");
                // --------------------------------------------------------------------start
                XDocument xdoc = XDocument.Load("Locations.xml");
                XElement root = xdoc.Element("locations");
                //XElement children = new XElement("children");
                if (root != null)
                {
                    // добавляем новый элемент
                    root.Add(new XElement("location",
                                new XAttribute("name", name)
                                ));



                    xdoc.Save("Locations.xml");
                    locList.Add(name);
                }
            }
        }
        public static void readFromFile()
        {
            //List<string> emp = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Locations.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    locList.Add(attr.Value); 
  
                }

            }
        }

        internal static bool deleteLoc(string text)
        {
            XDocument xdoc = XDocument.Load("Locations.xml");
            var elToRemove = xdoc.Root.Elements().Where(p => p.Attribute("name").Value == text).FirstOrDefault();
            if (elToRemove != null)
            {
                elToRemove.Remove();
                xdoc.Save("Locations.xml");

                var affectedAreas = Area.getArList().FindAll((p => p.location == text));
                foreach (var ar in affectedAreas)
                    Area.changeArea(ar.title, ar.riskCr, "");



                return true;
            }
            else
                return false;
        }
    }
}
