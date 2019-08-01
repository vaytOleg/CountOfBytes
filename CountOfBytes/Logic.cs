using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CountOfBytes
{
    
    public class Logic
    {
        public delegate void OutputInfo(string message);
        public event OutputInfo AddInfo;
        private const int BUFFER = 3000000; //~3 Mb
       
        public IEnumerable< IGrouping< string,FileInfo>> SearchFiles(string path)
        {
            DirectoryInfo folders = new DirectoryInfo(path);
            var  fileInfo = folders.GetFiles("*",SearchOption.AllDirectories);
            
            return fileInfo.GroupBy(u => u.DirectoryName);
        }
      
        public long CountOfBytes(string path, int buffer)
        {
            long counter = 0;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) 
            using (BinaryReader br = new BinaryReader(fs))
            {
                byte[] bytes;
                for (long i = 0; i < fs.Length; i += buffer)
                {
                    bytes = br.ReadBytes(buffer);
                    for (var j = 0; j < bytes.Length; j++)
                    {
                        counter += bytes[j];
                    }
                }
            }
            return counter;
        }

        //create record for XML
        public XElement AddRecord(string contentAtt,string nameElement,long? count)
        {
            XElement element = new XElement($"{nameElement}");
            XAttribute nameAtt = new XAttribute("name", $"{contentAtt}");
            element.Add(nameAtt);

            if (count!=null)
            {
                element.Add(new XElement("count", $"{count}"));
            }

            return element;
        }

        //iterate over files 
        public void FolderCount(IGrouping<string, FileInfo> folder, XElement mainFolderElement)
        {
            Logic logic = new Logic();
            XElement folderElement = logic.AddRecord(folder.Key, "folder", null);
            foreach (var file in folder)
            {
                var count = logic.CountOfBytes(file.FullName, BUFFER);//
                AddInfo($" {file.Name} - {count}");//output result
                folderElement.Add(logic.AddRecord(file.Name, "file", count));
            }
            mainFolderElement.Add(folderElement);
        }
    }
}
