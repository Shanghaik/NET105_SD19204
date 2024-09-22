namespace Demo_API_Winform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbt_weight = new System.Windows.Forms.TextBox();
            this.tbt_height = new System.Windows.Forms.TextBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập cân nặng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập chiều cao";
            // 
            // tbt_weight
            // 
            this.tbt_weight.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_weight.Location = new System.Drawing.Point(215, 43);
            this.tbt_weight.Name = "tbt_weight";
            this.tbt_weight.Size = new System.Drawing.Size(710, 31);
            this.tbt_weight.TabIndex = 2;
            // 
            // tbt_height
            // 
            this.tbt_height.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_height.Location = new System.Drawing.Point(216, 112);
            this.tbt_height.Name = "tbt_height";
            this.tbt_height.Size = new System.Drawing.Size(709, 31);
            this.tbt_height.TabIndex = 3;
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_result.Location = new System.Drawing.Point(371, 172);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(205, 52);
            this.btn_result.TabIndex = 4;
            this.btn_result.Text = "Kết quả";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_result.Location = new System.Drawing.Point(45, 260);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(78, 25);
            this.lb_result.TabIndex = 5;
            this.lb_result.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 327);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.tbt_height);
            this.Controls.Add(this.tbt_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbt_weight;
        private TextBox tbt_height;
        private Button btn_result;
        private Label lb_result;
    }
}