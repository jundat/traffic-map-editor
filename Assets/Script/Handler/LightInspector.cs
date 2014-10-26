﻿using UnityEngine;
using System.Collections;

public class LightInspector : IInspector {

	public UILabel lbID;
	public UIInput inGroupID;
	public UIPopupList popHuong;
	public UIInput inLanDuong;

	void Start () {}
	void Update () {}
	
	public override void Save () {
		if (gridtile != null) {
			//GroupdID
			gridtile.tile.properties[TileKey.LIGHT_GROUP_ID] = inGroupID.value;

			//Huong
			gridtile.tile.properties[TileKey.LIGHT_HUONG] = popHuong.value;

			//LanDuong
			gridtile.tile.properties[TileKey.LIGHT_LAN_DUONG] = inLanDuong.value;
		}
	}

	public override void Init (GridTileHandler tile)
	{
		if (tile.tile.typeId != 301) { 
			Debug.LogError (tile.tile.typeId);
			return;
		}
		
		this.gridtile = tile;
		
		//Id
		lbID.text = ""+gridtile.tile.objId;

		//GroupID
		inGroupID.value = Ultil.GetString (TileKey.LIGHT_GROUP_ID, "0", gridtile.tile.properties);

		//Huong
		popHuong.value = Ultil.GetString (TileKey.LIGHT_HUONG, "UP", gridtile.tile.properties);
		
		//LanDuong
		inLanDuong.value = Ultil.GetString (TileKey.LIGHT_LAN_DUONG, "0", gridtile.tile.properties);

	}
}
