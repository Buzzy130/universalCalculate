namespace universalCalculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSlideMenu = new Panel();
            panelSubInfo = new Panel();
            button6 = new Button();
            button7 = new Button();
            btnInfo = new Button();
            panelChoosing = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnChoosing = new Button();
            panelLogo = new Panel();
            panel1 = new Panel();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panelChildForm = new Panel();
            pictureBox2 = new PictureBox();
            panelSlideMenu.SuspendLayout();
            panelSubInfo.SuspendLayout();
            panelChoosing.SuspendLayout();
            panelLogo.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelSlideMenu
            // 
            panelSlideMenu.AutoScroll = true;
            panelSlideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSlideMenu.Controls.Add(panelSubInfo);
            panelSlideMenu.Controls.Add(btnInfo);
            panelSlideMenu.Controls.Add(panelChoosing);
            panelSlideMenu.Controls.Add(btnChoosing);
            panelSlideMenu.Controls.Add(panelLogo);
            panelSlideMenu.Dock = DockStyle.Left;
            panelSlideMenu.Location = new Point(0, 0);
            panelSlideMenu.Name = "panelSlideMenu";
            panelSlideMenu.Size = new Size(250, 561);
            panelSlideMenu.TabIndex = 0;
            // 
            // panelSubInfo
            // 
            panelSubInfo.BackColor = Color.FromArgb(35, 32, 39);
            panelSubInfo.Controls.Add(button6);
            panelSubInfo.Controls.Add(button7);
            panelSubInfo.Dock = DockStyle.Top;
            panelSubInfo.Location = new Point(0, 325);
            panelSubInfo.Name = "panelSubInfo";
            panelSubInfo.Size = new Size(250, 94);
            panelSubInfo.TabIndex = 3;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.LightGray;
            button6.Location = new Point(0, 40);
            button6.Name = "button6";
            button6.Padding = new Padding(35, 0, 0, 0);
            button6.Size = new Size(250, 40);
            button6.TabIndex = 1;
            button6.Text = "Помощь";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.LightGray;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Padding = new Padding(35, 0, 0, 0);
            button7.Size = new Size(250, 40);
            button7.TabIndex = 0;
            button7.Text = "Справка";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // btnInfo
            // 
            btnInfo.Dock = DockStyle.Top;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.Gainsboro;
            btnInfo.Location = new Point(0, 280);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(10, 0, 0, 0);
            btnInfo.Size = new Size(250, 45);
            btnInfo.TabIndex = 2;
            btnInfo.Text = "Info";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // panelChoosing
            // 
            panelChoosing.BackColor = Color.FromArgb(35, 32, 39);
            panelChoosing.Controls.Add(button4);
            panelChoosing.Controls.Add(button3);
            panelChoosing.Controls.Add(button2);
            panelChoosing.Dock = DockStyle.Top;
            panelChoosing.Location = new Point(0, 145);
            panelChoosing.Name = "panelChoosing";
            panelChoosing.Size = new Size(250, 135);
            panelChoosing.TabIndex = 1;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.LightGray;
            button4.Location = new Point(0, 80);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(250, 40);
            button4.TabIndex = 2;
            button4.Text = "Рациональные дроби";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.LightGray;
            button3.Location = new Point(0, 40);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(250, 40);
            button3.TabIndex = 1;
            button3.Text = "Комплексные числа";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.LightGray;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(250, 40);
            button2.TabIndex = 0;
            button2.Text = "p-ичные числа";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnChoosing
            // 
            btnChoosing.Dock = DockStyle.Top;
            btnChoosing.FlatAppearance.BorderSize = 0;
            btnChoosing.FlatStyle = FlatStyle.Flat;
            btnChoosing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoosing.ForeColor = Color.Gainsboro;
            btnChoosing.Location = new Point(0, 100);
            btnChoosing.Name = "btnChoosing";
            btnChoosing.Padding = new Padding(10, 0, 0, 0);
            btnChoosing.Size = new Size(250, 45);
            btnChoosing.TabIndex = 0;
            btnChoosing.Text = "Выбор режима";
            btnChoosing.TextAlign = ContentAlignment.MiddleLeft;
            btnChoosing.UseVisualStyleBackColor = true;
            btnChoosing.Click += btnChoosing_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Center;
            panelLogo.Controls.Add(panel1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(256, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 392);
            panel1.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Controls.Add(pictureBox2);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(684, 561);
            panelChildForm.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(684, 561);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(934, 561);
            Controls.Add(panelChildForm);
            Controls.Add(panelSlideMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(950, 600);
            MinimumSize = new Size(950, 600);
            Name = "Form1";
            Text = "calculate";
            TransparencyKey = Color.Gray;
            Load += Form1_Load;
            panelSlideMenu.ResumeLayout(false);
            panelSubInfo.ResumeLayout(false);
            panelChoosing.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSlideMenu;
        private Button btnChoosing;
        private Panel panelLogo;
        private Panel panelChoosing;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panelSubInfo;
        private Button button6;
        private Button button7;
        private Button btnInfo;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel1;
        private Panel panelChildForm;
        private PictureBox pictureBox2;
    }
}