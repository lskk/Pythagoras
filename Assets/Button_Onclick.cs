using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_Onclick : MonoBehaviour {
	[SerializeField]
	private GameObject Panel_Soal = null;
	[SerializeField]
	private Text player_button = null;
	[SerializeField]
	private Button[] but = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetPanelSoalVisible(){
		int c = int.Parse(player_button.text);
		ColorBlock cb;
		cb = but[c].colors;
		cb.normalColor = Color.blue;
		but[c].colors = cb;
		but[c].interactable = true;

		Panel_Soal.SetActive (true);
	}
}
