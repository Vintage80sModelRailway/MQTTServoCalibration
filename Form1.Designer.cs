namespace MQTTMessenger
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
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.tbClosedVal = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbThrownVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendThrown = new System.Windows.Forms.Button();
            this.cbDegrees = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(98, 30);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(178, 20);
            this.tbServer.TabIndex = 0;
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(98, 68);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(178, 20);
            this.tbTopic.TabIndex = 1;
            // 
            // tbClosedVal
            // 
            this.tbClosedVal.Location = new System.Drawing.Point(98, 105);
            this.tbClosedVal.Name = "tbClosedVal";
            this.tbClosedVal.Size = new System.Drawing.Size(178, 20);
            this.tbClosedVal.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(307, 103);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send Closed";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(12, 194);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(505, 95);
            this.lbOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Topic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Closed Val";
            // 
            // tbThrownVal
            // 
            this.tbThrownVal.Location = new System.Drawing.Point(98, 141);
            this.tbThrownVal.Name = "tbThrownVal";
            this.tbThrownVal.Size = new System.Drawing.Size(178, 20);
            this.tbThrownVal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thrown Val";
            // 
            // btnSendThrown
            // 
            this.btnSendThrown.Location = new System.Drawing.Point(307, 137);
            this.btnSendThrown.Name = "btnSendThrown";
            this.btnSendThrown.Size = new System.Drawing.Size(98, 23);
            this.btnSendThrown.TabIndex = 10;
            this.btnSendThrown.Text = "Send Thrown";
            this.btnSendThrown.UseVisualStyleBackColor = true;
            this.btnSendThrown.Click += new System.EventHandler(this.btnSendThrown_Click);
            // 
            // cbDegrees
            // 
            this.cbDegrees.AutoSize = true;
            this.cbDegrees.Location = new System.Drawing.Point(400, 32);
            this.cbDegrees.Name = "cbDegrees";
            this.cbDegrees.Size = new System.Drawing.Size(66, 17);
            this.cbDegrees.TabIndex = 11;
            this.cbDegrees.Text = "Degrees";
            this.cbDegrees.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 301);
            this.Controls.Add(this.cbDegrees);
            this.Controls.Add(this.btnSendThrown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbThrownVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbClosedVal);
            this.Controls.Add(this.tbTopic);
            this.Controls.Add(this.tbServer);
            this.Name = "Form1";
            this.Text = "MQTTMessenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.TextBox tbClosedVal;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbThrownVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendThrown;
        private System.Windows.Forms.CheckBox cbDegrees;
    }
}

