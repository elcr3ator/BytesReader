using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Views
{
    public interface IMainView
    {
        String FilePathText { get; }
        Int32 PictureHeight { get; }
        Int32 PictureWidth { get; }
        String FileSizeText { set; }
        String ExportSize { set; }
        Bitmap Bitmap { set; }
    }
}
