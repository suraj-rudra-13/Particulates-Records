
namespace ParticulateRecords
{
    partial class FormsBasedUI
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
            this.DatesBtn = new System.Windows.Forms.Button();
            this.LocationsBtn = new System.Windows.Forms.Button();
            this.RunProducerConsumerBtn = new System.Windows.Forms.Button();
            this.configBtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.LocationcomboBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.largestReadingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatesBtn
            // 
            this.DatesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatesBtn.Enabled = false;
            this.DatesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatesBtn.Location = new System.Drawing.Point(400, 39);
            this.DatesBtn.Name = "DatesBtn";
            this.DatesBtn.Size = new System.Drawing.Size(124, 49);
            this.DatesBtn.TabIndex = 8;
            this.DatesBtn.Text = "Dates";
            this.DatesBtn.UseVisualStyleBackColor = false;
            this.DatesBtn.Click += new System.EventHandler(this.DatesBtn_Click);
            // 
            // LocationsBtn
            // 
            this.LocationsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LocationsBtn.Enabled = false;
            this.LocationsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LocationsBtn.Location = new System.Drawing.Point(270, 39);
            this.LocationsBtn.Name = "LocationsBtn";
            this.LocationsBtn.Size = new System.Drawing.Size(124, 49);
            this.LocationsBtn.TabIndex = 7;
            this.LocationsBtn.Text = "Locations";
            this.LocationsBtn.UseVisualStyleBackColor = false;
            this.LocationsBtn.Click += new System.EventHandler(this.LocationsBtn_Click);
            // 
            // RunProducerConsumerBtn
            // 
            this.RunProducerConsumerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RunProducerConsumerBtn.Enabled = false;
            this.RunProducerConsumerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunProducerConsumerBtn.Location = new System.Drawing.Point(140, 39);
            this.RunProducerConsumerBtn.Name = "RunProducerConsumerBtn";
            this.RunProducerConsumerBtn.Size = new System.Drawing.Size(124, 49);
            this.RunProducerConsumerBtn.TabIndex = 6;
            this.RunProducerConsumerBtn.Text = "Load Data";
            this.RunProducerConsumerBtn.UseVisualStyleBackColor = false;
            this.RunProducerConsumerBtn.Click += new System.EventHandler(this.RunProducerConsumerBtn_Click);
            // 
            // configBtn
            // 
            this.configBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.configBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.configBtn.Location = new System.Drawing.Point(10, 39);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(124, 49);
            this.configBtn.TabIndex = 5;
            this.configBtn.Text = "Create Config Data";
            this.configBtn.UseVisualStyleBackColor = false;
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 9;
            // 
            // LocationcomboBox
            // 
            this.LocationcomboBox.FormattingEnabled = true;
            this.LocationcomboBox.Location = new System.Drawing.Point(694, 50);
            this.LocationcomboBox.Name = "LocationcomboBox";
            this.LocationcomboBox.Size = new System.Drawing.Size(151, 28);
            this.LocationcomboBox.TabIndex = 10;
            this.LocationcomboBox.SelectedIndexChanged += new System.EventHandler(this.LocationcomboBox_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(76, 123);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(609, 304);
            this.listBox.TabIndex = 11;
            // 
            // largestReadingBtn
            // 
            this.largestReadingBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.largestReadingBtn.Enabled = false;
            this.largestReadingBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.largestReadingBtn.Location = new System.Drawing.Point(546, 39);
            this.largestReadingBtn.Name = "largestReadingBtn";
            this.largestReadingBtn.Size = new System.Drawing.Size(124, 49);
            this.largestReadingBtn.TabIndex = 12;
            this.largestReadingBtn.Text = "Largest Reading";
            this.largestReadingBtn.UseVisualStyleBackColor = false;
            this.largestReadingBtn.Click += new System.EventHandler(this.largestReadingBtn_Click);
            // 
            // FormsBasedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.largestReadingBtn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.LocationcomboBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.DatesBtn);
            this.Controls.Add(this.LocationsBtn);
            this.Controls.Add(this.RunProducerConsumerBtn);
            this.Controls.Add(this.configBtn);
            this.Name = "FormsBasedUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DatesBtn;
        private System.Windows.Forms.Button LocationsBtn;
        private System.Windows.Forms.Button RunProducerConsumerBtn;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox LocationcomboBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button largestReadingBtn;
    }
}

