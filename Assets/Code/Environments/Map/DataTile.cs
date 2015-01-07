using UnityEngine;

public class DataTile {

	//Boundaries
	public Vector2 _boundarySouth;
	public Vector2 _boundaryNorth;
	//Information
	public string _type;
	public string _streetName;
	public int _number;


	public DataTile(string type, string streetName, int number, Vector2 north, Vector2 south) {
		_boundaryNorth = north;
		_boundarySouth = south;
		_type = type;
		_streetName = streetName;
		_number = number;
	}

}
