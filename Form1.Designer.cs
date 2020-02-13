namespace Part_3_Console_Input_WinForms
{
    partial class MainForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.IBInstruction = new System.Windows.Forms.Label();
            this.IbMessage = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSubmit.Location = new System.Drawing.Point(44, 118);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 48);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Click Me";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // IBInstruction
            // 
            this.IBInstruction.AutoSize = true;
            this.IBInstruction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IBInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IBInstruction.Location = new System.Drawing.Point(25, 39);
            this.IBInstruction.Name = "IBInstruction";
            this.IBInstruction.Size = new System.Drawing.Size(232, 25);
            this.IBInstruction.TabIndex = 1;
            this.IBInstruction.Text = "Please Enter Your Name:";
            // 
            // IbMessage
            // 
            this.IbMessage.AutoSize = true;
            this.IbMessage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.IbMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IbMessage.Location = new System.Drawing.Point(258, 132);
            this.IbMessage.Name = "IbMessage";
            this.IbMessage.Size = new System.Drawing.Size(0, 25);
            this.IbMessage.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(263, 43);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(198, 22);
            this.txtInput.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 214);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.IbMessage);
            this.Controls.Add(this.IBInstruction);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MainForm";
            this.Text = "Getting Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label IBInstruction;
        private System.Windows.Forms.Label IbMessage;
        private System.Windows.Forms.TextBox txtInput;
    }
}

