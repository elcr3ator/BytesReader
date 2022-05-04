using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;
using TestApp.Views;

namespace TestApp.Presenters
{
	public class MainPresenter
	{
		private readonly IMainView view;
		private readonly MainModel model;
		public MainPresenter(IMainView view, MainModel model)
		{
			this.view = view;
			this.model = model;
		}

		public void GetFile()
		{
			model.File = new FileInfo(view.FilePathText);
			if (model.FileLength <= 102400)
			{
				view.FileSizeText = model.FileLengthKB + " Kb";
				byte[] bytes;
				using (FileStream file = new FileStream(model.FilePath, FileMode.Open, FileAccess.Read))
				{
					bytes = new byte[file.Length];
					file.Read(bytes, 0, (int)file.Length);
					String bits = String.Empty;
					foreach (String str in bytes.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')))
					{
						bits += str;
					}
					model.Bits = bits;
				}
			}
		}

		public void CreateBitmap()
		{
			IEnumerator<char> enumerator = model.Bits.GetEnumerator();
			model.Bitmap = new Bitmap(view.PictureWidth, view.PictureHeight);
			for (int i = 0; i < view.PictureHeight; i++)
			{
				for (int y = 0; y < view.PictureWidth; y++)
				{
					if (!enumerator.MoveNext())
					{
						model.Bitmap.SetPixel(y, i, Color.Gray);
					}
					else
					{
						if (enumerator.Current == '0')
						{
							model.Bitmap.SetPixel(y, i, Color.Black);

						}
						else
						{
							model.Bitmap.SetPixel(y, i, Color.White);
						}
					}
				}
			}
			view.Bitmap = model.Bitmap;
		}

		public bool WriteBinFile(String filePath)
		{
            try
			{
				String upd = String.Empty;
				int i = 0;
				if (filePath == "")
				{
					foreach (char item in model.Bits)
					{
						if (i < 8)
						{
							upd += item;
							++i;
						}
						else
						{
							upd += ' ';
							i = 0;
						}

					}

					File.WriteAllText(filePath, upd, Encoding.Unicode);
					long length = new FileInfo(filePath).Length;
					length = length / 1024;
					view.ExportSize = length.ToString() + " kb";
					return true;
				}
                else
                {
					return false;
                }
			}
            catch
            {
				return false;
            }
		}

		public bool WriteDecFile(String filePath)
		{
            try
            {
				string decValue = String.Empty;
				int i = 0;
				string number = String.Empty;
				if (filePath == "")
				{
					foreach (char item in model.Bits)
					{
						if (i < 8)
						{
							number += item;
							i++;
						}
						else
						{
							decValue += Convert.ToInt32(number, 2).ToString();
							decValue += " ";
							number = String.Empty;
							i = 0;
						}
					}
					File.WriteAllText(filePath, decValue, Encoding.Unicode);
					long length = new FileInfo(filePath).Length;
					length = length / 1024;
					view.ExportSize = length.ToString() + " kb";
					return true;
				}
                else
                {
					return false;
                }
			}
            catch
            {
				return false;
            }
		}
	}
}
