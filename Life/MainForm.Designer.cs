namespace Life
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.densityNum = new System.Windows.Forms.NumericUpDown();
            this.densityLabel = new System.Windows.Forms.Label();
            this.resolutionNum = new System.Windows.Forms.NumericUpDown();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.densityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.CausesValidation = false;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.stopButton);
            this.splitContainer.Panel1.Controls.Add(this.startButton);
            this.splitContainer.Panel1.Controls.Add(this.densityNum);
            this.splitContainer.Panel1.Controls.Add(this.densityLabel);
            this.splitContainer.Panel1.Controls.Add(this.resolutionNum);
            this.splitContainer.Panel1.Controls.Add(this.resolutionLabel);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.image);
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.Size = new System.Drawing.Size(1070, 572);
            this.splitContainer.SplitterDistance = 297;
            this.splitContainer.TabIndex = 0;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(26, 253);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(149, 37);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(26, 192);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(149, 37);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // densityNum
            // 
            this.densityNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.densityNum.Location = new System.Drawing.Point(15, 120);
            this.densityNum.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.densityNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.densityNum.Name = "densityNum";
            this.densityNum.Size = new System.Drawing.Size(120, 30);
            this.densityNum.TabIndex = 3;
            this.densityNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.densityLabel.Location = new System.Drawing.Point(10, 92);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(84, 25);
            this.densityLabel.TabIndex = 2;
            this.densityLabel.Text = "Density";
            // 
            // resolutionNum
            // 
            this.resolutionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionNum.Location = new System.Drawing.Point(15, 46);
            this.resolutionNum.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.resolutionNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resolutionNum.Name = "resolutionNum";
            this.resolutionNum.Size = new System.Drawing.Size(120, 30);
            this.resolutionNum.TabIndex = 1;
            this.resolutionNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionLabel.Location = new System.Drawing.Point(10, 18);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(113, 25);
            this.resolutionLabel.TabIndex = 0;
            this.resolutionLabel.Text = "Resolution";
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(765, 568);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_MouseMove);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 572);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "Current generation: 0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.densityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown densityNum;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.NumericUpDown resolutionNum;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Timer timer;
    }
}

