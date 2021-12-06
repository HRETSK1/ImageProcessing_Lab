
namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.первоначальноИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преобразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semitoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьКонтрастToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freqFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.thresholdInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.declineBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.детектированиеОбъектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.преобразованияToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.детектированиеОбъектовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(778, 41);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.первоначальноИзображениеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 37);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // первоначальноИзображениеToolStripMenuItem
            // 
            this.первоначальноИзображениеToolStripMenuItem.Name = "первоначальноИзображениеToolStripMenuItem";
            this.первоначальноИзображениеToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.первоначальноИзображениеToolStripMenuItem.Text = "Первоначально изображение";
            this.первоначальноИзображениеToolStripMenuItem.Click += new System.EventHandler(this.SourceImageToolStripMenuItem_Click);
            // 
            // преобразованияToolStripMenuItem
            // 
            this.преобразованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semitoneToolStripMenuItem,
            this.negativToolStripMenuItem,
            this.binarizationToolStripMenuItem,
            this.яркостьКонтрастToolStripMenuItem});
            this.преобразованияToolStripMenuItem.Name = "преобразованияToolStripMenuItem";
            this.преобразованияToolStripMenuItem.Size = new System.Drawing.Size(112, 37);
            this.преобразованияToolStripMenuItem.Text = "Преобразования";
            // 
            // semitoneToolStripMenuItem
            // 
            this.semitoneToolStripMenuItem.Name = "semitoneToolStripMenuItem";
            this.semitoneToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.semitoneToolStripMenuItem.Text = "Полутон";
            this.semitoneToolStripMenuItem.Click += new System.EventHandler(this.semitoneToolStripMenuItem_Click);
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.negativToolStripMenuItem.Text = "Негатив";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click);
            // 
            // binarizationToolStripMenuItem
            // 
            this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.binarizationToolStripMenuItem.Text = "Бинаризация";
            this.binarizationToolStripMenuItem.Click += new System.EventHandler(this.binarizationToolStripMenuItem_Click);
            // 
            // яркостьКонтрастToolStripMenuItem
            // 
            this.яркостьКонтрастToolStripMenuItem.Name = "яркостьКонтрастToolStripMenuItem";
            this.яркостьКонтрастToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.яркостьКонтрастToolStripMenuItem.Text = "Яркость/Контраст";
            this.яркостьКонтрастToolStripMenuItem.Click += new System.EventHandler(this.Brightness_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrixFilterToolStripMenuItem,
            this.freqFilterToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 37);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // matrixFilterToolStripMenuItem
            // 
            this.matrixFilterToolStripMenuItem.Name = "matrixFilterToolStripMenuItem";
            this.matrixFilterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.matrixFilterToolStripMenuItem.Text = "Матричный фильтр";
            this.matrixFilterToolStripMenuItem.Click += new System.EventHandler(this.matrixFilterToolStripMenuItem_Click);
            // 
            // freqFilterToolStripMenuItem
            // 
            this.freqFilterToolStripMenuItem.Name = "freqFilterToolStripMenuItem";
            this.freqFilterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.freqFilterToolStripMenuItem.Text = "Частотный фильтр";
            this.freqFilterToolStripMenuItem.Click += new System.EventHandler(this.freqFilterToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images|*.bmp;*.jpg;*.png; *.jpeg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Images|*.bmp;*.jpg;*.png";
            this.saveFileDialog1.ShowHelp = true;
            // 
            // thresholdInput
            // 
            this.thresholdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdInput.Location = new System.Drawing.Point(579, 11);
            this.thresholdInput.Margin = new System.Windows.Forms.Padding(2);
            this.thresholdInput.Name = "thresholdInput";
            this.thresholdInput.Size = new System.Drawing.Size(91, 20);
            this.thresholdInput.TabIndex = 3;
            this.thresholdInput.Visible = false;
            this.thresholdInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TheresholdIntput_KeyPress);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(473, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(431, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 38);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.AutoSize = true;
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.Location = new System.Drawing.Point(674, 7);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(28, 24);
            this.acceptBtn.TabIndex = 13;
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Visible = false;
            this.acceptBtn.Click += new System.EventHandler(this.Accept_Click);
            // 
            // declineBtn
            // 
            this.declineBtn.AutoSize = true;
            this.declineBtn.Image = ((System.Drawing.Image)(resources.GetObject("declineBtn.Image")));
            this.declineBtn.Location = new System.Drawing.Point(707, 7);
            this.declineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.declineBtn.Name = "declineBtn";
            this.declineBtn.Size = new System.Drawing.Size(28, 24);
            this.declineBtn.TabIndex = 14;
            this.declineBtn.UseVisualStyleBackColor = true;
            this.declineBtn.Visible = false;
            this.declineBtn.Click += new System.EventHandler(this.Decline_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(778, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer
            // 
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(66, 17);
            this.timer.Text = "time edit: 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // детектированиеОбъектовToolStripMenuItem
            // 
            this.детектированиеОбъектовToolStripMenuItem.Name = "детектированиеОбъектовToolStripMenuItem";
            this.детектированиеОбъектовToolStripMenuItem.Size = new System.Drawing.Size(162, 37);
            this.детектированиеОбъектовToolStripMenuItem.Text = "Детектирование объектов";
            this.детектированиеОбъектовToolStripMenuItem.Click += new System.EventHandler(this.детектированиеОбъектовToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(778, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.declineBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.thresholdInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(794, 546);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pragrama";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
      //  private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem первоначальноИзображениеToolStripMenuItem;
        private System.Windows.Forms.TextBox thresholdInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button declineBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem преобразованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semitoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freqFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьКонтрастToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem детектированиеОбъектовToolStripMenuItem;
    }
}

