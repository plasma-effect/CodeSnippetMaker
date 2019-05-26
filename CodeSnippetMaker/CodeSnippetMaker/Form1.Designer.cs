namespace CodeSnippetMaker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.shortcutBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(195, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイトル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(192, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "著作者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(192, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "説明文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(104, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "ショートカット";
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleBox.Location = new System.Drawing.Point(362, 9);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(500, 50);
            this.titleBox.TabIndex = 4;
            // 
            // authorBox
            // 
            this.authorBox.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.authorBox.Location = new System.Drawing.Point(362, 65);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(500, 50);
            this.authorBox.TabIndex = 5;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.descriptionBox.Location = new System.Drawing.Point(362, 121);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(500, 50);
            this.descriptionBox.TabIndex = 6;
            // 
            // shortcutBox
            // 
            this.shortcutBox.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shortcutBox.Location = new System.Drawing.Point(362, 177);
            this.shortcutBox.Name = "shortcutBox";
            this.shortcutBox.Size = new System.Drawing.Size(500, 50);
            this.shortcutBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(4, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 48);
            this.label5.TabIndex = 8;
            this.label5.Text = "コード";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(12, 331);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(850, 420);
            this.codeBox.TabIndex = 9;
            this.codeBox.Text = "";
            // 
            // outputButton
            // 
            this.outputButton.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputButton.Location = new System.Drawing.Point(662, 757);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(200, 60);
            this.outputButton.TabIndex = 10;
            this.outputButton.Text = "出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputButtonClick);
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "CPP",
            "CSharp"});
            this.typeBox.Location = new System.Drawing.Point(362, 233);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(250, 51);
            this.typeBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(240, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 48);
            this.label6.TabIndex = 12;
            this.label6.Text = "言語";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 829);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shortcutBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox shortcutBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label6;
    }
}

