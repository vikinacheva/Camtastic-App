namespace WindowsFormsApp1
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
            this.photoForumData = new System.Windows.Forms.DataGridView();
            this.URLInput = new System.Windows.Forms.TextBox();
            this.inputTextLabel = new System.Windows.Forms.Label();
            this.previousLink = new System.Windows.Forms.Button();
            this.nextLink = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoForumData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // photoForumData
            // 
            this.photoForumData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photoForumData.Location = new System.Drawing.Point(746, 36);
            this.photoForumData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.photoForumData.Name = "photoForumData";
            this.photoForumData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.photoForumData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photoForumData.Size = new System.Drawing.Size(697, 546);
            this.photoForumData.TabIndex = 0;
            // 
            // URLInput
            // 
            this.URLInput.AcceptsReturn = true;
            this.URLInput.Location = new System.Drawing.Point(58, 817);
            this.URLInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.URLInput.Multiline = true;
            this.URLInput.Name = "URLInput";
            this.URLInput.Size = new System.Drawing.Size(518, 41);
            this.URLInput.TabIndex = 1;
            // 
            // inputTextLabel
            // 
            this.inputTextLabel.AutoSize = true;
            this.inputTextLabel.Location = new System.Drawing.Point(66, 775);
            this.inputTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.inputTextLabel.Name = "inputTextLabel";
            this.inputTextLabel.Size = new System.Drawing.Size(190, 25);
            this.inputTextLabel.TabIndex = 2;
            this.inputTextLabel.Text = "Add a new picture:";
            // 
            // previousLink
            // 
            this.previousLink.Location = new System.Drawing.Point(120, 650);
            this.previousLink.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.previousLink.Name = "previousLink";
            this.previousLink.Size = new System.Drawing.Size(150, 44);
            this.previousLink.TabIndex = 4;
            this.previousLink.Text = "Previous";
            this.previousLink.UseVisualStyleBackColor = true;
            this.previousLink.Click += new System.EventHandler(this.previousLink_Click);
            // 
            // nextLink
            // 
            this.nextLink.Location = new System.Drawing.Point(506, 650);
            this.nextLink.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nextLink.Name = "nextLink";
            this.nextLink.Size = new System.Drawing.Size(150, 44);
            this.nextLink.TabIndex = 5;
            this.nextLink.Text = "Next";
            this.nextLink.UseVisualStyleBackColor = true;
            this.nextLink.Click += new System.EventHandler(this.nextLink_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 814);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.hand_painted_background_violet_orange_colours_23_2148427578;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1496, 886);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nextLink);
            this.Controls.Add(this.previousLink);
            this.Controls.Add(this.inputTextLabel);
            this.Controls.Add(this.URLInput);
            this.Controls.Add(this.photoForumData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoForumData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView photoForumData;
        private System.Windows.Forms.TextBox URLInput;
        private System.Windows.Forms.Label inputTextLabel;
        private System.Windows.Forms.Button previousLink;
        private System.Windows.Forms.Button nextLink;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

