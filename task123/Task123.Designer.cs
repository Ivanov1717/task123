
namespace task123
{
    partial class Task123
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
            this.saveButton = new System.Windows.Forms.Button();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.familyNameLabel = new System.Windows.Forms.Label();
            this.secondNamelabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(506, 308);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 39);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Запиши";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(169, 220);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(117, 20);
            this.classTextBox.TabIndex = 17;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classLabel.Location = new System.Drawing.Point(169, 193);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(45, 18);
            this.classLabel.TabIndex = 16;
            this.classLabel.Text = "Клас";
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.Location = new System.Drawing.Point(460, 131);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(114, 20);
            this.familyNameTextBox.TabIndex = 15;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(319, 131);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.secondNameTextBox.TabIndex = 14;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(169, 131);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(128, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // familyNameLabel
            // 
            this.familyNameLabel.AutoSize = true;
            this.familyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.familyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.familyNameLabel.Location = new System.Drawing.Point(460, 103);
            this.familyNameLabel.Name = "familyNameLabel";
            this.familyNameLabel.Size = new System.Drawing.Size(76, 18);
            this.familyNameLabel.TabIndex = 12;
            this.familyNameLabel.Text = "Фамилия";
            // 
            // secondNamelabel
            // 
            this.secondNamelabel.AutoSize = true;
            this.secondNamelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNamelabel.Location = new System.Drawing.Point(319, 103);
            this.secondNamelabel.Name = "secondNamelabel";
            this.secondNamelabel.Size = new System.Drawing.Size(76, 18);
            this.secondNamelabel.TabIndex = 11;
            this.secondNamelabel.Text = "Презиме";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(169, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 18);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Име";
            // 
            // Task123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.familyNameLabel);
            this.Controls.Add(this.secondNamelabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Task123";
            this.Text = "Task123";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label familyNameLabel;
        private System.Windows.Forms.Label secondNamelabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

