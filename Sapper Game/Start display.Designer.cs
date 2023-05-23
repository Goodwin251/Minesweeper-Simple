namespace Sapper_Game
{
    partial class Start_display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_display));
            this.SizePanel = new System.Windows.Forms.Panel();
            this.LargeLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.SmallLabel = new System.Windows.Forms.Label();
            this.LargeButton = new System.Windows.Forms.RadioButton();
            this.MediumButton = new System.Windows.Forms.RadioButton();
            this.SmallButton = new System.Windows.Forms.RadioButton();
            this.DifficultyPanel = new System.Windows.Forms.Panel();
            this.HardLabel = new System.Windows.Forms.Label();
            this.NormalLabel = new System.Windows.Forms.Label();
            this.EasyLabel = new System.Windows.Forms.Label();
            this.HardButton = new System.Windows.Forms.RadioButton();
            this.NormalButton = new System.Windows.Forms.RadioButton();
            this.EasyButton = new System.Windows.Forms.RadioButton();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Author = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SizePanel.SuspendLayout();
            this.DifficultyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SizePanel
            // 
            this.SizePanel.Controls.Add(this.LargeLabel);
            this.SizePanel.Controls.Add(this.MediumLabel);
            this.SizePanel.Controls.Add(this.SmallLabel);
            this.SizePanel.Controls.Add(this.LargeButton);
            this.SizePanel.Controls.Add(this.MediumButton);
            this.SizePanel.Controls.Add(this.SmallButton);
            this.SizePanel.Location = new System.Drawing.Point(55, 123);
            this.SizePanel.Name = "SizePanel";
            this.SizePanel.Size = new System.Drawing.Size(328, 130);
            this.SizePanel.TabIndex = 0;
            this.SizePanel.TabStop = true;
            // 
            // LargeLabel
            // 
            this.LargeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LargeLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LargeLabel.Location = new System.Drawing.Point(247, 99);
            this.LargeLabel.Name = "LargeLabel";
            this.LargeLabel.Size = new System.Drawing.Size(60, 21);
            this.LargeLabel.TabIndex = 5;
            this.LargeLabel.Text = "12x12";
            this.LargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MediumLabel
            // 
            this.MediumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MediumLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MediumLabel.Location = new System.Drawing.Point(148, 99);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(40, 21);
            this.MediumLabel.TabIndex = 4;
            this.MediumLabel.Text = "8х8";
            this.MediumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SmallLabel
            // 
            this.SmallLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SmallLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SmallLabel.Location = new System.Drawing.Point(30, 99);
            this.SmallLabel.Name = "SmallLabel";
            this.SmallLabel.Size = new System.Drawing.Size(40, 21);
            this.SmallLabel.TabIndex = 3;
            this.SmallLabel.Text = "4x4";
            this.SmallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LargeButton
            // 
            this.LargeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.LargeButton.BackColor = System.Drawing.SystemColors.Control;
            this.LargeButton.BackgroundImage = global::Sapper_Game.Properties.Resources.Large;
            this.LargeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LargeButton.Location = new System.Drawing.Point(237, 16);
            this.LargeButton.Name = "LargeButton";
            this.LargeButton.Size = new System.Drawing.Size(80, 80);
            this.LargeButton.TabIndex = 2;
            this.LargeButton.UseVisualStyleBackColor = false;
            // 
            // MediumButton
            // 
            this.MediumButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MediumButton.BackColor = System.Drawing.SystemColors.Control;
            this.MediumButton.BackgroundImage = global::Sapper_Game.Properties.Resources.Medium;
            this.MediumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MediumButton.Location = new System.Drawing.Point(126, 16);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(80, 80);
            this.MediumButton.TabIndex = 1;
            this.MediumButton.UseVisualStyleBackColor = false;
            // 
            // SmallButton
            // 
            this.SmallButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SmallButton.BackColor = System.Drawing.SystemColors.Control;
            this.SmallButton.BackgroundImage = global::Sapper_Game.Properties.Resources.Small;
            this.SmallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SmallButton.Checked = true;
            this.SmallButton.Location = new System.Drawing.Point(9, 16);
            this.SmallButton.Name = "SmallButton";
            this.SmallButton.Size = new System.Drawing.Size(80, 80);
            this.SmallButton.TabIndex = 0;
            this.SmallButton.TabStop = true;
            this.SmallButton.UseVisualStyleBackColor = false;
            // 
            // DifficultyPanel
            // 
            this.DifficultyPanel.Controls.Add(this.HardLabel);
            this.DifficultyPanel.Controls.Add(this.NormalLabel);
            this.DifficultyPanel.Controls.Add(this.EasyLabel);
            this.DifficultyPanel.Controls.Add(this.HardButton);
            this.DifficultyPanel.Controls.Add(this.NormalButton);
            this.DifficultyPanel.Controls.Add(this.EasyButton);
            this.DifficultyPanel.Location = new System.Drawing.Point(55, 275);
            this.DifficultyPanel.Name = "DifficultyPanel";
            this.DifficultyPanel.Size = new System.Drawing.Size(328, 130);
            this.DifficultyPanel.TabIndex = 1;
            this.DifficultyPanel.TabStop = true;
            // 
            // HardLabel
            // 
            this.HardLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HardLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HardLabel.Location = new System.Drawing.Point(250, 97);
            this.HardLabel.Name = "HardLabel";
            this.HardLabel.Size = new System.Drawing.Size(60, 21);
            this.HardLabel.TabIndex = 8;
            this.HardLabel.Text = "Тяжко";
            this.HardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NormalLabel
            // 
            this.NormalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NormalLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NormalLabel.Location = new System.Drawing.Point(117, 97);
            this.NormalLabel.Name = "NormalLabel";
            this.NormalLabel.Size = new System.Drawing.Size(103, 21);
            this.NormalLabel.TabIndex = 7;
            this.NormalLabel.Text = "Нормально";
            this.NormalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EasyLabel
            // 
            this.EasyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EasyLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EasyLabel.Location = new System.Drawing.Point(21, 97);
            this.EasyLabel.Name = "EasyLabel";
            this.EasyLabel.Size = new System.Drawing.Size(59, 21);
            this.EasyLabel.TabIndex = 6;
            this.EasyLabel.Text = "Легко";
            this.EasyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HardButton
            // 
            this.HardButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.HardButton.BackColor = System.Drawing.SystemColors.Control;
            this.HardButton.BackgroundImage = global::Sapper_Game.Properties.Resources.Three_Bombs;
            this.HardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HardButton.Location = new System.Drawing.Point(237, 14);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(80, 80);
            this.HardButton.TabIndex = 2;
            this.HardButton.UseVisualStyleBackColor = false;
            // 
            // NormalButton
            // 
            this.NormalButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.NormalButton.BackColor = System.Drawing.SystemColors.Control;
            this.NormalButton.BackgroundImage = global::Sapper_Game.Properties.Resources.Two_Bombs;
            this.NormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NormalButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NormalButton.Location = new System.Drawing.Point(126, 14);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(80, 80);
            this.NormalButton.TabIndex = 1;
            this.NormalButton.UseVisualStyleBackColor = false;
            // 
            // EasyButton
            // 
            this.EasyButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.EasyButton.BackColor = System.Drawing.SystemColors.Control;
            this.EasyButton.BackgroundImage = global::Sapper_Game.Properties.Resources.Bomb;
            this.EasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EasyButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EasyButton.Checked = true;
            this.EasyButton.Location = new System.Drawing.Point(9, 14);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(80, 80);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.TabStop = true;
            this.EasyButton.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(155, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(131, 50);
            this.Title.TabIndex = 2;
            this.Title.Text = "Сапер";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sapper_Game.Properties.Resources.Bomb;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(371, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sapper_Game.Properties.Resources.Bomb;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Author.Location = new System.Drawing.Point(55, 567);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(320, 25);
            this.Author.TabIndex = 5;
            this.Author.Text = "Розроблено Солодким Ярославом";
            this.Author.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.NewGameButton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewGameButton.Location = new System.Drawing.Point(117, 464);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(200, 69);
            this.NewGameButton.TabIndex = 6;
            this.NewGameButton.Text = "Нова гра";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // Start_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 601);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DifficultyPanel);
            this.Controls.Add(this.SizePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start_display";
            this.Text = "Початковий екран";
            this.SizePanel.ResumeLayout(false);
            this.DifficultyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel SizePanel;
        private RadioButton LargeButton;
        private RadioButton MediumButton;
        private RadioButton SmallButton;
        private Panel DifficultyPanel;
        private RadioButton HardButton;
        private RadioButton NormalButton;
        private RadioButton EasyButton;
        private Label Title;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Author;
        private Button NewGameButton;
        private Label SmallLabel;
        private Label LargeLabel;
        private Label MediumLabel;
        private Label HardLabel;
        private Label NormalLabel;
        private Label EasyLabel;
    }
}