
namespace FilesRenamerApp
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
            label1 = new Label();
            createReport = new CheckBox();
            linkLabel1 = new LinkLabel();
            SubmitButton = new Button();
            folderPath = new TextBox();
            name = new TextBox();
            label2 = new Label();
            reportPath = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(30, 99);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Caminho da Pasta";
            // 
            // createReport
            // 
            createReport.AutoSize = true;
            createReport.Font = new Font("Segoe UI", 11F);
            createReport.Location = new Point(30, 233);
            createReport.Name = "createReport";
            createReport.Size = new Size(130, 24);
            createReport.TabIndex = 1;
            createReport.Text = "Quero relatório";
            createReport.UseVisualStyleBackColor = true;
            createReport.CheckedChanged += createReport_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(30, 426);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Confira meu Github";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.Location = new Point(30, 358);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(116, 34);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Enviar";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // folderPath
            // 
            folderPath.Location = new Point(30, 122);
            folderPath.Name = "folderPath";
            folderPath.Size = new Size(412, 23);
            folderPath.TabIndex = 4;
            // 
            // name
            // 
            name.Location = new Point(30, 183);
            name.Name = "name";
            name.Size = new Size(412, 23);
            name.TabIndex = 6;
            name.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(30, 160);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 5;
            label2.Text = "Nome do(s) Arquivo(s)";
            // 
            // reportPath
            // 
            reportPath.ForeColor = Color.Black;
            reportPath.Location = new Point(30, 298);
            reportPath.Name = "reportPath";
            reportPath.Size = new Size(412, 23);
            reportPath.TabIndex = 10;
            reportPath.TextChanged += reportPath_TextChanged;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 52);
            label4.Name = "label4";
            label4.Size = new Size(184, 31);
            label4.TabIndex = 9;
            label4.Text = "Files Renamer";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(30, 275);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 12;
            label5.Text = "Criar Relatório em: ";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(reportPath);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(folderPath);
            Controls.Add(SubmitButton);
            Controls.Add(linkLabel1);
            Controls.Add(createReport);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox createReport;
        private LinkLabel linkLabel1;
        private Button SubmitButton;
        private TextBox folderPath;
        private TextBox name;
        private Label label2;
        private TextBox reportPath;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
