
namespace Assignment1Project2
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
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtYesNo = new System.Windows.Forms.TextBox();
            this.txtRetry = new System.Windows.Forms.TextBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.lblYesNo = new System.Windows.Forms.Label();
            this.lblRetryCancel = new System.Windows.Forms.Label();
            this.btnErrorMsg = new System.Windows.Forms.Button();
            this.btnYesNo = new System.Windows.Forms.Button();
            this.btnRetryCancel = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(261, 59);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(143, 20);
            this.txtError.TabIndex = 0;
            // 
            // txtYesNo
            // 
            this.txtYesNo.Location = new System.Drawing.Point(295, 88);
            this.txtYesNo.Name = "txtYesNo";
            this.txtYesNo.Size = new System.Drawing.Size(109, 20);
            this.txtYesNo.TabIndex = 1;
            // 
            // txtRetry
            // 
            this.txtRetry.Location = new System.Drawing.Point(304, 117);
            this.txtRetry.Name = "txtRetry";
            this.txtRetry.Size = new System.Drawing.Size(100, 20);
            this.txtRetry.TabIndex = 2;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Location = new System.Drawing.Point(46, 66);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(209, 13);
            this.lblErr.TabIndex = 3;
            this.lblErr.Text = "This will pop an error box, enter your name:";
            // 
            // lblYesNo
            // 
            this.lblYesNo.AutoSize = true;
            this.lblYesNo.Location = new System.Drawing.Point(46, 95);
            this.lblYesNo.Name = "lblYesNo";
            this.lblYesNo.Size = new System.Drawing.Size(243, 13);
            this.lblYesNo.TabIndex = 4;
            this.lblYesNo.Text = "This will give you yes or no options, enter your job:";
            // 
            // lblRetryCancel
            // 
            this.lblRetryCancel.AutoSize = true;
            this.lblRetryCancel.Location = new System.Drawing.Point(46, 124);
            this.lblRetryCancel.Name = "lblRetryCancel";
            this.lblRetryCancel.Size = new System.Drawing.Size(252, 13);
            this.lblRetryCancel.TabIndex = 5;
            this.lblRetryCancel.Text = "This will let you retry or cancel, enter your password:";
            // 
            // btnErrorMsg
            // 
            this.btnErrorMsg.Location = new System.Drawing.Point(437, 57);
            this.btnErrorMsg.Name = "btnErrorMsg";
            this.btnErrorMsg.Size = new System.Drawing.Size(75, 23);
            this.btnErrorMsg.TabIndex = 6;
            this.btnErrorMsg.Text = "Error!";
            this.btnErrorMsg.UseVisualStyleBackColor = true;
            this.btnErrorMsg.Click += new System.EventHandler(this.btnErrorMsg_Click);
            // 
            // btnYesNo
            // 
            this.btnYesNo.Location = new System.Drawing.Point(437, 90);
            this.btnYesNo.Name = "btnYesNo";
            this.btnYesNo.Size = new System.Drawing.Size(75, 23);
            this.btnYesNo.TabIndex = 7;
            this.btnYesNo.Text = "Y/N";
            this.btnYesNo.UseVisualStyleBackColor = true;
            this.btnYesNo.Click += new System.EventHandler(this.btnYesNo_Click);
            // 
            // btnRetryCancel
            // 
            this.btnRetryCancel.Location = new System.Drawing.Point(437, 119);
            this.btnRetryCancel.Name = "btnRetryCancel";
            this.btnRetryCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRetryCancel.TabIndex = 8;
            this.btnRetryCancel.Text = "Retry";
            this.btnRetryCancel.UseVisualStyleBackColor = true;
            this.btnRetryCancel.Click += new System.EventHandler(this.btnRetryCancel_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(87, 216);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(607, 382);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRetryCancel);
            this.Controls.Add(this.btnYesNo);
            this.Controls.Add(this.btnErrorMsg);
            this.Controls.Add(this.lblRetryCancel);
            this.Controls.Add(this.lblYesNo);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.txtRetry);
            this.Controls.Add(this.txtYesNo);
            this.Controls.Add(this.txtError);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtYesNo;
        private System.Windows.Forms.TextBox txtRetry;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Label lblYesNo;
        private System.Windows.Forms.Label lblRetryCancel;
        private System.Windows.Forms.Button btnErrorMsg;
        private System.Windows.Forms.Button btnYesNo;
        private System.Windows.Forms.Button btnRetryCancel;
        private System.Windows.Forms.Label lblResult;
    }
}

