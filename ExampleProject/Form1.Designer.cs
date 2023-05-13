namespace ExampleProject
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
            textBoxGameName = new TextBox();
            buttonCreateGame = new Button();
            SuspendLayout();
            // 
            // textBoxGameName
            // 
            textBoxGameName.Location = new Point(310, 157);
            textBoxGameName.Name = "textBoxGameName";
            textBoxGameName.Size = new Size(163, 27);
            textBoxGameName.TabIndex = 0;
            textBoxGameName.Text = "textBoxGameName";
            // 
            // buttonCreateGame
            // 
            buttonCreateGame.Location = new Point(310, 231);
            buttonCreateGame.Name = "buttonCreateGame";
            buttonCreateGame.Size = new Size(163, 46);
            buttonCreateGame.TabIndex = 1;
            buttonCreateGame.Text = "buttonCreateGame";
            buttonCreateGame.UseVisualStyleBackColor = true;
            buttonCreateGame.Click += buttonCreateGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreateGame);
            Controls.Add(textBoxGameName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGameName;
        private Button buttonCreateGame;
    }
}