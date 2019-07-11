namespace SyncTable
{
    partial class SyncForm
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
            this.btn_request = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_request
            // 
            this.btn_request.Location = new System.Drawing.Point(54, 12);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(75, 23);
            this.btn_request.TabIndex = 0;
            this.btn_request.Text = "Request";
            this.btn_request.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 50);
            this.Controls.Add(this.btn_request);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_request;
    }
}

