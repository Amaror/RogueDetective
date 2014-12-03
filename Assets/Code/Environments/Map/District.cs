using UnityEngine;

public class District{

	//Boundaries
	public Vector2 _boundarySouth;
	public Vector2 _boundaryNorth;
	//Size
	public int _x;
	public int _y;
	//Blocks
	public Block[] _blocks;

	public District(int south, int north) {
		_boundarySouth = south;
		_boundaryNorth = north;
		_x = (int)_boundaryNorth.x - (int)_boundarySouth.x;
		_y = (int)_boundaryNorth.y - (int)_boundarySouth.y;
	}
}
