﻿using UnityEngine;
using System.Collections;

public class ToolbarHandler : MonoBehaviour {

	public static ToolbarHandler Instance;
	void Awake () {
		Instance = this;
	}

	public void OnNewLayer () {
		Main.Instance.NewLayer ();
	}

}
