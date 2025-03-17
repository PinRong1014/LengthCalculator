namespace LengthCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYard = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(33, 156);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(108, 25);
            this.txtCM.TabIndex = 0;
            this.txtCM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCM_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "公分";
            // 
            // btnAllClear
            // 
            this.btnAllClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllClear.Location = new System.Drawing.Point(33, 43);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(96, 53);
            this.btnAllClear.TabIndex = 2;
            this.btnAllClear.Text = "清除";
            this.btnAllClear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(164, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "公尺";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(169, 156);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(108, 25);
            this.txtM.TabIndex = 3;
            this.txtM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtM_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(298, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "公里";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(303, 156);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(108, 25);
            this.txtKM.TabIndex = 5;
            this.txtKM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKM_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "英吋";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(33, 233);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(108, 25);
            this.txtIn.TabIndex = 7;
            this.txtIn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIn_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(298, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "碼";
            // 
            // txtYard
            // 
            this.txtYard.Location = new System.Drawing.Point(303, 233);
            this.txtYard.Name = "txtYard";
            this.txtYard.Size = new System.Drawing.Size(108, 25);
            this.txtYard.TabIndex = 9;
            this.txtYard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtYard_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(164, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "英呎";
            // 
            // txtFt
            // 
            this.txtFt.Location = new System.Drawing.Point(169, 233);
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(108, 25);
            this.txtFt.TabIndex = 11;
            this.txtFt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFt_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(28, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "說明文字";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(33, 313);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(378, 25);
            this.txtInfo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInfo;
    }
}

