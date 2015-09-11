using UnityEngine;
using System.Collections;

public class GameManager : Photon.MonoBehaviour {
	
	public GameObject[] redSpawns;
	public GameObject[] blueSpawns;
	
	public int state = 0;
	
	void Connect (){
		PhotonNetwork.ConnectToBestCloudServer ("V1.0");
		Connect ();
	}
	
	void Start () {
		
	}
	
	void Update () {
		
	}
	
	void OnGUI () {
		switch (state) {
		case 0:
			if (GUI.Button(new Rect(10, 10, 100, 30), "Connect")){
				Connect ();
			}
			break;
		case 1:
			GUI.Label(new Rect(10, 10, 100, 30), "Connected");
			break;
		}
	}
}