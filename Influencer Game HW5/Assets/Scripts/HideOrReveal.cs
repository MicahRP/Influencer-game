using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOrReveal : MonoBehaviour
{	
	
	public GameObject gameobject; 
	
	public void HideObject()
		{
			gameobject.SetActive(false);		
		}

	public void ShowObject()
		{
			gameobject.SetActive(true);		
		}
}
