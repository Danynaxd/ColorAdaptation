using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextLevel : MonoBehaviour {

	public GameObject m_on, m_off;
	public void Play(){
		SceneManager.LoadScene ("play");
	}
	public void MainScene(){
		SceneManager.LoadScene ("Main");

	}
	public void Help(){
		SceneManager.LoadScene ("Help");
	}
	public void About(){
		SceneManager.LoadScene ("About");
	}

	void OnMouseAsButton() {	
	
		switch (gameObject.name) {
		case "Music":
			if (PlayerPrefs.GetString ("Music") != "no") {
				PlayerPrefs.SetString ("Music", "no");
				m_on.SetActive (false);
				m_off.SetActive (true);
			} else 
			{
				PlayerPrefs.SetString ("Music", "yes");
				m_on.SetActive (true);
				m_off.SetActive (false);
			}
			break;
		}
	}
}
