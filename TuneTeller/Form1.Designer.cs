
namespace TuneTeller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title_Label = new System.Windows.Forms.Label();
            this.SloganLabel = new System.Windows.Forms.Label();
            this.buttonTemplate1 = new TuneTeller.ButtonTemplate();
            this.buttonTemplate7 = new TuneTeller.ButtonTemplate();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Label.AutoSize = true;
            this.Title_Label.BackColor = System.Drawing.Color.Transparent;
            this.Title_Label.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title_Label.ForeColor = System.Drawing.Color.White;
            this.Title_Label.Location = new System.Drawing.Point(74, 27);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(340, 72);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "TuneTeller";
            // 
            // SloganLabel
            // 
            this.SloganLabel.BackColor = System.Drawing.Color.Transparent;
            this.SloganLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SloganLabel.ForeColor = System.Drawing.Color.White;
            this.SloganLabel.Location = new System.Drawing.Point(74, 108);
            this.SloganLabel.Name = "SloganLabel";
            this.SloganLabel.Size = new System.Drawing.Size(318, 18);
            this.SloganLabel.TabIndex = 1;
            this.SloganLabel.Text = "Finding music made easy.";
            this.SloganLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SloganLabel.Click += new System.EventHandler(this.SloganLabel_Click_1);
            // 
            // buttonTemplate1
            // 
            this.buttonTemplate1.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonTemplate1.FlatAppearance.BorderSize = 0;
            this.buttonTemplate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemplate1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemplate1.ForeColor = System.Drawing.Color.White;
            this.buttonTemplate1.Location = new System.Drawing.Point(139, 181);
            this.buttonTemplate1.Name = "buttonTemplate1";
            this.buttonTemplate1.Size = new System.Drawing.Size(189, 80);
            this.buttonTemplate1.TabIndex = 4;
            this.buttonTemplate1.Text = "Explore";
            this.buttonTemplate1.UseVisualStyleBackColor = false;
            this.buttonTemplate1.Click += new System.EventHandler(this.buttonTemplate1_Click);
            // 
            // buttonTemplate7
            // 
            this.buttonTemplate7.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonTemplate7.FlatAppearance.BorderSize = 0;
            this.buttonTemplate7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemplate7.ForeColor = System.Drawing.Color.White;
            this.buttonTemplate7.Location = new System.Drawing.Point(482, 404);
            this.buttonTemplate7.Name = "buttonTemplate7";
            this.buttonTemplate7.Size = new System.Drawing.Size(8, 26);
            this.buttonTemplate7.TabIndex = 6;
            this.buttonTemplate7.Text = "buttonTemplate7";
            this.buttonTemplate7.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 574);
            this.Controls.Add(this.buttonTemplate7);
            this.Controls.Add(this.buttonTemplate1);
            this.Controls.Add(this.SloganLabel);
            this.Controls.Add(this.Title_Label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Label SloganLabel;
        private ButtonTemplate exploreButton1;
        private ButtonTemplate buttonTemplate1;
        private ButtonTemplate buttonTemplate7;
    }
}

