using System.Collections;
using UnityEditor;
using UnityEngine;

public class AssetImporterProcessor : AssetPostprocessor {

	public string data = "{\"foo\": \"bar\"}";

	static void OnPostprocessAllAssets(
		string[] importedAssets,
		string[] deletedAssets,
		string[] movedAssets,
		string[] movedFromAssetPaths)
	{
		Debug.Log("OnPostprocessAllAssets called");
		int i;
		for (i = 0; i < importedAssets.Length; i++)
			Debug.Log("Reimported Asset: " + importedAssets[i]);
		for (i = 0; i < deletedAssets.Length; i++)
			Debug.Log("Deleted Asset: " + deletedAssets[i]);
		for (i = 0; i < movedAssets.Length; i++)
			Debug.Log("Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
	}

	void OnPreprocessModel()
	{
		Debug.Log("OnPreprocessModel called");
		ModelImporter importer = assetImporter as ModelImporter;
	}

	void OnPostprocessTexture(Texture2D texture)
	{
		Debug.Log("OnPostprocessTexture called");

		var lowerCaseAssetPath = assetPath.ToLower();
		if (assetPath.IndexOf ("/Sprites/") == -1)
		{
			Debug.Log ("Texture not processed...");
			return;
		}
		Debug.Log ("processing Texture ...");
		assetImporter.userData = data;
	}
}
