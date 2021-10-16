using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue{
			
		//allows you to choose name of character and number of sentences of dialogue
		public string name;

		[TextArea (3,10)]
		public string[] sentences;
}
