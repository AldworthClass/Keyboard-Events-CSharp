namespace Keyboard_Events_CSharp
{
    partial class FormKeyboard
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
            this.lblKeyInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKeyInfo
            // 
            this.lblKeyInfo.AutoSize = true;
            this.lblKeyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyInfo.Location = new System.Drawing.Point(42, 33);
            this.lblKeyInfo.Name = "lblKeyInfo";
            this.lblKeyInfo.Size = new System.Drawing.Size(209, 25);
            this.lblKeyInfo.TabIndex = 0;
            this.lblKeyInfo.Text = "No Event Detected";
            // 
            // FormKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 120);
            this.Controls.Add(this.lblKeyInfo);
            this.Name = "FormKeyboard";
            this.Text = "Keyboard Events";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyboard_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormKeyboard_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyInfo;
    }
}

