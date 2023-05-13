namespace ExampleProject
{
    partial class InGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelGameName = new Label();
            buttonAddPoints = new Button();
            buttonRemovePoints = new Button();
            textBoxPlayerName = new TextBox();
            textBoxPointsToGive = new TextBox();
            labelTotalPoints = new Label();
            buttonEndGame = new Button();
            label1 = new Label();
            label2 = new Label();
            labelStartDate = new Label();
            SuspendLayout();
            // 
            // labelGameName
            // 
            labelGameName.AutoSize = true;
            labelGameName.Location = new Point(338, 113);
            labelGameName.Name = "labelGameName";
            labelGameName.Size = new Size(121, 20);
            labelGameName.TabIndex = 0;
            labelGameName.Text = "labelGameName";
            // 
            // buttonAddPoints
            // 
            buttonAddPoints.Location = new Point(171, 252);
            buttonAddPoints.Name = "buttonAddPoints";
            buttonAddPoints.Size = new Size(141, 41);
            buttonAddPoints.TabIndex = 1;
            buttonAddPoints.Text = "buttonAddPoints";
            buttonAddPoints.UseVisualStyleBackColor = true;
            buttonAddPoints.Click += buttonAddPoints_Click;
            // 
            // buttonRemovePoints
            // 
            buttonRemovePoints.Location = new Point(390, 252);
            buttonRemovePoints.Name = "buttonRemovePoints";
            buttonRemovePoints.Size = new Size(166, 41);
            buttonRemovePoints.TabIndex = 2;
            buttonRemovePoints.Text = "buttonRemovePoints";
            buttonRemovePoints.UseVisualStyleBackColor = true;
            buttonRemovePoints.Click += buttonRemovePoints_Click;
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Location = new Point(227, 197);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(144, 27);
            textBoxPlayerName.TabIndex = 3;
            textBoxPlayerName.Text = "textBoxPlayerName";
            // 
            // textBoxPointsToGive
            // 
            textBoxPointsToGive.Location = new Point(327, 259);
            textBoxPointsToGive.Name = "textBoxPointsToGive";
            textBoxPointsToGive.Size = new Size(44, 27);
            textBoxPointsToGive.TabIndex = 4;
            // 
            // labelTotalPoints
            // 
            labelTotalPoints.AutoSize = true;
            labelTotalPoints.Location = new Point(390, 200);
            labelTotalPoints.Name = "labelTotalPoints";
            labelTotalPoints.Size = new Size(17, 20);
            labelTotalPoints.TabIndex = 5;
            labelTotalPoints.Text = "0";
            // 
            // buttonEndGame
            // 
            buttonEndGame.Location = new Point(259, 363);
            buttonEndGame.Name = "buttonEndGame";
            buttonEndGame.Size = new Size(191, 38);
            buttonEndGame.TabIndex = 6;
            buttonEndGame.Text = "buttonEndGame";
            buttonEndGame.UseVisualStyleBackColor = true;
            buttonEndGame.Click += buttonEndGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 113);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 7;
            label1.Text = "GameName : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 145);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "StartDate : ";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(338, 145);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(50, 20);
            labelStartDate.TabIndex = 9;
            labelStartDate.Text = "label3";
            // 
            // InGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEndGame);
            Controls.Add(labelTotalPoints);
            Controls.Add(textBoxPointsToGive);
            Controls.Add(textBoxPlayerName);
            Controls.Add(buttonRemovePoints);
            Controls.Add(buttonAddPoints);
            Controls.Add(labelGameName);
            Name = "InGameForm";
            Text = "InGameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGameName;
        private Button buttonAddPoints;
        private Button buttonRemovePoints;
        private TextBox textBoxPlayerName;
        private TextBox textBoxPointsToGive;
        private Label labelTotalPoints;
        private Button buttonEndGame;
        private Label label1;
        private Label label2;
        private Label labelStartDate;
    }
}