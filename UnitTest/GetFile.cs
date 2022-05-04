using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.IO;
using TestApp.Models;
using TestApp.Presenters;

namespace UnitTest
{
    [TestClass]
    public class GetFile
    {
        private TestView view;
        private MainModel model;
        private MainPresenter presenter;

        public GetFile()
        {
            view = new TestView();
            model = new MainModel();
            presenter = new MainPresenter(view, model);

            view.FilePathText = "NullOnly.txt";
        }

        [TestMethod]
        public void NullChar() //00000000
        {
            using (StreamWriter writer = new StreamWriter(view.FilePathText))
            {
                char a = (char)0;
                writer.Write(a);
            }

            presenter.GetFile();

            foreach (char i in model.Bits)
            {
                Assert.IsTrue(i == '0');
            }
        }

        [TestMethod]
        public void HalfNull() //00001111
        {
            using (StreamWriter writer = new StreamWriter(view.FilePathText))
            {
                char a = (char)15;
                writer.Write(a);
            }

            presenter.GetFile();

            int i = 0;
            while (i < 4)
            {
                Assert.IsTrue(model.Bits[i] == '0');
                ++i;
            }
            while (i < 8)
            {
                Assert.IsTrue(model.Bits[i] == '1');
                ++i;
            }
        }

        [TestMethod]
        public void ChessOrder() //01010101
        {
            using (StreamWriter writer = new StreamWriter(view.FilePathText))
            {
                char a = (char)85;
                writer.Write(a);
            }

            presenter.GetFile();

            bool isNull = true;
            foreach (char i in model.Bits)
            {
                Assert.AreEqual(isNull, i == '0');
                isNull = !isNull;
            }
        }
    }
}
