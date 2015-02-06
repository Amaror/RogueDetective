using UnityEngine;
using System.Collections.Generic;

public class District{

	//Boundaries
	public Vector2 boundarySouth;
	public Vector2 boundaryNorth;
	//Size
	public int sizeX;
	public int sizeY;
	//Block
	public Block[] blockArray;
	//Tags to allow or disallow various blocks
	public List<string> tagList;

	public District(Vector2 south, Vector2 north) {
		//Setup Variables
		tagList = new List<string> ();
		tagList.Add("Base");

		boundarySouth = south;
		boundaryNorth = north;
		sizeX = (int)boundaryNorth.x - (int)boundarySouth.x;
		sizeY = (int)boundaryNorth.y - (int)boundarySouth.y;
	}
}
