using UnityEngine;
using System.Collections;

public class AndroidVersion {
	
	private static AndroidJavaClass _jc = null;
	
	private static AndroidJavaClass jc 
	{
		get {
			if (_jc == null) {
				try {
					_jc = new AndroidJavaClass("com.kayac.androidVersion.VersionChecker");
				} catch (System.Exception e) {
					Debug.Log(e.ToString());
				}
			}
			return _jc;
		}
	}
	
	public static int APILevel() {
		if (Application.platform == RuntimePlatform.Android) {
			if (jc != null) {
				return jc.CallStatic<int>("APILevel");
			}
		}
		return -1;
	}
}
