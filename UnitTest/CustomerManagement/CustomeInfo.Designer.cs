namespace CustomerManagement
{
    partial class CustomeInfo
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.txt_box_ip = new System.Windows.Forms.TextBox();
            this.txt_box_port = new System.Windows.Forms.TextBox();
            this.txt_box_database = new System.Windows.Forms.TextBox();
            this.txt_box_version = new System.Windows.Forms.TextBox();
            this.txt_box_userId = new System.Windows.Forms.TextBox();
            this.txt_box_fpId = new System.Windows.Forms.TextBox();
            this.txt_box_service_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(137, 249);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(126, 23);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // txt_box_ip
            // 
            this.txt_box_ip.Location = new System.Drawing.Point(68, 12);
            this.txt_box_ip.MaxLength = 15;
            this.txt_box_ip.Name = "txt_box_ip";
            this.txt_box_ip.Size = new System.Drawing.Size(147, 21);
            this.txt_box_ip.TabIndex = 1;
            this.txt_box_ip.Text = "79.127.99.82";
            this.txt_box_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_box_port
            // 
            this.txt_box_port.Location = new System.Drawing.Point(324, 12);
            this.txt_box_port.MaxLength = 5;
            this.txt_box_port.Name = "txt_box_port";
            this.txt_box_port.Size = new System.Drawing.Size(52, 21);
            this.txt_box_port.TabIndex = 2;
            this.txt_box_port.Text = "9020";
            this.txt_box_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_box_database
            // 
            this.txt_box_database.Location = new System.Drawing.Point(68, 45);
            this.txt_box_database.Name = "txt_box_database";
            this.txt_box_database.Size = new System.Drawing.Size(147, 21);
            this.txt_box_database.TabIndex = 3;
            this.txt_box_database.Text = "SARDOMID";
            this.txt_box_database.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_box_version
            // 
            this.txt_box_version.Location = new System.Drawing.Point(68, 83);
            this.txt_box_version.Name = "txt_box_version";
            this.txt_box_version.Size = new System.Drawing.Size(147, 21);
            this.txt_box_version.TabIndex = 4;
            this.txt_box_version.Text = "3.0";
            this.txt_box_version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_box_userId
            // 
            this.txt_box_userId.Location = new System.Drawing.Point(68, 121);
            this.txt_box_userId.Name = "txt_box_userId";
            this.txt_box_userId.Size = new System.Drawing.Size(147, 21);
            this.txt_box_userId.TabIndex = 5;
            this.txt_box_userId.Text = "267";
            this.txt_box_userId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_box_fpId
            // 
            this.txt_box_fpId.Location = new System.Drawing.Point(68, 157);
            this.txt_box_fpId.Name = "txt_box_fpId";
            this.txt_box_fpId.Size = new System.Drawing.Size(147, 21);
            this.txt_box_fpId.TabIndex = 6;
            this.txt_box_fpId.Text = "3";
            this.txt_box_fpId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_box_service_key
            // 
            this.txt_box_service_key.Location = new System.Drawing.Point(68, 193);
            this.txt_box_service_key.Name = "txt_box_service_key";
            this.txt_box_service_key.Size = new System.Drawing.Size(147, 21);
            this.txt_box_service_key.TabIndex = 7;
            this.txt_box_service_key.Text = "1234";
            this.txt_box_service_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "UserId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "FPId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ServiceKey";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "PORT(Database)";
            // 
            // CustomeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 284);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_box_service_key);
            this.Controls.Add(this.txt_box_fpId);
            this.Controls.Add(this.txt_box_userId);
            this.Controls.Add(this.txt_box_version);
            this.Controls.Add(this.txt_box_database);
            this.Controls.Add(this.txt_box_port);
            this.Controls.Add(this.txt_box_ip);
            this.Controls.Add(this.btnRequest);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CustomeInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Customer Acc Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.TextBox txt_box_ip;
        private System.Windows.Forms.TextBox txt_box_port;
        private System.Windows.Forms.TextBox txt_box_database;
        private System.Windows.Forms.TextBox txt_box_version;
        private System.Windows.Forms.TextBox txt_box_userId;
        private System.Windows.Forms.TextBox txt_box_fpId;
        private System.Windows.Forms.TextBox txt_box_service_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

