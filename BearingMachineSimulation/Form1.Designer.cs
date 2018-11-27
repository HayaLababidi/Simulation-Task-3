namespace BearingMachineSimulation
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_input = new System.Windows.Forms.TabPage();
            this.tabPage_Current = new System.Windows.Forms.TabPage();
            this.tabPage_Proposed = new System.Windows.Forms.TabPage();
            this.GrdView_bearings = new System.Windows.Forms.DataGridView();
            this.GrdView_delay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_repairperson = new System.Windows.Forms.Label();
            this.lbl_bearing = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_downtime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_single = new System.Windows.Forms.Label();
            this.lbl_AllB = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_bearings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_delay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_input);
            this.tabControl.Controls.Add(this.tabPage_Current);
            this.tabControl.Controls.Add(this.tabPage_Proposed);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 478);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_input
            // 
            this.tabPage_input.Controls.Add(this.label14);
            this.tabPage_input.Controls.Add(this.label13);
            this.tabPage_input.Controls.Add(this.lbl_AllB);
            this.tabPage_input.Controls.Add(this.lbl_single);
            this.tabPage_input.Controls.Add(this.label10);
            this.tabPage_input.Controls.Add(this.label7);
            this.tabPage_input.Controls.Add(this.label6);
            this.tabPage_input.Controls.Add(this.lbl_downtime);
            this.tabPage_input.Controls.Add(this.label9);
            this.tabPage_input.Controls.Add(this.label8);
            this.tabPage_input.Controls.Add(this.lbl_bearing);
            this.tabPage_input.Controls.Add(this.lbl_repairperson);
            this.tabPage_input.Controls.Add(this.label5);
            this.tabPage_input.Controls.Add(this.label4);
            this.tabPage_input.Controls.Add(this.label3);
            this.tabPage_input.Controls.Add(this.label2);
            this.tabPage_input.Controls.Add(this.label1);
            this.tabPage_input.Controls.Add(this.GrdView_delay);
            this.tabPage_input.Controls.Add(this.GrdView_bearings);
            this.tabPage_input.Location = new System.Drawing.Point(4, 22);
            this.tabPage_input.Name = "tabPage_input";
            this.tabPage_input.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_input.Size = new System.Drawing.Size(780, 452);
            this.tabPage_input.TabIndex = 0;
            this.tabPage_input.Text = "current test case";
            this.tabPage_input.UseVisualStyleBackColor = true;
            this.tabPage_input.Click += new System.EventHandler(this.tabPageinput_Click);
            // 
            // tabPage_Current
            // 
            this.tabPage_Current.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Current.Name = "tabPage_Current";
            this.tabPage_Current.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Current.Size = new System.Drawing.Size(780, 412);
            this.tabPage_Current.TabIndex = 1;
            this.tabPage_Current.Text = "Current policy simulation ";
            this.tabPage_Current.UseVisualStyleBackColor = true;
            // 
            // tabPage_Proposed
            // 
            this.tabPage_Proposed.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Proposed.Name = "tabPage_Proposed";
            this.tabPage_Proposed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Proposed.Size = new System.Drawing.Size(780, 412);
            this.tabPage_Proposed.TabIndex = 2;
            this.tabPage_Proposed.Text = "Proposed Policy simulation";
            this.tabPage_Proposed.UseVisualStyleBackColor = true;
            // 
            // GrdView_bearings
            // 
            this.GrdView_bearings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_bearings.Location = new System.Drawing.Point(372, 52);
            this.GrdView_bearings.Name = "GrdView_bearings";
            this.GrdView_bearings.Size = new System.Drawing.Size(405, 150);
            this.GrdView_bearings.TabIndex = 0;
            // 
            // GrdView_delay
            // 
            this.GrdView_delay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_delay.Location = new System.Drawing.Point(372, 233);
            this.GrdView_delay.Name = "GrdView_delay";
            this.GrdView_delay.Size = new System.Drawing.Size(412, 150);
            this.GrdView_delay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Costs :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mill Downtime cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repairperson cost  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bearing cost :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "per minute";
            // 
            // lbl_repairperson
            // 
            this.lbl_repairperson.AutoSize = true;
            this.lbl_repairperson.Location = new System.Drawing.Point(123, 90);
            this.lbl_repairperson.Name = "lbl_repairperson";
            this.lbl_repairperson.Size = new System.Drawing.Size(35, 13);
            this.lbl_repairperson.TabIndex = 7;
            this.lbl_repairperson.Text = "label6";
            this.lbl_repairperson.Visible = false;
            // 
            // lbl_bearing
            // 
            this.lbl_bearing.AutoSize = true;
            this.lbl_bearing.Location = new System.Drawing.Point(123, 110);
            this.lbl_bearing.Name = "lbl_bearing";
            this.lbl_bearing.Size = new System.Drawing.Size(35, 13);
            this.lbl_bearing.TabIndex = 8;
            this.lbl_bearing.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "per minute";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "per minute";
            // 
            // lbl_downtime
            // 
            this.lbl_downtime.AutoSize = true;
            this.lbl_downtime.Location = new System.Drawing.Point(123, 70);
            this.lbl_downtime.Name = "lbl_downtime";
            this.lbl_downtime.Size = new System.Drawing.Size(41, 13);
            this.lbl_downtime.TabIndex = 11;
            this.lbl_downtime.Text = "label10";
            this.lbl_downtime.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Repair time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Single baring";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "All bearings";
            // 
            // lbl_single
            // 
            this.lbl_single.AutoSize = true;
            this.lbl_single.Location = new System.Drawing.Point(123, 180);
            this.lbl_single.Name = "lbl_single";
            this.lbl_single.Size = new System.Drawing.Size(41, 13);
            this.lbl_single.TabIndex = 15;
            this.lbl_single.Text = "label11";
            this.lbl_single.Visible = false;
            // 
            // lbl_AllB
            // 
            this.lbl_AllB.AutoSize = true;
            this.lbl_AllB.Location = new System.Drawing.Point(123, 200);
            this.lbl_AllB.Name = "lbl_AllB";
            this.lbl_AllB.Size = new System.Drawing.Size(41, 13);
            this.lbl_AllB.TabIndex = 16;
            this.lbl_AllB.Text = "label12";
            this.lbl_AllB.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Minutes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Minutes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 479);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_input.ResumeLayout(false);
            this.tabPage_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_bearings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_delay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_input;
        private System.Windows.Forms.TabPage tabPage_Current;
        private System.Windows.Forms.TabPage tabPage_Proposed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdView_delay;
        private System.Windows.Forms.DataGridView GrdView_bearings;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_AllB;
        private System.Windows.Forms.Label lbl_single;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_downtime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_bearing;
        private System.Windows.Forms.Label lbl_repairperson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}