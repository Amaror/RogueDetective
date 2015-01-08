using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockDataBase {

	private string[,] _blockTags;
	private int[,] _blockSizes;
	private int _blockTypes = 5;

	public BlockDataBase() {
		initializeBlockData ();
	}

	public int[] getBlockSizes(string[] tags) {
		List<int> sizeListX = new List<int> ();
		List<int> sizeListY = new List<int> ();
		for (int x = 0; x < _blockTypes; x++) {
			foreach(string tag in tags) {
				if(tag.Equals(_blockTags[x,1])){
					sizeListX.Add(_blockSizes[x,0]);
					sizeListY.Add(_blockSizes[x,1]);
				}
			}
		}
		int[,] sizes = new int[sizeListX.Count,2];
		for (int y = 0; y < sizeListX.Count; y++) {
			sizes[y,0] = sizeListX.Remove;
			sizes[y,1] = sizeListY.Remove;
		}
	}

	private void initializeBlockData() {
		_blockTags = new string[_blockTypes, 2];
		_blockSizes = new int[_blockTypes,2];

		_blockTags [0, 0] = "Small Residental"; _blockTags [0, 1] = "basic";
		_blockSizes[0,0] = 2; _blockSizes[0,1] = 2;

		_blockTags [1, 0] = "Medium Residental"; _blockTags [1, 1] = "basic";
		_blockSizes[1,0] = 3; _blockSizes[1,1] = 3;

		_blockTags [2, 0] = "Large Residental"; _blockTags [2, 1] = "basic";
		_blockSizes[2,0] = 4; _blockSizes[2,1] = 4;

		_blockTags [3, 0] = "Hospital"; _blockTags [3, 1] = "medicine";
		_blockSizes[3,0] = 2; _blockSizes[3,1] = 4;

		_blockTags [4, 0] = "Airport"; _blockTags [4, 1] = "airport";
		_blockSizes[4,0] = 10; _blockSizes[4,1] = 5;

		//_blockTags [5, 0] = ""; _blockTags [5, 1] = "";
		//_blockSizes[5,0] = ; _blockSizes[5,1] = ;
	}
}
