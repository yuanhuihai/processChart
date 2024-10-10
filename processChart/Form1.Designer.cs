namespace processChart
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.fan1 = new chartUnit.fan();
            this.pump1 = new chartUnit.pump();
            this.line1 = new chartUnit.Line();
            this.SuspendLayout();
            // 
            // fan1
            // 
            this.fan1.Location = new System.Drawing.Point(65, 38);
            this.fan1.Name = "fan1";
            this.fan1.Size = new System.Drawing.Size(150, 150);
            this.fan1.Status = "stop";
            this.fan1.TabIndex = 0;
            // 
            // pump1
            // 
            this.pump1.Location = new System.Drawing.Point(274, 49);
            this.pump1.Name = "pump1";
            this.pump1.Size = new System.Drawing.Size(150, 150);
            this.pump1.Status = "run";
            this.pump1.TabIndex = 1;
            // 
            // line1
            // 
            this.line1.Direction = chartUnit.Line._direction.Vertical;
            this.line1.LineColor = System.Drawing.Color.Red;
            this.line1.Location = new System.Drawing.Point(65, 261);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(150, 103);
            this.line1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.pump1);
            this.Controls.Add(this.fan1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private chartUnit.fan fan1;
        private chartUnit.pump pump1;
        private chartUnit.Line line1;
    }
}

