namespace Prog2
{
    partial class LetterForm
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
            this.originAddressCB = new System.Windows.Forms.ComboBox();
            this.destinationAddCB = new System.Windows.Forms.ComboBox();
            this.originAddLabel = new System.Windows.Forms.Label();
            this.destinationAddLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // originAddressCB
            // 
            this.originAddressCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originAddressCB.FormattingEnabled = true;
            this.originAddressCB.Location = new System.Drawing.Point(137, 58);
            this.originAddressCB.Name = "originAddressCB";
            this.originAddressCB.Size = new System.Drawing.Size(121, 21);
            this.originAddressCB.TabIndex = 1;
            this.originAddressCB.Validating += new System.ComponentModel.CancelEventHandler(this.originAddressCB_Validating);
            this.originAddressCB.Validated += new System.EventHandler(this.originAddressCB_Validated);
            // 
            // destinationAddCB
            // 
            this.destinationAddCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationAddCB.FormattingEnabled = true;
            this.destinationAddCB.Location = new System.Drawing.Point(137, 108);
            this.destinationAddCB.Name = "destinationAddCB";
            this.destinationAddCB.Size = new System.Drawing.Size(121, 21);
            this.destinationAddCB.TabIndex = 3;
            this.destinationAddCB.Validating += new System.ComponentModel.CancelEventHandler(this.destAddCB_Validating);
            this.destinationAddCB.Validated += new System.EventHandler(this.destAddCB_Validated);
            // 
            // originAddLabel
            // 
            this.originAddLabel.AutoSize = true;
            this.originAddLabel.Location = new System.Drawing.Point(47, 61);
            this.originAddLabel.Name = "originAddLabel";
            this.originAddLabel.Size = new System.Drawing.Size(78, 13);
            this.originAddLabel.TabIndex = 0;
            this.originAddLabel.Text = "Origin Address:";
            // 
            // destinationAddLabel
            // 
            this.destinationAddLabel.AutoSize = true;
            this.destinationAddLabel.Location = new System.Drawing.Point(21, 111);
            this.destinationAddLabel.Name = "destinationAddLabel";
            this.destinationAddLabel.Size = new System.Drawing.Size(104, 13);
            this.destinationAddLabel.TabIndex = 2;
            this.destinationAddLabel.Text = "Destination Address:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(38, 204);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(171, 204);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(66, 156);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(59, 13);
            this.fixedCostLabel.TabIndex = 4;
            this.fixedCostLabel.Text = "Fixed Cost:";
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.Location = new System.Drawing.Point(137, 153);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(121, 20);
            this.fixedCostTextBox.TabIndex = 5;
            this.fixedCostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTextBox_Validating);
            this.fixedCostTextBox.Validated += new System.EventHandler(this.fixedCostTextBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.destinationAddLabel);
            this.Controls.Add(this.originAddLabel);
            this.Controls.Add(this.destinationAddCB);
            this.Controls.Add(this.originAddressCB);
            this.Name = "LetterForm";
            this.Text = "                                    ";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox originAddressCB;
        private System.Windows.Forms.ComboBox destinationAddCB;
        private System.Windows.Forms.Label originAddLabel;
        private System.Windows.Forms.Label destinationAddLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label fixedCostLabel;
        private System.Windows.Forms.TextBox fixedCostTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}