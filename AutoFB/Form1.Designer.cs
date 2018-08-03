namespace AutoFB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLinkLikePost = new System.Windows.Forms.RichTextBox();
            this.ChkLikePost = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContentPostStatus = new System.Windows.Forms.RichTextBox();
            this.ChkPostStatus = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtCommentContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLinkComment = new System.Windows.Forms.RichTextBox();
            this.ChkComment = new System.Windows.Forms.CheckBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.myBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 224);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtPass);
            this.tabPage5.Controls.Add(this.txtUser);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(603, 198);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Information";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(71, 50);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(71, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "pass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "user";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtLinkLikePost);
            this.tabPage1.Controls.Add(this.ChkLikePost);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Like post";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link post";
            // 
            // txtLinkLikePost
            // 
            this.txtLinkLikePost.Location = new System.Drawing.Point(7, 55);
            this.txtLinkLikePost.Name = "txtLinkLikePost";
            this.txtLinkLikePost.Size = new System.Drawing.Size(590, 137);
            this.txtLinkLikePost.TabIndex = 1;
            this.txtLinkLikePost.Text = "";
            // 
            // ChkLikePost
            // 
            this.ChkLikePost.AutoSize = true;
            this.ChkLikePost.Location = new System.Drawing.Point(7, 6);
            this.ChkLikePost.Name = "ChkLikePost";
            this.ChkLikePost.Size = new System.Drawing.Size(102, 17);
            this.ChkLikePost.TabIndex = 0;
            this.ChkLikePost.Text = "Active Like post";
            this.ChkLikePost.UseVisualStyleBackColor = true;
            this.ChkLikePost.CheckedChanged += new System.EventHandler(this.ChkLikePost_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtContentPostStatus);
            this.tabPage2.Controls.Add(this.ChkPostStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Post status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Each status is posted after 3 second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Content";
            // 
            // txtContentPostStatus
            // 
            this.txtContentPostStatus.Location = new System.Drawing.Point(6, 55);
            this.txtContentPostStatus.Name = "txtContentPostStatus";
            this.txtContentPostStatus.Size = new System.Drawing.Size(590, 137);
            this.txtContentPostStatus.TabIndex = 3;
            this.txtContentPostStatus.Text = "";
            // 
            // ChkPostStatus
            // 
            this.ChkPostStatus.AutoSize = true;
            this.ChkPostStatus.Location = new System.Drawing.Point(7, 6);
            this.ChkPostStatus.Name = "ChkPostStatus";
            this.ChkPostStatus.Size = new System.Drawing.Size(111, 17);
            this.ChkPostStatus.TabIndex = 1;
            this.ChkPostStatus.Text = "Active Post status";
            this.ChkPostStatus.UseVisualStyleBackColor = true;
            this.ChkPostStatus.CheckedChanged += new System.EventHandler(this.ChkPostStatus_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtCommentContent);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtLinkComment);
            this.tabPage3.Controls.Add(this.ChkComment);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(603, 198);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtCommentContent
            // 
            this.txtCommentContent.Location = new System.Drawing.Point(189, 6);
            this.txtCommentContent.Name = "txtCommentContent";
            this.txtCommentContent.Size = new System.Drawing.Size(407, 20);
            this.txtCommentContent.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Content: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Link post";
            // 
            // txtLinkComment
            // 
            this.txtLinkComment.Location = new System.Drawing.Point(6, 55);
            this.txtLinkComment.Name = "txtLinkComment";
            this.txtLinkComment.Size = new System.Drawing.Size(590, 137);
            this.txtLinkComment.TabIndex = 7;
            this.txtLinkComment.Text = "";
            // 
            // ChkComment
            // 
            this.ChkComment.AutoSize = true;
            this.ChkComment.Location = new System.Drawing.Point(7, 6);
            this.ChkComment.Name = "ChkComment";
            this.ChkComment.Size = new System.Drawing.Size(111, 17);
            this.ChkComment.TabIndex = 6;
            this.ChkComment.Text = "Active Post status";
            this.ChkComment.UseVisualStyleBackColor = true;
            this.ChkComment.CheckedChanged += new System.EventHandler(this.ChkComment_CheckedChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(533, 242);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(5, 251);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 271);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Auto FB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtLinkLikePost;
        private System.Windows.Forms.CheckBox ChkLikePost;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtContentPostStatus;
        private System.Windows.Forms.CheckBox ChkPostStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker myBackgroundWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCommentContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtLinkComment;
        private System.Windows.Forms.CheckBox ChkComment;
    }
}