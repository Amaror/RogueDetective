using UnityEngine;
using System;

public class MapGenerator {

	public DataMap dataMap;
	//Database for different Blocks
	private BlockDataBase blockDataBase;

	public MapGenerator() {
		blockDataBase = new BlockDataBase ();
	}

	//Manages Map Generation
	public void generateMap() {
		//Basix Map Setup
		int lSizeX = ApplicationModel.sizeX;
		int lSizeY = ApplicationModel.sizeY;
		dataMap = new DataMap (lSizeX, lSizeY);
		dataMap.tileArray = new DataTile[lSizeX, lSizeY];

		//Determine the Layout based on the Number of Districts
		for (int x = 1; x < (ApplicationModel.numberOfDistricts); x++) {
			if ((Math.Sqrt (ApplicationModel.numberOfDistricts - x) % 1) == 0) 
			{
				generateDistricts((int)Math.Sqrt (ApplicationModel.numberOfDistricts - x), x);
				x = ApplicationModel.numberOfDistricts;
			} 
		}
		for (int x = 0; x < ApplicationModel.numberOfDistricts; x++) {
			generateBlocks(x);
		}


	}

	//Generate Districts
	private void generateDistricts(int pSquareRootDistricts, int pAdditionalDistricts) {
		District[] lDistrictArray = new District[ApplicationModel.numberOfDistricts];
		int lDistrictSizeX = Mathf.FloorToInt(ApplicationModel.sizeX / (pSquareRootDistricts + pAdditionalDistricts));
		int lDistrictSizeY = Mathf.FloorToInt(ApplicationModel.sizeY / pSquareRootDistricts);

		for (int y = 0; y < pSquareRootDistricts; y++) {
			for(int x = 0; x < pSquareRootDistricts; x++) {
				Vector2 south = new Vector2(x * lDistrictSizeX, y * lDistrictSizeY);
				Vector2 north = new Vector2((x+1) * lDistrictSizeX, (y+1) * lDistrictSizeY);
				lDistrictArray[(y*3)+x] = new District(south, north);
			}
		}
		for (int x = 0; x < pAdditionalDistricts; x++) {
			Vector2 south = new Vector2(x * lDistrictSizeX, 0);
			Vector2 north = new Vector2((x+1) * lDistrictSizeX, ApplicationModel.sizeY);
			if(x == pAdditionalDistricts - 1) {
				north.x = ApplicationModel.sizeX;
			}
			lDistrictArray[(pSquareRootDistricts * pSquareRootDistricts) + x] = new District(south, north);
		}

		dataMap.districtArray = lDistrictArray;
	}

	//Generate Blocks for the generated Districts
	private void generateBlocks(int districtNumber) {
		District lDistrict = dataMap.districtArray [districtNumber];
		int[,] lBlockSizes = blockDataBase.getBlockSizes (lDistrict.tagList.ToArray());

		//While Schleife für Blockgenerierung
		int lRestSizeX = lDistrict.sizeX;
		int lRestSizeY = lDistrict.sizeY;
	}


}
