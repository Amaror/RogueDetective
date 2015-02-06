using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.IO;

public class NameGenerator {

	//Name Templates
	private string[] mainStreetNameTemplates;
	private string[] byStreetNameTemplates;
	//FileNames
	private string mainStreetNamesFile = "/Data/Names/mainStreetNames.txt";
	private string byStreetNamesFile = "/Data/Names/byStreetNames.txt";
	//Generated Names
	List<string> streetNames;

	public string streetname;

	public NameGenerator() {
		readNameFiles ();
	}

	public string generateStreetName(){
		System.Random lrandom = new System.Random();
		string lStreetName;
		int lmainCount = mainStreetNameTemplates.GetLength(0);
		int lbyCount = byStreetNameTemplates.GetLength(0);
		do {
			lStreetName = mainStreetNameTemplates [lrandom.Next (0, lmainCount)] + " " + byStreetNameTemplates [lrandom.Next (0, lbyCount)];
		} 
		while(streetNames.Contains(lStreetName));
		return lStreetName;
	}

	private void readNameFiles() {
		//Street Names
		List<string> nameList = new List<string>();
		StreamReader sr = new StreamReader (Application.dataPath + mainStreetNamesFile);
		string line;
		do
		{
			line = sr.ReadLine();
			if(line != null){
				nameList.Add(line);
			}
		}
		while(line  != null);
		mainStreetNameTemplates = nameList.ToArray();

		nameList.Clear();
		sr = new StreamReader (Application.dataPath + byStreetNamesFile);
		line = null;
		do
		{
			line = sr.ReadLine();
			if(line != null){
				nameList.Add(line);
			}
		}
		while(line  != null);
		byStreetNameTemplates = nameList.ToArray();
	}



}
