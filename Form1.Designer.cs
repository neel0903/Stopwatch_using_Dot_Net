namespace stopwatch
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
            this.components = new System.ComponentModel.Container();
            this.Timers = new System.Windows.Forms.Timer(this.components);
            this.txth = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.labelhour = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.Label();
            this.Btnstart = new System.Windows.Forms.Button();
            this.Btnstop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timers
            // 
            this.Timers.Interval = 2;
            this.Timers.Tick += new System.EventHandler(this.Timers_Tick);
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(477, 438);
            this.txth.Multiline = true;
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(200, 116);
            this.txth.TabIndex = 0;
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(1277, 438);
            this.txts.Multiline = true;
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(179, 116);
            this.txts.TabIndex = 1;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(914, 438);
            this.txtm.Multiline = true;
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(190, 116);
            this.txtm.TabIndex = 2;
            // 
            // labelhour
            // 
            this.labelhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhour.Location = new System.Drawing.Point(464, 273);
            this.labelhour.Name = "labelhour";
            this.labelhour.Size = new System.Drawing.Size(236, 79);
            this.labelhour.TabIndex = 3;
            this.labelhour.Text = "Hour";
            this.labelhour.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelm
            // 
            this.labelm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelm.Location = new System.Drawing.Point(821, 268);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(268, 86);
            this.labelm.TabIndex = 4;
            this.labelm.Text = "Minute";
            // 
            // labels
            // 
            this.labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels.Location = new System.Drawing.Point(1271, 237);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(304, 79);
            this.labels.TabIndex = 5;
            this.labels.Text = "Second";
            // 
            // Btnstart
            // 
            this.Btnstart.Location = new System.Drawing.Point(552, 731);
            this.Btnstart.Name = "Btnstart";
            this.Btnstart.Size = new System.Drawing.Size(224, 105);
            this.Btnstart.TabIndex = 6;
            this.Btnstart.Text = "Start";
            this.Btnstart.UseVisualStyleBackColor = true;
            this.Btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // Btnstop
            // 
            this.Btnstop.Location = new System.Drawing.Point(914, 731);
            this.Btnstop.Name = "Btnstop";
            this.Btnstop.Size = new System.Drawing.Size(215, 105);
            this.Btnstop.TabIndex = 7;
            this.Btnstop.Text = "Reset";
            this.Btnstop.UseVisualStyleBackColor = true;
            this.Btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1283, 721);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 105);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 1099);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btnstop);
            this.Controls.Add(this.Btnstart);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.labelm);
            this.Controls.Add(this.labelhour);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timers;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label labelhour;
        private System.Windows.Forms.Label labelm;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.Button Btnstart;
        private System.Windows.Forms.Button Btnstop;
        private System.Windows.Forms.Button button1;
    }
}

