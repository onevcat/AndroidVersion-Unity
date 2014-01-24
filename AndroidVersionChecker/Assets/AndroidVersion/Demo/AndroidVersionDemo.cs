using UnityEngine;
using System.Collections;

public class AndroidVersionDemo : MonoBehaviour {
    void OnGUI() {
    	GUI.Label(new Rect(0,0,100,50), "API Level:" + AndroidVersion.APILevel());
    }
}
