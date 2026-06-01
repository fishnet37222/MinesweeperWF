// Copyright (c) 2026 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

namespace MinesweeperWF;

partial class MainWindow
{
	private System.ComponentModel.IContainer components = null;

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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		MenuStrip menuStrip;
		ToolStripMenuItem gameToolStripMenuItem;
		ToolStripMenuItem helpToolStripMenuItem;
		ToolStripMenuItem aboutMinesweeperToolStripMenuItem;
		ToolStripMenuItem newToolStripMenuItem;
		ToolStripSeparator toolStripMenuItem1;
		ToolStripSeparator toolStripMenuItem2;
		ToolStripMenuItem bestTimesToolStripMenuItem;
		ToolStripSeparator toolStripMenuItem3;
		ToolStripMenuItem exitToolStripMenuItem;
		var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
		this.m_begnnerToolStripMenuItem = new ToolStripMenuItem();
		this.m_intermediateToolStripMenuItem = new ToolStripMenuItem();
		this.m_expertToolStripMenuItem = new ToolStripMenuItem();
		this.m_customToolStripMenuItem = new ToolStripMenuItem();
		this.m_btnNewGame = new Button();
		menuStrip = new MenuStrip();
		gameToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		aboutMinesweeperToolStripMenuItem = new ToolStripMenuItem();
		newToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem1 = new ToolStripSeparator();
		toolStripMenuItem2 = new ToolStripSeparator();
		bestTimesToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem3 = new ToolStripSeparator();
		exitToolStripMenuItem = new ToolStripMenuItem();
		menuStrip.SuspendLayout();
		this.SuspendLayout();
		// 
		// menuStrip
		// 
		menuStrip.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, helpToolStripMenuItem });
		menuStrip.Location = new Point(0, 0);
		menuStrip.Name = "menuStrip";
		menuStrip.RenderMode = ToolStripRenderMode.System;
		menuStrip.Size = new Size(800, 24);
		menuStrip.TabIndex = 0;
		// 
		// gameToolStripMenuItem
		// 
		gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripMenuItem1, this.m_begnnerToolStripMenuItem, this.m_intermediateToolStripMenuItem, this.m_expertToolStripMenuItem, this.m_customToolStripMenuItem, toolStripMenuItem2, bestTimesToolStripMenuItem, toolStripMenuItem3, exitToolStripMenuItem });
		gameToolStripMenuItem.Name = "gameToolStripMenuItem";
		gameToolStripMenuItem.Size = new Size(50, 20);
		gameToolStripMenuItem.Text = "&Game";
		// 
		// helpToolStripMenuItem
		// 
		helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMinesweeperToolStripMenuItem });
		helpToolStripMenuItem.Name = "helpToolStripMenuItem";
		helpToolStripMenuItem.Size = new Size(44, 20);
		helpToolStripMenuItem.Text = "&Help";
		// 
		// aboutMinesweeperToolStripMenuItem
		// 
		aboutMinesweeperToolStripMenuItem.Name = "aboutMinesweeperToolStripMenuItem";
		aboutMinesweeperToolStripMenuItem.Size = new Size(180, 22);
		aboutMinesweeperToolStripMenuItem.Text = "&About Minesweeper";
		// 
		// newToolStripMenuItem
		// 
		newToolStripMenuItem.Name = "newToolStripMenuItem";
		newToolStripMenuItem.ShortcutKeys = Keys.F2;
		newToolStripMenuItem.Size = new Size(180, 22);
		newToolStripMenuItem.Text = "&New";
		// 
		// toolStripMenuItem1
		// 
		toolStripMenuItem1.Name = "toolStripMenuItem1";
		toolStripMenuItem1.Size = new Size(177, 6);
		// 
		// m_begnnerToolStripMenuItem
		// 
		this.m_begnnerToolStripMenuItem.Name = "m_begnnerToolStripMenuItem";
		this.m_begnnerToolStripMenuItem.Size = new Size(180, 22);
		this.m_begnnerToolStripMenuItem.Text = "&Beginner";
		// 
		// m_intermediateToolStripMenuItem
		// 
		this.m_intermediateToolStripMenuItem.Name = "m_intermediateToolStripMenuItem";
		this.m_intermediateToolStripMenuItem.Size = new Size(180, 22);
		this.m_intermediateToolStripMenuItem.Text = "&Intermediate";
		// 
		// m_expertToolStripMenuItem
		// 
		this.m_expertToolStripMenuItem.Name = "m_expertToolStripMenuItem";
		this.m_expertToolStripMenuItem.Size = new Size(180, 22);
		this.m_expertToolStripMenuItem.Text = "&Expert";
		// 
		// m_customToolStripMenuItem
		// 
		this.m_customToolStripMenuItem.Name = "m_customToolStripMenuItem";
		this.m_customToolStripMenuItem.Size = new Size(180, 22);
		this.m_customToolStripMenuItem.Text = "&Custom...";
		// 
		// toolStripMenuItem2
		// 
		toolStripMenuItem2.Name = "toolStripMenuItem2";
		toolStripMenuItem2.Size = new Size(177, 6);
		// 
		// bestTimesToolStripMenuItem
		// 
		bestTimesToolStripMenuItem.Name = "bestTimesToolStripMenuItem";
		bestTimesToolStripMenuItem.Size = new Size(180, 22);
		bestTimesToolStripMenuItem.Text = "Best &Times...";
		// 
		// toolStripMenuItem3
		// 
		toolStripMenuItem3.Name = "toolStripMenuItem3";
		toolStripMenuItem3.Size = new Size(177, 6);
		// 
		// exitToolStripMenuItem
		// 
		exitToolStripMenuItem.Name = "exitToolStripMenuItem";
		exitToolStripMenuItem.Size = new Size(180, 22);
		exitToolStripMenuItem.Text = "E&xit";
		// 
		// m_btnNewGame
		// 
		this.m_btnNewGame.Anchor = AnchorStyles.Top;
		this.m_btnNewGame.AutoSize = true;
		this.m_btnNewGame.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		this.m_btnNewGame.Image = Properties.Resources.Smile1;
		this.m_btnNewGame.Location = new Point(378, 27);
		this.m_btnNewGame.Name = "m_btnNewGame";
		this.m_btnNewGame.Padding = new Padding(3);
		this.m_btnNewGame.Size = new Size(44, 44);
		this.m_btnNewGame.TabIndex = 1;
		this.m_btnNewGame.UseVisualStyleBackColor = true;
		// 
		// MainWindow
		// 
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new Size(800, 450);
		this.Controls.Add(this.m_btnNewGame);
		this.Controls.Add(menuStrip);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.Icon = (Icon)resources.GetObject("$this.Icon");
		this.MainMenuStrip = menuStrip;
		this.MaximizeBox = false;
		this.Name = "MainWindow";
		this.Text = "Minesweeper";
		menuStrip.ResumeLayout(false);
		menuStrip.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private ToolStripMenuItem m_begnnerToolStripMenuItem;
	private ToolStripMenuItem m_intermediateToolStripMenuItem;
	private ToolStripMenuItem m_expertToolStripMenuItem;
	private ToolStripMenuItem m_customToolStripMenuItem;
	private Button m_btnNewGame;
}
