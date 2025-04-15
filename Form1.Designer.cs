namespace task3
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
            btnExit = new Button();
            txt = new TextBox();
            lst = new ListBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(237, 83);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Вход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txt
            // 
            txt.BackColor = Color.White;
            txt.Location = new Point(138, 12);
            txt.Name = "txt";
            txt.Size = new Size(199, 23);
            txt.TabIndex = 1;
            // 
            // lst
            // 
            lst.FormattingEnabled = true;
            lst.Items.AddRange(new object[] { "black", "red", "green", "blue" });
            lst.Location = new Point(12, 12);
            lst.Name = "lst";
            lst.Size = new Size(120, 94);
            lst.TabIndex = 2;
            lst.SelectedIndexChanged += lst_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 121);
            Controls.Add(lst);
            Controls.Add(txt);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private TextBox txt;
        private ListBox lst;
    }
}
