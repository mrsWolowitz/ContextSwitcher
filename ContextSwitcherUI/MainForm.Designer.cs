namespace ContextSwitcher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDBPath = new System.Windows.Forms.TextBox();
            this.labelDBPath = new System.Windows.Forms.Label();
            this.labelJiraIssue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelDBVersionName = new System.Windows.Forms.Label();
            this.labelDBVersion = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDBPath
            // 
            this.textBoxDBPath.Location = new System.Drawing.Point(87, 2);
            this.textBoxDBPath.Name = "textBoxDBPath";
            this.textBoxDBPath.Size = new System.Drawing.Size(185, 20);
            this.textBoxDBPath.TabIndex = 0;
            // 
            // labelDBPath
            // 
            this.labelDBPath.AutoSize = true;
            this.labelDBPath.Location = new System.Drawing.Point(2, 9);
            this.labelDBPath.Name = "labelDBPath";
            this.labelDBPath.Size = new System.Drawing.Size(85, 13);
            this.labelDBPath.TabIndex = 1;
            this.labelDBPath.Text = "DB backup path";
            // 
            // labelJiraIssue
            // 
            this.labelJiraIssue.AutoSize = true;
            this.labelJiraIssue.Location = new System.Drawing.Point(2, 35);
            this.labelJiraIssue.Name = "labelJiraIssue";
            this.labelJiraIssue.Size = new System.Drawing.Size(50, 13);
            this.labelJiraIssue.TabIndex = 2;
            this.labelJiraIssue.Text = "Jira issue";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Restore DB",
            "Git checkout",
            "Change Web.config",
            "Build"});
            this.checkedListBox1.Location = new System.Drawing.Point(5, 63);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 79);
            this.checkedListBox1.TabIndex = 4;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(5, 149);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 5;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // labelDBVersionName
            // 
            this.labelDBVersionName.AutoSize = true;
            this.labelDBVersionName.Location = new System.Drawing.Point(131, 63);
            this.labelDBVersionName.Name = "labelDBVersionName";
            this.labelDBVersionName.Size = new System.Drawing.Size(59, 13);
            this.labelDBVersionName.TabIndex = 6;
            this.labelDBVersionName.Text = "DB version";
            // 
            // labelDBVersion
            // 
            this.labelDBVersion.AutoSize = true;
            this.labelDBVersion.Location = new System.Drawing.Point(197, 63);
            this.labelDBVersion.Name = "labelDBVersion";
            this.labelDBVersion.Size = new System.Drawing.Size(0, 13);
            this.labelDBVersion.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelDBVersion);
            this.Controls.Add(this.labelDBVersionName);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelJiraIssue);
            this.Controls.Add(this.labelDBPath);
            this.Controls.Add(this.textBoxDBPath);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDBPath;
        private System.Windows.Forms.Label labelDBPath;
        private System.Windows.Forms.Label labelJiraIssue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelDBVersionName;
        private System.Windows.Forms.Label labelDBVersion;
        private System.Windows.Forms.TextBox textBox2;
    }
}

