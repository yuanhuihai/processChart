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
            this.button1 = new System.Windows.Forms.Button();
            this.fan2 = new chartUnit.fan();
            this.fan1 = new chartUnit.fan();
            this.valve1 = new chartUnit.valve();
            this.line1 = new chartUnit.Line();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fan2
            // 
            this.fan2.Location = new System.Drawing.Point(180, 70);
            this.fan2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.fan2.Name = "fan2";
            this.fan2.Size = new System.Drawing.Size(86, 86);
            this.fan2.TabIndex = 3;
            // 
            // fan1
            // 
            this.fan1.Location = new System.Drawing.Point(746, 115);
            this.fan1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.fan1.Name = "fan1";
            this.fan1.Size = new System.Drawing.Size(66, 64);
            this.fan1.TabIndex = 2;
            // 
            // valve1
            // 
            this.valve1.Direction = chartUnit.valve._direction.Vertical;
            this.valve1.Location = new System.Drawing.Point(364, 466);
            this.valve1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valve1.Name = "valve1";
            this.valve1.Size = new System.Drawing.Size(55, 88);
            this.valve1.TabIndex = 1;
            this.valve1.ValveColor = System.Drawing.Color.Lime;
            // 
            // line1
            // 
            this.line1.Direction = chartUnit.Line._direction.Vertical;
            this.line1.LineColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(18, 115);
            this.line1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(224, 243);
            this.line1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fan2);
            this.Controls.Add(this.fan1);
            this.Controls.Add(this.valve1);
            this.Controls.Add(this.line1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private chartUnit.Line line1;
        private chartUnit.valve valve1;
        private chartUnit.fan fan1;
        private chartUnit.fan fan2;
        private System.Windows.Forms.Button button1;
    }
}

