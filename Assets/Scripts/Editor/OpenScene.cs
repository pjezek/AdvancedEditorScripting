using UnityEngine;
using UnityEditor;
using System.Collections;

public class OpenScene : MonoBehaviour {

	/// <summary>
	/// MeniItem to open MainMenu scene.
	/// </summary>
	[MenuItem("Open Scene/MainMenu")]
	public static void OpenMainMenu()
	{
		OpenSceneHelper("MainMenu");
	}

	/// <summary>
	/// Opens the Test scene.
	/// </summary>
	[MenuItem("Open Scene/Test")]
	public static void OpenTest()
	{
		OpenSceneHelper("Test");
	}
	
	/// <summary>
	/// Opens the scene named with name.
	/// </summary>
	/// <param name="name">Name.</param>
	private static void OpenSceneHelper(string name)
	{
		if (EditorApplication.SaveCurrentSceneIfUserWantsTo())
		{
			EditorApplication.OpenScene("Assets/Scenes/" + name + ".unity");
		}
	}
}
