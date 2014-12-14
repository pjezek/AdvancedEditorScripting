using System;
using System.Collections;
using UnityEngine;
using UnityEditor;

public enum IngredientUnit {Bowl, Cup, Piece}

[Serializable]
public class Ingredient {
	public string name;
	public int amount = 1;
	public IngredientUnit unit;
}

public class IngredientAttribute : PropertyAttribute
{
	public IngredientAttribute() { }
}

[CustomPropertyDrawer(typeof(Ingredient))]
public class IngredientDrawer : PropertyDrawer
{
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		EditorGUI.BeginProperty(position, label, property);
		position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

		Rect aspectRatioRect = new Rect(position.x, position.y, 50, position.height);
		Rect descriptionRect = new Rect(position.x + 55, position.y, position.width - 55, position.height);

		EditorGUI.PropertyField(aspectRatioRect, property.FindPropertyRelative("amount"), GUIContent.none);
		EditorGUI.PropertyField(descriptionRect, property.FindPropertyRelative("unit"), GUIContent.none);

		EditorGUI.EndProperty();

	}
}

[ExecuteInEditMode]
public class CustomPropertyDrawerExample : MonoBehaviour {

	public Ingredient potionResult;
	public Ingredient[] potionIngredients;

	/// <summary>
	/// generate some content.
	/// </summary>
	void Awake()
	{
		potionResult = new Ingredient();
		potionResult.name = "lemonade";
		potionResult.amount = 1;
		potionResult.unit = IngredientUnit.Bowl;

		potionIngredients = new Ingredient[5];

		potionIngredients[0] = new Ingredient();
		potionIngredients[0].name = "sugar";
		potionIngredients[0].amount = 1;
		potionIngredients[0].unit = IngredientUnit.Cup;

		potionIngredients[1] = new Ingredient();
		potionIngredients[1].name = "hot water";
		potionIngredients[1].amount = 1;
		potionIngredients[1].unit = IngredientUnit.Cup;

		potionIngredients[2] = new Ingredient();
		potionIngredients[2].name = "lemon juice";
		potionIngredients[2].amount = 1;
		potionIngredients[2].unit = IngredientUnit.Cup;
	
		potionIngredients[3] = new Ingredient();
		potionIngredients[3].name = "cold water";
		potionIngredients[3].amount = 4;
		potionIngredients[3].unit = IngredientUnit.Cup;

		potionIngredients[4] = new Ingredient();
		potionIngredients[4].name = "lemon slice";
		potionIngredients[4].amount = 2;
		potionIngredients[4].unit = IngredientUnit.Piece;
	}
}
