namespace WindowsFormsApp3
{
    partial class ObjectDetection
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
            this.label1 = new System.Windows.Forms.Label();
            this.accept_detect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confThreshold = new System.Windows.Forms.ComboBox();
            this.itemSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // accept_detect
            // 
            this.accept_detect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accept_detect.Location = new System.Drawing.Point(401, 20);
            this.accept_detect.Name = "accept_detect";
            this.accept_detect.Size = new System.Drawing.Size(95, 33);
            this.accept_detect.TabIndex = 1;
            this.accept_detect.Text = "Распознать";
            this.accept_detect.UseVisualStyleBackColor = true;
            this.accept_detect.Click += new System.EventHandler(this.accept_detect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 148);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // confThreshold
            // 
            this.confThreshold.DisplayMember = "0";
            this.confThreshold.FormattingEnabled = true;
            this.confThreshold.Items.AddRange(new object[] {
            "0,3",
            "0,6",
            "0,9"});
            this.confThreshold.Location = new System.Drawing.Point(389, 78);
            this.confThreshold.Name = "confThreshold";
            this.confThreshold.Size = new System.Drawing.Size(121, 21);
            this.confThreshold.TabIndex = 3;
            // 
            // itemSize
            // 
            this.itemSize.FormattingEnabled = true;
            this.itemSize.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256"});
            this.itemSize.Location = new System.Drawing.Point(389, 126);
            this.itemSize.Name = "itemSize";
            this.itemSize.Size = new System.Drawing.Size(121, 21);
            this.itemSize.TabIndex = 4;
            // 
            // ObjectDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(522, 342);
            this.Controls.Add(this.itemSize);
            this.Controls.Add(this.confThreshold);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.accept_detect);
            this.Controls.Add(this.label1);
            this.Name = "ObjectDetection";
            this.Text = "ObjectDetection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accept_detect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox confThreshold;
        private System.Windows.Forms.ComboBox itemSize;
    }
}