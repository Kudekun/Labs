namespace Гишко_ООП16
{
    partial class Form1
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
            this.StringLabel = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.AddToTail = new System.Windows.Forms.Button();
            this.RemoveAtTail = new System.Windows.Forms.Button();
            this.AddToHead = new System.Windows.Forms.Button();
            this.RemoveAtHead = new System.Windows.Forms.Button();
            this.RemoveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StringLabel
            // 
            this.StringLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StringLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StringLabel.Location = new System.Drawing.Point(12, 9);
            this.StringLabel.Name = "StringLabel";
            this.StringLabel.Size = new System.Drawing.Size(528, 255);
            this.StringLabel.TabIndex = 0;
            // 
            // dataBox
            // 
            this.dataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBox.Location = new System.Drawing.Point(12, 283);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(528, 29);
            this.dataBox.TabIndex = 1;
            // 
            // AddToTail
            // 
            this.AddToTail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToTail.Location = new System.Drawing.Point(312, 329);
            this.AddToTail.Name = "AddToTail";
            this.AddToTail.Size = new System.Drawing.Size(179, 40);
            this.AddToTail.TabIndex = 2;
            this.AddToTail.Text = "Додати в кінець";
            this.AddToTail.UseVisualStyleBackColor = true;
            this.AddToTail.Click += new System.EventHandler(this.AddToTail_Click);
            // 
            // RemoveAtTail
            // 
            this.RemoveAtTail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveAtTail.Location = new System.Drawing.Point(312, 375);
            this.RemoveAtTail.Name = "RemoveAtTail";
            this.RemoveAtTail.Size = new System.Drawing.Size(179, 40);
            this.RemoveAtTail.TabIndex = 3;
            this.RemoveAtTail.Text = "Видалити з кінця";
            this.RemoveAtTail.UseVisualStyleBackColor = true;
            this.RemoveAtTail.Click += new System.EventHandler(this.RemoveAtTail_Click);
            // 
            // AddToHead
            // 
            this.AddToHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToHead.Location = new System.Drawing.Point(67, 329);
            this.AddToHead.Name = "AddToHead";
            this.AddToHead.Size = new System.Drawing.Size(179, 40);
            this.AddToHead.TabIndex = 4;
            this.AddToHead.Text = "Додати на початок";
            this.AddToHead.UseVisualStyleBackColor = true;
            this.AddToHead.Click += new System.EventHandler(this.AddToHead_Click);
            // 
            // RemoveAtHead
            // 
            this.RemoveAtHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveAtHead.Location = new System.Drawing.Point(67, 375);
            this.RemoveAtHead.Name = "RemoveAtHead";
            this.RemoveAtHead.Size = new System.Drawing.Size(179, 40);
            this.RemoveAtHead.TabIndex = 5;
            this.RemoveAtHead.Text = "Видалити з початку";
            this.RemoveAtHead.UseVisualStyleBackColor = true;
            this.RemoveAtHead.Click += new System.EventHandler(this.RemoveAtHead_Click);
            // 
            // RemoveAll
            // 
            this.RemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveAll.Location = new System.Drawing.Point(189, 436);
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Size = new System.Drawing.Size(179, 40);
            this.RemoveAll.TabIndex = 6;
            this.RemoveAll.Text = "Видалити все";
            this.RemoveAll.UseVisualStyleBackColor = true;
            this.RemoveAll.Click += new System.EventHandler(this.RemoveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 508);
            this.Controls.Add(this.RemoveAll);
            this.Controls.Add(this.RemoveAtHead);
            this.Controls.Add(this.AddToHead);
            this.Controls.Add(this.RemoveAtTail);
            this.Controls.Add(this.AddToTail);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.StringLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StringLabel;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.Button AddToTail;
        private System.Windows.Forms.Button RemoveAtTail;
        private System.Windows.Forms.Button AddToHead;
        private System.Windows.Forms.Button RemoveAtHead;
        private System.Windows.Forms.Button RemoveAll;
    }
}

