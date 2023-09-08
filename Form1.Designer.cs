namespace WebcameCaptureApp
{
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
            comboBox1WebCame = new ComboBox();
            button1Start = new Button();
            button2Capture = new Button();
            button3Save = new Button();
            button4Exit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1WebCame
            // 
            comboBox1WebCame.FormattingEnabled = true;
            comboBox1WebCame.Location = new Point(12, 12);
            comboBox1WebCame.Name = "comboBox1WebCame";
            comboBox1WebCame.Size = new Size(151, 29);
            comboBox1WebCame.TabIndex = 0;
            // 
            // button1Start
            // 
            button1Start.Location = new Point(169, 11);
            button1Start.Name = "button1Start";
            button1Start.Size = new Size(94, 29);
            button1Start.TabIndex = 1;
            button1Start.Text = "Start";
            button1Start.UseVisualStyleBackColor = true;
            button1Start.Click += button1_Click;
            // 
            // button2Capture
            // 
            button2Capture.Location = new Point(269, 11);
            button2Capture.Name = "button2Capture";
            button2Capture.Size = new Size(94, 29);
            button2Capture.TabIndex = 2;
            button2Capture.Text = "Capture";
            button2Capture.UseVisualStyleBackColor = true;
            button2Capture.Click += button2Capture_Click;
            // 
            // button3Save
            // 
            button3Save.Location = new Point(369, 11);
            button3Save.Name = "button3Save";
            button3Save.Size = new Size(131, 29);
            button3Save.TabIndex = 3;
            button3Save.Text = "Save Image";
            button3Save.UseVisualStyleBackColor = true;
            button3Save.Click += button3Save_Click;
            // 
            // button4Exit
            // 
            button4Exit.Location = new Point(729, 12);
            button4Exit.Name = "button4Exit";
            button4Exit.Size = new Size(59, 29);
            button4Exit.TabIndex = 4;
            button4Exit.Text = "Exit";
            button4Exit.UseVisualStyleBackColor = true;
            button4Exit.Click += button4Exit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(13, 57);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(775, 381);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(390, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(382, 375);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button4Exit);
            Controls.Add(button3Save);
            Controls.Add(button2Capture);
            Controls.Add(button1Start);
            Controls.Add(comboBox1WebCame);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1WebCame;
        private Button button1Start;
        private Button button2Capture;
        private Button button3Save;
        private Button button4Exit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}