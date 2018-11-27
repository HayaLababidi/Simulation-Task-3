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
            this.lbl_NoHours = new System.Windows.Forms.Label();
            this.lbl_NoBearings = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bttn_startsim = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_AllB = new System.Windows.Forms.Label();
            this.lbl_single = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_downtime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_bearing = new System.Windows.Forms.Label();
            this.lbl_repairperson = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdView_delay = new System.Windows.Forms.DataGridView();
            this.GrdView_bearings = new System.Windows.Forms.DataGridView();
            this.tabPage_Current = new System.Windows.Forms.TabPage();
            this.GrdView_CPerformanceMeasures = new System.Windows.Forms.DataGridView();
            this.lbl_Cdelay = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GrdView_currenttable = new System.Windows.Forms.DataGridView();
            this.tabPage_Proposed = new System.Windows.Forms.TabPage();
            this.GrdView_PPerformancemeasures = new System.Windows.Forms.DataGridView();
            this.lbl_Pdelay = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GrdView_Prposedtable = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_bearings)).BeginInit();
            this.tabPage_Current.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_CPerformanceMeasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_currenttable)).BeginInit();
            this.tabPage_Proposed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_PPerformancemeasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_Prposedtable)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(836, 478);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_input
            // 
            this.tabPage_input.Controls.Add(this.lbl_NoHours);
            this.tabPage_input.Controls.Add(this.lbl_NoBearings);
            this.tabPage_input.Controls.Add(this.label17);
            this.tabPage_input.Controls.Add(this.label18);
            this.tabPage_input.Controls.Add(this.comboBox1);
            this.tabPage_input.Controls.Add(this.bttn_startsim);
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
            this.tabPage_input.Size = new System.Drawing.Size(828, 452);
            this.tabPage_input.TabIndex = 0;
            this.tabPage_input.Text = "current test case";
            this.tabPage_input.UseVisualStyleBackColor = true;
            this.tabPage_input.Click += new System.EventHandler(this.tabPageinput_Click);
            // 
            // lbl_NoHours
            // 
            this.lbl_NoHours.AutoSize = true;
            this.lbl_NoHours.Location = new System.Drawing.Point(119, 90);
            this.lbl_NoHours.Name = "lbl_NoHours";
            this.lbl_NoHours.Size = new System.Drawing.Size(41, 13);
            this.lbl_NoHours.TabIndex = 24;
            this.lbl_NoHours.Text = "label10";
            this.lbl_NoHours.Visible = false;
            // 
            // lbl_NoBearings
            // 
            this.lbl_NoBearings.AutoSize = true;
            this.lbl_NoBearings.Location = new System.Drawing.Point(119, 110);
            this.lbl_NoBearings.Name = "lbl_NoBearings";
            this.lbl_NoBearings.Size = new System.Drawing.Size(35, 13);
            this.lbl_NoBearings.TabIndex = 23;
            this.lbl_NoBearings.Text = "label6";
            this.lbl_NoBearings.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Number of Bearings:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Number of hours: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Test case 1 ",
            "Test case 2 ",
            "Test case 3 "});
            this.comboBox1.Location = new System.Drawing.Point(8, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bttn_startsim
            // 
            this.bttn_startsim.Location = new System.Drawing.Point(135, 36);
            this.bttn_startsim.Name = "bttn_startsim";
            this.bttn_startsim.Size = new System.Drawing.Size(75, 23);
            this.bttn_startsim.TabIndex = 19;
            this.bttn_startsim.Text = "Start";
            this.bttn_startsim.UseVisualStyleBackColor = true;
            this.bttn_startsim.Click += new System.EventHandler(this.bttn_startsim_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(176, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Minutes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Minutes";
            // 
            // lbl_AllB
            // 
            this.lbl_AllB.AutoSize = true;
            this.lbl_AllB.Location = new System.Drawing.Point(119, 294);
            this.lbl_AllB.Name = "lbl_AllB";
            this.lbl_AllB.Size = new System.Drawing.Size(41, 13);
            this.lbl_AllB.TabIndex = 16;
            this.lbl_AllB.Text = "label12";
            this.lbl_AllB.Visible = false;
            // 
            // lbl_single
            // 
            this.lbl_single.AutoSize = true;
            this.lbl_single.Location = new System.Drawing.Point(119, 274);
            this.lbl_single.Name = "lbl_single";
            this.lbl_single.Size = new System.Drawing.Size(41, 13);
            this.lbl_single.TabIndex = 15;
            this.lbl_single.Text = "label11";
            this.lbl_single.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "All bearings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Single baring";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Repair time:";
            // 
            // lbl_downtime
            // 
            this.lbl_downtime.AutoSize = true;
            this.lbl_downtime.Location = new System.Drawing.Point(119, 164);
            this.lbl_downtime.Name = "lbl_downtime";
            this.lbl_downtime.Size = new System.Drawing.Size(41, 13);
            this.lbl_downtime.TabIndex = 11;
            this.lbl_downtime.Text = "label10";
            this.lbl_downtime.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "per minute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "per minute";
            // 
            // lbl_bearing
            // 
            this.lbl_bearing.AutoSize = true;
            this.lbl_bearing.Location = new System.Drawing.Point(119, 204);
            this.lbl_bearing.Name = "lbl_bearing";
            this.lbl_bearing.Size = new System.Drawing.Size(35, 13);
            this.lbl_bearing.TabIndex = 8;
            this.lbl_bearing.Text = "label7";
            // 
            // lbl_repairperson
            // 
            this.lbl_repairperson.AutoSize = true;
            this.lbl_repairperson.Location = new System.Drawing.Point(119, 184);
            this.lbl_repairperson.Name = "lbl_repairperson";
            this.lbl_repairperson.Size = new System.Drawing.Size(35, 13);
            this.lbl_repairperson.TabIndex = 7;
            this.lbl_repairperson.Text = "label6";
            this.lbl_repairperson.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "per minute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bearing cost :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repairperson cost  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mill Downtime cost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Costs :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GrdView_delay
            // 
            this.GrdView_delay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_delay.Location = new System.Drawing.Point(264, 48);
            this.GrdView_delay.Name = "GrdView_delay";
            this.GrdView_delay.Size = new System.Drawing.Size(546, 150);
            this.GrdView_delay.TabIndex = 1;
            // 
            // GrdView_bearings
            // 
            this.GrdView_bearings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_bearings.Location = new System.Drawing.Point(264, 204);
            this.GrdView_bearings.Name = "GrdView_bearings";
            this.GrdView_bearings.Size = new System.Drawing.Size(546, 241);
            this.GrdView_bearings.TabIndex = 0;
            // 
            // tabPage_Current
            // 
            this.tabPage_Current.Controls.Add(this.GrdView_CPerformanceMeasures);
            this.tabPage_Current.Controls.Add(this.lbl_Cdelay);
            this.tabPage_Current.Controls.Add(this.label12);
            this.tabPage_Current.Controls.Add(this.GrdView_currenttable);
            this.tabPage_Current.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Current.Name = "tabPage_Current";
            this.tabPage_Current.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Current.Size = new System.Drawing.Size(828, 452);
            this.tabPage_Current.TabIndex = 1;
            this.tabPage_Current.Text = "Current policy simulation ";
            this.tabPage_Current.UseVisualStyleBackColor = true;
            this.tabPage_Current.Click += new System.EventHandler(this.tabPage_Current_Click);
            // 
            // GrdView_CPerformanceMeasures
            // 
            this.GrdView_CPerformanceMeasures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_CPerformanceMeasures.Location = new System.Drawing.Point(324, 20);
            this.GrdView_CPerformanceMeasures.Name = "GrdView_CPerformanceMeasures";
            this.GrdView_CPerformanceMeasures.Size = new System.Drawing.Size(498, 150);
            this.GrdView_CPerformanceMeasures.TabIndex = 5;
            // 
            // lbl_Cdelay
            // 
            this.lbl_Cdelay.AutoSize = true;
            this.lbl_Cdelay.Location = new System.Drawing.Point(98, 20);
            this.lbl_Cdelay.Name = "lbl_Cdelay";
            this.lbl_Cdelay.Size = new System.Drawing.Size(41, 13);
            this.lbl_Cdelay.TabIndex = 2;
            this.lbl_Cdelay.Text = "label15";
            this.lbl_Cdelay.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total delay time:";
            // 
            // GrdView_currenttable
            // 
            this.GrdView_currenttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_currenttable.Location = new System.Drawing.Point(8, 184);
            this.GrdView_currenttable.Name = "GrdView_currenttable";
            this.GrdView_currenttable.Size = new System.Drawing.Size(812, 261);
            this.GrdView_currenttable.TabIndex = 0;
            // 
            // tabPage_Proposed
            // 
            this.tabPage_Proposed.Controls.Add(this.GrdView_PPerformancemeasures);
            this.tabPage_Proposed.Controls.Add(this.lbl_Pdelay);
            this.tabPage_Proposed.Controls.Add(this.label11);
            this.tabPage_Proposed.Controls.Add(this.GrdView_Prposedtable);
            this.tabPage_Proposed.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Proposed.Name = "tabPage_Proposed";
            this.tabPage_Proposed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Proposed.Size = new System.Drawing.Size(828, 452);
            this.tabPage_Proposed.TabIndex = 2;
            this.tabPage_Proposed.Text = "Proposed Policy simulation";
            this.tabPage_Proposed.UseVisualStyleBackColor = true;
            this.tabPage_Proposed.Click += new System.EventHandler(this.tabPage_Proposed_Click);
            // 
            // GrdView_PPerformancemeasures
            // 
            this.GrdView_PPerformancemeasures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_PPerformancemeasures.Location = new System.Drawing.Point(324, 20);
            this.GrdView_PPerformancemeasures.Name = "GrdView_PPerformancemeasures";
            this.GrdView_PPerformancemeasures.Size = new System.Drawing.Size(496, 150);
            this.GrdView_PPerformancemeasures.TabIndex = 4;
            // 
            // lbl_Pdelay
            // 
            this.lbl_Pdelay.AutoSize = true;
            this.lbl_Pdelay.Location = new System.Drawing.Point(98, 20);
            this.lbl_Pdelay.Name = "lbl_Pdelay";
            this.lbl_Pdelay.Size = new System.Drawing.Size(41, 13);
            this.lbl_Pdelay.TabIndex = 3;
            this.lbl_Pdelay.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total delay time:";
            // 
            // GrdView_Prposedtable
            // 
            this.GrdView_Prposedtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdView_Prposedtable.Location = new System.Drawing.Point(8, 184);
            this.GrdView_Prposedtable.Name = "GrdView_Prposedtable";
            this.GrdView_Prposedtable.Size = new System.Drawing.Size(809, 265);
            this.GrdView_Prposedtable.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 479);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_input.ResumeLayout(false);
            this.tabPage_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_bearings)).EndInit();
            this.tabPage_Current.ResumeLayout(false);
            this.tabPage_Current.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_CPerformanceMeasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_currenttable)).EndInit();
            this.tabPage_Proposed.ResumeLayout(false);
            this.tabPage_Proposed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_PPerformancemeasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdView_Prposedtable)).EndInit();
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
        private System.Windows.Forms.Button bttn_startsim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView GrdView_currenttable;
        private System.Windows.Forms.DataGridView GrdView_Prposedtable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Cdelay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Pdelay;
        private System.Windows.Forms.DataGridView GrdView_CPerformanceMeasures;
        private System.Windows.Forms.DataGridView GrdView_PPerformancemeasures;
        private System.Windows.Forms.Label lbl_NoHours;
        private System.Windows.Forms.Label lbl_NoBearings;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}