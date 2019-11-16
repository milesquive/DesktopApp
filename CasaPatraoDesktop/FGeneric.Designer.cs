namespace CasaPatraoDesktop
{
    partial class FGeneric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGeneric));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PExitButton = new System.Windows.Forms.PictureBox();
            this.PCreateProduct = new System.Windows.Forms.PictureBox();
            this.PGenericContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCreateProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PExitButton);
            this.splitContainer1.Panel1.Controls.Add(this.PCreateProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PGenericContainer);
            this.splitContainer1.Size = new System.Drawing.Size(2304, 507);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 0;
            // 
            // PExitButton
            // 
            this.PExitButton.Image = ((System.Drawing.Image)(resources.GetObject("PExitButton.Image")));
            this.PExitButton.Location = new System.Drawing.Point(2201, 4);
            this.PExitButton.Name = "PExitButton";
            this.PExitButton.Size = new System.Drawing.Size(100, 65);
            this.PExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PExitButton.TabIndex = 1;
            this.PExitButton.TabStop = false;
            this.PExitButton.Click += new System.EventHandler(this.PExitButton_Click);
            this.PExitButton.MouseHover += new System.EventHandler(this.PExitButton_MouseHover);
            // 
            // PCreateProduct
            // 
            this.PCreateProduct.Image = ((System.Drawing.Image)(resources.GetObject("PCreateProduct.Image")));
            this.PCreateProduct.Location = new System.Drawing.Point(3, 3);
            this.PCreateProduct.Name = "PCreateProduct";
            this.PCreateProduct.Size = new System.Drawing.Size(100, 65);
            this.PCreateProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCreateProduct.TabIndex = 0;
            this.PCreateProduct.TabStop = false;
            this.PCreateProduct.Click += new System.EventHandler(this.PCreateProduct_Click);
            // 
            // PGenericContainer
            // 
            this.PGenericContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PGenericContainer.Location = new System.Drawing.Point(0, 0);
            this.PGenericContainer.Name = "PGenericContainer";
            this.PGenericContainer.Size = new System.Drawing.Size(2304, 432);
            this.PGenericContainer.TabIndex = 0;
            // 
            // FGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2304, 507);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGeneric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCreateProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox PExitButton;
        private System.Windows.Forms.PictureBox PCreateProduct;
        private System.Windows.Forms.Panel PGenericContainer;
    }
}

