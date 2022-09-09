
namespace AddText
{
    partial class frmThemChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThemChu = new System.Windows.Forms.Button();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dtgFileExcel = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgListText = new System.Windows.Forms.DataGridView();
            this.pnlRightTop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnLuuChu = new System.Windows.Forms.Button();
            this.btnXemTruocChu = new System.Windows.Forms.Button();
            this.txtTenText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkCanGiuaDoc = new System.Windows.Forms.CheckBox();
            this.chkCanGiuaNgang = new System.Windows.Forms.CheckBox();
            this.cboFontChu = new System.Windows.Forms.ComboBox();
            this.chkStrikeout = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtViTriNgang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtViTriDoc = new System.Windows.Forms.TextBox();
            this.txtSizeChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.btnXemTruoc = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnTaiExcel = new System.Windows.Forms.Button();
            this.btnThemHinhAnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.pnlFill.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFileExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListText)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemChu
            // 
            this.btnThemChu.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChu.Location = new System.Drawing.Point(939, 5);
            this.btnThemChu.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemChu.Name = "btnThemChu";
            this.btnThemChu.Size = new System.Drawing.Size(150, 40);
            this.btnThemChu.TabIndex = 1;
            this.btnThemChu.Text = "Thêm chữ";
            this.btnThemChu.UseVisualStyleBackColor = true;
            this.btnThemChu.Click += new System.EventHandler(this.btnThemChu_Click);
            // 
            // ptb
            // 
            this.ptb.Location = new System.Drawing.Point(208, 63);
            this.ptb.Margin = new System.Windows.Forms.Padding(5);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(590, 456);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb.TabIndex = 0;
            this.ptb.TabStop = false;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.pnlRight);
            this.pnlFill.Controls.Add(this.pnlLeft);
            this.pnlFill.Controls.Add(this.pnlBot);
            this.pnlFill.Controls.Add(this.pnlTop);
            this.pnlFill.Controls.Add(this.ptb);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(1103, 580);
            this.pnlFill.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dtgFileExcel);
            this.pnlRight.Controls.Add(this.label9);
            this.pnlRight.Controls.Add(this.dtgListText);
            this.pnlRight.Controls.Add(this.pnlRightTop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(806, 55);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(297, 472);
            this.pnlRight.TabIndex = 4;
            // 
            // dtgFileExcel
            // 
            this.dtgFileExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFileExcel.Location = new System.Drawing.Point(0, 291);
            this.dtgFileExcel.Name = "dtgFileExcel";
            this.dtgFileExcel.RowHeadersWidth = 51;
            this.dtgFileExcel.RowTemplate.Height = 24;
            this.dtgFileExcel.Size = new System.Drawing.Size(297, 181);
            this.dtgFileExcel.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Danh sách thông tin exel";
            // 
            // dtgListText
            // 
            this.dtgListText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListText.Location = new System.Drawing.Point(0, 59);
            this.dtgListText.Name = "dtgListText";
            this.dtgListText.RowHeadersWidth = 51;
            this.dtgListText.RowTemplate.Height = 24;
            this.dtgListText.Size = new System.Drawing.Size(297, 173);
            this.dtgListText.TabIndex = 0;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.label7);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(297, 59);
            this.pnlRightTop.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Danh sách chữ";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnLuuChu);
            this.pnlLeft.Controls.Add(this.btnXemTruocChu);
            this.pnlLeft.Controls.Add(this.txtTenText);
            this.pnlLeft.Controls.Add(this.label8);
            this.pnlLeft.Controls.Add(this.chkCanGiuaDoc);
            this.pnlLeft.Controls.Add(this.chkCanGiuaNgang);
            this.pnlLeft.Controls.Add(this.cboFontChu);
            this.pnlLeft.Controls.Add(this.chkStrikeout);
            this.pnlLeft.Controls.Add(this.chkUnderline);
            this.pnlLeft.Controls.Add(this.chkItalic);
            this.pnlLeft.Controls.Add(this.chkBold);
            this.pnlLeft.Controls.Add(this.chkRegular);
            this.pnlLeft.Controls.Add(this.label6);
            this.pnlLeft.Controls.Add(this.txtViTriNgang);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.txtViTriDoc);
            this.pnlLeft.Controls.Add(this.txtSizeChu);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 55);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 472);
            this.pnlLeft.TabIndex = 3;
            // 
            // btnLuuChu
            // 
            this.btnLuuChu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuChu.Location = new System.Drawing.Point(15, 427);
            this.btnLuuChu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuuChu.Name = "btnLuuChu";
            this.btnLuuChu.Size = new System.Drawing.Size(150, 40);
            this.btnLuuChu.TabIndex = 24;
            this.btnLuuChu.Text = "Lưu chữ";
            this.btnLuuChu.UseVisualStyleBackColor = true;
            this.btnLuuChu.Click += new System.EventHandler(this.btnLuuChu_Click);
            // 
            // btnXemTruocChu
            // 
            this.btnXemTruocChu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTruocChu.Location = new System.Drawing.Point(15, 377);
            this.btnXemTruocChu.Margin = new System.Windows.Forms.Padding(5);
            this.btnXemTruocChu.Name = "btnXemTruocChu";
            this.btnXemTruocChu.Size = new System.Drawing.Size(150, 40);
            this.btnXemTruocChu.TabIndex = 5;
            this.btnXemTruocChu.Text = "Xem trước";
            this.btnXemTruocChu.UseVisualStyleBackColor = true;
            this.btnXemTruocChu.Click += new System.EventHandler(this.btnXemTruocChu_Click);
            // 
            // txtTenText
            // 
            this.txtTenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenText.Location = new System.Drawing.Point(87, 59);
            this.txtTenText.Name = "txtTenText";
            this.txtTenText.Size = new System.Drawing.Size(100, 24);
            this.txtTenText.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tên Text:";
            // 
            // chkCanGiuaDoc
            // 
            this.chkCanGiuaDoc.AutoSize = true;
            this.chkCanGiuaDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanGiuaDoc.Location = new System.Drawing.Point(12, 263);
            this.chkCanGiuaDoc.Name = "chkCanGiuaDoc";
            this.chkCanGiuaDoc.Size = new System.Drawing.Size(117, 22);
            this.chkCanGiuaDoc.TabIndex = 21;
            this.chkCanGiuaDoc.Text = "Căn giữa dọc";
            this.chkCanGiuaDoc.UseVisualStyleBackColor = true;
            // 
            // chkCanGiuaNgang
            // 
            this.chkCanGiuaNgang.AutoSize = true;
            this.chkCanGiuaNgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanGiuaNgang.Location = new System.Drawing.Point(12, 235);
            this.chkCanGiuaNgang.Name = "chkCanGiuaNgang";
            this.chkCanGiuaNgang.Size = new System.Drawing.Size(132, 22);
            this.chkCanGiuaNgang.TabIndex = 20;
            this.chkCanGiuaNgang.Text = "Căn giữa ngang";
            this.chkCanGiuaNgang.UseVisualStyleBackColor = true;
            // 
            // cboFontChu
            // 
            this.cboFontChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFontChu.FormattingEnabled = true;
            this.cboFontChu.Location = new System.Drawing.Point(87, 90);
            this.cboFontChu.Name = "cboFontChu";
            this.cboFontChu.Size = new System.Drawing.Size(100, 26);
            this.cboFontChu.TabIndex = 4;
            // 
            // chkStrikeout
            // 
            this.chkStrikeout.AutoSize = true;
            this.chkStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStrikeout.Location = new System.Drawing.Point(35, 347);
            this.chkStrikeout.Name = "chkStrikeout";
            this.chkStrikeout.Size = new System.Drawing.Size(89, 22);
            this.chkStrikeout.TabIndex = 19;
            this.chkStrikeout.Text = "Strikeout";
            this.chkStrikeout.UseVisualStyleBackColor = true;
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(95, 319);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(92, 22);
            this.chkUnderline.TabIndex = 18;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(8, 319);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(59, 22);
            this.chkItalic.TabIndex = 17;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(95, 291);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(60, 22);
            this.chkBold.TabIndex = 16;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegular.Location = new System.Drawing.Point(8, 291);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(81, 22);
            this.chkRegular.TabIndex = 15;
            this.chkRegular.Text = "Regular";
            this.chkRegular.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Style chữ:";
            // 
            // txtViTriNgang
            // 
            this.txtViTriNgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTriNgang.Location = new System.Drawing.Point(87, 189);
            this.txtViTriNgang.Name = "txtViTriNgang";
            this.txtViTriNgang.Size = new System.Drawing.Size(100, 24);
            this.txtViTriNgang.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngang:";
            // 
            // txtViTriDoc
            // 
            this.txtViTriDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTriDoc.Location = new System.Drawing.Point(87, 159);
            this.txtViTriDoc.Name = "txtViTriDoc";
            this.txtViTriDoc.Size = new System.Drawing.Size(100, 24);
            this.txtViTriDoc.TabIndex = 6;
            // 
            // txtSizeChu
            // 
            this.txtSizeChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizeChu.Location = new System.Drawing.Point(87, 126);
            this.txtSizeChu.Name = "txtSizeChu";
            this.txtSizeChu.Size = new System.Drawing.Size(100, 24);
            this.txtSizeChu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dọc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size chữ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Font chữ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm chữ";
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.btnXemTruoc);
            this.pnlBot.Controls.Add(this.btnThemChu);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 527);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(1103, 53);
            this.pnlBot.TabIndex = 2;
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTruoc.Location = new System.Drawing.Point(779, 8);
            this.btnXemTruoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(150, 40);
            this.btnXemTruoc.TabIndex = 4;
            this.btnXemTruoc.Text = "Xem trước";
            this.btnXemTruoc.UseVisualStyleBackColor = true;
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnTaiExcel);
            this.pnlTop.Controls.Add(this.btnThemHinhAnh);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1103, 55);
            this.pnlTop.TabIndex = 1;
            // 
            // btnTaiExcel
            // 
            this.btnTaiExcel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiExcel.Location = new System.Drawing.Point(165, 5);
            this.btnTaiExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnTaiExcel.Name = "btnTaiExcel";
            this.btnTaiExcel.Size = new System.Drawing.Size(150, 40);
            this.btnTaiExcel.TabIndex = 4;
            this.btnTaiExcel.Text = "Tải file excel";
            this.btnTaiExcel.UseVisualStyleBackColor = true;
            this.btnTaiExcel.Visible = false;
            // 
            // btnThemHinhAnh
            // 
            this.btnThemHinhAnh.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHinhAnh.Location = new System.Drawing.Point(5, 5);
            this.btnThemHinhAnh.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemHinhAnh.Name = "btnThemHinhAnh";
            this.btnThemHinhAnh.Size = new System.Drawing.Size(150, 40);
            this.btnThemHinhAnh.TabIndex = 2;
            this.btnThemHinhAnh.Text = "Thêm hình ảnh";
            this.btnThemHinhAnh.UseVisualStyleBackColor = true;
            this.btnThemHinhAnh.Click += new System.EventHandler(this.btnThemHinhAnh_Click);
            // 
            // frmThemChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 580);
            this.Controls.Add(this.pnlFill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThemChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chữ";
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFileExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListText)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlBot.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThemChu;
        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Button btnThemHinhAnh;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtViTriNgang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtViTriDoc;
        private System.Windows.Forms.TextBox txtSizeChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkStrikeout;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.ComboBox cboFontChu;
        private System.Windows.Forms.CheckBox chkCanGiuaDoc;
        private System.Windows.Forms.CheckBox chkCanGiuaNgang;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlRightTop;
        private System.Windows.Forms.TextBox txtTenText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXemTruoc;
        private System.Windows.Forms.DataGridView dtgListText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuuChu;
        private System.Windows.Forms.Button btnXemTruocChu;
        private System.Windows.Forms.DataGridView dtgFileExcel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTaiExcel;
    }
}

