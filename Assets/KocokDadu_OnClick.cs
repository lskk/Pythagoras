using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KocokDadu_OnClick : MonoBehaviour {
	[SerializeField]
	private Text hasil_kocok1 = null;
	[SerializeField]
	private Text hasil_kocok2 = null;
	[SerializeField]
	private Text player_button = null;
	[SerializeField]
	private Text lap = null;	
	[SerializeField]
	private Button[] but = null;
	[SerializeField]
	private GameObject Panel_Soal = null;

	// Use this for initialization
	void Start () {
		Panel_Soal.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void setText(){
		int a,b = 0;
		int c = int.Parse(player_button.text);
		int e = int.Parse (lap.text);
		float d;
		a = Random.Range(1,6);
		b = Random.Range(1,6);
		hasil_kocok1.text = a.ToString();
		hasil_kocok2.text = b.ToString();
		d =(Mathf.Sqrt (a * a + b * b));
		c += (int)d;
		ColorBlock cb;
		for (int count = 0; count < 24; count++) {
			cb = but[count].colors;
			cb.normalColor = Color.white;
			but[count].colors = cb;
			but[count].interactable = false;
		}

		if(c > 24){
			e++;
			c -= 24;
			lap.text = e.ToString();
		}

		cb = but[c].colors;
		cb.normalColor = Color.red;
		but[c].colors = cb;
		but[c].interactable = true;
		Panel_Soal.SetActive (false);

		player_button.text = c.ToString();
		}
}
