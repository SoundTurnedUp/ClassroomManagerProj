namespace ClassroomManagerProj
{
    partial class StudentMenu
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
            studentsListBox = new ListBox();
            RightBox = new GroupBox();
            AddButton = new Button();
            textBoxAddress = new TextBox();
            textBoxAge = new TextBox();
            textBoxName = new TextBox();
            studentNameLabel = new Label();
            studentAddressLabel = new Label();
            studentAgeLabel = new Label();
            studentInfoLabel = new Label();
            exitButton = new Button();
            LeftBox.SuspendLayout();
            RightBox.SuspendLayout();
            SuspendLayout();
            // 
            // LeftBox
            // 
            LeftBox.Controls.Add(studentsListBox);
            LeftBox.Location = new Point(12, 13);
            LeftBox.Name = "LeftBox";
            LeftBox.Size = new Size(226, 479);
            LeftBox.TabIndex = 0;
            LeftBox.TabStop = false;
            LeftBox.Text = "Students";
            // 
            // studentsListBox
            // 
            studentsListBox.FormattingEnabled = true;
            studentsListBox.ItemHeight = 15;
            studentsListBox.Location = new Point(6, 22);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new Size(214, 439);
            studentsListBox.TabIndex = 0;
            // 
            // RightBox
            // 
            RightBox.Controls.Add(AddButton);
            RightBox.Controls.Add(textBoxAddress);
            RightBox.Controls.Add(textBoxAge);
            RightBox.Controls.Add(textBoxName);
            RightBox.Controls.Add(studentNameLabel);
            RightBox.Controls.Add(studentAddressLabel);
            RightBox.Controls.Add(studentAgeLabel);
            RightBox.Controls.Add(studentInfoLabel);
            RightBox.Location = new Point(254, 13);
            RightBox.Name = "RightBox";
            RightBox.Size = new Size(417, 479);
            RightBox.TabIndex = 1;
            RightBox.TabStop = false;
            RightBox.Text = "Add Student";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(321, 426);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(73, 35);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(157, 175);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(237, 23);
            textBoxAddress.TabIndex = 6;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(157, 129);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(237, 23);
            textBoxAge.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(157, 81);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(237, 23);
            textBoxName.TabIndex = 4;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new Point(33, 84);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(89, 15);
            studentNameLabel.TabIndex = 3;
            studentNameLabel.Text = "Student Name: ";
            // 
            // studentAddressLabel
            // 
            studentAddressLabel.AutoSize = true;
            studentAddressLabel.Location = new Point(33, 178);
            studentAddressLabel.Name = "studentAddressLabel";
            studentAddressLabel.Size = new Size(99, 15);
            studentAddressLabel.TabIndex = 2;
            studentAddressLabel.Text = "Student Address: ";
            // 
            // studentAgeLabel
            // 
            studentAgeLabel.AutoSize = true;
            studentAgeLabel.Location = new Point(33, 132);
            studentAgeLabel.Name = "studentAgeLabel";
            studentAgeLabel.Size = new Size(78, 15);
            studentAgeLabel.TabIndex = 1;
            studentAgeLabel.Text = "Student Age: ";
            // 
            // studentInfoLabel
            // 
            studentInfoLabel.AutoSize = true;
            studentInfoLabel.Location = new Point(33, 39);
            studentInfoLabel.Name = "studentInfoLabel";
            studentInfoLabel.Size = new Size(117, 15);
            studentInfoLabel.TabIndex = 0;
            studentInfoLabel.Text = "Student information:";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(575, 508);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(73, 35);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // StudentMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 566);
            Controls.Add(exitButton);
            Controls.Add(RightBox);
            Controls.Add(LeftBox);
            Name = "StudentMenu";
            Text = "StudentMenu";
            Load += StudentMenu_Load;
            LeftBox.ResumeLayout(false);
            RightBox.ResumeLayout(false);
            RightBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LeftBox;
        private ListBox studentsListBox;
        private GroupBox RightBox;
        private Label studentAgeLabel;
        private Label studentInfoLabel;
        private Label studentAddressLabel;
        private Label studentNameLabel;
        private Button AddButton;
        private TextBox textBoxAddress;
        private TextBox textBoxAge;
        private TextBox textBoxName;
        private Button exitButton;
    }
}