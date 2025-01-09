namespace ClassroomManagerProj
{
    partial class CMMenu
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
            studentButton = new Button();
            teachersButton = new Button();
            subjectsButton = new Button();
            classButton = new Button();
            searchButton = new Button();
            SuspendLayout();
            // 
            // studentButton
            // 
            studentButton.Location = new Point(188, 19);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(150, 61);
            studentButton.TabIndex = 0;
            studentButton.Text = "Students";
            studentButton.UseVisualStyleBackColor = true;
            studentButton.Click += StudentButton_Click;
            // 
            // teachersButton
            // 
            teachersButton.Location = new Point(23, 95);
            teachersButton.Name = "teachersButton";
            teachersButton.Size = new Size(150, 61);
            teachersButton.TabIndex = 1;
            teachersButton.Text = "Teachers";
            teachersButton.UseVisualStyleBackColor = true;
            teachersButton.Click += TeacherButton_Click;
            // 
            // subjectsButton
            // 
            subjectsButton.Location = new Point(23, 19);
            subjectsButton.Name = "subjectsButton";
            subjectsButton.Size = new Size(150, 61);
            subjectsButton.TabIndex = 2;
            subjectsButton.Text = "Subjects";
            subjectsButton.UseVisualStyleBackColor = true;
            subjectsButton.Click += SubjectButton_Click;
            // 
            // classButton
            // 
            classButton.Location = new Point(188, 95);
            classButton.Name = "classButton";
            classButton.Size = new Size(150, 61);
            classButton.TabIndex = 3;
            classButton.Text = "Classes";
            classButton.UseVisualStyleBackColor = true;
            classButton.Click += ClassButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(403, 60);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(150, 61);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // CMMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 180);
            Controls.Add(searchButton);
            Controls.Add(classButton);
            Controls.Add(subjectsButton);
            Controls.Add(teachersButton);
            Controls.Add(studentButton);
            Name = "CMMenu";
            Text = "CMMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button studentButton;
        private Button teachersButton;
        private Button subjectsButton;
        private Button classButton;
        private Button searchButton;
    }
}
