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
            pictureBoxTank.Name = "pictureBoxTank";
            pictureBoxTank.Size = new Size(799, 449);
            pictureBoxTank.TabIndex = 0;
            pictureBoxTank.TabStop = false;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(12, 376);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(116, 39);
            ButtonCreate.TabIndex = 1;
            ButtonCreate.Text = "Создать Танк";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // keyDown
            // 
            keyDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            keyDown.BackgroundImage = Properties.Resources.KeyDown;
            keyDown.BackgroundImageLayout = ImageLayout.Stretch;
            keyDown.Location = new Point(718, 386);
            keyDown.Name = "keyDown";
            keyDown.Size = new Size(30, 30);
            keyDown.TabIndex = 11;
            keyDown.UseVisualStyleBackColor = true;
            keyDown.Click += ButtonMove_Click;
            // 
            // keyUp
            // 
            keyUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            keyUp.BackgroundImage = Properties.Resources.KeyUp;
            keyUp.BackgroundImageLayout = ImageLayout.Stretch;
            keyUp.Location = new Point(718, 350);
            keyUp.Name = "keyUp";
            keyUp.Size = new Size(30, 30);
            keyUp.TabIndex = 12;
            keyUp.UseVisualStyleBackColor = true;
            keyUp.Click += ButtonMove_Click;
            // 
            // keyLeft
            // 
            keyLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            keyLeft.BackgroundImage = Properties.Resources.KeyLeft;
            keyLeft.BackgroundImageLayout = ImageLayout.Stretch;
            keyLeft.Location = new Point(682, 386);
            keyLeft.Name = "keyLeft";
            keyLeft.Size = new Size(30, 30);
            keyLeft.TabIndex = 13;
            keyLeft.UseVisualStyleBackColor = true;
            keyLeft.Click += ButtonMove_Click;
            // 
            // keyRight
            // 
            keyRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            keyRight.BackgroundImage = Properties.Resources.KeyRight;
            keyRight.BackgroundImageLayout = ImageLayout.Stretch;
            keyRight.Location = new Point(753, 386);
            keyRight.Name = "keyRight";
            keyRight.Size = new Size(30, 30);
            keyRight.TabIndex = 14;
            keyRight.UseVisualStyleBackColor = true;
            keyRight.Click += ButtonMove_Click;
            // 
            // FormTank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 426);
            Controls.Add(keyRight);
            Controls.Add(keyLeft);
            Controls.Add(keyUp);
            Controls.Add(keyDown);
            Controls.Add(ButtonCreate);
            Controls.Add(pictureBoxTank);
            Name = "FormTank";
            Text = "FormTank";
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