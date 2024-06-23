namespace NoteTakingApplication
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
            label2 = new Label();
            txtTitle = new TextBox();
            txtMessages = new TextBox();
            dataGridView1 = new DataGridView();
            New = new Button();
            Save = new Button();
            Read = new Button();
            Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 79);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 202);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(151, 79);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(209, 31);
            txtTitle.TabIndex = 2;
            // 
            // txtMessages
            // 
            txtMessages.Location = new Point(151, 184);
            txtMessages.Multiline = true;
            txtMessages.Name = "txtMessages";
            txtMessages.Size = new Size(209, 182);
            txtMessages.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(396, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(377, 351);
            dataGridView1.TabIndex = 4;
            // 
            // New
            // 
            New.Location = new Point(59, 460);
            New.Name = "New";
            New.Size = new Size(109, 40);
            New.TabIndex = 5;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Save
            // 
            Save.Location = new Point(238, 459);
            Save.Name = "Save";
            Save.Size = new Size(109, 40);
            Save.TabIndex = 6;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Read
            // 
            Read.Location = new Point(396, 461);
            Read.Name = "Read";
            Read.Size = new Size(100, 39);
            Read.TabIndex = 7;
            Read.Text = "Read";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(554, 462);
            Delete.Name = "Delete";
            Delete.Size = new Size(96, 38);
            Delete.TabIndex = 8;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 537);
            Controls.Add(Delete);
            Controls.Add(Read);
            Controls.Add(Save);
            Controls.Add(New);
            Controls.Add(dataGridView1);
            Controls.Add(txtMessages);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtMessages;
        private DataGridView dataGridView1;
        private Button New;
        private Button Save;
        private Button Read;
        private Button Delete;
    }
}