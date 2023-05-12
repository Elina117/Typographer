namespace Typographer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        public override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_enter = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exit = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_enter
            // 
            this.richTextBox_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_enter.Location = new System.Drawing.Point(57, 173);
            this.richTextBox_enter.Name = "richTextBox_enter";
            this.richTextBox_enter.Size = new System.Drawing.Size(1383, 380);
            this.richTextBox_enter.TabIndex = 0;
            this.richTextBox_enter.Text = "";
            // 
            // richTextBox_exit
            // 
            this.richTextBox_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_exit.Location = new System.Drawing.Point(57, 634);
            this.richTextBox_exit.Name = "richTextBox_exit";
            this.richTextBox_exit.Size = new System.Drawing.Size(1383, 380);
            this.richTextBox_exit.TabIndex = 1;
            this.richTextBox_exit.Text = "";
            this.richTextBox_exit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(569, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Это \"Типограф\"?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(522, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "— Нет, это «Типограф»!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(623, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Оттопографить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_end
            // 
            this.button_end.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_end.Location = new System.Drawing.Point(623, 1020);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(241, 59);
            this.button_end.TabIndex = 5;
            this.button_end.Text = "Завершить";
            this.button_end.UseVisualStyleBackColor = false;
            this.button_end.Visible = false;
            this.button_end.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1507, 1103);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_exit);
            this.Controls.Add(this.richTextBox_enter);
            this.Name = "Form1";
            this.Text = "— Нет, это «Типограф»!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox_enter;
        public System.Windows.Forms.RichTextBox richTextBox_exit;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button_end;
    }
}

