
namespace OfflineChat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
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
            this.components = new System.ComponentModel.Container();
            this.chatWindow = new System.Windows.Forms.RichTextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userNickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chatWindow
            // 
            this.chatWindow.Location = new System.Drawing.Point(12, 40);
            this.chatWindow.Name = "chatWindow";
            this.chatWindow.ReadOnly = true;
            this.chatWindow.Size = new System.Drawing.Size(699, 330);
            this.chatWindow.TabIndex = 0;
            this.chatWindow.Text = "";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 393);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(558, 22);
            this.messageBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Окно чата:";
            // 
            // userNickname
            // 
            this.userNickname.Location = new System.Drawing.Point(611, 6);
            this.userNickname.Name = "userNickname";
            this.userNickname.Size = new System.Drawing.Size(100, 22);
            this.userNickname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите ваш никнейм";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.chatWindow);
            this.Name = "Form1";
            this.Text = "Оффлайн чат";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatWindow;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

