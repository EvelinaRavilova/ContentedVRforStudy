using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAnotherScreen : MonoBehaviour {

	public GameObject screenToDisable;
	public GameObject screenToEnable;

	public void Open(){
		screenToDisable.SetActive (false);
		screenToEnable.SetActive (true);
	}
}
