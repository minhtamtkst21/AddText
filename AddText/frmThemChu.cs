using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using AddText.Classes;

namespace AddText
{
    public partial class frmThemChu : Form
    {
        private HinhAnh _hinhAnh = new HinhAnh();
        private List<AddTextClass> _addTexts = new List<AddTextClass>();
        public frmThemChu()
        {
            InitializeComponent();
        }
        private void btnThemChu_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            try
            {
                // mở file excel
                var file = new FileInfo("E:/HSV/1.xlsx");
                var package = new ExcelPackage(file);
                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                for (int i = workSheet.Dimension.Start.Row; i <= workSheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        //nguồn hình ảnh
                        ptb.Image = Image.FromFile("E:\\HSV\\GIAYCHUNGNHAN.png");
                        //lấy tên chiến sĩ
                        string name = workSheet.Cells[i, 6].Value.ToString();
                        Bitmap bitmap = new Bitmap(ptb.Image);
                        Graphics g = Graphics.FromImage(bitmap);
                        //lấy độ dài file
                        var ImageSize = bitmap.Width;
                        //set font chữ
                        var font = new Font("Times New Roman", 60, FontStyle.Bold | FontStyle.Italic);
                        //lấy độ dài chữ
                        var MeasureString = g.MeasureString(name, font).Width;
                        //điền tên vào hình
                        g.DrawString(name, font, Brushes.Black, new PointF((ImageSize - MeasureString) / 2, 590));
                        ptb.Image = (Image)bitmap;
                        //lưu ảnh
                        string filePath = "E:\\HSV\\File\\" + name + ".png";
                        if (!File.Exists(filePath))
                            ptb.Image.Save(filePath);
                        else
                        {
                            filePath = "E:\\HSV\\File\\" + name + "(1).png";
                            ptb.Image.Save(filePath);
                        }
                    }
                    catch { }
                }
            }
            catch (Exception er)
            {
                var err = er.Message;
            }
        }

        private void btnThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
"All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _hinhAnh.path = dlg.FileName;
                _hinhAnh.Image = Image.FromFile(_hinhAnh.path);
                _hinhAnh.Bitmap = new Bitmap(_hinhAnh.Image);
                _hinhAnh.Graphics = Graphics.FromImage(_hinhAnh.Bitmap);
                var render = RenderImage(_hinhAnh.Image.Width, _hinhAnh.Image.Height);
                _hinhAnh.Width = render[0];
                _hinhAnh.Height = render[1];
                ptb.Size = new Size((int)_hinhAnh.Width, (int)_hinhAnh.Height);
                ptb.Image = _hinhAnh.Image;
            }
        }

        private double[] RenderImage(double width, double height)
        {
            double[] size = { width, height };
            while (width > 1000 || height > 1000)
            {
                width = width / 1.1;
                height = height / 1.1;
            }
            size[0] = width;
            size[1] = height;
            return size;
        }
    }
}
