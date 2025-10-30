namespace HardwareInventory_main_
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnWorker);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(247, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 554);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Your Account To continue";
            // 
            // btnWorker
            // 
            this.btnWorker.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWorker.Location = new System.Drawing.Point(117, 413);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(378, 51);
            this.btnWorker.TabIndex = 2;
            this.btnWorker.Text = "Worker";
            this.btnWorker.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmin.Location = new System.Drawing.Point(117, 325);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(378, 47);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "LogIn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = global::HardwareInventory_main_.Properties.Resources.futuristic_abstract_dark_red_and_white_papercut_overlap_on_bright_white_color_geometric_design_modern_overlap_papercut_background_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 638);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

