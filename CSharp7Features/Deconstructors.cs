using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Features
{
    public class PathInfo
    {
        public string DirectoryName { get; }
        public string FileName { get; }
        public string Extension { get; }
        public string Path
        {
            get
            {
                return System.IO.Path.Combine(
                    DirectoryName, FileName, Extension);
            }
        }
        public PathInfo(string path)
        {

            
            DirectoryName = System.IO.Path.GetDirectoryName(path);
            FileName = System.IO.Path.GetFileNameWithoutExtension(path);
            Extension = System.IO.Path.GetExtension(path);
        }
        public void Deconstruct(
            out string directoryName, out string fileName, out string extension)
        {
            directoryName = DirectoryName;
            fileName = FileName;
            extension = Extension;
        }
        // ...
    }

}
