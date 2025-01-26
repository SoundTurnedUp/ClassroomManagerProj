namespace ClassroomManagerProj
{
    partial class TeachersMenu
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
            listViewTeachers = new ListView();
            TeacherName = new ColumnHeader();
            Subject = new ColumnHeader();
            YoE = new ColumnHeader();
            RightBox = new GroupBox();
            comboBoxSubjects = new ComboBox();
            comboBoxSalutation = new ComboBox();
            ErrorLabel = new Label();
            AddButton = new Button();
            textBoxYears = new TextBox();
            textBoxName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ExitButton = new Button();
            LeftBox.SuspendLayout();
            RightBox.SuspendLayout();
            SuspendLayout();
            // 
            // LeftBox
            // 
            LeftBox.Controls.Add(listViewTeachers);
            LeftBox.Location = new Point(12, 13);
            LeftBox.Name = "LeftBox";
            LeftBox.Size = new Size(312, 479);
            LeftBox.TabIndex = 0;
            LeftBox.TabStop = false;
            LeftBox.Text = "Teachers";
            // 
            // listViewTeachers
            // 
            listViewTeachers.Columns.AddRange(new ColumnHeader[] { TeacherName, Subject, YoE });
            listViewTeachers.Location = new Point(6, 22);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new Size(300, 451);
            listViewTeachers.TabIndex = 13;
            listViewTeachers.TabStop = false;
            listViewTeachers.UseCompatibleStateImageBehavior = false;
            listViewTeachers.View = View.Details;
            // 
            // TeacherName
            // 
            TeacherName.Text = "Name";
            TeacherName.Width = 100;
            // 
            // Subject
            // 
            Subject.Text = "Subject";
            Subject.Width = 100;
            // 
            // YoE
            // 
            YoE.Text = "Experience";
            YoE.Width = 95;
            // 
            // RightBox
            // 
            RightBox.Controls.Add(comboBoxSubjects);
            RightBox.Controls.Add(comboBoxSalutation);
            RightBox.Controls.Add(ErrorLabel);
            RightBox.Controls.Add(AddButton);
            RightBox.Controls.Add(textBoxYears);
            RightBox.Controls.Add(textBoxName);
            RightBox.Controls.Add(label5);
            RightBox.Controls.Add(label4);
            RightBox.Controls.Add(label3);
            RightBox.Controls.Add(label2);
            RightBox.Controls.Add(label1);
            RightBox.Location = new Point(330, 13);
            RightBox.Name = "RightBox";
            RightBox.Size = new Size(341, 479);
            RightBox.TabIndex = 1;
            RightBox.TabStop = false;
            RightBox.Text = "Add Teacher";
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new Point(157, 167);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new Size(178, 23);
            comboBoxSubjects.TabIndex = 13;
            // 
            // comboBoxSalutation
            // 
            comboBoxSalutation.FormattingEnabled = true;
            comboBoxSalutation.Location = new Point(157, 87);
            comboBoxSalutation.Name = "comboBoxSalutation";
            comboBoxSalutation.Size = new Size(178, 23);
            comboBoxSalutation.TabIndex = 12;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(33, 436);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 11;
            ErrorLabel.Visible = false;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(245, 426);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(73, 35);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // textBoxYears
            // 
            textBoxYears.Location = new Point(157, 207);
            textBoxYears.Name = "textBoxYears";
            textBoxYears.Size = new Size(178, 23);
            textBoxYears.TabIndex = 9;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(157, 127);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(178, 23);
            textBoxName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 210);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 6;
            label5.Text = "Teacher Experience: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 170);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 5;
            label4.Text = "Teacher Subject: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 130);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Teacher Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 90);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Teacher Salutation: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Teacher information: ";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(575, 508);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(73, 35);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // TeachersMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 566);
            Controls.Add(ExitButton);
            Controls.Add(RightBox);
            Controls.Add(LeftBox);
            Name = "TeachersMenu";
            Text = "TeachersMenu";
            Load += TeachersMenu_Load;
            LeftBox.ResumeLayout(false);
            RightBox.ResumeLayout(false);
            RightBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LeftBox;
        private GroupBox RightBox;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox textBoxYears;
        private TextBox textBoxName;
        private Button AddButton;
        private Button ExitButton;
        private Label ErrorLabel;
        private ComboBox comboBoxSalutation;
        private ListView listViewTeachers;
        private ColumnHeader TeacherName;
        private ColumnHeader Subject;
        private ColumnHeader YoE;
        private ComboBox comboBoxSubjects;
    }
}