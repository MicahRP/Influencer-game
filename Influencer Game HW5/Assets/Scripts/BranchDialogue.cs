using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BranchDialogue{
			
		//allows you to choose name of character and number of sentences of dialogue
		public string name;

		[TextArea (3,10)]
		public string[] Asentences;
                
                [TextArea (3,10)]
		public string[] Bsentences;
}
