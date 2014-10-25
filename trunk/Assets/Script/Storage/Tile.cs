﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Tile {

	public int objId;
	public int typeId;
	public LayerType layerType;
	public float x;
	public float y;
	public Dictionary<string, string> properties;

	public Tile () {
		properties = new Dictionary<string, string> ();
	}

	public Tile Copy () {
		Tile t = new Tile ();
		t.objId = this.objId;
		t.typeId = this.typeId;
		t.layerType = this.layerType;
	
		foreach (KeyValuePair<string, string> p in this.properties) {
			t.properties[p.Key] = p.Value;
		}

		return t;
	}
}
