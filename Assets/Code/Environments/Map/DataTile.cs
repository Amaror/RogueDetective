using UnityEngine;

public class DataTile {

	//Boundaries
	public Vector2 boundarySouth;
	public Vector2 boundaryNorth;
	//Information
	public string type;
	public string streetName;
	public int number;


	public DataTile(string pType, string pStreetName, int pNumber, Vector2 pNorth, Vector2 pSouth) {
		boundaryNorth = pNorth;
		boundarySouth = pSouth;
		type = pType;
		streetName = pStreetName;
		number = pNumber;
	}

}
