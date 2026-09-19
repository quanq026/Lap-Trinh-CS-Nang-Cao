namespace WinFormsBasicAdditionCalculator
{
    partial class FormBasicAdditionCalculator
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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtResult = new TextBox();
            btnCalculate = new Button();
            btnNewCalculation = new Button();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(105, 58);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(78, 20);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "Number 1:";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(105, 91);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(78, 20);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "Number 2:";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(204, 55);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(125, 27);
            txtNumber1.TabIndex = 2;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(204, 88);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(125, 27);
            txtNumber2.TabIndex = 3;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(105, 184);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(224, 27);
            txtResult.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(105, 121);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(224, 57);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnNewCalculation
            // 
            btnNewCalculation.Location = new Point(105, 217);
            btnNewCalculation.Name = "btnNewCalculation";
            btnNewCalculation.Size = new Size(224, 29);
            btnNewCalculation.TabIndex = 6;
            btnNewCalculation.Text = "New Calculation";
            btnNewCalculation.UseVisualStyleBackColor = true;
            btnNewCalculation.Click += btnNewCalculation_Click;
            // 
            // FormBasicAdditionCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 281);
            Controls.Add(btnNewCalculation);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Name = "FormBasicAdditionCalculator";
            Text = "Basic Addition Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtResult;
        private Button btnCalculate;
        private Button btnNewCalculation;
    }
}
