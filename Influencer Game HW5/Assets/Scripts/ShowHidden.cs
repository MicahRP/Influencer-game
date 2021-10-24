using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//object starts hidden and you can reveal later on then hide again + repeat
public class ShowHidden : MonoBehaviour
{	
	public GameObject gameobject;
	
	void Start(){
	gameobject.SetActive(false);
	}

	public void HideObject()
		{
			gameobject.SetActive(false);		
		}

	public void ShowObject()
		{
			gameobject.SetActive(true);		
		}
}
