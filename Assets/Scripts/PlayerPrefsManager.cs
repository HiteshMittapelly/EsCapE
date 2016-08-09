using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string Player_X = "player_x";
	const string Player_Y = "player_y";
	const string Player_Z = "player_z";
	const string Visited_Key = "visited_key";
	const string Visited_KeyOne = "visited_keyone";

	public static void SetPlayer_X(float x){
		PlayerPrefs.SetFloat ("player_x", x);
	}

	public static void SetPlayer_Y(float y){
		PlayerPrefs.SetFloat ("player_y", y);
	}

	public static void SetPlayer_Z(float z){
		PlayerPrefs.SetFloat ("player_z", z);
	}

	public static void SetVisitedKey(int k){
		PlayerPrefs.SetInt ("visited_key", k);
	}

	public static void SetVisitedKeyOne(int k){
		PlayerPrefs.SetInt ("visited_keyone", k);
	}

	public static float GetPlayer_X(){
		return PlayerPrefs.GetFloat ("player_x");
	}

	public static float GetPlayer_Y(){
		return PlayerPrefs.GetFloat ("player_y");
	}

	public static float GetPlayer_Z(){
		return PlayerPrefs.GetFloat ("player_z");
	}

	public static int GetVisitedKey(){
		return PlayerPrefs.GetInt ("visited_key");
	}

	public static int GetVisitedKeyOne(){
		return PlayerPrefs.GetInt ("visited_keyone");
	}
}
