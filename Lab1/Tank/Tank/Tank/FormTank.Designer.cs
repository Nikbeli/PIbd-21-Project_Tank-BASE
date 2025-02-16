namespace Tank
{
    partial class FormTank
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
            pictureBoxTank = new PictureBox();
            ButtonCreate = new Button();
            keyDown = new Button();
            keyUp = new Button();
            keyLeft = new Button();
            keyRight = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTank).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTank
            // 
            pictureBoxTank.Location = new Point(1, 0);
            pictureBoxTank.Margin = new Padding(3, 4, 3, 4);
            pictureBoxTank.Name = "pictureBoxTank";
            pictureBoxTank.Size = new Size(913, 599);
            pictureBoxTank.TabIndex = 0;
            pictureBoxTank.TabStop = false;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(14, 523);
            ButtonCreate.Margin = new Padding(3, 4, 3, 4);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(90, 31);
            ButtonCreate.TabIndex = 1;
            ButtonCreate.Text = "button";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click_1;
            // 
            // keyDown
            // 
            keyDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            keyDown.BackgroundImage = Properties.Resources.KeyDown;
            keyDown.BackgroundImageLayout = ImageLayout.Stretch;
            keyDown.Location = new Point(820, 514);
            keyDown.Margin = new Padding(3, 4, 3, 4);
            keyDown.Name = "keyDown";
            keyDown.Size = new Size(34, 40);
            keyDown.TabIndex = 11;
            keyDown.UseVisualStyleBackColor = true;
            keyDown.Click += ButtonMove_Click;
            // 
            // keyUp
            // 
            keyUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            keyUp.BackgroundImage = Properties.Resources.KeyUp;
            keyUp.BackgroundImageLayout = ImageLayout.Stretch;
            keyUp.Location = new Point(820, 466);
            keyUp.Margin = new Padding(3, 4, 3, 4);
            keyUp.Name = "keyUp";
            keyUp.Size = new Size(34, 40);
            keyUp.TabIndex = 12;
            keyUp.UseVisualStyleBackColor = true;
            keyUp.Click += ButtonMove_Click;
            // 
            // keyLeft
            // 
            keyLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            keyLeft.BackgroundImage = Properties.Resources.KeyLeft;
            keyLeft.BackgroundImageLayout = ImageLayout.Stretch;
            keyLeft.Location = new Point(779, 514);
            keyLeft.Margin = new Padding(3, 4, 3, 4);
            keyLeft.Name = "keyLeft";
            keyLeft.Size = new Size(34, 40);
            keyLeft.TabIndex = 13;
            keyLeft.UseVisualStyleBackColor = true;
            keyLeft.Click += ButtonMove_Click;
            // 
            // keyRight
            // 
            keyRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            keyRight.BackgroundImage = Properties.Resources.KeyRight;
            keyRight.BackgroundImageLayout = ImageLayout.Stretch;
            keyRight.Location = new Point(861, 514);
            keyRight.Margin = new Padding(3, 4, 3, 4);
            keyRight.Name = "keyRight";
            keyRight.Size = new Size(34, 40);
            keyRight.TabIndex = 14;
            keyRight.UseVisualStyleBackColor = true;
            keyRight.Click += ButtonMove_Click;
            // 
            // FormTank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 568);
            Controls.Add(keyRight);
            Controls.Add(keyLeft);
            Controls.Add(keyUp);
            Controls.Add(keyDown);
            Controls.Add(ButtonCreate);
            Controls.Add(pictureBoxTank);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTank";
            Text = "FormTank";
            Load += FormTank_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTank).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxTank;
        private Button ButtonCreate;
        private Button keyRight;
        private Button keyLeft;
        private Button keyUp;
        private Button keyDown;
    }
}