using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

/// <summary>
/// post processing stuff per platform
/// </summary>
public class BuildPostprocessor
{
	[PostProcessBuild]
	public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
	{
		if (target.ToString() == "WP8Player")
		{
			Debug.Log("target: " + target + ", path: " + pathToBuiltProject);
		}
	}
}
