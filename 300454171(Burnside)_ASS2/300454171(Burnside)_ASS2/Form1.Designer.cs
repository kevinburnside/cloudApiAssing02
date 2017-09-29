namespace _300454171_Burnside__ASS2
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listOfTasksBox = new System.Windows.Forms.ListBox();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.modifytaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createdByTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(114, 51);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(139, 124);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Task";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // listOfTasksBox
            // 
            this.listOfTasksBox.FormattingEnabled = true;
            this.listOfTasksBox.Location = new System.Drawing.Point(266, 111);
            this.listOfTasksBox.Name = "listOfTasksBox";
            this.listOfTasksBox.Size = new System.Drawing.Size(167, 134);
            this.listOfTasksBox.TabIndex = 2;
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Location = new System.Drawing.Point(266, 268);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTaskButton.TabIndex = 3;
            this.deleteTaskButton.Text = "Delete Task";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // modifytaskButton
            // 
            this.modifytaskButton.Location = new System.Drawing.Point(358, 268);
            this.modifytaskButton.Name = "modifytaskButton";
            this.modifytaskButton.Size = new System.Drawing.Size(75, 23);
            this.modifytaskButton.TabIndex = 4;
            this.modifytaskButton.Text = "Mark Done";
            this.modifytaskButton.UseVisualStyleBackColor = true;
            this.modifytaskButton.Click += new System.EventHandler(this.ModifytaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add a task";
            // 
            // createdByTxtBox
            // 
            this.createdByTxtBox.Location = new System.Drawing.Point(114, 86);
            this.createdByTxtBox.Name = "createdByTxtBox";
            this.createdByTxtBox.Size = new System.Drawing.Size(100, 20);
            this.createdByTxtBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Created By";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(12, 54);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(60, 13);
            this.description.TabIndex = 8;
            this.description.Text = "Description";
            // 
            // RefreshButton
            // 
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshButton.Location = new System.Drawing.Point(15, 259);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(135, 23);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "Load/Refresh Entities";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 312);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createdByTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifytaskButton);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.listOfTasksBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox listOfTasksBox;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button modifytaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createdByTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button RefreshButton;
    }
}

