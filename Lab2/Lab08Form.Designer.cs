namespace Lab2
{
    partial class Lab08Form
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(172, 61);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Lab08";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.BackColor = System.Drawing.Color.Gray;
            this.infoGroupBox.Controls.Add(this.ageTextBox);
            this.infoGroupBox.Controls.Add(this.ageLabel);
            this.infoGroupBox.Controls.Add(this.nameTextBox);
            this.infoGroupBox.Controls.Add(this.nameLabel);
            this.infoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroupBox.Location = new System.Drawing.Point(12, 86);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(590, 200);
            this.infoGroupBox.TabIndex = 1;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "info";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.Location = new System.Drawing.Point(355, 113);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(229, 68);
            this.ageTextBox.TabIndex = 2;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(57, 112);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(300, 63);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Enter age: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(355, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(229, 68);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(346, 63);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter name: ";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(379, 317);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(217, 80);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 327);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(361, 63);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Enter age: ";
            // 
            // Lab08Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(614, 409);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Lab08Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab08";
            this.Load += new System.EventHandler(this.Lab08Form_Load);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

