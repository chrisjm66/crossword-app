namespace Crossword
{
    partial class MenuForm
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
            label1 = new Label();
            startButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.MaximumSize = new Size(0, 100);
            label1.MinimumSize = new Size(0, 100);
            label1.Name = "label1";
            label1.Size = new Size(1140, 100);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Crossword";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            startButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            startButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.Location = new Point(301, 233);
            startButton.Margin = new Padding(3, 200, 3, 3);
            startButton.MaximumSize = new Size(10000, 100);
            startButton.MinimumSize = new Size(320, 100);
            startButton.Name = "startButton";
            startButton.Size = new Size(468, 100);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // quitButton
            // 
            quitButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            quitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            quitButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quitButton.Location = new Point(301, 357);
            quitButton.MaximumSize = new Size(10000, 100);
            quitButton.MinimumSize = new Size(320, 100);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(468, 100);
            quitButton.TabIndex = 2;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1140, 728);
            Controls.Add(quitButton);
            Controls.Add(startButton);
            Controls.Add(label1);
            Name = "MenuForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private void startButton_Click()
        {
            Program.startGame();
        }

        private Label label1;
        private Button startButton;
        private Button quitButton;
    }
}
