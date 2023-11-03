namespace zein
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalcu = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtbouns = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.txtsalaryafter = new System.Windows.Forms.TextBox();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(45)))), ((int)(((byte)(6)))));
            resources.ApplyResources(this.btnexit, "btnexit");
            this.btnexit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexit.Name = "btnexit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            resources.ApplyResources(this.btnclear, "btnclear");
            this.btnclear.Name = "btnclear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalcu
            // 
            this.btncalcu.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.btncalcu, "btncalcu");
            this.btncalcu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalcu.Name = "btncalcu";
            this.btncalcu.UseVisualStyleBackColor = false;
            this.btncalcu.Click += new System.EventHandler(this.btncalcu_Click);
            // 
            // txtname
            // 
            resources.ApplyResources(this.txtname, "txtname");
            this.txtname.Name = "txtname";
            // 
            // txttotal
            // 
            resources.ApplyResources(this.txttotal, "txttotal");
            this.txttotal.Name = "txttotal";
            // 
            // txtrate
            // 
            resources.ApplyResources(this.txtrate, "txtrate");
            this.txtrate.Name = "txtrate";
            // 
            // txtdiscount
            // 
            resources.ApplyResources(this.txtdiscount, "txtdiscount");
            this.txtdiscount.Name = "txtdiscount";
            // 
            // txtbouns
            // 
            resources.ApplyResources(this.txtbouns, "txtbouns");
            this.txtbouns.Name = "txtbouns";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtsalary
            // 
            resources.ApplyResources(this.txtsalary, "txtsalary");
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.ReadOnly = true;
            // 
            // txtvalue
            // 
            resources.ApplyResources(this.txtvalue, "txtvalue");
            this.txtvalue.Name = "txtvalue";
            // 
            // txtsalaryafter
            // 
            resources.ApplyResources(this.txtsalaryafter, "txtsalaryafter");
            this.txtsalaryafter.Name = "txtsalaryafter";
            // 
            // txtnet
            // 
            resources.ApplyResources(this.txtnet, "txtnet");
            this.txtnet.Name = "txtnet";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.txtnet);
            this.Controls.Add(this.txtsalaryafter);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbouns);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btncalcu);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalcu;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtbouns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.TextBox txtsalaryafter;
        private System.Windows.Forms.TextBox txtnet;
    }
}

