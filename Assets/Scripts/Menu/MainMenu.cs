﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public string ip;
	public string port;
	public string Name;
	public Texture MenuBackgroundTexture;
	public GUISkin MenuSkin;
	
	LevelLoader netLoadobj;
	
	void OnGUI(){
		/*GUI.Box(new Rect(10,10,150,150), "Main Menu");
		
		GUI.Label(new Rect(15,100,30,20), "IP:");
		ip = GUI.TextField(new Rect(46,100,84,20), ip);
		
		GUI.Label(new Rect(15,130,30,20), "Port:");
		port = GUI.TextField(new Rect(46,130,84,20), port);
		
		if(GUI.Button(new Rect(20,40,80,20), "Host Server")){
			Network.InitializeServer(30, parseInt(port), false);
			//Instantiate(netLoadobj);
		}
		
		if(GUI.Button(new Rect(20,70,80,20), "Join Server")){
			Network.Connect(ip, parseInt(port));
		}*/
		GUI.skin = MenuSkin;
		GUIStyle GUIStyle1 = new GUIStyle();
		//GUI.contentColor = new Color(0,0,0);
		GUIStyle1.richText = true;
		GUILayout.BeginArea(new Rect(10, 10, 400, 400), new GUIContent("Main Menu!", MenuBackgroundTexture), GUIStyle1); //Starts the area for our buttons
		
		GUILayout.BeginVertical(); //Starts the fact that we are adding stuff in a vertical row.
		
		GUILayout.BeginHorizontal();
			GUILayout.Label("Name: ");
			Name = GUILayout.TextField(Name);
			GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
	
		GUILayout.BeginHorizontal();
			GUILayout.Label("IP: ");
			ip = GUILayout.TextField(ip);
			GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
			GUILayout.Label("Port: ");
			port = GUILayout.TextField(port);
			GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
	
		GUILayout.BeginHorizontal();
			if(GUILayout.Button("Host Server")){
				netLoadobj.PlayerName = Name;
				Network.InitializeServer(30,System.Convert.ToInt32(port), false);
			}
		
			if(GUILayout.Button("Join Server")){
				netLoadobj.PlayerName = Name;
				Network.Connect(ip, System.Convert.ToInt32(port));
			}
			GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.FlexibleSpace();
			/*if(GUILayout.Button("Disconnect")){
				Network.Disconnect();
				MasterServer.UnregisterHost(); //Doesn't do anything unless we are registered, so I put it in here, just in case.
			}
			
			for (var level in supportedNetworkLevels) //Adds a button for every row.
			{
				if (GUILayout.Button(level)) //Buttons in Unity GUI are created and used in if statements
				{
					//Hopefully we will remove all the RPCs, and go to the next level
					Network.RemoveRPCsInGroup(0); 
					Network.RemoveRPCsInGroup(1); 
					networkView.RPC( "LoadLevel", RPCMode.AllBuffered, level, lastLevelPrefix + 1);
				}
			}*/
	
			//GUILayout.FlexibleSpace(); //Makes it flexible
			GUILayout.EndVertical();
			GUILayout.EndArea();
			
	
	}
	// Use this for initialization
	void Start () {
		netLoadobj = (GameObject.Find("networkLevelLoader").GetComponent(typeof(LevelLoader)) as LevelLoader);
		ip = "76.84.167.144";
		port = "27015";
		Name = "BowWacker";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
