﻿namespace Source_Control_Test.Forms
{
    partial class SimpleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.GroupBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.AnotherButtonButton = new System.Windows.Forms.Button();
            this.ButtonButton = new System.Windows.Forms.Button();
            this.GroupBoxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxGroupBox
            // 
            this.GroupBoxGroupBox.Controls.Add(this.AnotherButtonButton);
            this.GroupBoxGroupBox.Controls.Add(this.ButtonButton);
            this.GroupBoxGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxGroupBox.Name = "GroupBoxGroupBox";
            this.GroupBoxGroupBox.Size = new System.Drawing.Size(225, 75);
            this.GroupBoxGroupBox.TabIndex = 0;
            this.GroupBoxGroupBox.TabStop = false;
            this.GroupBoxGroupBox.Text = "Group Box";
            // 
            // AnotherButtonButton
            // 
            this.AnotherButtonButton.Location = new System.Drawing.Point(104, 30);
            this.AnotherButtonButton.Name = "AnotherButtonButton";
            this.AnotherButtonButton.Size = new System.Drawing.Size(100, 23);
            this.AnotherButtonButton.TabIndex = 1;
            this.AnotherButtonButton.Text = "Another Button";
            this.AnotherButtonButton.UseVisualStyleBackColor = true;
            this.AnotherButtonButton.Click += new System.EventHandler(this.AnotherButtonButton_Click);
            // 
            // ButtonButton
            // 
            this.ButtonButton.Location = new System.Drawing.Point(23, 30);
            this.ButtonButton.Name = "ButtonButton";
            this.ButtonButton.Size = new System.Drawing.Size(75, 23);
            this.ButtonButton.TabIndex = 0;
            this.ButtonButton.Text = "Button";
            this.ButtonButton.UseVisualStyleBackColor = true;
            this.ButtonButton.Click += new System.EventHandler(this.ButtonButton_Click);
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 100);
            this.Controls.Add(this.GroupBoxGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SimpleForm";
            this.Text = "Simple";
            this.GroupBoxGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxGroupBox;
        private System.Windows.Forms.Button ButtonButton;
        private System.Windows.Forms.Button AnotherButtonButton;
    }
}

