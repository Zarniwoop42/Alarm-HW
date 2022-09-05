
namespace Alarm501
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
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSnooze = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.AlarmsList = new System.Windows.Forms.ListBox();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(12, 12);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(99, 51);
            this.ButtonEdit.TabIndex = 0;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(151, 12);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(99, 51);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.AddAlarm);
            // 
            // ButtonSnooze
            // 
            this.ButtonSnooze.Enabled = false;
            this.ButtonSnooze.Location = new System.Drawing.Point(12, 257);
            this.ButtonSnooze.Name = "ButtonSnooze";
            this.ButtonSnooze.Size = new System.Drawing.Size(99, 53);
            this.ButtonSnooze.TabIndex = 2;
            this.ButtonSnooze.Text = "Snooze";
            this.ButtonSnooze.UseVisualStyleBackColor = true;
            this.ButtonSnooze.Click += new System.EventHandler(this.ButtonSnooze_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(151, 257);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(99, 53);
            this.ButtonStop.TabIndex = 3;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // AlarmsList
            // 
            this.AlarmsList.FormattingEnabled = true;
            this.AlarmsList.Location = new System.Drawing.Point(13, 96);
            this.AlarmsList.Name = "AlarmsList";
            this.AlarmsList.Size = new System.Drawing.Size(237, 147);
            this.AlarmsList.TabIndex = 4;
            this.AlarmsList.SelectedIndexChanged += new System.EventHandler(this.AlarmsList_SelectedIndexChanged);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(13, 70);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.ReadOnly = true;
            this.TextMessage.Size = new System.Drawing.Size(237, 20);
            this.TextMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 322);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.AlarmsList);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonSnooze);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonEdit);
            this.Name = "Form1";
            this.Text = "Alarm501";
            this.Activated += new System.EventHandler(this.UpdateList);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonSnooze;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.ListBox AlarmsList;
        private System.Windows.Forms.TextBox TextMessage;
    }
}

