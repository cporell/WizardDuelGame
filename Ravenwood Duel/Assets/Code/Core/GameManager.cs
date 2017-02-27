using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Game Manager started!!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 250, 100), "Game Manager started!!");
        GUI.Label(new Rect(0, 20, 250, 100), "Time is" + System.DateTime.Now.ToString());
    }
}
