namespace PaidLocker
{
    partial class Lock
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
            this.TopText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyInput = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.Helper = new System.Windows.Forms.Label();
            this.TipBackg = new System.Windows.Forms.Panel();
            this.HideTip = new System.Windows.Forms.Label();
            this.AlwaysVisibleTip = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.TipBackg.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopText
            // 
            this.TopText.AutoSize = true;
            this.TopText.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopText.Location = new System.Drawing.Point(12, 16);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(252, 27);
            this.TopText.TabIndex = 0;
            this.TopText.Text = "输入序列号以激活应用程序";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "请在下方输入框输入你所获取的密钥。注意，密钥区分大小写。";
            // 
            // KeyInput
            // 
            this.KeyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyInput.Location = new System.Drawing.Point(12, 73);
            this.KeyInput.Name = "KeyInput";
            this.KeyInput.Size = new System.Drawing.Size(344, 23);
            this.KeyInput.TabIndex = 2;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(238, 102);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(118, 23);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "提交并验证";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AutoLogin
            // 
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.Location = new System.Drawing.Point(12, 102);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(183, 21);
            this.AutoLogin.TabIndex = 4;
            this.AutoLogin.Text = "保存可用的序列号并自动激活";
            this.AutoLogin.UseVisualStyleBackColor = true;
            // 
            // Helper
            // 
            this.Helper.AutoSize = true;
            this.Helper.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Helper.Location = new System.Drawing.Point(12, 174);
            this.Helper.Name = "Helper";
            this.Helper.Size = new System.Drawing.Size(92, 17);
            this.Helper.TabIndex = 5;
            this.Helper.Text = "序列号相关问题";
            this.Helper.Click += new System.EventHandler(this.Helper_Click);
            // 
            // TipBackg
            // 
            this.TipBackg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TipBackg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TipBackg.Controls.Add(this.HideTip);
            this.TipBackg.Controls.Add(this.AlwaysVisibleTip);
            this.TipBackg.Location = new System.Drawing.Point(11, 129);
            this.TipBackg.Name = "TipBackg";
            this.TipBackg.Size = new System.Drawing.Size(345, 33);
            this.TipBackg.TabIndex = 6;
            // 
            // HideTip
            // 
            this.HideTip.AutoSize = true;
            this.HideTip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HideTip.Location = new System.Drawing.Point(306, 8);
            this.HideTip.Name = "HideTip";
            this.HideTip.Size = new System.Drawing.Size(32, 17);
            this.HideTip.TabIndex = 1;
            this.HideTip.Text = "隐藏";
            this.HideTip.Click += new System.EventHandler(this.HideTip_Click);
            // 
            // AlwaysVisibleTip
            // 
            this.AlwaysVisibleTip.AutoSize = true;
            this.AlwaysVisibleTip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AlwaysVisibleTip.Location = new System.Drawing.Point(8, 8);
            this.AlwaysVisibleTip.Name = "AlwaysVisibleTip";
            this.AlwaysVisibleTip.Size = new System.Drawing.Size(140, 17);
            this.AlwaysVisibleTip.TabIndex = 0;
            this.AlwaysVisibleTip.Text = "你的序列号无效或已过期";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Contact.Location = new System.Drawing.Point(228, 174);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(128, 17);
            this.Contact.TabIndex = 7;
            this.Contact.Text = "在此键入你的联系方式";
            // 
            // Lock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(369, 197);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.TipBackg);
            this.Controls.Add(this.Helper);
            this.Controls.Add(this.AutoLogin);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.KeyInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopText);
            this.MaximizeBox = false;
            this.Name = "Lock";
            this.Text = "需要激活";
            this.TipBackg.ResumeLayout(false);
            this.TipBackg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TopText;
        private Label label1;
        private TextBox KeyInput;
        private Button Submit;
        private CheckBox AutoLogin;
        private Label Helper;
        private Panel TipBackg;
        private Label HideTip;
        private Label AlwaysVisibleTip;
        private Label Contact;
    }
}