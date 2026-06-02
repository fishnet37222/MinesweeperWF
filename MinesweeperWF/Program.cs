// Copyright (c) 2026 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

using System.Text.Json.Nodes;

namespace MinesweeperWF;

public static class Program
{
	private static JsonNode? s_settingsNode;
	private static string? s_settingsFilePath;

	[STAThread]
	public static void Main()
	{
		ApplicationConfiguration.Initialize();

		s_settingsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FishNetSoft", "MinesweeperWF", "settings.json");

		if (File.Exists(s_settingsFilePath))
		{
			s_settingsNode = JsonNode.Parse(File.ReadAllText(s_settingsFilePath));
		}
		else
		{
			s_settingsNode = new JsonObject();
		}

		Application.ApplicationExit += Application_ApplicationExit;

		Application.Run(new MainWindow());
	}

	private static void Application_ApplicationExit(object? sender, EventArgs e)
	{
		Directory.CreateDirectory(Path.GetDirectoryName(s_settingsFilePath)!);
		File.WriteAllText(s_settingsFilePath!, s_settingsNode!.ToJsonString());
	}

	public static JsonObject GetSettingsNode() => s_settingsNode!.AsObject();
}
