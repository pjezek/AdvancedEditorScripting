using UnityEngine;
using System.Collections;
using DLLTest;

public class DLLTestCaller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyUtilities utils = new MyUtilities();
		utils.AddValues(2, 3);
		print("2 + 3 = " + utils.c);
	}

	// Update is called once per frame
	void Update () {
		print(MyUtilities.GenerateRandom(0, 100));
	}

}
