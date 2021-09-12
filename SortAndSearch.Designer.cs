namespace _1911191_Lab03_Bai01
{
    partial class SortAndSearch
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
            this.pnSort = new System.Windows.Forms.Panel();
            this.rbNgaySinh = new System.Windows.Forms.RadioButton();
            this.rbHoTen = new System.Windows.Forms.RadioButton();
            this.rbMaSV = new System.Windows.Forms.RadioButton();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCloseDialogue = new System.Windows.Forms.Button();
            this.pnSort.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSort
            // 
            this.pnSort.Controls.Add(this.rbNgaySinh);
            this.pnSort.Controls.Add(this.rbHoTen);
            this.pnSort.Controls.Add(this.rbMaSV);
            this.pnSort.Location = new System.Drawing.Point(20, 19);
            this.pnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnSort.Name = "pnSort";
            this.pnSort.Size = new System.Drawing.Size(506, 112);
            this.pnSort.TabIndex = 0;
            // 
            // rbNgaySinh
            // 
            this.rbNgaySinh.AutoSize = true;
            this.rbNgaySinh.Location = new System.Drawing.Point(393, 45);
            this.rbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNgaySinh.Name = "rbNgaySinh";
            this.rbNgaySinh.Size = new System.Drawing.Size(95, 23);
            this.rbNgaySinh.TabIndex = 2;
            this.rbNgaySinh.TabStop = true;
            this.rbNgaySinh.Text = "Ngày sinh";
            this.rbNgaySinh.UseVisualStyleBackColor = true;
            // 
            // rbHoTen
            // 
            this.rbHoTen.AutoSize = true;
            this.rbHoTen.Location = new System.Drawing.Point(209, 45);
            this.rbHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbHoTen.Name = "rbHoTen";
            this.rbHoTen.Size = new System.Drawing.Size(93, 23);
            this.rbHoTen.TabIndex = 1;
            this.rbHoTen.TabStop = true;
            this.rbHoTen.Text = "Họ và tên";
            this.rbHoTen.UseVisualStyleBackColor = true;
            // 
            // rbMaSV
            // 
            this.rbMaSV.AutoSize = true;
            this.rbMaSV.Location = new System.Drawing.Point(20, 44);
            this.rbMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMaSV.Name = "rbMaSV";
            this.rbMaSV.Size = new System.Drawing.Size(70, 23);
            this.rbMaSV.TabIndex = 0;
            this.rbMaSV.TabStop = true;
            this.rbMaSV.Text = "Mã SV";
            this.rbMaSV.UseVisualStyleBackColor = true;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtThongTin);
            this.pnSearch.Controls.Add(this.label1);
            this.pnSearch.Location = new System.Drawing.Point(20, 155);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(506, 64);
            this.pnSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(413, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(152, 17);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(244, 26);
            this.txtThongTin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // btnSort
            // 
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSort.Location = new System.Drawing.Point(101, 245);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 31);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCloseDialogue
            // 
            this.btnCloseDialogue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseDialogue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDialogue.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnCloseDialogue.Location = new System.Drawing.Point(356, 245);
            this.btnCloseDialogue.Name = "btnCloseDialogue";
            this.btnCloseDialogue.Size = new System.Drawing.Size(75, 31);
            this.btnCloseDialogue.TabIndex = 4;
            this.btnCloseDialogue.Text = "Thoát";
            this.btnCloseDialogue.UseVisualStyleBackColor = true;
            this.btnCloseDialogue.Click += new System.EventHandler(this.btnCloseDialogue_Click);
            // 
            // SortAndSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 288);
            this.Controls.Add(this.btnCloseDialogue);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.pnSort);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SortAndSearch";
            this.Text = "SortAndSearch";
            this.pnSort.ResumeLayout(false);
            this.pnSort.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSort;
        private System.Windows.Forms.RadioButton rbNgaySinh;
        private System.Windows.Forms.RadioButton rbHoTen;
        private System.Windows.Forms.RadioButton rbMaSV;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnCloseDialogue;
    }
}