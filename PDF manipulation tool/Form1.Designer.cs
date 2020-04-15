namespace PDF_manipulation_tool
{
    partial class pdfManipulationTool
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mergeButton = new System.Windows.Forms.Button();
            this.mainSection = new System.Windows.Forms.GroupBox();
            this.removeFiles = new System.Windows.Forms.Button();
            this.addFiles = new System.Windows.Forms.Button();
            this.moveFileDown = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.moveFileUp = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.splitAndSave = new System.Windows.Forms.Button();
            this.specificPageSelectionWindow = new System.Windows.Forms.CheckedListBox();
            this.specificPageSelectionRadioBtn = new System.Windows.Forms.RadioButton();
            this.rangeOfPagesRadioBtn = new System.Windows.Forms.RadioButton();
            this.endPageIndex = new System.Windows.Forms.NumericUpDown();
            this.startPageIndex = new System.Windows.Forms.NumericUpDown();
            this.endPageLabel = new System.Windows.Forms.Label();
            this.startPageLabel = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.Label();
            this.endPageSlider = new System.Windows.Forms.TrackBar();
            this.startPageSlider = new System.Windows.Forms.TrackBar();
            this.browse = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mainSection.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endPageIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPageSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.mergeButton);
            this.tabPage1.Controls.Add(this.mainSection);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Merge";
            // 
            // mergeButton
            // 
            this.mergeButton.Enabled = false;
            this.mergeButton.Location = new System.Drawing.Point(12, 371);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(525, 29);
            this.mergeButton.TabIndex = 5;
            this.mergeButton.Text = "Merge and save...";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // mainSection
            // 
            this.mainSection.Controls.Add(this.removeFiles);
            this.mainSection.Controls.Add(this.addFiles);
            this.mainSection.Controls.Add(this.moveFileDown);
            this.mainSection.Controls.Add(this.fileList);
            this.mainSection.Controls.Add(this.moveFileUp);
            this.mainSection.Location = new System.Drawing.Point(12, 33);
            this.mainSection.Name = "mainSection";
            this.mainSection.Size = new System.Drawing.Size(525, 332);
            this.mainSection.TabIndex = 4;
            this.mainSection.TabStop = false;
            this.mainSection.Text = "File list";
            // 
            // removeFiles
            // 
            this.removeFiles.Enabled = false;
            this.removeFiles.Location = new System.Drawing.Point(421, 99);
            this.removeFiles.Name = "removeFiles";
            this.removeFiles.Size = new System.Drawing.Size(98, 73);
            this.removeFiles.TabIndex = 6;
            this.removeFiles.Text = "Remove selected file\r\n-";
            this.removeFiles.UseVisualStyleBackColor = true;
            this.removeFiles.Click += new System.EventHandler(this.removePdfFromList);
            // 
            // addFiles
            // 
            this.addFiles.Location = new System.Drawing.Point(421, 21);
            this.addFiles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.addFiles.Name = "addFiles";
            this.addFiles.Size = new System.Drawing.Size(98, 73);
            this.addFiles.TabIndex = 5;
            this.addFiles.Text = "Add files\r\n+";
            this.addFiles.UseVisualStyleBackColor = true;
            this.addFiles.Click += new System.EventHandler(this.SelecPdfToMerge);
            // 
            // moveFileDown
            // 
            this.moveFileDown.Enabled = false;
            this.moveFileDown.Location = new System.Drawing.Point(421, 256);
            this.moveFileDown.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.moveFileDown.Name = "moveFileDown";
            this.moveFileDown.Size = new System.Drawing.Size(98, 73);
            this.moveFileDown.TabIndex = 4;
            this.moveFileDown.Text = "Move down\r\n▼";
            this.moveFileDown.UseVisualStyleBackColor = true;
            this.moveFileDown.Click += new System.EventHandler(this.moveFileDown_Click);
            // 
            // fileList
            // 
            this.fileList.DisplayMember = "Hello1";
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 16;
            this.fileList.Location = new System.Drawing.Point(6, 21);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(409, 308);
            this.fileList.TabIndex = 2;
            // 
            // moveFileUp
            // 
            this.moveFileUp.Enabled = false;
            this.moveFileUp.Location = new System.Drawing.Point(421, 178);
            this.moveFileUp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.moveFileUp.Name = "moveFileUp";
            this.moveFileUp.Size = new System.Drawing.Size(98, 73);
            this.moveFileUp.TabIndex = 3;
            this.moveFileUp.Text = "▲\r\nMove up";
            this.moveFileUp.UseVisualStyleBackColor = true;
            this.moveFileUp.Click += new System.EventHandler(this.moveFileUp_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(390, 17);
            this.title.TabIndex = 0;
            this.title.Text = "Add files and order them in the way you want them combined";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.selectAllCheckBox);
            this.tabPage2.Controls.Add(this.splitAndSave);
            this.tabPage2.Controls.Add(this.specificPageSelectionWindow);
            this.tabPage2.Controls.Add(this.specificPageSelectionRadioBtn);
            this.tabPage2.Controls.Add(this.rangeOfPagesRadioBtn);
            this.tabPage2.Controls.Add(this.endPageIndex);
            this.tabPage2.Controls.Add(this.startPageIndex);
            this.tabPage2.Controls.Add(this.endPageLabel);
            this.tabPage2.Controls.Add(this.startPageLabel);
            this.tabPage2.Controls.Add(this.filename);
            this.tabPage2.Controls.Add(this.endPageSlider);
            this.tabPage2.Controls.Add(this.startPageSlider);
            this.tabPage2.Controls.Add(this.browse);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Split";
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Enabled = false;
            this.selectAllCheckBox.Location = new System.Drawing.Point(66, 228);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(87, 21);
            this.selectAllCheckBox.TabIndex = 16;
            this.selectAllCheckBox.Text = "Select all";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // splitAndSave
            // 
            this.splitAndSave.Enabled = false;
            this.splitAndSave.Location = new System.Drawing.Point(13, 367);
            this.splitAndSave.Name = "splitAndSave";
            this.splitAndSave.Size = new System.Drawing.Size(519, 34);
            this.splitAndSave.TabIndex = 15;
            this.splitAndSave.Text = "Split and save...";
            this.splitAndSave.UseVisualStyleBackColor = true;
            this.splitAndSave.Click += new System.EventHandler(this.splitAndSave_Click);
            // 
            // specificPageSelectionWindow
            // 
            this.specificPageSelectionWindow.CheckOnClick = true;
            this.specificPageSelectionWindow.Enabled = false;
            this.specificPageSelectionWindow.FormattingEnabled = true;
            this.specificPageSelectionWindow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.specificPageSelectionWindow.Location = new System.Drawing.Point(63, 255);
            this.specificPageSelectionWindow.Name = "specificPageSelectionWindow";
            this.specificPageSelectionWindow.Size = new System.Drawing.Size(388, 106);
            this.specificPageSelectionWindow.TabIndex = 14;
            // 
            // specificPageSelectionRadioBtn
            // 
            this.specificPageSelectionRadioBtn.AutoSize = true;
            this.specificPageSelectionRadioBtn.Enabled = false;
            this.specificPageSelectionRadioBtn.Location = new System.Drawing.Point(13, 201);
            this.specificPageSelectionRadioBtn.Name = "specificPageSelectionRadioBtn";
            this.specificPageSelectionRadioBtn.Size = new System.Drawing.Size(138, 21);
            this.specificPageSelectionRadioBtn.TabIndex = 13;
            this.specificPageSelectionRadioBtn.Text = "Specific selection";
            this.specificPageSelectionRadioBtn.UseVisualStyleBackColor = true;
            this.specificPageSelectionRadioBtn.CheckedChanged += new System.EventHandler(this.specificPageSelectionRadioBtn_CheckedChanged);
            // 
            // rangeOfPagesRadioBtn
            // 
            this.rangeOfPagesRadioBtn.AutoSize = true;
            this.rangeOfPagesRadioBtn.Checked = true;
            this.rangeOfPagesRadioBtn.Enabled = false;
            this.rangeOfPagesRadioBtn.Location = new System.Drawing.Point(12, 69);
            this.rangeOfPagesRadioBtn.Name = "rangeOfPagesRadioBtn";
            this.rangeOfPagesRadioBtn.Size = new System.Drawing.Size(130, 21);
            this.rangeOfPagesRadioBtn.TabIndex = 12;
            this.rangeOfPagesRadioBtn.TabStop = true;
            this.rangeOfPagesRadioBtn.Text = "Range of pages";
            this.rangeOfPagesRadioBtn.UseVisualStyleBackColor = true;
            this.rangeOfPagesRadioBtn.CheckedChanged += new System.EventHandler(this.rangeOfPagesRadioBtn_CheckedChanged);
            // 
            // endPageIndex
            // 
            this.endPageIndex.Enabled = false;
            this.endPageIndex.Location = new System.Drawing.Point(168, 157);
            this.endPageIndex.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.endPageIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endPageIndex.Name = "endPageIndex";
            this.endPageIndex.ReadOnly = true;
            this.endPageIndex.Size = new System.Drawing.Size(66, 22);
            this.endPageIndex.TabIndex = 11;
            this.endPageIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endPageIndex.GotFocus += new System.EventHandler(this.endPageIndex_focus);
            this.endPageIndex.LostFocus += new System.EventHandler(this.endPageIndex_unfocus);
            // 
            // startPageIndex
            // 
            this.startPageIndex.Enabled = false;
            this.startPageIndex.Location = new System.Drawing.Point(168, 107);
            this.startPageIndex.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.startPageIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startPageIndex.Name = "startPageIndex";
            this.startPageIndex.ReadOnly = true;
            this.startPageIndex.Size = new System.Drawing.Size(66, 22);
            this.startPageIndex.TabIndex = 10;
            this.startPageIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startPageIndex.GotFocus += new System.EventHandler(this.startPageIndex_focus);
            this.startPageIndex.LostFocus += new System.EventHandler(this.startPageIndex_unfocus);
            // 
            // endPageLabel
            // 
            this.endPageLabel.AutoSize = true;
            this.endPageLabel.Enabled = false;
            this.endPageLabel.Location = new System.Drawing.Point(60, 157);
            this.endPageLabel.Name = "endPageLabel";
            this.endPageLabel.Size = new System.Drawing.Size(88, 17);
            this.endPageLabel.TabIndex = 5;
            this.endPageLabel.Text = "Ending page";
            // 
            // startPageLabel
            // 
            this.startPageLabel.AutoSize = true;
            this.startPageLabel.Enabled = false;
            this.startPageLabel.Location = new System.Drawing.Point(60, 107);
            this.startPageLabel.Name = "startPageLabel";
            this.startPageLabel.Size = new System.Drawing.Size(93, 17);
            this.startPageLabel.TabIndex = 4;
            this.startPageLabel.Text = "Starting page";
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(165, 46);
            this.filename.MaximumSize = new System.Drawing.Size(350, 0);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(0, 17);
            this.filename.TabIndex = 3;
            // 
            // endPageSlider
            // 
            this.endPageSlider.Enabled = false;
            this.endPageSlider.Location = new System.Drawing.Point(253, 157);
            this.endPageSlider.Minimum = 1;
            this.endPageSlider.Name = "endPageSlider";
            this.endPageSlider.Size = new System.Drawing.Size(279, 56);
            this.endPageSlider.TabIndex = 2;
            this.endPageSlider.Value = 10;
            this.endPageSlider.Scroll += new System.EventHandler(this.endPageSlider_Scroll);
            // 
            // startPageSlider
            // 
            this.startPageSlider.Enabled = false;
            this.startPageSlider.Location = new System.Drawing.Point(253, 107);
            this.startPageSlider.Minimum = 1;
            this.startPageSlider.Name = "startPageSlider";
            this.startPageSlider.Size = new System.Drawing.Size(279, 56);
            this.startPageSlider.TabIndex = 1;
            this.startPageSlider.Value = 1;
            this.startPageSlider.GotFocus += new System.EventHandler(this.startPageSlider_focus);
            this.startPageSlider.LostFocus += new System.EventHandler(this.startPageSlider_unfocus);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(13, 40);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pdfManipulationTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 466);
            this.Controls.Add(this.tabControl1);
            this.Name = "pdfManipulationTool";
            this.Text = "PDF Manipulation Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.mainSection.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endPageIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPageSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.Button splitAndSave;
        private System.Windows.Forms.CheckedListBox specificPageSelectionWindow;
        private System.Windows.Forms.RadioButton specificPageSelectionRadioBtn;
        private System.Windows.Forms.RadioButton rangeOfPagesRadioBtn;
        private System.Windows.Forms.NumericUpDown endPageIndex;
        private System.Windows.Forms.NumericUpDown startPageIndex;
        private System.Windows.Forms.Label endPageLabel;
        private System.Windows.Forms.Label startPageLabel;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.TrackBar endPageSlider;
        private System.Windows.Forms.TrackBar startPageSlider;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.GroupBox mainSection;
        private System.Windows.Forms.Button removeFiles;
        private System.Windows.Forms.Button addFiles;
        private System.Windows.Forms.Button moveFileDown;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Button moveFileUp;
        private System.Windows.Forms.Label title;
    }
}

