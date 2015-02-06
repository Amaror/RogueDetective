using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockDataBase {

	private string[,] blockTagArray;
	private int[,] blockSizeArray;
	private int NumberOfBlockTypes = 5;

	public BlockDataBase() {
		initializeBlockData ();
	}

	public int[,] getBlockSizes(string[] pTagArray) {
		List<int> sizeListX = new List<int> ();
		List<int> sizeListY = new List<int> ();
		for (int x = 0; x < blockTagArray.Length; x++) {
			foreach(string tag in pTagArray) {
				if(tag.Equals(blockTagArray[x,1])){
					sizeListX.Add(blockSizeArray[x,0]);
					sizeListY.Add(blockSizeArray[x,1]);
				}
			}
		}
		int[,] sizes = new int[sizeListX.Count,2];
		for (int y = 0; y < sizeListX.Count; y++) {
			sizes[y,0] = sizeListX[y];
			sizes[y,1] = sizeListY[y];
		}

		return sizes;
	}

	private void initializeBlockData() {
		blockTagArray = new string[NumberOfBlockTypes, 2];
		blockSizeArray = new int[NumberOfBlockTypes,2];

		blockTagArray [0, 0] = "Small Residental"; blockTagArray [0, 1] = "basic";
		blockSizeArray[0,0] = 2; blockSizeArray[0,1] = 2;

		blockTagArray [1, 0] = "Medium Residental"; blockTagArray [1, 1] = "basic";
		blockSizeArray[1,0] = 3; blockSizeArray[1,1] = 3;

		blockTagArray [2, 0] = "Large Residental"; blockTagArray [2, 1] = "basic";
		blockSizeArray[2,0] = 4; blockSizeArray[2,1] = 4;

		blockTagArray [3, 0] = "Hospital"; blockTagArray [3, 1] = "medicine";
		blockSizeArray[3,0] = 2; blockSizeArray[3,1] = 4;

		blockTagArray [4, 0] = "Airport"; blockTagArray [4, 1] = "airport";
		blockSizeArray[4,0] = 10; blockSizeArray[4,1] = 5;

		//_blockTags [5, 0] = ""; _blockTags [5, 1] = "";
		//_blockSizes[5,0] = ; _blockSizes[5,1] = ;
	}
}
