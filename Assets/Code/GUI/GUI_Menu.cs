using UnityEngine;
using System.Collections;

public class GUI_Menu : MonoBehaviour {

	//The current Menu
	private string _currentMenu;
	//Buttonsettings
	private float _buttonwidth;
	private float _buttonheight;

	// Use this for initialization
	void Start () {
		//Select starting Menu
		_currentMenu = "Main";

		//Determine Button settings
		_buttonwidth = Screen.width * 0.1f;
		_buttonheight = _buttonwidth * 0.33f;
		
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (_currentMenu == "Main") {
			Menu_Main();
		}
	
	}

	private void Menu_Main() {
		if(GUI.Button(new Rect((Screen.width * 0.5f) - _buttonwidth * 0.5f, Screen.height * 0.38f, _buttonwidth, _buttonheight), "Neues Spiel")) {
			_currentMenu = "Game Start";
		}
		if(GUI.Button(new Rect((Screen.width * 0.5f) - _buttonwidth * 0.5f, (Screen.height * 0.38f) + _buttonheight * 1.5f, _buttonwidth, _buttonheight), "Optionen")) {
			_currentMenu = "Options";
		}
		if(GUI.Button(new Rect((Screen.width * 0.5f) - _buttonwidth * 0.5f, (Screen.height * 0.38f) + _buttonheight * 3f, _buttonwidth, _buttonheight), "Spiel Beenden")) {
			Application.Quit();
		}
	}
}
