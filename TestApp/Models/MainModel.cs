using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class MainModel
    {
        public Bitmap Bitmap { get; set; }
        public FileInfo File { get; set; }
        public String Bits { get; set; }
        public long FileLength { get => File.Length; }
        public long FileLengthKB { get => FileLength / 1024; }
        public String FilePath { get => File.FullName; }
    }
}
