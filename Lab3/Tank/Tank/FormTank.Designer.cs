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
            buttonArmVechicle = new Button();
            buttonStep = new Button();
            comboBoxStrategy = new ComboBox();
            ChooseCar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTank).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTank
            // 
            pictureBoxTank.Location = new Point(1, 0);
            pictureBoxTank.Name = "pictureBoxTank";
            pictureBoxTank.Size = new Size(799, 428);
            pictureBoxTank.TabIndex = 0;
            pictureBoxTank.TabStop = false;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(12, 375);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(127, 40);
            ButtonCreate.TabIndex = 1;
            ButtonCreate.Text = "Создание танка";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreateTank_Click;
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
            // buttonArmVechicle
            // 
            buttonArmVechicle.Location = new Point(154, 376);
            buttonArmVechicle.Name = "buttonArmVechicle";
            buttonArmVechicle.Size = new Size(127, 40);
            buttonArmVechicle.TabIndex = 15;
            buttonArmVechicle.Text = "Создание бронеавтомобиля";
            buttonArmVechicle.UseVisualStyleBackColor = true;
            buttonArmVechicle.Click += CreateButtonArmoVehicle_Click;
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(713, 53);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(75, 23);
            buttonStep.TabIndex = 17;
            buttonStep.Text = "Шаг";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += ButtonStep_Click;
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Items.AddRange(new object[] { "0", "1" });
            comboBoxStrategy.Location = new Point(655, 18);
            comboBoxStrategy.Margin = new Padding(3, 2, 3, 2);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new Size(133, 23);
            comboBoxStrategy.TabIndex = 19;
            // 
            // ChooseCar
            // 
            ChooseCar.Location = new Point(706, 90);
            ChooseCar.Margin = new Padding(3, 2, 3, 2);
            ChooseCar.Name = "ChooseCar";
            ChooseCar.Size = new Size(82, 39);
            ChooseCar.TabIndex = 20;
            ChooseCar.Text = "Выбрать технику";
            ChooseCar.UseVisualStyleBackColor = true;
            ChooseCar.Click += ButtonSelectTank_Click;
            // 
            // FormTank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 426);
            Controls.Add(ChooseCar);
            Controls.Add(comboBoxStrategy);
            Controls.Add(buttonStep);
            Controls.Add(buttonArmVechicle);
            Controls.Add(keyRight);
            Controls.Add(keyLeft);
            Controls.Add(keyUp);
            Controls.Add(keyDown);
            Controls.Add(ButtonCreate);
            Controls.Add(pictureBoxTank);
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
        private Button buttonArmVechicle;
        private Button buttonStep;
        private ComboBox comboBoxStrategy;
        private Button ChooseCar;
    }
}