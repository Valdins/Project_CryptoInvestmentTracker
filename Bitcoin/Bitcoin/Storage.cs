using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Bitcoin
{
    static class Storage<T> where T : IComparable
    {
        static private List<InsertInfo> dataStorage = new List<InsertInfo>();
        static private string fileLocation = @"C:\Users\VVL\Desktop\Test Subject\storage.xml";

        static public void AddDataToList(InsertInfo data)
        {
            dataStorage.Add(data);
            SaveDataToXML();
        }
        static public void RemoveDataToList(int id)
        {
            foreach (InsertInfo n in dataStorage)
            {
                if (id == n.ID)
                {
                    dataStorage.Remove(n);
                    break;
                }

            }
            SaveDataToXML();
        }

        static public List<InsertInfo> getList()
        {
            return dataStorage;
        }
        static public void ListForDisplay(ref List<InsertInfo> list)
        {
            foreach (InsertInfo n in dataStorage)
            {
                list.Add(n);
            }
        }

        static public void SaveDataToXML()
        {
            using (Stream fs = new FileStream(fileLocation, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<InsertInfo>));
                serializer.Serialize(fs, dataStorage);
            }
        }

        static public void GetDataToXML()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<InsertInfo>));

            using (FileStream fs2 = File.OpenRead(fileLocation))
            {
                dataStorage = (List<InsertInfo>)deserializer.Deserialize(fs2);
            }
            /*
            foreach (InsertInfo dataPoint in dataStorage)
            {
                dataStorage.Add(dataPoint);
            }*/
        }

    }
}
