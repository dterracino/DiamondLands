namespace DiamondLands
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
            this.generateButton = new System.Windows.Forms.Button();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.canvasPanel = new DiamondLands.CanvasPanel();
            this.mapSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.loopHCheckBox = new System.Windows.Forms.CheckBox();
            this.loopVCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seedUpDown = new System.Windows.Forms.NumericUpDown();
            this.renewSeedButton = new System.Windows.Forms.Button();
            this.alwaysNewCheckBox = new System.Windows.Forms.CheckBox();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(701, 244);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // scrollPanel
            // 
            this.scrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.canvasPanel);
            this.scrollPanel.Location = new System.Drawing.Point(12, 12);
            this.scrollPanel.Margin = new System.Windows.Forms.Padding(0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(682, 537);
            this.scrollPanel.TabIndex = 1;
            // 
            // canvasPanel
            // 
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(200, 100);
            this.canvasPanel.TabIndex = 1;
            // 
            // mapSizeUpDown
            // 
            this.mapSizeUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapSizeUpDown.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.mapSizeUpDown.Location = new System.Drawing.Point(701, 28);
            this.mapSizeUpDown.Maximum = new decimal(new int[] {
            8193,
            0,
            0,
            0});
            this.mapSizeUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.mapSizeUpDown.Name = "mapSizeUpDown";
            this.mapSizeUpDown.Size = new System.Drawing.Size(71, 20);
            this.mapSizeUpDown.TabIndex = 0;
            this.mapSizeUpDown.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Map size -- -";
            // 
            // saveAsButton
            // 
            this.saveAsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAsButton.Location = new System.Drawing.Point(701, 270);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 2;
            this.saveAsButton.Text = "Save As...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.Filter = "PNG image file (*.png)|*.png";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loop -- -";
            // 
            // loopHCheckBox
            // 
            this.loopHCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loopHCheckBox.AutoSize = true;
            this.loopHCheckBox.Location = new System.Drawing.Point(701, 77);
            this.loopHCheckBox.Name = "loopHCheckBox";
            this.loopHCheckBox.Size = new System.Drawing.Size(65, 17);
            this.loopHCheckBox.TabIndex = 4;
            this.loopHCheckBox.Text = "Horizont";
            this.loopHCheckBox.UseVisualStyleBackColor = true;
            // 
            // loopVCheckBox
            // 
            this.loopVCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loopVCheckBox.AutoSize = true;
            this.loopVCheckBox.Location = new System.Drawing.Point(701, 100);
            this.loopVCheckBox.Name = "loopVCheckBox";
            this.loopVCheckBox.Size = new System.Drawing.Size(61, 17);
            this.loopVCheckBox.TabIndex = 4;
            this.loopVCheckBox.Text = "Vertical";
            this.loopVCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seed -- -";
            // 
            // seedUpDown
            // 
            this.seedUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seedUpDown.Location = new System.Drawing.Point(701, 146);
            this.seedUpDown.Maximum = new decimal(new int[] {
            1521386012,
            2,
            0,
            0});
            this.seedUpDown.Name = "seedUpDown";
            this.seedUpDown.Size = new System.Drawing.Size(71, 20);
            this.seedUpDown.TabIndex = 0;
            this.seedUpDown.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // renewSeedButton
            // 
            this.renewSeedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renewSeedButton.Enabled = false;
            this.renewSeedButton.Location = new System.Drawing.Point(701, 195);
            this.renewSeedButton.Name = "renewSeedButton";
            this.renewSeedButton.Size = new System.Drawing.Size(75, 23);
            this.renewSeedButton.TabIndex = 1;
            this.renewSeedButton.Text = "Renew";
            this.renewSeedButton.UseVisualStyleBackColor = true;
            this.renewSeedButton.Click += new System.EventHandler(this.renewSeedButton_Click);
            // 
            // alwaysNewCheckBox
            // 
            this.alwaysNewCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alwaysNewCheckBox.AutoSize = true;
            this.alwaysNewCheckBox.Checked = true;
            this.alwaysNewCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysNewCheckBox.Location = new System.Drawing.Point(701, 172);
            this.alwaysNewCheckBox.Name = "alwaysNewCheckBox";
            this.alwaysNewCheckBox.Size = new System.Drawing.Size(81, 17);
            this.alwaysNewCheckBox.TabIndex = 5;
            this.alwaysNewCheckBox.Text = "always new";
            this.alwaysNewCheckBox.UseVisualStyleBackColor = true;
            this.alwaysNewCheckBox.CheckedChanged += new System.EventHandler(this.alwaysNewCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.alwaysNewCheckBox);
            this.Controls.Add(this.loopVCheckBox);
            this.Controls.Add(this.loopHCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seedUpDown);
            this.Controls.Add(this.mapSizeUpDown);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.renewSeedButton);
            this.Controls.Add(this.generateButton);
            this.Name = "MainForm";
            this.Text = "Diamond Lands";
            this.scrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Panel scrollPanel;
        private CanvasPanel canvasPanel;
        private System.Windows.Forms.NumericUpDown mapSizeUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox loopHCheckBox;
        private System.Windows.Forms.CheckBox loopVCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown seedUpDown;
        private System.Windows.Forms.Button renewSeedButton;
        private System.Windows.Forms.CheckBox alwaysNewCheckBox;
    }
}

