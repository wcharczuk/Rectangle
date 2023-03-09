﻿namespace Rectangle
{
    partial class Settings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            groupBox = new GroupBox();
            trayIcon = new NotifyIcon(components);
            trayIconContextMenu = new ContextMenuStrip(components);
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            foreach (var input in allHotKeyInputs)
            {
                groupBox.Controls.Add(input);
            }
            groupBox.Location = new Point(10, 10);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(380, 580);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Input Settings";
            // 
            // notifyIcon1
            // 
            trayIcon.ContextMenuStrip = trayIconContextMenu;
            trayIcon.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            trayIcon.Text = "Rectangle";
            trayIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            trayIconContextMenu.Name = "notifyIconContextMenu";
            trayIconContextMenu.Size = new Size(64, 4);

            // inputs
            inputMaximize.Location = new Point(20, 20);
            inputUnmaximize.Location = new Point(20, inputMaximize.Location.Y+inputMaximize.Height);
            inputHalfLeft.Location = new Point(20, inputUnmaximize.Location.Y+inputUnmaximize.Height);
            inputHalfRight.Location = new Point(20, inputHalfLeft.Location.Y+inputHalfLeft.Height);
            inputMiddleTwoThirds.Location = new Point(20, inputHalfRight.Location.Y+inputHalfRight.Height);
            inputTopLeft.Location = new Point(20, inputMiddleTwoThirds.Location.Y+inputMiddleTwoThirds.Height);
            inputTopRight.Location = new Point(20, inputTopLeft.Location.Y+inputTopLeft.Height);
            inputBottomLeft.Location = new Point(20, inputTopRight.Location.Y+inputTopRight.Height);
            inputBottomRight.Location = new Point(20, inputBottomLeft.Location.Y+inputBottomLeft.Height);
            inputPreviousDisplay.Location = new Point(20, inputBottomRight.Location.Y+inputBottomRight.Height);
            inputNextDisplay.Location = new Point(20, inputPreviousDisplay.Location.Y+inputPreviousDisplay.Height);

            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 600);
            Controls.Add(groupBox);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Settings";
            Text = "Rectangle Settings & Help";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayIconContextMenu;
    }
}