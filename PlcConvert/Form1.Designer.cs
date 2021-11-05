
namespace PlcConvert
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMesWord = new System.Windows.Forms.TextBox();
            this.btnConvertPlc = new System.Windows.Forms.Button();
            this.txtPlcWord = new System.Windows.Forms.TextBox();
            this.txtWordArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvertMes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMesWord
            // 
            this.txtMesWord.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMesWord.Location = new System.Drawing.Point(124, 92);
            this.txtMesWord.Name = "txtMesWord";
            this.txtMesWord.Size = new System.Drawing.Size(290, 22);
            this.txtMesWord.TabIndex = 0;
            // 
            // btnConvertPlc
            // 
            this.btnConvertPlc.Location = new System.Drawing.Point(420, 91);
            this.btnConvertPlc.Name = "btnConvertPlc";
            this.btnConvertPlc.Size = new System.Drawing.Size(105, 23);
            this.btnConvertPlc.TabIndex = 1;
            this.btnConvertPlc.Text = "ConvertToPLC";
            this.btnConvertPlc.UseVisualStyleBackColor = true;
            this.btnConvertPlc.Click += new System.EventHandler(this.btnConvertPlc_Click);
            // 
            // txtPlcWord
            // 
            this.txtPlcWord.Location = new System.Drawing.Point(124, 141);
            this.txtPlcWord.Multiline = true;
            this.txtPlcWord.Name = "txtPlcWord";
            this.txtPlcWord.Size = new System.Drawing.Size(290, 151);
            this.txtPlcWord.TabIndex = 2;
            // 
            // txtWordArray
            // 
            this.txtWordArray.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWordArray.Location = new System.Drawing.Point(124, 49);
            this.txtWordArray.Name = "txtWordArray";
            this.txtWordArray.Size = new System.Drawing.Size(83, 22);
            this.txtWordArray.TabIndex = 3;
            this.txtWordArray.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Word Array";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Convert";
            // 
            // btnConvertMes
            // 
            this.btnConvertMes.Location = new System.Drawing.Point(420, 141);
            this.btnConvertMes.Name = "btnConvertMes";
            this.btnConvertMes.Size = new System.Drawing.Size(105, 23);
            this.btnConvertMes.TabIndex = 7;
            this.btnConvertMes.Text = "ConvertToMES";
            this.btnConvertMes.UseVisualStyleBackColor = true;
            this.btnConvertMes.Click += new System.EventHandler(this.btnConvertMes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 331);
            this.Controls.Add(this.btnConvertMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWordArray);
            this.Controls.Add(this.txtPlcWord);
            this.Controls.Add(this.btnConvertPlc);
            this.Controls.Add(this.txtMesWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesWord;
        private System.Windows.Forms.Button btnConvertPlc;
        private System.Windows.Forms.TextBox txtPlcWord;
        private System.Windows.Forms.TextBox txtWordArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvertMes;
    }
}

