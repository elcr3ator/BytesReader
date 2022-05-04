using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Views;

namespace UnitTest
{
    public class TestView : IMainView
    {
        public string FilePathText { get; set; }
        public int PictureHeight { get; set; }
        public int PictureWidth { get; set; }
        public string FileSizeText { get; set; }
        public string ExportSize { get; set; }
        public Bitmap Bitmap { get; set; }
    }
}
