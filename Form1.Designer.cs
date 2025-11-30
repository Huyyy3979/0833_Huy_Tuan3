namespace _0833_Huy_Tuan3
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
            listView1 = new ListView();
            txtLast = new TextBox();
            txtFirst = new TextBox();
            txtPhone = new TextBox();
            btnAddName = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(141, 77);
            listView1.Name = "listView1";
            listView1.Size = new Size(345, 233);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(492, 122);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(100, 23);
            txtLast.TabIndex = 1;
            txtLast.TextChanged += txtLast_TextChanged;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(492, 166);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(100, 23);
            txtFirst.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(492, 210);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 3;
            // 
            // btnAddName
            // 
            btnAddName.Location = new Point(504, 239);
            btnAddName.Name = "btnAddName";
            btnAddName.Size = new Size(75, 23);
            btnAddName.TabIndex = 4;
            btnAddName.Text = "Add Name";
            btnAddName.UseVisualStyleBackColor = true;
            btnAddName.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 104);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 5;
            label1.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 148);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 192);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Phone:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddName);
            Controls.Add(txtPhone);
            Controls.Add(txtFirst);
            Controls.Add(txtLast);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "ListView Demo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox txtLast;
        private TextBox txtFirst;
        private TextBox txtPhone;
        private Button btnAddName;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
