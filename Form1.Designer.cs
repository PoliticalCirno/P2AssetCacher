namespace P2AssetCacher;

    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            opencache = new OpenFileDialog();
            Materialist = new ListBox();
            add = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            Cachelist = new ListBox();
            numericUpDown1 = new NumericUpDown();
            Cachetypeindi = new Label();
            button1 = new Button();
            MeshSelect = new Button();
            label1 = new Label();
            curdir = new Label();
            RemoveMat = new Button();
            AddMat = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // opencache
            // 
            opencache.FileName = "openFileDialog1";
            opencache.FileOk += opencache_FileOk;
            // 
            // Materialist
            // 
            Materialist.BorderStyle = BorderStyle.FixedSingle;
            Materialist.FormattingEnabled = true;
            Materialist.ItemHeight = 25;
            Materialist.Location = new Point(465, 159);
            Materialist.Name = "Materialist";
            Materialist.Size = new Size(279, 527);
            Materialist.TabIndex = 2;
            Materialist.SelectedIndexChanged += Materialist_SelectedIndexChanged;
            // 
            // add
            // 
            add.Location = new Point(252, 779);
            add.Name = "add";
            add.Size = new Size(193, 69);
            add.TabIndex = 6;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(36, 742);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 31);
            textBox1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(938, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(169, 34);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(169, 34);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(766, 548);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 138);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // Cachelist
            // 
            Cachelist.BorderStyle = BorderStyle.FixedSingle;
            Cachelist.FormattingEnabled = true;
            Cachelist.ItemHeight = 25;
            Cachelist.Location = new Point(36, 159);
            Cachelist.Name = "Cachelist";
            Cachelist.Size = new Size(409, 577);
            Cachelist.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(729, 78);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 17;
            // 
            // Cachetypeindi
            // 
            Cachetypeindi.AutoSize = true;
            Cachetypeindi.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cachetypeindi.Location = new Point(652, 75);
            Cachetypeindi.Name = "Cachetypeindi";
            Cachetypeindi.Size = new Size(61, 32);
            Cachetypeindi.TabIndex = 18;
            Cachetypeindi.Text = "Part:";
            // 
            // button1
            // 
            button1.Location = new Point(36, 779);
            button1.Name = "button1";
            button1.Size = new Size(193, 69);
            button1.TabIndex = 19;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // MeshSelect
            // 
            MeshSelect.Location = new Point(766, 702);
            MeshSelect.Name = "MeshSelect";
            MeshSelect.Size = new Size(143, 34);
            MeshSelect.TabIndex = 20;
            MeshSelect.Text = "Import Mesh";
            MeshSelect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(465, 758);
            label1.Name = "label1";
            label1.Size = new Size(225, 45);
            label1.TabIndex = 21;
            label1.Text = "Current Mesh:";
            label1.Click += label1_Click;
            // 
            // curdir
            // 
            curdir.AutoSize = true;
            curdir.Font = new Font("Malgun Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            curdir.Location = new Point(465, 803);
            curdir.Name = "curdir";
            curdir.Size = new Size(78, 45);
            curdir.TabIndex = 22;
            curdir.Text = "N/A";
            curdir.Click += curdir_Click;
            // 
            // RemoveMat
            // 
            RemoveMat.Location = new Point(465, 702);
            RemoveMat.Name = "RemoveMat";
            RemoveMat.Size = new Size(128, 34);
            RemoveMat.TabIndex = 23;
            RemoveMat.Text = "Remove";
            RemoveMat.UseVisualStyleBackColor = true;
            // 
            // AddMat
            // 
            AddMat.Location = new Point(614, 702);
            AddMat.Name = "AddMat";
            AddMat.Size = new Size(130, 34);
            AddMat.TabIndex = 24;
            AddMat.Text = "Add";
            AddMat.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(12, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(609, 191);
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(36, 131);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 26;
            label2.Text = "Cache";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 131);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 27;
            label3.Text = "Materials";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(766, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 138);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(766, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 138);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 878);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AddMat);
            Controls.Add(RemoveMat);
            Controls.Add(curdir);
            Controls.Add(label1);
            Controls.Add(MeshSelect);
            Controls.Add(button1);
            Controls.Add(Cachetypeindi);
            Controls.Add(numericUpDown1);
            Controls.Add(Cachelist);
            Controls.Add(pictureBox3);
            Controls.Add(textBox1);
            Controls.Add(add);
            Controls.Add(Materialist);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "P2AssetCacher";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog opencache;
        private ListBox Materialist;
        private Button add;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private PictureBox pictureBox3;
        private ListBox Cachelist;
        private NumericUpDown numericUpDown1;
        private Label Cachetypeindi;
        private Button button1;
        private Button MeshSelect;
        private Label label1;
        private Label curdir;
        private Button RemoveMat;
        private Button AddMat;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox5;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }