namespace TP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelInstruction = new Label();
            labelfeedback = new Label();
            buttonSubmit = new Button();
            listBoxWrongGuesses = new ListBox();
            textBoxGuess = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelInstruction
            // 
            labelInstruction.AutoSize = true;
            labelInstruction.Font = new Font("Jokerman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInstruction.Location = new Point(86, 9);
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size(409, 70);
            labelInstruction.TabIndex = 0;
            labelInstruction.Text = "Guess the Word";
            labelInstruction.Click += labelInstruction_Click;
            // 
            // labelfeedback
            // 
            labelfeedback.AutoSize = true;
            labelfeedback.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelfeedback.Location = new Point(39, 362);
            labelfeedback.Name = "labelfeedback";
            labelfeedback.Size = new Size(0, 30);
            labelfeedback.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.DarkSeaGreen;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 12F);
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(104, 274);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(138, 31);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Guess";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // listBoxWrongGuesses
            // 
            listBoxWrongGuesses.AccessibleRole = AccessibleRole.None;
            listBoxWrongGuesses.BackColor = Color.DarkSeaGreen;
            listBoxWrongGuesses.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxWrongGuesses.ForeColor = SystemColors.InactiveCaptionText;
            listBoxWrongGuesses.FormattingEnabled = true;
            listBoxWrongGuesses.ItemHeight = 19;
            listBoxWrongGuesses.Location = new Point(357, 161);
            listBoxWrongGuesses.Name = "listBoxWrongGuesses";
            listBoxWrongGuesses.Size = new Size(206, 232);
            listBoxWrongGuesses.TabIndex = 3;
            // 
            // textBoxGuess
            // 
            textBoxGuess.Font = new Font("Segoe UI", 14F);
            textBoxGuess.Location = new Point(70, 222);
            textBoxGuess.Name = "textBoxGuess";
            textBoxGuess.Size = new Size(215, 32);
            textBoxGuess.TabIndex = 4;
            textBoxGuess.TextAlign = HorizontalAlignment.Center;
            textBoxGuess.TextChanged += textBoxGuess_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(325, 56);
            label1.TabIndex = 5;
            label1.Text = "C_ _ _ O _ _ _ A";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 13F);
            label2.Location = new Point(357, 111);
            label2.Name = "label2";
            label2.Size = new Size(206, 31);
            label2.TabIndex = 6;
            label2.Text = "List of Wrong Guess";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(600, 466);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxGuess);
            Controls.Add(listBoxWrongGuesses);
            Controls.Add(buttonSubmit);
            Controls.Add(labelfeedback);
            Controls.Add(labelInstruction);
            Name = "Form1";
            Text = "Guess the Word";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInstruction;
        private Label labelfeedback;
        private Button buttonSubmit;
        private ListBox listBoxWrongGuesses;
        private TextBox textBoxGuess;
        private Label label1;
        private Label label2;
    }
}
