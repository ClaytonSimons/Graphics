namespace GraphicsLab1
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
            this.vector1RTxt = new System.Windows.Forms.RichTextBox();
            this.vector2RTxt = new System.Windows.Forms.RichTextBox();
            this.vector1xTxt = new System.Windows.Forms.TextBox();
            this.vector1yTxt = new System.Windows.Forms.TextBox();
            this.vector1zTxt = new System.Windows.Forms.TextBox();
            this.vector2zTxt = new System.Windows.Forms.TextBox();
            this.vector2yTxt = new System.Windows.Forms.TextBox();
            this.vector2xTxt = new System.Windows.Forms.TextBox();
            this.addVectorRad = new System.Windows.Forms.RadioButton();
            this.scalarRTxt = new System.Windows.Forms.RichTextBox();
            this.scalarTxt = new System.Windows.Forms.TextBox();
            this.addScalarRBtn = new System.Windows.Forms.RadioButton();
            this.subVectorRBtn = new System.Windows.Forms.RadioButton();
            this.SubScalarRBtn = new System.Windows.Forms.RadioButton();
            this.multVectorRBtn = new System.Windows.Forms.RadioButton();
            this.multScalarRBtn = new System.Windows.Forms.RadioButton();
            this.divScalarRBtn = new System.Windows.Forms.RadioButton();
            this.dotRBtn = new System.Windows.Forms.RadioButton();
            this.crossRBtn = new System.Windows.Forms.RadioButton();
            this.magRBtn = new System.Windows.Forms.RadioButton();
            this.unitRBtn = new System.Windows.Forms.RadioButton();
            this.vectorAnswerRTxt = new System.Windows.Forms.RichTextBox();
            this.scalarAnswerRTxt = new System.Windows.Forms.RichTextBox();
            this.vectorxAnswerTxt = new System.Windows.Forms.TextBox();
            this.vectoryAnswerTxt = new System.Windows.Forms.TextBox();
            this.vectorzAnswerTxt = new System.Windows.Forms.TextBox();
            this.scalarAnswerTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearEntriesBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vector1RTxt
            // 
            this.vector1RTxt.BackColor = System.Drawing.SystemColors.Control;
            this.vector1RTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vector1RTxt.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vector1RTxt.Location = new System.Drawing.Point(13, 13);
            this.vector1RTxt.Name = "vector1RTxt";
            this.vector1RTxt.Size = new System.Drawing.Size(170, 20);
            this.vector1RTxt.TabIndex = 0;
            this.vector1RTxt.Text = "Vector 1 (x,y,z)";
            // 
            // vector2RTxt
            // 
            this.vector2RTxt.BackColor = System.Drawing.SystemColors.Control;
            this.vector2RTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vector2RTxt.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vector2RTxt.Location = new System.Drawing.Point(12, 66);
            this.vector2RTxt.Name = "vector2RTxt";
            this.vector2RTxt.Size = new System.Drawing.Size(170, 20);
            this.vector2RTxt.TabIndex = 1;
            this.vector2RTxt.Text = "Vector 2 (x,y,z)";
            // 
            // vector1xTxt
            // 
            this.vector1xTxt.Location = new System.Drawing.Point(13, 40);
            this.vector1xTxt.Name = "vector1xTxt";
            this.vector1xTxt.Size = new System.Drawing.Size(38, 20);
            this.vector1xTxt.TabIndex = 2;
            // 
            // vector1yTxt
            // 
            this.vector1yTxt.Location = new System.Drawing.Point(57, 40);
            this.vector1yTxt.Name = "vector1yTxt";
            this.vector1yTxt.Size = new System.Drawing.Size(38, 20);
            this.vector1yTxt.TabIndex = 3;
            // 
            // vector1zTxt
            // 
            this.vector1zTxt.Location = new System.Drawing.Point(101, 40);
            this.vector1zTxt.Name = "vector1zTxt";
            this.vector1zTxt.Size = new System.Drawing.Size(38, 20);
            this.vector1zTxt.TabIndex = 4;
            // 
            // vector2zTxt
            // 
            this.vector2zTxt.Location = new System.Drawing.Point(101, 92);
            this.vector2zTxt.Name = "vector2zTxt";
            this.vector2zTxt.Size = new System.Drawing.Size(38, 20);
            this.vector2zTxt.TabIndex = 7;
            // 
            // vector2yTxt
            // 
            this.vector2yTxt.Location = new System.Drawing.Point(57, 92);
            this.vector2yTxt.Name = "vector2yTxt";
            this.vector2yTxt.Size = new System.Drawing.Size(38, 20);
            this.vector2yTxt.TabIndex = 6;
            // 
            // vector2xTxt
            // 
            this.vector2xTxt.Location = new System.Drawing.Point(13, 92);
            this.vector2xTxt.Name = "vector2xTxt";
            this.vector2xTxt.Size = new System.Drawing.Size(38, 20);
            this.vector2xTxt.TabIndex = 5;
            // 
            // addVectorRad
            // 
            this.addVectorRad.AutoSize = true;
            this.addVectorRad.Location = new System.Drawing.Point(189, 16);
            this.addVectorRad.Name = "addVectorRad";
            this.addVectorRad.Size = new System.Drawing.Size(83, 17);
            this.addVectorRad.TabIndex = 8;
            this.addVectorRad.TabStop = true;
            this.addVectorRad.Text = "Add Vectors";
            this.addVectorRad.UseVisualStyleBackColor = true;
            // 
            // scalarRTxt
            // 
            this.scalarRTxt.BackColor = System.Drawing.SystemColors.Control;
            this.scalarRTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scalarRTxt.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalarRTxt.Location = new System.Drawing.Point(13, 118);
            this.scalarRTxt.Name = "scalarRTxt";
            this.scalarRTxt.Size = new System.Drawing.Size(170, 20);
            this.scalarRTxt.TabIndex = 9;
            this.scalarRTxt.Text = "Scalar";
            // 
            // scalarTxt
            // 
            this.scalarTxt.Location = new System.Drawing.Point(13, 144);
            this.scalarTxt.Name = "scalarTxt";
            this.scalarTxt.Size = new System.Drawing.Size(82, 20);
            this.scalarTxt.TabIndex = 10;
            // 
            // addScalarRBtn
            // 
            this.addScalarRBtn.AutoSize = true;
            this.addScalarRBtn.Location = new System.Drawing.Point(189, 39);
            this.addScalarRBtn.Name = "addScalarRBtn";
            this.addScalarRBtn.Size = new System.Drawing.Size(129, 17);
            this.addScalarRBtn.TabIndex = 11;
            this.addScalarRBtn.TabStop = true;
            this.addScalarRBtn.Text = "Add Scalar to Vector1";
            this.addScalarRBtn.UseVisualStyleBackColor = true;
            // 
            // subVectorRBtn
            // 
            this.subVectorRBtn.AutoSize = true;
            this.subVectorRBtn.Location = new System.Drawing.Point(189, 62);
            this.subVectorRBtn.Name = "subVectorRBtn";
            this.subVectorRBtn.Size = new System.Drawing.Size(104, 17);
            this.subVectorRBtn.TabIndex = 12;
            this.subVectorRBtn.TabStop = true;
            this.subVectorRBtn.Text = "Subtract Vectors";
            this.subVectorRBtn.UseVisualStyleBackColor = true;
            // 
            // SubScalarRBtn
            // 
            this.SubScalarRBtn.AutoSize = true;
            this.SubScalarRBtn.Location = new System.Drawing.Point(189, 85);
            this.SubScalarRBtn.Name = "SubScalarRBtn";
            this.SubScalarRBtn.Size = new System.Drawing.Size(161, 17);
            this.SubScalarRBtn.TabIndex = 13;
            this.SubScalarRBtn.TabStop = true;
            this.SubScalarRBtn.Text = "Subtract Scalar from Vector1";
            this.SubScalarRBtn.UseVisualStyleBackColor = true;
            // 
            // multVectorRBtn
            // 
            this.multVectorRBtn.AutoSize = true;
            this.multVectorRBtn.Location = new System.Drawing.Point(189, 108);
            this.multVectorRBtn.Name = "multVectorRBtn";
            this.multVectorRBtn.Size = new System.Drawing.Size(99, 17);
            this.multVectorRBtn.TabIndex = 14;
            this.multVectorRBtn.TabStop = true;
            this.multVectorRBtn.Text = "Multiply Vectors";
            this.multVectorRBtn.UseVisualStyleBackColor = true;
            // 
            // multScalarRBtn
            // 
            this.multScalarRBtn.AutoSize = true;
            this.multScalarRBtn.Location = new System.Drawing.Point(189, 131);
            this.multScalarRBtn.Name = "multScalarRBtn";
            this.multScalarRBtn.Size = new System.Drawing.Size(147, 17);
            this.multScalarRBtn.TabIndex = 15;
            this.multScalarRBtn.TabStop = true;
            this.multScalarRBtn.Text = "Multiply Vector1 by Scalar";
            this.multScalarRBtn.UseVisualStyleBackColor = true;
            // 
            // divScalarRBtn
            // 
            this.divScalarRBtn.AutoSize = true;
            this.divScalarRBtn.Location = new System.Drawing.Point(189, 154);
            this.divScalarRBtn.Name = "divScalarRBtn";
            this.divScalarRBtn.Size = new System.Drawing.Size(142, 17);
            this.divScalarRBtn.TabIndex = 16;
            this.divScalarRBtn.TabStop = true;
            this.divScalarRBtn.Text = "Divide Vector1 by Scalar";
            this.divScalarRBtn.UseVisualStyleBackColor = true;
            // 
            // dotRBtn
            // 
            this.dotRBtn.AutoSize = true;
            this.dotRBtn.Location = new System.Drawing.Point(189, 177);
            this.dotRBtn.Name = "dotRBtn";
            this.dotRBtn.Size = new System.Drawing.Size(81, 17);
            this.dotRBtn.TabIndex = 17;
            this.dotRBtn.TabStop = true;
            this.dotRBtn.Text = "Dot Vectors";
            this.dotRBtn.UseVisualStyleBackColor = true;
            // 
            // crossRBtn
            // 
            this.crossRBtn.AutoSize = true;
            this.crossRBtn.Location = new System.Drawing.Point(189, 200);
            this.crossRBtn.Name = "crossRBtn";
            this.crossRBtn.Size = new System.Drawing.Size(90, 17);
            this.crossRBtn.TabIndex = 18;
            this.crossRBtn.TabStop = true;
            this.crossRBtn.Text = "Cross Vectors";
            this.crossRBtn.UseVisualStyleBackColor = true;
            // 
            // magRBtn
            // 
            this.magRBtn.AutoSize = true;
            this.magRBtn.Location = new System.Drawing.Point(189, 223);
            this.magRBtn.Name = "magRBtn";
            this.magRBtn.Size = new System.Drawing.Size(127, 17);
            this.magRBtn.TabIndex = 19;
            this.magRBtn.TabStop = true;
            this.magRBtn.Text = "Magnitude of Vector1";
            this.magRBtn.UseVisualStyleBackColor = true;
            // 
            // unitRBtn
            // 
            this.unitRBtn.AutoSize = true;
            this.unitRBtn.Location = new System.Drawing.Point(189, 246);
            this.unitRBtn.Name = "unitRBtn";
            this.unitRBtn.Size = new System.Drawing.Size(182, 17);
            this.unitRBtn.TabIndex = 20;
            this.unitRBtn.TabStop = true;
            this.unitRBtn.Text = "Vector1 with Magnitude of Scalar";
            this.unitRBtn.UseVisualStyleBackColor = true;
            // 
            // vectorAnswerRTxt
            // 
            this.vectorAnswerRTxt.BackColor = System.Drawing.SystemColors.Control;
            this.vectorAnswerRTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vectorAnswerRTxt.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorAnswerRTxt.Location = new System.Drawing.Point(12, 177);
            this.vectorAnswerRTxt.Name = "vectorAnswerRTxt";
            this.vectorAnswerRTxt.Size = new System.Drawing.Size(170, 20);
            this.vectorAnswerRTxt.TabIndex = 21;
            this.vectorAnswerRTxt.Text = "Vector Answer";
            // 
            // scalarAnswerRTxt
            // 
            this.scalarAnswerRTxt.BackColor = System.Drawing.SystemColors.Control;
            this.scalarAnswerRTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scalarAnswerRTxt.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalarAnswerRTxt.Location = new System.Drawing.Point(12, 229);
            this.scalarAnswerRTxt.Name = "scalarAnswerRTxt";
            this.scalarAnswerRTxt.Size = new System.Drawing.Size(170, 20);
            this.scalarAnswerRTxt.TabIndex = 22;
            this.scalarAnswerRTxt.Text = "Scalar Answer";
            // 
            // vectorxAnswerTxt
            // 
            this.vectorxAnswerTxt.Location = new System.Drawing.Point(12, 203);
            this.vectorxAnswerTxt.Name = "vectorxAnswerTxt";
            this.vectorxAnswerTxt.Size = new System.Drawing.Size(39, 20);
            this.vectorxAnswerTxt.TabIndex = 23;
            // 
            // vectoryAnswerTxt
            // 
            this.vectoryAnswerTxt.Location = new System.Drawing.Point(57, 203);
            this.vectoryAnswerTxt.Name = "vectoryAnswerTxt";
            this.vectoryAnswerTxt.Size = new System.Drawing.Size(38, 20);
            this.vectoryAnswerTxt.TabIndex = 24;
            // 
            // vectorzAnswerTxt
            // 
            this.vectorzAnswerTxt.Location = new System.Drawing.Point(101, 203);
            this.vectorzAnswerTxt.Name = "vectorzAnswerTxt";
            this.vectorzAnswerTxt.Size = new System.Drawing.Size(38, 20);
            this.vectorzAnswerTxt.TabIndex = 25;
            // 
            // scalarAnswerTxt
            // 
            this.scalarAnswerTxt.Location = new System.Drawing.Point(12, 255);
            this.scalarAnswerTxt.Name = "scalarAnswerTxt";
            this.scalarAnswerTxt.Size = new System.Drawing.Size(83, 20);
            this.scalarAnswerTxt.TabIndex = 26;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(284, 270);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 27;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // clearEntriesBtn
            // 
            this.clearEntriesBtn.Location = new System.Drawing.Point(123, 270);
            this.clearEntriesBtn.Name = "clearEntriesBtn";
            this.clearEntriesBtn.Size = new System.Drawing.Size(75, 23);
            this.clearEntriesBtn.TabIndex = 28;
            this.clearEntriesBtn.Text = "Clear Entries";
            this.clearEntriesBtn.UseVisualStyleBackColor = true;
            this.clearEntriesBtn.Click += new System.EventHandler(this.clearEntriesBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Location = new System.Drawing.Point(204, 270);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(75, 23);
            this.clearAllBtn.TabIndex = 29;
            this.clearAllBtn.Text = "Clear All";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 305);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.clearEntriesBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.scalarAnswerTxt);
            this.Controls.Add(this.vectorzAnswerTxt);
            this.Controls.Add(this.vectoryAnswerTxt);
            this.Controls.Add(this.vectorxAnswerTxt);
            this.Controls.Add(this.scalarAnswerRTxt);
            this.Controls.Add(this.vectorAnswerRTxt);
            this.Controls.Add(this.unitRBtn);
            this.Controls.Add(this.magRBtn);
            this.Controls.Add(this.crossRBtn);
            this.Controls.Add(this.dotRBtn);
            this.Controls.Add(this.divScalarRBtn);
            this.Controls.Add(this.multScalarRBtn);
            this.Controls.Add(this.multVectorRBtn);
            this.Controls.Add(this.SubScalarRBtn);
            this.Controls.Add(this.subVectorRBtn);
            this.Controls.Add(this.addScalarRBtn);
            this.Controls.Add(this.scalarTxt);
            this.Controls.Add(this.scalarRTxt);
            this.Controls.Add(this.addVectorRad);
            this.Controls.Add(this.vector2zTxt);
            this.Controls.Add(this.vector2yTxt);
            this.Controls.Add(this.vector2xTxt);
            this.Controls.Add(this.vector1zTxt);
            this.Controls.Add(this.vector1yTxt);
            this.Controls.Add(this.vector1xTxt);
            this.Controls.Add(this.vector2RTxt);
            this.Controls.Add(this.vector1RTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox vector1RTxt;
        private System.Windows.Forms.RichTextBox vector2RTxt;
        private System.Windows.Forms.TextBox vector1xTxt;
        private System.Windows.Forms.TextBox vector1yTxt;
        private System.Windows.Forms.TextBox vector1zTxt;
        private System.Windows.Forms.TextBox vector2zTxt;
        private System.Windows.Forms.TextBox vector2yTxt;
        private System.Windows.Forms.TextBox vector2xTxt;
        private System.Windows.Forms.RadioButton addVectorRad;
        private System.Windows.Forms.RichTextBox scalarRTxt;
        private System.Windows.Forms.TextBox scalarTxt;
        private System.Windows.Forms.RadioButton addScalarRBtn;
        private System.Windows.Forms.RadioButton subVectorRBtn;
        private System.Windows.Forms.RadioButton SubScalarRBtn;
        private System.Windows.Forms.RadioButton multVectorRBtn;
        private System.Windows.Forms.RadioButton multScalarRBtn;
        private System.Windows.Forms.RadioButton divScalarRBtn;
        private System.Windows.Forms.RadioButton dotRBtn;
        private System.Windows.Forms.RadioButton crossRBtn;
        private System.Windows.Forms.RadioButton magRBtn;
        private System.Windows.Forms.RadioButton unitRBtn;
        private System.Windows.Forms.RichTextBox vectorAnswerRTxt;
        private System.Windows.Forms.RichTextBox scalarAnswerRTxt;
        private System.Windows.Forms.TextBox vectorxAnswerTxt;
        private System.Windows.Forms.TextBox vectoryAnswerTxt;
        private System.Windows.Forms.TextBox vectorzAnswerTxt;
        private System.Windows.Forms.TextBox scalarAnswerTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearEntriesBtn;
        private System.Windows.Forms.Button clearAllBtn;
    }
}

