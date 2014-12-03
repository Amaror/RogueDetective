using UnityEngine;
using System;

public class MapGenerator {

	public DataMap _dataMap;

	public MapGenerator() {
	}

	//Manages Map Generation
	public void generateMap() {
		//Basix Map Setup
		int sizeX = ApplicationModel._sizeX;
		int sizeY = ApplicationModel._sizeY;
		_dataMap = new DataMap (sizeX, sizeY);
		_dataMap._tiles = new DataTile[sizeX, sizeY];

		//Determine the Layout based on the Number of Districts
		for (int x = 1; x < (ApplicationModel._numberOfDistricts); x++) {
			if ((Math.Sqrt (ApplicationModel._numberOfDistricts - x) % 1) == 0) 
			{
				generateDistricts((int)Math.Sqrt (ApplicationModel._numberOfDistricts - x), x);
				x = ApplicationModel._numberOfDistricts;
			} 
		}
		for (int x = 0; x < ApplicationModel._numberOfDistricts; x++) {
			generateBlocks(x);
		}


	}

	//Generate Districts
	private void generateDistricts(int squareRootDistricts, int additionalDistricts) {
		District[] districts = new District[ApplicationModel._numberOfDistricts];
		int districtSizeX = Mathf.FloorToInt(ApplicationModel._sizeX / (squareRootDistricts + additionalDistricts));
		int districtSizeY = Mathf.FloorToInt(ApplicationModel._sizeY / squareRootDistricts);

		for (int y = 0; y < squareRootDistricts; y++) {
			for(int x = 0; x < squareRootDistricts; x++) {
				Vector2 south = new Vector2(x * districtSizeX, y * districtSizeY);
				Vector2 north = new Vector2((x+1) * districtSizeX, (y+1) * districtSizeY);
				districts[(y*3)+x] = new District(south, north);
			}
		}
		for (int x = 0; x < additionalDistricts; x++) {
			Vector2 south = new Vector2(x * districtSizeX, 0);
			Vector2 north = new Vector2((x+1) * districtSizeX, ApplicationModel._sizeY);
			if(x == additionalDistricts - 1) {
				north.x = ApplicationModel._sizeX;
			}
			districts[(squareRootDistricts * squareRootDistricts) + x] = new District(south, north);
		}

		_dataMap._districts = districts;
	}

	//Generate Blocks for the generated Districts
	private void generateBlocks(int districtNumber) {
		District district = _dataMap._districts [districtNumber];

	}


}
