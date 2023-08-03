namespace RAILWAYSYSTEM
{
    partial class frm_loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loading));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_loadingi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularProgressBar_loading1 = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_loadingi);
            this.panel1.Location = new System.Drawing.Point(-3, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 88);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(144, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sri Lanka.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "All rights Reserved Sri Lanka Railways,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_loadingi
            // 
            this.lbl_loadingi.AutoSize = true;
            this.lbl_loadingi.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadingi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_loadingi.Location = new System.Drawing.Point(81, 16);
            this.lbl_loadingi.Name = "lbl_loadingi";
            this.lbl_loadingi.Size = new System.Drawing.Size(223, 19);
            this.lbl_loadingi.TabIndex = 0;
            this.lbl_loadingi.Text = "© 2011 Sri Lanka Railways (SLR).";
            this.lbl_loadingi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 395);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "LOADING....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(57, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sri Lanka Railway";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.circularProgressBar_loading1);
            this.panel3.Location = new System.Drawing.Point(96, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 187);
            this.panel3.TabIndex = 0;
            // 
            // circularProgressBar_loading1
            // 
            this.circularProgressBar_loading1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar_loading1.AnimationFunction")));
            this.circularProgressBar_loading1.AnimationSpeed = 500;
            this.circularProgressBar_loading1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.circularProgressBar_loading1.Font = new System.Drawing.Font("Century Gothic", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar_loading1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar_loading1.InnerColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar_loading1.InnerMargin = 2;
            this.circularProgressBar_loading1.InnerWidth = -1;
            this.circularProgressBar_loading1.Location = new System.Drawing.Point(0, 3);
            this.circularProgressBar_loading1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar_loading1.Name = "circularProgressBar_loading1";
            this.circularProgressBar_loading1.OuterColor = System.Drawing.Color.DarkGray;
            this.circularProgressBar_loading1.OuterMargin = -25;
            this.circularProgressBar_loading1.OuterWidth = 26;
            this.circularProgressBar_loading1.ProgressColor = System.Drawing.Color.Aqua;
            this.circularProgressBar_loading1.ProgressWidth = 6;
            this.circularProgressBar_loading1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar_loading1.Size = new System.Drawing.Size(190, 183);
            this.circularProgressBar_loading1.StartAngle = 270;
            this.circularProgressBar_loading1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar_loading1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_loading1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_loading1.SubscriptText = "";
            this.circularProgressBar_loading1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar_loading1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_loading1.SuperscriptText = "";
            this.circularProgressBar_loading1.TabIndex = 1;
            this.circularProgressBar_loading1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar_loading1.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_loading";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loading";
            this.Load += new System.EventHandler(this.frm_loading_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_loadingi;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar circularProgressBar_loading1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}