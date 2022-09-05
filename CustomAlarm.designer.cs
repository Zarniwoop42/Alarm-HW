
namespace Alarm501
{
    partial class CustomAlarm
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
            this.TimePick = new System.Windows.Forms.DateTimePicker();
            this.BoxOn = new System.Windows.Forms.CheckBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimePick
            // 
            this.TimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePick.Location = new System.Drawing.Point(22, 34);
            this.TimePick.Name = "TimePick";
            this.TimePick.Size = new System.Drawing.Size(200, 20);
            this.TimePick.TabIndex = 0;
            // 
            // BoxOn
            // 
            this.BoxOn.AutoSize = true;
            this.BoxOn.Location = new System.Drawing.Point(229, 36);
            this.BoxOn.Name = "BoxOn";
            this.BoxOn.Size = new System.Drawing.Size(40, 17);
            this.BoxOn.TabIndex = 1;
            this.BoxOn.Text = "On";
            this.BoxOn.UseVisualStyleBackColor = true;
            this.BoxOn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(22, 92);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(94, 43);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSet
            // 
            this.ButtonSet.Location = new System.Drawing.Point(175, 92);
            this.ButtonSet.Name = "ButtonSet";
            this.ButtonSet.Size = new System.Drawing.Size(94, 43);
            this.ButtonSet.TabIndex = 3;
            this.ButtonSet.Text = "Set";
            this.ButtonSet.UseVisualStyleBackColor = true;
            this.ButtonSet.Click += new System.EventHandler(this.ButtonSet_Click);
            // 
            // CustomAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 147);
            this.Controls.Add(this.ButtonSet);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.BoxOn);
            this.Controls.Add(this.TimePick);
            this.Name = "CustomAlarm";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TimePick;
        private System.Windows.Forms.CheckBox BoxOn;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSet;
    }
}