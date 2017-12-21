namespace Assessment10B
{
    partial class WorkingWithDataIIForm
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
            this.richTxtBoxUserInput = new System.Windows.Forms.RichTextBox();
            this.txtBoxWordToReplace = new System.Windows.Forms.TextBox();
            this.txtBoxWordToFind = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.listBoxStartingPositions = new System.Windows.Forms.ListBox();
            this.lblNumberOfMatches = new System.Windows.Forms.Label();
            this.checkBoxLength = new System.Windows.Forms.CheckBox();
            this.txtBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.checkBoxLowerCase = new System.Windows.Forms.CheckBox();
            this.checkBoxUpperCase = new System.Windows.Forms.CheckBox();
            this.checkBoxHasNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecialCarachter = new System.Windows.Forms.CheckBox();
            this.lblTextInputPrompt = new System.Windows.Forms.Label();
            this.lblIndexesListBoxPrompt = new System.Windows.Forms.Label();
            this.lblNumberOfMatchesPrompt = new System.Windows.Forms.Label();
            this.lblPasswordPrompt = new System.Windows.Forms.Label();
            this.lblTextReplacementPrompt = new System.Windows.Forms.Label();
            this.lblWordToSearchPrompt = new System.Windows.Forms.Label();
            this.lblPasswordFuturePrompt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTxtBoxUserInput
            // 
            this.richTxtBoxUserInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxUserInput.Location = new System.Drawing.Point(23, 46);
            this.richTxtBoxUserInput.Name = "richTxtBoxUserInput";
            this.richTxtBoxUserInput.Size = new System.Drawing.Size(410, 163);
            this.richTxtBoxUserInput.TabIndex = 1;
            this.richTxtBoxUserInput.Text = "";
            // 
            // txtBoxWordToReplace
            // 
            this.txtBoxWordToReplace.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWordToReplace.Location = new System.Drawing.Point(619, 118);
            this.txtBoxWordToReplace.Name = "txtBoxWordToReplace";
            this.txtBoxWordToReplace.Size = new System.Drawing.Size(131, 27);
            this.txtBoxWordToReplace.TabIndex = 2;
            // 
            // txtBoxWordToFind
            // 
            this.txtBoxWordToFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWordToFind.Location = new System.Drawing.Point(619, 69);
            this.txtBoxWordToFind.Name = "txtBoxWordToFind";
            this.txtBoxWordToFind.Size = new System.Drawing.Size(131, 27);
            this.txtBoxWordToFind.TabIndex = 3;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.Firebrick;
            this.btnActivate.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.Location = new System.Drawing.Point(561, 167);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(121, 42);
            this.btnActivate.TabIndex = 4;
            this.btnActivate.Text = "Start";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // listBoxStartingPositions
            // 
            this.listBoxStartingPositions.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStartingPositions.FormattingEnabled = true;
            this.listBoxStartingPositions.ItemHeight = 17;
            this.listBoxStartingPositions.Location = new System.Drawing.Point(932, 35);
            this.listBoxStartingPositions.Name = "listBoxStartingPositions";
            this.listBoxStartingPositions.Size = new System.Drawing.Size(178, 157);
            this.listBoxStartingPositions.TabIndex = 5;
            // 
            // lblNumberOfMatches
            // 
            this.lblNumberOfMatches.BackColor = System.Drawing.Color.White;
            this.lblNumberOfMatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberOfMatches.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMatches.Location = new System.Drawing.Point(798, 118);
            this.lblNumberOfMatches.Name = "lblNumberOfMatches";
            this.lblNumberOfMatches.Size = new System.Drawing.Size(121, 23);
            this.lblNumberOfMatches.TabIndex = 6;
            this.lblNumberOfMatches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxLength
            // 
            this.checkBoxLength.AutoCheck = false;
            this.checkBoxLength.AutoSize = true;
            this.checkBoxLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxLength.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLength.Location = new System.Drawing.Point(404, 311);
            this.checkBoxLength.Name = "checkBoxLength";
            this.checkBoxLength.Size = new System.Drawing.Size(190, 19);
            this.checkBoxLength.TabIndex = 7;
            this.checkBoxLength.Text = "at least 8 characters length";
            this.checkBoxLength.UseVisualStyleBackColor = true;
            // 
            // txtBoxPasswordInput
            // 
            this.txtBoxPasswordInput.BackColor = System.Drawing.Color.Red;
            this.txtBoxPasswordInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPasswordInput.ForeColor = System.Drawing.Color.White;
            this.txtBoxPasswordInput.Location = new System.Drawing.Point(192, 357);
            this.txtBoxPasswordInput.Name = "txtBoxPasswordInput";
            this.txtBoxPasswordInput.Size = new System.Drawing.Size(155, 27);
            this.txtBoxPasswordInput.TabIndex = 8;
            this.txtBoxPasswordInput.TextChanged += new System.EventHandler(this.txtBoxPasswordInput_TextChanged);
            // 
            // checkBoxSpace
            // 
            this.checkBoxSpace.AutoCheck = false;
            this.checkBoxSpace.AutoSize = true;
            this.checkBoxSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxSpace.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpace.Location = new System.Drawing.Point(404, 403);
            this.checkBoxSpace.Name = "checkBoxSpace";
            this.checkBoxSpace.Size = new System.Drawing.Size(219, 19);
            this.checkBoxSpace.TabIndex = 9;
            this.checkBoxSpace.Text = "has at least one space character";
            this.checkBoxSpace.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowerCase
            // 
            this.checkBoxLowerCase.AutoCheck = false;
            this.checkBoxLowerCase.AutoSize = true;
            this.checkBoxLowerCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxLowerCase.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLowerCase.Location = new System.Drawing.Point(404, 380);
            this.checkBoxLowerCase.Name = "checkBoxLowerCase";
            this.checkBoxLowerCase.Size = new System.Drawing.Size(249, 19);
            this.checkBoxLowerCase.TabIndex = 10;
            this.checkBoxLowerCase.Text = "has at least one lower case character";
            this.checkBoxLowerCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperCase
            // 
            this.checkBoxUpperCase.AutoCheck = false;
            this.checkBoxUpperCase.AutoSize = true;
            this.checkBoxUpperCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxUpperCase.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUpperCase.Location = new System.Drawing.Point(404, 357);
            this.checkBoxUpperCase.Name = "checkBoxUpperCase";
            this.checkBoxUpperCase.Size = new System.Drawing.Size(251, 19);
            this.checkBoxUpperCase.TabIndex = 11;
            this.checkBoxUpperCase.Text = "has at least one upper case character";
            this.checkBoxUpperCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasNumber
            // 
            this.checkBoxHasNumber.AutoCheck = false;
            this.checkBoxHasNumber.AutoSize = true;
            this.checkBoxHasNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxHasNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHasNumber.Location = new System.Drawing.Point(404, 334);
            this.checkBoxHasNumber.Name = "checkBoxHasNumber";
            this.checkBoxHasNumber.Size = new System.Drawing.Size(173, 19);
            this.checkBoxHasNumber.TabIndex = 12;
            this.checkBoxHasNumber.Text = "has at least one number";
            this.checkBoxHasNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecialCarachter
            // 
            this.checkBoxSpecialCarachter.AutoCheck = false;
            this.checkBoxSpecialCarachter.AutoSize = true;
            this.checkBoxSpecialCarachter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxSpecialCarachter.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpecialCarachter.Location = new System.Drawing.Point(404, 426);
            this.checkBoxSpecialCarachter.Name = "checkBoxSpecialCarachter";
            this.checkBoxSpecialCarachter.Size = new System.Drawing.Size(227, 19);
            this.checkBoxSpecialCarachter.TabIndex = 13;
            this.checkBoxSpecialCarachter.Text = "has at least one special carachter";
            this.checkBoxSpecialCarachter.UseVisualStyleBackColor = true;
            // 
            // lblTextInputPrompt
            // 
            this.lblTextInputPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextInputPrompt.Location = new System.Drawing.Point(144, 12);
            this.lblTextInputPrompt.Name = "lblTextInputPrompt";
            this.lblTextInputPrompt.Size = new System.Drawing.Size(117, 23);
            this.lblTextInputPrompt.TabIndex = 14;
            this.lblTextInputPrompt.Text = "Place your text here";
            this.lblTextInputPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndexesListBoxPrompt
            // 
            this.lblIndexesListBoxPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexesListBoxPrompt.Location = new System.Drawing.Point(932, 12);
            this.lblIndexesListBoxPrompt.Name = "lblIndexesListBoxPrompt";
            this.lblIndexesListBoxPrompt.Size = new System.Drawing.Size(178, 23);
            this.lblIndexesListBoxPrompt.TabIndex = 15;
            this.lblIndexesListBoxPrompt.Text = "Indexes for each match found";
            this.lblIndexesListBoxPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfMatchesPrompt
            // 
            this.lblNumberOfMatchesPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMatchesPrompt.Location = new System.Drawing.Point(795, 69);
            this.lblNumberOfMatchesPrompt.Name = "lblNumberOfMatchesPrompt";
            this.lblNumberOfMatchesPrompt.Size = new System.Drawing.Size(124, 35);
            this.lblNumberOfMatchesPrompt.TabIndex = 16;
            this.lblNumberOfMatchesPrompt.Text = "Number of matches";
            this.lblNumberOfMatchesPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordPrompt
            // 
            this.lblPasswordPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordPrompt.Location = new System.Drawing.Point(35, 359);
            this.lblPasswordPrompt.Name = "lblPasswordPrompt";
            this.lblPasswordPrompt.Size = new System.Drawing.Size(151, 23);
            this.lblPasswordPrompt.TabIndex = 17;
            this.lblPasswordPrompt.Text = "Type in your password here";
            this.lblPasswordPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextReplacementPrompt
            // 
            this.lblTextReplacementPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextReplacementPrompt.Location = new System.Drawing.Point(478, 120);
            this.lblTextReplacementPrompt.Name = "lblTextReplacementPrompt";
            this.lblTextReplacementPrompt.Size = new System.Drawing.Size(117, 23);
            this.lblTextReplacementPrompt.TabIndex = 18;
            this.lblTextReplacementPrompt.Text = "Replace with";
            this.lblTextReplacementPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWordToSearchPrompt
            // 
            this.lblWordToSearchPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToSearchPrompt.Location = new System.Drawing.Point(478, 69);
            this.lblWordToSearchPrompt.Name = "lblWordToSearchPrompt";
            this.lblWordToSearchPrompt.Size = new System.Drawing.Size(117, 23);
            this.lblWordToSearchPrompt.TabIndex = 19;
            this.lblWordToSearchPrompt.Text = "Text to look for";
            this.lblWordToSearchPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordFuturePrompt
            // 
            this.lblPasswordFuturePrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordFuturePrompt.Location = new System.Drawing.Point(143, 256);
            this.lblPasswordFuturePrompt.Name = "lblPasswordFuturePrompt";
            this.lblPasswordFuturePrompt.Size = new System.Drawing.Size(488, 23);
            this.lblPasswordFuturePrompt.TabIndex = 20;
            this.lblPasswordFuturePrompt.Text = "PASSWORD FUTURE";
            this.lblPasswordFuturePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(948, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 42);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(784, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 42);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1002, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "© Ahmed Matoussi";
            // 
            // WorkingWithDataIIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1133, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPasswordFuturePrompt);
            this.Controls.Add(this.lblWordToSearchPrompt);
            this.Controls.Add(this.lblTextReplacementPrompt);
            this.Controls.Add(this.lblPasswordPrompt);
            this.Controls.Add(this.lblNumberOfMatchesPrompt);
            this.Controls.Add(this.lblIndexesListBoxPrompt);
            this.Controls.Add(this.lblTextInputPrompt);
            this.Controls.Add(this.checkBoxSpecialCarachter);
            this.Controls.Add(this.checkBoxHasNumber);
            this.Controls.Add(this.checkBoxUpperCase);
            this.Controls.Add(this.checkBoxLowerCase);
            this.Controls.Add(this.checkBoxSpace);
            this.Controls.Add(this.txtBoxPasswordInput);
            this.Controls.Add(this.checkBoxLength);
            this.Controls.Add(this.lblNumberOfMatches);
            this.Controls.Add(this.listBoxStartingPositions);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.txtBoxWordToFind);
            this.Controls.Add(this.txtBoxWordToReplace);
            this.Controls.Add(this.richTxtBoxUserInput);
            this.Name = "WorkingWithDataIIForm";
            this.Text = "Working with data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBoxUserInput;
        private System.Windows.Forms.TextBox txtBoxWordToReplace;
        private System.Windows.Forms.TextBox txtBoxWordToFind;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.ListBox listBoxStartingPositions;
        private System.Windows.Forms.Label lblNumberOfMatches;
        private System.Windows.Forms.CheckBox checkBoxLength;
        private System.Windows.Forms.TextBox txtBoxPasswordInput;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.CheckBox checkBoxLowerCase;
        private System.Windows.Forms.CheckBox checkBoxUpperCase;
        private System.Windows.Forms.CheckBox checkBoxHasNumber;
        private System.Windows.Forms.CheckBox checkBoxSpecialCarachter;
        private System.Windows.Forms.Label lblTextInputPrompt;
        private System.Windows.Forms.Label lblIndexesListBoxPrompt;
        private System.Windows.Forms.Label lblNumberOfMatchesPrompt;
        private System.Windows.Forms.Label lblPasswordPrompt;
        private System.Windows.Forms.Label lblTextReplacementPrompt;
        private System.Windows.Forms.Label lblWordToSearchPrompt;
        private System.Windows.Forms.Label lblPasswordFuturePrompt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
    }
}

