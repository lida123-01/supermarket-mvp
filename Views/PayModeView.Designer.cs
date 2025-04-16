namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            TapControl = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            textBox3 = new TextBox();
            TxtPayModeObservation = new Label();
            textBox2 = new TextBox();
            TxtPayModeName = new Label();
            textBox1 = new TextBox();
            TxtPayModeId = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            TapControl.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TapControl
            // 
            TapControl.Controls.Add(tabPagePayModeList);
            TapControl.Controls.Add(tabPagePayModeDetail);
            TapControl.Location = new Point(3, 74);
            TapControl.Name = "TapControl";
            TapControl.SelectedIndex = 0;
            TapControl.Size = new Size(882, 448);
            TapControl.TabIndex = 10;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label1);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(874, 415);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.Gainsboro;
            BtnClose.BackgroundImage = (Image)resources.GetObject("BtnClose.BackgroundImage");
            BtnClose.BackgroundImageLayout = ImageLayout.Center;
            BtnClose.Location = new Point(651, 342);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(200, 51);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += button5_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Gainsboro;
            BtnDelete.BackgroundImage = (Image)resources.GetObject("BtnDelete.BackgroundImage");
            BtnDelete.BackgroundImageLayout = ImageLayout.Center;
            BtnDelete.Location = new Point(651, 271);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(200, 62);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.Gainsboro;
            BtnEdit.BackgroundImage = (Image)resources.GetObject("BtnEdit.BackgroundImage");
            BtnEdit.BackgroundImageLayout = ImageLayout.Center;
            BtnEdit.Location = new Point(651, 197);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(200, 65);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += button3_Click;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.Gainsboro;
            BtnNew.BackgroundImage = (Image)resources.GetObject("BtnNew.BackgroundImage");
            BtnNew.BackgroundImageLayout = ImageLayout.Center;
            BtnNew.Location = new Point(651, 125);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(200, 63);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            BtnNew.Click += button2_Click;
            // 
            // DgPayMode
            // 
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(20, 104);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.Size = new Size(614, 289);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.Gainsboro;
            BtnSearch.BackgroundImage = (Image)resources.GetObject("BtnSearch.BackgroundImage");
            BtnSearch.BackgroundImageLayout = ImageLayout.Center;
            BtnSearch.Location = new Point(584, 42);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 40);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.ForeColor = SystemColors.ScrollBar;
            TxtSearch.Location = new Point(20, 55);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(558, 27);
            TxtSearch.TabIndex = 1;
            TxtSearch.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Search Pay Mode";
            label1.Click += label1_Click_1;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(textBox3);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(textBox2);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(textBox1);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(874, 415);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.Gainsboro;
            BtnCancel.BackgroundImage = (Image)resources.GetObject("BtnCancel.BackgroundImage");
            BtnCancel.BackgroundImageLayout = ImageLayout.Center;
            BtnCancel.Location = new Point(151, 347);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(99, 61);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.Gainsboro;
            BtnSave.BackgroundImage = (Image)resources.GetObject("BtnSave.BackgroundImage");
            BtnSave.BackgroundImageLayout = ImageLayout.Center;
            BtnSave.Location = new Point(15, 347);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(99, 61);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += button6_Click;
            // 
            // textBox3
            // 
            textBox3.AccessibleDescription = "";
            textBox3.Location = new Point(15, 209);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Pay Mode Observation";
            textBox3.Size = new Size(422, 122);
            textBox3.TabIndex = 5;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.AutoSize = true;
            TxtPayModeObservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TxtPayModeObservation.ForeColor = SystemColors.ActiveCaptionText;
            TxtPayModeObservation.Location = new Point(15, 175);
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(168, 20);
            TxtPayModeObservation.TabIndex = 4;
            TxtPayModeObservation.Text = "Pay Mode Observation";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 130);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Pay Mode Name";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 3;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.AutoSize = true;
            TxtPayModeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TxtPayModeName.ForeColor = SystemColors.ActiveCaptionText;
            TxtPayModeName.Location = new Point(15, 96);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(124, 20);
            TxtPayModeName.TabIndex = 2;
            TxtPayModeName.Text = "Pay Mode Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 1;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.AutoSize = true;
            TxtPayModeId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TxtPayModeId.ForeColor = SystemColors.ActiveCaptionText;
            TxtPayModeId.Location = new Point(15, 19);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(96, 20);
            TxtPayModeId.TabIndex = 0;
            TxtPayModeId.Text = "Pay Mode Id";
            TxtPayModeId.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 78);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(176, 22);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(157, 41);
            label2.TabIndex = 12;
            label2.Text = "Pay Mode";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(885, 519);
            Controls.Add(panel1);
            Controls.Add(TapControl);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PayModeView";
            Text = "Pay Mode  Management";
            Load += PayModeView_Load;
            TapControl.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TapControl;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Label label1;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label TxtPayModeId;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label TxtPayModeName;
        private TextBox textBox3;
        private Label TxtPayModeObservation;
        private Button BtnSave;
        private Button BtnCancel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}