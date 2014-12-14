using System;
using System.Collections;
using UnityEngine;

public class SerializableTest : MonoBehaviour {

	[Serializable]
	public class Player
	{
		public int level = 3;
		[SerializeField]
		private bool hasHealthPotion = true;
	}

	public Player player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
