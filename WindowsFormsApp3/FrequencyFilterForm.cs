using AForge;
using System;

namespace WindowsFormsApp3
{
    public class FrequencyFilterForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TrackBar minTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar maxTrackBar;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;

        private System.ComponentModel.Container components = null;

        private IntRange inputRange = new IntRange(0, 64);
        private System.Windows.Forms.TextBox maxBox;
        private IntRange outputRange = new IntRange(0, 64);

        public IntRange InputRange
        {
            get { return inputRange; }
            set
            {
                inputRange = value;
                minTrackBar.SetRange(inputRange.Min, inputRange.Max);
                maxTrackBar.SetRange(inputRange.Min, inputRange.Max);
            }
        }

        public IntRange OutputRange
        {
            get { return outputRange; }
            set
            {
                outputRange = value;
                minBox.Text = outputRange.Min.ToString();
                maxBox.Text = outputRange.Max.ToString();
            }
        }
        public FrequencyFilterForm()
        {
            InitializeComponent();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxTrackBar = new System.Windows.Forms.TrackBar();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minTrackBar = new System.Windows.Forms.TrackBar();
            this.minBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxTrackBar);
            this.groupBox1.Controls.Add(this.maxBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minTrackBar);
            this.groupBox1.Controls.Add(this.minBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удалите частоты за пределами диапазона";
            // 
            // maxTrackBar
            // 
            this.maxTrackBar.Location = new System.Drawing.Point(100, 70);
            this.maxTrackBar.Name = "maxTrackBar";
            this.maxTrackBar.Size = new System.Drawing.Size(250, 45);
            this.maxTrackBar.TabIndex = 5;
            this.maxTrackBar.TickFrequency = 10;
            this.maxTrackBar.ValueChanged += new System.EventHandler(this.maxTrackBar_ValueChanged);
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(40, 70);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(50, 20);
            this.maxBox.TabIndex = 4;
            this.maxBox.TextChanged += new System.EventHandler(this.maxBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Max:";
            // 
            // minTrackBar
            // 
            this.minTrackBar.Location = new System.Drawing.Point(100, 20);
            this.minTrackBar.Name = "minTrackBar";
            this.minTrackBar.Size = new System.Drawing.Size(250, 45);
            this.minTrackBar.TabIndex = 2;
            this.minTrackBar.TickFrequency = 10;
            this.minTrackBar.ValueChanged += new System.EventHandler(this.minTrackBar_ValueChanged);
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(40, 20);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(50, 20);
            this.minBox.TabIndex = 1;
            this.minBox.TextChanged += new System.EventHandler(this.minBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Min:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(109, 135);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "&Ok";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(194, 135);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Cancel";
            // 
            // FrequencyFilterForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(379, 168);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 207);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 207);
            this.Name = "FrequencyFilterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Частотный фильтр";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        private void minBox_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                minTrackBar.Value = outputRange.Min = Math.Max(inputRange.Min, Math.Min(inputRange.Max, int.Parse(minBox.Text)));
            }
            catch (Exception)
            {
            }
        }

        private void maxBox_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                maxTrackBar.Value = outputRange.Max = Math.Max(inputRange.Min, Math.Min(inputRange.Max, int.Parse(maxBox.Text)));
            }
            catch (Exception)
            {
            }
        }

        private void minTrackBar_ValueChanged(object sender, System.EventArgs e)
        {
            minBox.Text = minTrackBar.Value.ToString();
        }

        private void maxTrackBar_ValueChanged(object sender, System.EventArgs e)
        {
            maxBox.Text = maxTrackBar.Value.ToString();
        }
    }
}