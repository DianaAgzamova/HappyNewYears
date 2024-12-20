namespace _12_20HappyNewYears
{
    partial class Snake
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            TimerGameLoop = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // TimerGameLoop
            // 
            TimerGameLoop.Interval = 300;
            // 
            // Snake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(700, 521);
            DoubleBuffered = true;
            Name = "Snake";
            Text = "Allineed.Ru";
            Load += FrmSnakeGame_Load;
            Paint += FrmSnakeGame_Paint;
            ResumeLayout(false);
        }
        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer TimerGameLoop;
    }
}