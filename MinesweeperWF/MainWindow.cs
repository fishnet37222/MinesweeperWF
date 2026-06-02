// Copyright (c) 2026 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

using System.Text.Json.Nodes;

namespace MinesweeperWF;

public partial class MainWindow : Form
{
	public MainWindow()
	{
		InitializeComponent();
	}

	private void MainWindow_Load(object sender, EventArgs e)
	{
		var settings = Program.GetSettingsNode();
		var savedLocation = new Point(-1, -1);

		if (settings.ContainsKey("MainWindowLocation"))
		{
			var locationNode = settings["MainWindowLocation"];
			if (locationNode != null)
			{
				var x = locationNode["X"]?.GetValue<int>() ?? -1;
				var y = locationNode["Y"]?.GetValue<int>() ?? -1;
				savedLocation = new Point(x, y);
			}
		}

		if (savedLocation is { X: >= 0, Y: >= 0 })
		{
			Location = savedLocation;
		}
		else
		{
			var workingArea = Screen.FromControl(this).WorkingArea;
			Location = new Point(workingArea.Left + (workingArea.Width - Width) / 2, workingArea.Top + (workingArea.Height - Height) / 2);
		}
	}

	private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
	{
		var locationNode = new JsonObject
		{
			["X"] = Location.X,
			["Y"] = Location.Y
		};

		Program.GetSettingsNode()["MainWindowLocation"] = locationNode;
	}
}
