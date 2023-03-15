namespace ReNamer
{
    partial class ReNamer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReNamer));
            lboxFiles = new ListBox();
            txtPath = new TextBox();
            btnBrowse = new Button();
            groupBox1 = new GroupBox();
            btnRename = new Button();
            chkLowercase = new CheckBox();
            chkUppercase = new CheckBox();
            chkNumbers = new CheckBox();
            chkSpaces = new CheckBox();
            chkRegex = new CheckBox();
            txtReplacewith = new TextBox();
            txtSearchfor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtProgress = new Label();
            pbarProgress = new ProgressBar();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lboxFiles
            // 
            lboxFiles.BackColor = Color.Silver;
            lboxFiles.BorderStyle = BorderStyle.None;
            lboxFiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lboxFiles.ForeColor = Color.FromArgb(64, 64, 64);
            lboxFiles.FormattingEnabled = true;
            lboxFiles.ItemHeight = 21;
            lboxFiles.Location = new Point(12, 263);
            lboxFiles.Name = "lboxFiles";
            lboxFiles.Size = new Size(444, 357);
            lboxFiles.TabIndex = 0;
            // 
            // txtPath
            // 
            txtPath.BackColor = Color.Silver;
            txtPath.Enabled = false;
            txtPath.ForeColor = Color.FromArgb(64, 64, 64);
            txtPath.Location = new Point(12, 12);
            txtPath.MinimumSize = new Size(379, 23);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(379, 23);
            txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.ForeColor = Color.FromArgb(224, 224, 224);
            btnBrowse.Location = new Point(397, 10);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(59, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRename);
            groupBox1.Controls.Add(chkLowercase);
            groupBox1.Controls.Add(chkUppercase);
            groupBox1.Controls.Add(chkNumbers);
            groupBox1.Controls.Add(chkSpaces);
            groupBox1.Controls.Add(chkRegex);
            groupBox1.Controls.Add(txtReplacewith);
            groupBox1.Controls.Add(txtSearchfor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 202);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnRename
            // 
            btnRename.FlatStyle = FlatStyle.Flat;
            btnRename.Location = new Point(308, 162);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(117, 23);
            btnRename.TabIndex = 2;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // chkLowercase
            // 
            chkLowercase.AutoSize = true;
            chkLowercase.Location = new Point(308, 109);
            chkLowercase.Name = "chkLowercase";
            chkLowercase.Size = new Size(96, 19);
            chkLowercase.TabIndex = 2;
            chkLowercase.Text = "To Lowercase";
            chkLowercase.UseVisualStyleBackColor = true;
            chkLowercase.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // chkUppercase
            // 
            chkUppercase.AutoSize = true;
            chkUppercase.Location = new Point(308, 79);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(96, 19);
            chkUppercase.TabIndex = 2;
            chkUppercase.Text = "To Uppercase";
            chkUppercase.UseVisualStyleBackColor = true;
            chkUppercase.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.Location = new Point(308, 50);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(121, 19);
            chkNumbers.TabIndex = 2;
            chkNumbers.Text = "Remove Numbers";
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSpaces
            // 
            chkSpaces.AutoSize = true;
            chkSpaces.Location = new Point(308, 22);
            chkSpaces.Name = "chkSpaces";
            chkSpaces.Size = new Size(108, 19);
            chkSpaces.TabIndex = 2;
            chkSpaces.Text = "Remove Spaces";
            chkSpaces.UseVisualStyleBackColor = true;
            // 
            // chkRegex
            // 
            chkRegex.AutoSize = true;
            chkRegex.Checked = true;
            chkRegex.CheckState = CheckState.Checked;
            chkRegex.Location = new Point(15, 75);
            chkRegex.Name = "chkRegex";
            chkRegex.Size = new Size(58, 19);
            chkRegex.TabIndex = 2;
            chkRegex.Text = "Regex";
            chkRegex.UseVisualStyleBackColor = true;
            // 
            // txtReplacewith
            // 
            txtReplacewith.BackColor = Color.Silver;
            txtReplacewith.ForeColor = Color.FromArgb(64, 64, 64);
            txtReplacewith.Location = new Point(15, 162);
            txtReplacewith.MinimumSize = new Size(230, 23);
            txtReplacewith.Name = "txtReplacewith";
            txtReplacewith.Size = new Size(230, 23);
            txtReplacewith.TabIndex = 1;
            // 
            // txtSearchfor
            // 
            txtSearchfor.BackColor = Color.Silver;
            txtSearchfor.ForeColor = Color.FromArgb(64, 64, 64);
            txtSearchfor.Location = new Point(15, 46);
            txtSearchfor.MinimumSize = new Size(230, 23);
            txtSearchfor.Name = "txtSearchfor";
            txtSearchfor.Size = new Size(230, 23);
            txtSearchfor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 144);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Replace with:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Search for:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 638);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // txtProgress
            // 
            txtProgress.AutoSize = true;
            txtProgress.Location = new Point(60, 638);
            txtProgress.Name = "txtProgress";
            txtProgress.Size = new Size(39, 15);
            txtProgress.TabIndex = 4;
            txtProgress.Text = "IDLE...";
            txtProgress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbarProgress
            // 
            pbarProgress.Location = new Point(275, 634);
            pbarProgress.Name = "pbarProgress";
            pbarProgress.Size = new Size(181, 23);
            pbarProgress.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 638);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Status:";
            // 
            // ReNamer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(468, 666);
            Controls.Add(pbarProgress);
            Controls.Add(txtProgress);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(btnBrowse);
            Controls.Add(txtPath);
            Controls.Add(lboxFiles);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReNamer";
            Text = "ReNamer";
            Load += Form1_Load;
            Shown += ReNamer_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lboxFiles;
        private TextBox txtPath;
        private Button btnBrowse;
        private GroupBox groupBox1;
        private Button btnRename;
        private CheckBox chkUppercase;
        private CheckBox chkNumbers;
        private CheckBox chkSpaces;
        private CheckBox chkRegex;
        private TextBox txtReplacewith;
        private TextBox txtSearchfor;
        private Label label2;
        private Label label1;
        private CheckBox chkLowercase;
        private Label label3;
        private Label txtProgress;
        private ProgressBar pbarProgress;
        private Label label5;


    }
}