namespace ClassroomManagerProj
{
    partial class ClassMenu
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
            LeftBox = new GroupBox();
            listBoxStudents = new ListBox();
            MiddleBox = new GroupBox();
            listBoxTeachers = new ListBox();
            RightBox = new GroupBox();
            listBoxClasses = new ListBox();
            textBoxClassName = new TextBox();
            labelClassName = new Label();
            CreateButton = new Button();
            ExitButton = new Button();
            ErrorLabel = new Label();
            LeftBox.SuspendLayout();
            MiddleBox.SuspendLayout();
            RightBox.SuspendLayout();
            SuspendLayout();
            // 
            // LeftBox
            // 
            LeftBox.Controls.Add(listBoxStudents);
            LeftBox.Location = new Point(12, 12);
            LeftBox.Name = "LeftBox";
            LeftBox.Size = new Size(210, 479);
            LeftBox.TabIndex = 0;
            LeftBox.TabStop = false;
            LeftBox.Text = "Students";
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(6, 19);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(198, 454);
            listBoxStudents.TabIndex = 0;
            // 
            // MiddleBox
            // 
            MiddleBox.Controls.Add(listBoxTeachers);
            MiddleBox.Location = new Point(244, 12);
            MiddleBox.Name = "MiddleBox";
            MiddleBox.Size = new Size(210, 479);
            MiddleBox.TabIndex = 0;
            MiddleBox.TabStop = false;
            MiddleBox.Text = "Teachers";
            // 
            // listBoxTeachers
            // 
            listBoxTeachers.FormattingEnabled = true;
            listBoxTeachers.ItemHeight = 15;
            listBoxTeachers.Location = new Point(6, 19);
            listBoxTeachers.Name = "listBoxTeachers";
            listBoxTeachers.Size = new Size(199, 454);
            listBoxTeachers.TabIndex = 1;
            // 
            // RightBox
            // 
            RightBox.Controls.Add(listBoxClasses);
            RightBox.Location = new Point(464, 12);
            RightBox.Name = "RightBox";
            RightBox.Size = new Size(210, 479);
            RightBox.TabIndex = 0;
            RightBox.TabStop = false;
            RightBox.Text = "Classes";
            // 
            // listBoxClasses
            // 
            listBoxClasses.FormattingEnabled = true;
            listBoxClasses.ItemHeight = 15;
            listBoxClasses.Location = new Point(6, 19);
            listBoxClasses.Name = "listBoxClasses";
            listBoxClasses.Size = new Size(198, 454);
            listBoxClasses.TabIndex = 2;
            // 
            // textBoxClassName
            // 
            textBoxClassName.Location = new Point(99, 509);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(199, 23);
            textBoxClassName.TabIndex = 1;
            // 
            // labelClassName
            // 
            labelClassName.AutoSize = true;
            labelClassName.Location = new Point(18, 512);
            labelClassName.Name = "labelClassName";
            labelClassName.Size = new Size(75, 15);
            labelClassName.TabIndex = 2;
            labelClassName.Text = "Class Name: ";
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(313, 502);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(73, 35);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(595, 502);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(73, 35);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Location = new Point(392, 509);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(197, 23);
            ErrorLabel.TabIndex = 0;
            ErrorLabel.Visible = false;
            // 
            // ClassMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 566);
            Controls.Add(ErrorLabel);
            Controls.Add(ExitButton);
            Controls.Add(CreateButton);
            Controls.Add(labelClassName);
            Controls.Add(textBoxClassName);
            Controls.Add(MiddleBox);
            Controls.Add(RightBox);
            Controls.Add(LeftBox);
            Name = "ClassMenu";
            Text = "ClassMenu";
            Load += ClassMenu_Load;
            LeftBox.ResumeLayout(false);
            MiddleBox.ResumeLayout(false);
            RightBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox LeftBox;
        private GroupBox MiddleBox;
        private GroupBox RightBox;
        private ListBox listBoxStudents;
        private ListBox listBoxTeachers;
        private ListBox listBoxClasses;
        private TextBox textBoxClassName;
        private Label labelClassName;
        private Button CreateButton;
        private Button ExitButton;
        private Label ErrorLabel;
    }
}