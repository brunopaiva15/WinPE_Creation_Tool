﻿/*
 *  Copyright (C) 2019 Bruno Paiva
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along
 * with this program; if not, write to the Free Software Foundation, Inc.,
 * 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 * 
 */

namespace WinPE_Creation_Tool
{
    partial class Wizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard));
            this.label2 = new System.Windows.Forms.Label();
            this.rbAMD64 = new System.Windows.Forms.RadioButton();
            this.rbX86 = new System.Windows.Forms.RadioButton();
            this.rbARM = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLCID = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxUSB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCreateUSB = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxGenerateISO = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnHelpScript = new System.Windows.Forms.Button();
            this.cbxScript = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbxDrivers = new System.Windows.Forms.CheckBox();
            this.tbxDrivers = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "WinPE Creation Tool";
            // 
            // rbAMD64
            // 
            this.rbAMD64.AutoSize = true;
            this.rbAMD64.Location = new System.Drawing.Point(12, 19);
            this.rbAMD64.Name = "rbAMD64";
            this.rbAMD64.Size = new System.Drawing.Size(57, 17);
            this.rbAMD64.TabIndex = 2;
            this.rbAMD64.TabStop = true;
            this.rbAMD64.Text = "amd64";
            this.rbAMD64.UseVisualStyleBackColor = true;
            // 
            // rbX86
            // 
            this.rbX86.AutoSize = true;
            this.rbX86.Location = new System.Drawing.Point(12, 42);
            this.rbX86.Name = "rbX86";
            this.rbX86.Size = new System.Drawing.Size(42, 17);
            this.rbX86.TabIndex = 3;
            this.rbX86.TabStop = true;
            this.rbX86.Text = "x86";
            this.rbX86.UseVisualStyleBackColor = true;
            // 
            // rbARM
            // 
            this.rbARM.AutoSize = true;
            this.rbARM.Location = new System.Drawing.Point(12, 65);
            this.rbARM.Name = "rbARM";
            this.rbARM.Size = new System.Drawing.Size(42, 17);
            this.rbARM.TabIndex = 4;
            this.rbARM.TabStop = true;
            this.rbARM.Text = "arm";
            this.rbARM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "LCID string :";
            // 
            // tbxLCID
            // 
            this.tbxLCID.Location = new System.Drawing.Point(81, 23);
            this.tbxLCID.Name = "tbxLCID";
            this.tbxLCID.Size = new System.Drawing.Size(71, 20);
            this.tbxLCID.TabIndex = 9;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(158, 23);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 20);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbX86);
            this.groupBox1.Controls.Add(this.rbAMD64);
            this.groupBox1.Controls.Add(this.rbARM);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 91);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Architecture";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHelp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxLCID);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 52);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyboard";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxUSB);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbxCreateUSB);
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 72);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "USB";
            // 
            // cbxUSB
            // 
            this.cbxUSB.FormattingEnabled = true;
            this.cbxUSB.Location = new System.Drawing.Point(71, 41);
            this.cbxUSB.Name = "cbxUSB";
            this.cbxUSB.Size = new System.Drawing.Size(110, 21);
            this.cbxUSB.TabIndex = 14;
            this.cbxUSB.DropDown += new System.EventHandler(this.cbxUSB_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "USB drive :";
            // 
            // cbxCreateUSB
            // 
            this.cbxCreateUSB.AutoSize = true;
            this.cbxCreateUSB.Location = new System.Drawing.Point(11, 22);
            this.cbxCreateUSB.Name = "cbxCreateUSB";
            this.cbxCreateUSB.Size = new System.Drawing.Size(126, 17);
            this.cbxCreateUSB.TabIndex = 0;
            this.cbxCreateUSB.Text = "Create bootable USB";
            this.cbxCreateUSB.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxGenerateISO);
            this.groupBox4.Location = new System.Drawing.Point(224, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 46);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ISO";
            // 
            // cbxGenerateISO
            // 
            this.cbxGenerateISO.AutoSize = true;
            this.cbxGenerateISO.Location = new System.Drawing.Point(11, 20);
            this.cbxGenerateISO.Name = "cbxGenerateISO";
            this.cbxGenerateISO.Size = new System.Drawing.Size(91, 17);
            this.cbxGenerateISO.TabIndex = 0;
            this.cbxGenerateISO.Text = "Generate ISO";
            this.cbxGenerateISO.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(12, 367);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(417, 27);
            this.btnGo.TabIndex = 18;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinPE_Creation_Tool.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(158, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "v0.5";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnHelpScript);
            this.groupBox5.Controls.Add(this.cbxScript);
            this.groupBox5.Location = new System.Drawing.Point(224, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 46);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Script";
            // 
            // btnHelpScript
            // 
            this.btnHelpScript.Location = new System.Drawing.Point(158, 18);
            this.btnHelpScript.Name = "btnHelpScript";
            this.btnHelpScript.Size = new System.Drawing.Size(23, 20);
            this.btnHelpScript.TabIndex = 13;
            this.btnHelpScript.Text = "?";
            this.btnHelpScript.UseVisualStyleBackColor = true;
            this.btnHelpScript.Click += new System.EventHandler(this.BtnHelpScript_Click);
            // 
            // cbxScript
            // 
            this.cbxScript.AutoSize = true;
            this.cbxScript.Location = new System.Drawing.Point(11, 20);
            this.cbxScript.Name = "cbxScript";
            this.cbxScript.Size = new System.Drawing.Size(143, 17);
            this.cbxScript.TabIndex = 0;
            this.cbxScript.Text = "Integrate script at startup";
            this.cbxScript.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbxDrivers);
            this.groupBox6.Controls.Add(this.cbxDrivers);
            this.groupBox6.Location = new System.Drawing.Point(223, 131);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(205, 123);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Drivers";
            // 
            // cbxDrivers
            // 
            this.cbxDrivers.AutoSize = true;
            this.cbxDrivers.Location = new System.Drawing.Point(12, 20);
            this.cbxDrivers.Name = "cbxDrivers";
            this.cbxDrivers.Size = new System.Drawing.Size(79, 17);
            this.cbxDrivers.TabIndex = 1;
            this.cbxDrivers.Text = "Add drivers";
            this.cbxDrivers.UseVisualStyleBackColor = true;
            this.cbxDrivers.CheckedChanged += new System.EventHandler(this.CbxDrivers_CheckedChanged);
            // 
            // tbxDrivers
            // 
            this.tbxDrivers.Location = new System.Drawing.Point(12, 42);
            this.tbxDrivers.Multiline = true;
            this.tbxDrivers.Name = "tbxDrivers";
            this.tbxDrivers.Size = new System.Drawing.Size(182, 68);
            this.tbxDrivers.TabIndex = 2;
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 404);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Wizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WPECT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wizard_FormClosing);
            this.Load += new System.EventHandler(this.Wizard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAMD64;
        private System.Windows.Forms.RadioButton rbX86;
        private System.Windows.Forms.RadioButton rbARM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLCID;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbxCreateUSB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUSB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbxGenerateISO;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbxScript;
        private System.Windows.Forms.Button btnHelpScript;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbxDrivers;
        private System.Windows.Forms.CheckBox cbxDrivers;
    }
}