
namespace LorenLicenseSystem
{
    partial class Licença
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licença));
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxproductID = new System.Windows.Forms.TextBox();
            this.TextBoxIP = new System.Windows.Forms.TextBox();
            this.TextBoxPlan = new System.Windows.Forms.TextBox();
            this.TextBoxExpire = new System.Windows.Forms.TextBox();
            this.TextBoxPackage = new System.Windows.Forms.TextBox();
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxHWID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxUserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "GERAR LICENÇA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxproductID
            // 
            this.TextBoxproductID.Location = new System.Drawing.Point(113, 128);
            this.TextBoxproductID.Name = "TextBoxproductID";
            this.TextBoxproductID.Size = new System.Drawing.Size(178, 20);
            this.TextBoxproductID.TabIndex = 14;
            this.TextBoxproductID.Text = "2";
            this.TextBoxproductID.TextChanged += new System.EventHandler(this.TextBoxproductID_TextChanged);
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.Location = new System.Drawing.Point(113, 168);
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.Size = new System.Drawing.Size(178, 20);
            this.TextBoxIP.TabIndex = 15;
            this.TextBoxIP.Text = "127.0.0.1";
            // 
            // TextBoxPlan
            // 
            this.TextBoxPlan.Location = new System.Drawing.Point(113, 309);
            this.TextBoxPlan.Name = "TextBoxPlan";
            this.TextBoxPlan.Size = new System.Drawing.Size(178, 20);
            this.TextBoxPlan.TabIndex = 16;
            this.TextBoxPlan.Text = "0";
            this.TextBoxPlan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TextBoxExpire
            // 
            this.TextBoxExpire.Location = new System.Drawing.Point(113, 344);
            this.TextBoxExpire.Name = "TextBoxExpire";
            this.TextBoxExpire.Size = new System.Drawing.Size(178, 20);
            this.TextBoxExpire.TabIndex = 17;
            this.TextBoxExpire.Text = "2050-01-01 00:00:00";
            // 
            // TextBoxPackage
            // 
            this.TextBoxPackage.Location = new System.Drawing.Point(113, 274);
            this.TextBoxPackage.Name = "TextBoxPackage";
            this.TextBoxPackage.Size = new System.Drawing.Size(178, 20);
            this.TextBoxPackage.TabIndex = 18;
            this.TextBoxPackage.Text = "0";
            // 
            // TextBoxStatus
            // 
            this.TextBoxStatus.Location = new System.Drawing.Point(113, 239);
            this.TextBoxStatus.Name = "TextBoxStatus";
            this.TextBoxStatus.Size = new System.Drawing.Size(178, 20);
            this.TextBoxStatus.TabIndex = 19;
            this.TextBoxStatus.Text = "1";
            this.TextBoxStatus.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxHWID
            // 
            this.textBoxHWID.Location = new System.Drawing.Point(113, 202);
            this.textBoxHWID.MaxLength = 36;
            this.textBoxHWID.Name = "textBoxHWID";
            this.textBoxHWID.Size = new System.Drawing.Size(178, 20);
            this.textBoxHWID.TabIndex = 20;
            this.textBoxHWID.Text = "C8B8C57C-5D2EF569-F45B0059-E046D8E7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ip do cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "HWID do Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Status Da Licença:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Numero Do Pacote:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Numero Do Plano:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Expirar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "ID Do Cliente:";
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(114, 91);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(178, 20);
            this.TextBoxUserID.TabIndex = 29;
            this.TextBoxUserID.Text = "3";
            this.TextBoxUserID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Licença
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 479);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxUserID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHWID);
            this.Controls.Add(this.TextBoxStatus);
            this.Controls.Add(this.TextBoxPackage);
            this.Controls.Add(this.TextBoxExpire);
            this.Controls.Add(this.TextBoxPlan);
            this.Controls.Add(this.TextBoxIP);
            this.Controls.Add(this.TextBoxproductID);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Licença";
            this.Text = "Licença";
            this.Load += new System.EventHandler(this.Licença_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxproductID;
        private System.Windows.Forms.TextBox TextBoxIP;
        private System.Windows.Forms.TextBox TextBoxPlan;
        private System.Windows.Forms.TextBox TextBoxExpire;
        private System.Windows.Forms.TextBox TextBoxPackage;
        private System.Windows.Forms.TextBox TextBoxStatus;
        private System.Windows.Forms.TextBox textBoxHWID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxUserID;
    }
}