namespace JustCCP_part_1_view
{
    partial class JustCCP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JustCCP));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.copyPage = new System.Windows.Forms.TabPage();
            this.copyButton = new System.Windows.Forms.Button();
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.pauseButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnSourceFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDestinition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.presentprogressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cutPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.setngPage = new System.Windows.Forms.TabPage();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.copyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cutPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.copyPage);
            this.tabControl1.Controls.Add(this.cutPage);
            this.tabControl1.Controls.Add(this.setngPage);
            this.tabControl1.Controls.Add(this.aboutPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // copyPage
            // 
            this.copyPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.copyPage.Controls.Add(this.copyButton);
            this.copyPage.Controls.Add(this.pauseButton);
            this.copyPage.Controls.Add(this.skipButton);
            this.copyPage.Controls.Add(this.quitButton);
            this.copyPage.Controls.Add(this.dataGridView1);
            this.copyPage.Controls.Add(this.progressBar2);
            this.copyPage.Controls.Add(this.label4);
            this.copyPage.Controls.Add(this.presentprogressBar);
            this.copyPage.Controls.Add(this.label3);
            this.copyPage.Controls.Add(this.destinationButton);
            this.copyPage.Controls.Add(this.textBox2);
            this.copyPage.Controls.Add(this.label2);
            this.copyPage.Controls.Add(this.sourceButton);
            this.copyPage.Controls.Add(this.textBox1);
            this.copyPage.Controls.Add(this.label1);
            this.copyPage.Location = new System.Drawing.Point(4, 22);
            this.copyPage.Name = "copyPage";
            this.copyPage.Padding = new System.Windows.Forms.Padding(3);
            this.copyPage.Size = new System.Drawing.Size(821, 595);
            this.copyPage.TabIndex = 0;
            this.copyPage.Text = "Copy";
            this.copyPage.Click += new System.EventHandler(this.copyPage_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.White;
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyButton.ImageIndex = 1;
            this.copyButton.ImageList = this.imageListButton;
            this.copyButton.Location = new System.Drawing.Point(468, 268);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(69, 29);
            this.copyButton.TabIndex = 16;
            this.copyButton.Text = "Copy";
            this.copyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // imageListButton
            // 
            this.imageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton.ImageStream")));
            this.imageListButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton.Images.SetKeyName(0, "02_pause-512.ico");
            this.imageListButton.Images.SetKeyName(1, "copy_page-512.ico");
            this.imageListButton.Images.SetKeyName(2, "cut-512.ico");
            this.imageListButton.Images.SetKeyName(3, "quitPng.ico");
            this.imageListButton.Images.SetKeyName(4, "skip_forward-512.ico");
            this.imageListButton.Images.SetKeyName(5, "sourcePng.ico");
            this.imageListButton.Images.SetKeyName(6, "destinationPng.ico");
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.White;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pauseButton.ImageIndex = 0;
            this.pauseButton.ImageList = this.imageListButton;
            this.pauseButton.Location = new System.Drawing.Point(557, 268);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(80, 29);
            this.pauseButton.TabIndex = 15;
            this.pauseButton.Text = "Pause";
            this.pauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pauseButton.UseVisualStyleBackColor = false;
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.White;
            this.skipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skipButton.ImageIndex = 4;
            this.skipButton.ImageList = this.imageListButton;
            this.skipButton.Location = new System.Drawing.Point(655, 268);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(68, 29);
            this.skipButton.TabIndex = 14;
            this.skipButton.Text = "Skip";
            this.skipButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skipButton.UseVisualStyleBackColor = false;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.White;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitButton.ImageIndex = 3;
            this.quitButton.ImageList = this.imageListButton;
            this.quitButton.Location = new System.Drawing.Point(740, 268);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(65, 29);
            this.quitButton.TabIndex = 13;
            this.quitButton.Text = "Quit";
            this.quitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quitButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSourceFile,
            this.ColumnSize,
            this.ColumnStatus,
            this.ColumnDestinition,
            this.ColumnTime});
            this.dataGridView1.Location = new System.Drawing.Point(13, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(792, 261);
            this.dataGridView1.TabIndex = 12;
            // 
            // ColumnSourceFile
            // 
            this.ColumnSourceFile.HeaderText = "Source File";
            this.ColumnSourceFile.Name = "ColumnSourceFile";
            this.ColumnSourceFile.ReadOnly = true;
            // 
            // ColumnSize
            // 
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // ColumnDestinition
            // 
            this.ColumnDestinition.HeaderText = "Destinition";
            this.ColumnDestinition.Name = "ColumnDestinition";
            this.ColumnDestinition.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Date/Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(10, 222);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(795, 23);
            this.progressBar2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Progress";
            // 
            // presentprogressBar
            // 
            this.presentprogressBar.Location = new System.Drawing.Point(10, 158);
            this.presentprogressBar.Name = "presentprogressBar";
            this.presentprogressBar.Size = new System.Drawing.Size(795, 23);
            this.presentprogressBar.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Present File Progress ";
            // 
            // destinationButton
            // 
            this.destinationButton.BackColor = System.Drawing.Color.White;
            this.destinationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.destinationButton.ImageIndex = 6;
            this.destinationButton.ImageList = this.imageListButton;
            this.destinationButton.Location = new System.Drawing.Point(697, 75);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(108, 29);
            this.destinationButton.TabIndex = 7;
            this.destinationButton.Text = "Destination";
            this.destinationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.destinationButton.UseVisualStyleBackColor = false;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(161, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(509, 24);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designation Path";
            // 
            // sourceButton
            // 
            this.sourceButton.BackColor = System.Drawing.Color.White;
            this.sourceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sourceButton.ImageIndex = 5;
            this.sourceButton.ImageList = this.imageListButton;
            this.sourceButton.Location = new System.Drawing.Point(717, 29);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(88, 29);
            this.sourceButton.TabIndex = 4;
            this.sourceButton.Text = "Source";
            this.sourceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sourceButton.UseVisualStyleBackColor = false;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(161, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 24);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Path";
            // 
            // cutPage
            // 
            this.cutPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cutPage.Controls.Add(this.button3);
            this.cutPage.Controls.Add(this.button5);
            this.cutPage.Controls.Add(this.button6);
            this.cutPage.Controls.Add(this.button10);
            this.cutPage.Controls.Add(this.dataGridView2);
            this.cutPage.Controls.Add(this.progressBar3);
            this.cutPage.Controls.Add(this.label5);
            this.cutPage.Controls.Add(this.progressBar4);
            this.cutPage.Controls.Add(this.label6);
            this.cutPage.Controls.Add(this.button11);
            this.cutPage.Controls.Add(this.textBox3);
            this.cutPage.Controls.Add(this.label7);
            this.cutPage.Controls.Add(this.button12);
            this.cutPage.Controls.Add(this.textBox4);
            this.cutPage.Controls.Add(this.label8);
            this.cutPage.Location = new System.Drawing.Point(4, 22);
            this.cutPage.Name = "cutPage";
            this.cutPage.Padding = new System.Windows.Forms.Padding(3);
            this.cutPage.Size = new System.Drawing.Size(821, 595);
            this.cutPage.TabIndex = 1;
            this.cutPage.Text = "Cut";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageListButton;
            this.button3.Location = new System.Drawing.Point(475, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 29);
            this.button3.TabIndex = 31;
            this.button3.Text = "Cut";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 0;
            this.button5.ImageList = this.imageListButton;
            this.button5.Location = new System.Drawing.Point(557, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 29);
            this.button5.TabIndex = 30;
            this.button5.Text = "Pause";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 4;
            this.button6.ImageList = this.imageListButton;
            this.button6.Location = new System.Drawing.Point(655, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 29);
            this.button6.TabIndex = 29;
            this.button6.Text = "Skip";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.ImageIndex = 3;
            this.button10.ImageList = this.imageListButton;
            this.button10.Location = new System.Drawing.Point(740, 268);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 29);
            this.button10.TabIndex = 28;
            this.button10.Text = "Quit";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(13, 318);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(792, 261);
            this.dataGridView2.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Source File";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Size";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Destinition";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date/Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(10, 222);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(795, 23);
            this.progressBar3.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Total Progress";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(10, 158);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(795, 23);
            this.progressBar4.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Present File Progress ";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.ImageIndex = 6;
            this.button11.ImageList = this.imageListButton;
            this.button11.Location = new System.Drawing.Point(697, 75);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(108, 29);
            this.button11.TabIndex = 22;
            this.button11.Text = "Destination";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(161, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(509, 24);
            this.textBox3.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Designation Path";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.ImageIndex = 5;
            this.button12.ImageList = this.imageListButton;
            this.button12.Location = new System.Drawing.Point(717, 29);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 29);
            this.button12.TabIndex = 19;
            this.button12.Text = "Source";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(161, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(509, 24);
            this.textBox4.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Source Path";
            // 
            // setngPage
            // 
            this.setngPage.Location = new System.Drawing.Point(4, 22);
            this.setngPage.Name = "setngPage";
            this.setngPage.Padding = new System.Windows.Forms.Padding(3);
            this.setngPage.Size = new System.Drawing.Size(821, 595);
            this.setngPage.TabIndex = 2;
            this.setngPage.Text = "Setting";
            this.setngPage.UseVisualStyleBackColor = true;
            // 
            // aboutPage
            // 
            this.aboutPage.Location = new System.Drawing.Point(4, 22);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(821, 595);
            this.aboutPage.TabIndex = 3;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // JustCCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 643);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "JustCCP";
            this.Text = "JustCCP";
            this.tabControl1.ResumeLayout(false);
            this.copyPage.ResumeLayout(false);
            this.copyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cutPage.ResumeLayout(false);
            this.cutPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage copyPage;
        private System.Windows.Forms.TabPage cutPage;
        private System.Windows.Forms.TabPage setngPage;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar presentprogressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSourceFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestinition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ImageList imageListButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;

    }
}

