﻿namespace Ordisoftware.Core
{
  partial class EditMemoForm
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
      if ( disposing && ( components != null ) )
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMemoForm));
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.ActionOk = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.PanelSep = new System.Windows.Forms.Panel();
      this.TextBox = new Ordisoftware.Core.RichTextBoxEx();
      this.Panel = new System.Windows.Forms.Panel();
      this.PanelButtons.SuspendLayout();
      this.Panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.ActionOk);
      this.PanelButtons.Controls.Add(this.ActionCancel);
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Name = "PanelButtons";
      // 
      // ActionOk
      // 
      resources.ApplyResources(this.ActionOk, "ActionOk");
      this.ActionOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionOk.Name = "ActionOk";
      this.ActionOk.UseVisualStyleBackColor = true;
      // 
      // ActionCancel
      // 
      resources.ApplyResources(this.ActionCancel, "ActionCancel");
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.UseVisualStyleBackColor = true;
      // 
      // PanelSep
      // 
      resources.ApplyResources(this.PanelSep, "PanelSep");
      this.PanelSep.Name = "PanelSep";
      // 
      // TextBox
      // 
      this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.TextBox.DetectUrls = false;
      resources.ApplyResources(this.TextBox, "TextBox");
      this.TextBox.Name = "TextBox";
      this.TextBox.SelectionAlignment = Ordisoftware.Core.TextAlign.Justify;
      this.TextBox.SizeChanged += new System.EventHandler(this.TextBox_SizeChanged);
      // 
      // Panel
      // 
      this.Panel.BackColor = System.Drawing.SystemColors.Window;
      this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel.Controls.Add(this.TextBox);
      resources.ApplyResources(this.Panel, "Panel");
      this.Panel.Name = "Panel";
      // 
      // EditMemoForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Panel);
      this.Controls.Add(this.PanelSep);
      this.Controls.Add(this.PanelButtons);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditMemoForm";
      this.ShowInTaskbar = false;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditMemoForm_FormClosed);
      this.Load += new System.EventHandler(this.EditMemoForm_Load);
      this.PanelButtons.ResumeLayout(false);
      this.Panel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.Button ActionOk;
    private System.Windows.Forms.Button ActionCancel;
    private Ordisoftware.Core.RichTextBoxEx TextBox;
    private System.Windows.Forms.Panel PanelSep;
    private Panel Panel;
  }
}