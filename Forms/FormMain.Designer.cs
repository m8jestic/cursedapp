namespace cursedapp
{
    partial class FormMain
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
            this.buttonSolving = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.edgeButton = new System.Windows.Forms.Button();
            this.vertexButton = new System.Windows.Forms.Button();
            this.cloth = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSaveSolving = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cloth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSolving
            // 
            this.buttonSolving.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSolving.Location = new System.Drawing.Point(12, 574);
            this.buttonSolving.Name = "buttonSolving";
            this.buttonSolving.Size = new System.Drawing.Size(113, 23);
            this.buttonSolving.TabIndex = 3;
            this.buttonSolving.Text = "Решение";
            this.buttonSolving.UseVisualStyleBackColor = true;
            this.buttonSolving.Click += new System.EventHandler(this.buttonSolving_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.BackgroundImage = global::cursedapp.Properties.Resources._1483063;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearButton.Location = new System.Drawing.Point(548, 562);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(35, 35);
            this.clearButton.TabIndex = 9;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.BackgroundImage = global::cursedapp.Properties.Resources.Transparent_X;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Location = new System.Drawing.Point(507, 562);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(35, 35);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // edgeButton
            // 
            this.edgeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edgeButton.BackgroundImage = global::cursedapp.Properties.Resources.png_transparent_black_vertical_line_rectangle_horizontal_line_angle_black_internet;
            this.edgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edgeButton.Location = new System.Drawing.Point(466, 562);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(35, 35);
            this.edgeButton.TabIndex = 7;
            this.edgeButton.UseVisualStyleBackColor = true;
            this.edgeButton.Click += new System.EventHandler(this.edgeButton_Click);
            // 
            // vertexButton
            // 
            this.vertexButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.vertexButton.BackgroundImage = global::cursedapp.Properties.Resources._174;
            this.vertexButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vertexButton.Location = new System.Drawing.Point(425, 562);
            this.vertexButton.Name = "vertexButton";
            this.vertexButton.Size = new System.Drawing.Size(35, 35);
            this.vertexButton.TabIndex = 6;
            this.vertexButton.UseVisualStyleBackColor = true;
            this.vertexButton.Click += new System.EventHandler(this.vertexButton_Click);
            // 
            // cloth
            // 
            this.cloth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cloth.BackColor = System.Drawing.Color.White;
            this.cloth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cloth.Location = new System.Drawing.Point(12, 22);
            this.cloth.Name = "cloth";
            this.cloth.Size = new System.Drawing.Size(984, 519);
            this.cloth.TabIndex = 4;
            this.cloth.TabStop = false;
            this.cloth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cloth_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(883, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "О программе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSaveSolving
            // 
            this.buttonSaveSolving.Location = new System.Drawing.Point(753, 574);
            this.buttonSaveSolving.Name = "buttonSaveSolving";
            this.buttonSaveSolving.Size = new System.Drawing.Size(124, 23);
            this.buttonSaveSolving.TabIndex = 11;
            this.buttonSaveSolving.Text = "Сохранить изображение";
            this.buttonSaveSolving.UseVisualStyleBackColor = true;
            this.buttonSaveSolving.Click += new System.EventHandler(this.buttonSaveSolving_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1007, 602);
            this.Controls.Add(this.buttonSaveSolving);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.edgeButton);
            this.Controls.Add(this.vertexButton);
            this.Controls.Add(this.cloth);
            this.Controls.Add(this.buttonSolving);
            this.MaximumSize = new System.Drawing.Size(1023, 641);
            this.Name = "FormMain";
            this.Text = "Окно решения";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cloth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSolving;
        private System.Windows.Forms.PictureBox cloth;
        private System.Windows.Forms.Button vertexButton;
        private System.Windows.Forms.Button edgeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSaveSolving;
    }
}