using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowMeName : MonoBehaviour
{
	public InputField PlayerName;
	public Text ShowName;

	// Start is called before the first frame update
	// Update is called once per frame
	void Update()
	{

	}

	public void DisplayName()
	{
		ShowName.text = PlayerName.text;
	}
}
