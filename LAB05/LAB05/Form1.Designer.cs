namespace LAB05
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
            label3 = new Label();
            lblResult = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Число 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Число 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 226);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Результат:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(103, 226);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(13, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "0";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(87, 32);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(174, 23);
            txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(87, 74);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(174, 23);
            txtNumber2.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(74, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(119, 115);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(39, 23);
            btnSub.TabIndex = 7;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(164, 115);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(39, 23);
            btnMul.TabIndex = 8;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(209, 115);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(39, 23);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(87, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 266);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnClear;
    }
}
