using System.IO;
using System.Xml.Serialization;

namespace _3.Paths
{
    public static class Storage
    {
        public static Path3D LoadPath(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                XmlSerializer xmlParser = new XmlSerializer(typeof(Path3D));
                return (Path3D)xmlParser.Deserialize(sr);
            }
        }

        public static void SavePath(Path3D path, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                XmlSerializer xmlParser = new XmlSerializer(path.GetType());
                xmlParser.Serialize(sw, path);
            }
        }
    }
}
