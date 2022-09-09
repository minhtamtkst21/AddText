using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using AddText.Classes;
using System.Linq;

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
            if (_hinhAnh.Image != null)
            {
                try
                {
                    OpenFileDialog dlg = new OpenFileDialog
                    {
                        InitialDirectory = @"D:\",
                        Title = "Browse Text Files",

                        CheckFileExists = true,
                        CheckPathExists = true,

                        DefaultExt = "txt",
                        Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                        FilterIndex = 2,
                        RestoreDirectory = true,

                        ReadOnlyChecked = true,
                        ShowReadOnly = true
                    };

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        string dir = dlg.FileName.Substring(0, dlg.FileName.LastIndexOf('\\')) + "/SaveZZZZ/";
                        if (Directory.Exists(dir))
                        {
                            Directory.Delete(dir, true);
                        }
                        // mở file excel
                        var file = new FileInfo(dlg.FileName);
                        var package = new ExcelPackage(file);
                        // lấy ra sheet đầu tiên để thao tác
                        ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                        for (int i = 1; workSheet.Cells[i + 1, 1].Value != null && !string.IsNullOrEmpty(workSheet.Cells[i + 1, 1].Value.ToString()); i++)
                        {
                            if (CheckExcel(workSheet, i))
                            {
                                UpdateImage();
                                for (int j = 0; j < _addTexts.Count(); j++)
                                {
                                    var fontstyle = new FontStyle();
                                    if (_addTexts[j].Regular) fontstyle |= FontStyle.Regular;
                                    if (_addTexts[j].Bold) fontstyle |= FontStyle.Bold;
                                    if (_addTexts[j].Italic) fontstyle |= FontStyle.Italic;
                                    if (_addTexts[j].Underline) fontstyle |= FontStyle.Underline;
                                    if (_addTexts[j].Strikeout) fontstyle |= FontStyle.Strikeout;

                                    //set font chữ
                                    var font = new Font("Times New Roman", _addTexts[j].SizeChu, fontstyle);
                                    var name = workSheet.Cells[i, j + 1].Value.ToString();
                                    var MeasureStringWidth = _hinhAnh.Graphics.MeasureString(name, font).Width;
                                    var MeasureStringHeight = _hinhAnh.Graphics.MeasureString(name, font).Height;
                                    float x, y;
                                    //điền tên vào hình
                                    if (_addTexts[j].CanGiuaNgang)
                                        x = float.Parse(_hinhAnh.Width.ToString()) - MeasureStringWidth / 2;
                                    else
                                        x = _addTexts[j].ViTriNgang;
                                    if (_addTexts[j].CanGiuaDoc)
                                        y = float.Parse(_hinhAnh.Height.ToString()) - MeasureStringHeight / 2;
                                    else
                                        y = _addTexts[j].ViTriDoc;
                                    _hinhAnh.Graphics.DrawString(name, font, Brushes.Black, new PointF(x, y));
                                    ptb.Image = _hinhAnh.Bitmap;
                                }
                                ptb.Refresh();
                                Directory.CreateDirectory(dir);
                                string filePath = dir + i + ".png";
                                if (!File.Exists(filePath))
                                    ptb.Image.Save(filePath);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi ở dòng " + i + "! Thiếu dữ liệu! Nhập lại đi bạn êi!");
                                break;
                            }
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                MessageBox.Show("Điền ảnh trước đê bạn êi!");
            }
        }
        private bool CheckExcel(ExcelWorksheet worksheet, int j)
        {
            for (int i = 1; i <= _addTexts.Count(); i++)
            {
                try
                {
                    if (worksheet.Cells[j, i].Value == null && string.IsNullOrEmpty(worksheet.Cells[j, i].Value.ToString()))
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
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
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
"All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _hinhAnh.path = dlg.FileName;
                UpdateImage();
            }
        }

        private void UpdateImage()
        {
            _hinhAnh.Image = Image.FromFile(_hinhAnh.path);
            _hinhAnh.Bitmap = new Bitmap(_hinhAnh.Image);
            _hinhAnh.Graphics = Graphics.FromImage(_hinhAnh.Bitmap);
            var render = RenderImage(_hinhAnh.Image.Width, _hinhAnh.Image.Height);
            _hinhAnh.Width = render[0];
            _hinhAnh.Height = render[1];
            ptb.Size = new Size((int)_hinhAnh.Width, (int)_hinhAnh.Height);
            ptb.Image = _hinhAnh.Image;
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

        private void btnLuuChu_Click(object sender, EventArgs e)
        {
            var text = new AddTextClass()
            {
                TenText = txtTenText.Text,
                FontChu = cboFontChu.Text,
                SizeChu = int.Parse(txtSizeChu.Text),
                ViTriDoc = int.Parse(txtViTriDoc.Text),
                ViTriNgang = int.Parse(txtViTriNgang.Text),
                CanGiuaDoc = chkCanGiuaDoc.Checked,
                CanGiuaNgang = chkCanGiuaNgang.Checked,
                Regular = chkRegular.Checked,
                Bold = chkBold.Checked,
                Italic = chkItalic.Checked,
                Underline = chkUnderline.Checked,
                Strikeout = chkStrikeout.Checked,
            };

            //set fontstyle
            var fontstyle = new FontStyle();
            if (text.Regular) fontstyle |= FontStyle.Regular;
            if (text.Bold) fontstyle |= FontStyle.Bold;
            if (text.Italic) fontstyle |= FontStyle.Italic;
            if (text.Underline) fontstyle |= FontStyle.Underline;
            if (text.Strikeout) fontstyle |= FontStyle.Strikeout;

            //set font chữ
            var font = new Font("Times New Roman", text.SizeChu, fontstyle);
            text.font = font;
            _addTexts.Add(text);
            dtgListText.DataSource = null;
            dtgListText.DataSource = _addTexts;
        }

        private void btnXemTruocChu_Click(object sender, EventArgs e)
        {
            if (_hinhAnh.Image != null)
            {
                UpdateImage();

                var fontstyle = new FontStyle();
                if (chkRegular.Checked) fontstyle |= FontStyle.Regular;
                if (chkBold.Checked) fontstyle |= FontStyle.Bold;
                if (chkItalic.Checked) fontstyle |= FontStyle.Italic;
                if (chkUnderline.Checked) fontstyle |= FontStyle.Underline;
                if (chkStrikeout.Checked) fontstyle |= FontStyle.Strikeout;

                //set font chữ
                var font = new Font("Times New Roman", int.Parse(txtSizeChu.Text), fontstyle);
                var name = "Xem trước text";
                var MeasureStringWidth = _hinhAnh.Graphics.MeasureString(name, font).Width;
                var MeasureStringHeight = _hinhAnh.Graphics.MeasureString(name, font).Height;
                float x, y;
                //điền tên vào hình
                if (chkCanGiuaNgang.Checked)
                    x = float.Parse(_hinhAnh.Width.ToString()) - MeasureStringWidth / 2;
                else
                    x = float.Parse(txtViTriNgang.Text);
                if (chkCanGiuaDoc.Checked)
                    y = float.Parse(_hinhAnh.Height.ToString()) - MeasureStringHeight / 2;
                else
                    y = float.Parse(txtViTriDoc.Text);
                _hinhAnh.Graphics.DrawString(name, font, Brushes.Black, new PointF(x, y));
                ptb.Image = _hinhAnh.Bitmap;
                ptb.Refresh();
            }
            else
            {
                MessageBox.Show("Điền ảnh trước đê bạn êi!");
            }
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            if (_hinhAnh.Image != null)
            {
                UpdateImage();
                foreach (var item in _addTexts)
                {
                    var fontstyle = new FontStyle();
                    if (item.Regular) fontstyle |= FontStyle.Regular;
                    if (item.Bold) fontstyle |= FontStyle.Bold;
                    if (item.Italic) fontstyle |= FontStyle.Italic;
                    if (item.Underline) fontstyle |= FontStyle.Underline;
                    if (item.Strikeout) fontstyle |= FontStyle.Strikeout;

                    //set font chữ
                    var font = new Font("Times New Roman", item.SizeChu, fontstyle);
                    var name = "Xem trước text";
                    var MeasureStringWidth = _hinhAnh.Graphics.MeasureString(name, font).Width;
                    var MeasureStringHeight = _hinhAnh.Graphics.MeasureString(name, font).Height;
                    float x, y;
                    //điền tên vào hình
                    if (item.CanGiuaNgang)
                        x = float.Parse(_hinhAnh.Width.ToString()) - MeasureStringWidth / 2;
                    else
                        x = item.ViTriNgang;
                    if (item.CanGiuaDoc)
                        y = float.Parse(_hinhAnh.Height.ToString()) - MeasureStringHeight / 2;
                    else
                        y = item.ViTriDoc;
                    _hinhAnh.Graphics.DrawString(name, font, Brushes.Black, new PointF(x, y));
                    ptb.Image = _hinhAnh.Bitmap;
                }
                ptb.Refresh();
            }
            else
            {
                MessageBox.Show("Điền ảnh trước đê bạn êi!");
            }
        }
    }
}
