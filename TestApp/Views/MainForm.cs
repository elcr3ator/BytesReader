using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Models;
using TestApp.Presenters;

namespace TestApp.Views
{
	public partial class MainForm : Form, IMainView
	{
		private readonly MainPresenter presenter;

        public MainForm()
		{
			InitializeComponent();
			presenter = new MainPresenter(this, new MainModel());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			presenter.CreateBitmap();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
				FilePath.Text = openFileDialog1.FileName;
				presenter.GetFile();
				Ok.Enabled = true;
			}

		}

		private void height_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bitmap.Height = Convert.ToInt32(height.Text);
			}
			catch (FormatException)
			{
				height.Text = "0";
				MessageBox.Show("Invalid value");
			}
		}

		private void width_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bitmap.Width = Convert.ToInt32(width.Text);

			}
			catch (FormatException)
			{
				width.Text = "0";
				MessageBox.Show("Invalid value");
			}
		}

		private void WriteFile_Click(object sender, EventArgs e)
		{
			saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
			saveFileDialog1.FileName = File1.Text;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
                if (!presenter.WriteBinFile(saveFileDialog1.FileName))
                {
					MessageBox.Show("Empty value in bitmap");
				}
			}
		}

		private void WriteFileDec_Click(object sender, EventArgs e)
		{
			saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
			saveFileDialog1.FileName = File2.Text;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (!presenter.WriteDecFile(saveFileDialog1.FileName))
				{
					MessageBox.Show("Empty value in bitmap");
				}
			}
		}

		public string FilePathText => FilePath.Text;
		public int PictureHeight => bitmap.Height;
		public int PictureWidth => bitmap.Width;
		public string FileSizeText { set { FileInfoSize.Text = "Розмір " + value; } }
		public string ExportSize { set { byteAmount.Text = value; } }
		public Bitmap Bitmap { set { bitmap.Image = value; } }
    }
}