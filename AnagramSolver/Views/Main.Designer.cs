namespace AnagramSolver.Views
{
  partial class Main
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
      this.bottomBar = new System.Windows.Forms.StatusStrip();
      this.bottomBarProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.bottomBarLblState = new System.Windows.Forms.ToolStripStatusLabel();
      this.bottomBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // bottomBar
      // 
      this.bottomBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottomBarProgressBar,
            this.bottomBarLblState});
      this.bottomBar.Location = new System.Drawing.Point(0, 428);
      this.bottomBar.Name = "bottomBar";
      this.bottomBar.Size = new System.Drawing.Size(800, 22);
      this.bottomBar.TabIndex = 0;
      this.bottomBar.Text = "statusStrip1";
      // 
      // bottomBarProgressBar
      // 
      this.bottomBarProgressBar.Name = "bottomBarProgressBar";
      this.bottomBarProgressBar.Size = new System.Drawing.Size(100, 16);
      this.bottomBarProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      // 
      // bottomBarLblState
      // 
      this.bottomBarLblState.Name = "bottomBarLblState";
      this.bottomBarLblState.Size = new System.Drawing.Size(33, 17);
      this.bottomBarLblState.Text = "State";
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.bottomBar);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main";
      this.Load += new System.EventHandler(this.Main_Load);
      this.bottomBar.ResumeLayout(false);
      this.bottomBar.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip bottomBar;
    private System.Windows.Forms.ToolStripProgressBar bottomBarProgressBar;
    private System.Windows.Forms.ToolStripStatusLabel bottomBarLblState;
  }
}