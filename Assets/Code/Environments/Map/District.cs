using UnityEngine;
using System.Collections.Generic;

public class District{

	//Boundaries
	public Vector2 _boundarySouth;
	public Vector2 _boundaryNorth;
	//Size
	public int _x;
	public int _y;
	//Blocks
	public Block[] _blocks;
	//Tags to allow or disallow various blocks
	public List<string> _tags;

	public District(Vector2 south, Vector2 north) {
		//Setup Variables
		_tags = new List<string> ();
		_tags.Add("Base");

		_boundarySouth = south;
		_boundaryNorth = north;
		_x = (int)_boundaryNorth.x - (int)_boundarySouth.x;
		_y = (int)_boundaryNorth.y - (int)_boundarySouth.y;
	}
}
