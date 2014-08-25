namespace Source_Control_Test
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
            this.ButtonButton = new System.Windows.Forms.Button();
            this.GroupBoxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxGroupBox
            // 
            this.GroupBoxGroupBox.Controls.Add(this.ButtonButton);
            this.GroupBoxGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxGroupBox.Name = "GroupBoxGroupBox";
            this.GroupBoxGroupBox.Size = new System.Drawing.Size(120, 75);
            this.GroupBoxGroupBox.TabIndex = 0;
            this.GroupBoxGroupBox.TabStop = false;
            this.GroupBoxGroupBox.Text = "Group Box";
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
            this.ClientSize = new System.Drawing.Size(145, 100);
            this.Controls.Add(this.GroupBoxGroupBox);
            this.Name = "SimpleForm";
            this.Text = "Simple";
            this.GroupBoxGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxGroupBox;
        private System.Windows.Forms.Button ButtonButton;
    }
}

