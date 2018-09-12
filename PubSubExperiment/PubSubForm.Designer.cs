namespace PubSubExperiment
{
    partial class frmPubSub
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
            this.btnCreatePolicy = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCreateAltPolicy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatePolicy
            // 
            this.btnCreatePolicy.Location = new System.Drawing.Point(92, 121);
            this.btnCreatePolicy.Name = "btnCreatePolicy";
            this.btnCreatePolicy.Size = new System.Drawing.Size(121, 23);
            this.btnCreatePolicy.TabIndex = 0;
            this.btnCreatePolicy.Text = "Create Policy";
            this.btnCreatePolicy.UseVisualStyleBackColor = true;
            this.btnCreatePolicy.Click += new System.EventHandler(this.btnCreatePolicy_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(92, 41);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(121, 23);
            this.btnSubscribe.TabIndex = 1;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(92, 81);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(121, 23);
            this.btnUnsubscribe.TabIndex = 2;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnCreateAltPolicy
            // 
            this.btnCreateAltPolicy.Location = new System.Drawing.Point(92, 162);
            this.btnCreateAltPolicy.Name = "btnCreateAltPolicy";
            this.btnCreateAltPolicy.Size = new System.Drawing.Size(121, 23);
            this.btnCreateAltPolicy.TabIndex = 3;
            this.btnCreateAltPolicy.Text = "Create Alt. Policy";
            this.btnCreateAltPolicy.UseVisualStyleBackColor = true;
            this.btnCreateAltPolicy.Click += new System.EventHandler(this.btnCreateAltPolicy_Click);
            // 
            // frmPubSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 209);
            this.Controls.Add(this.btnCreateAltPolicy);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.btnCreatePolicy);
            this.Name = "frmPubSub";
            this.Text = "PubSub Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePolicy;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnCreateAltPolicy;
    }
}

