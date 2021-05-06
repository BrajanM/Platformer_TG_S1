using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
	public GameObject RestartMenuPanel;
	public GameObject Player;
    
	public static float GameSpeed;

	// Start is called before the first frame update
	void Start()
    {
		RestartMenuPanel.gameObject.SetActive(false);
		GameSpeed = 4;

	}

    // Update is called once per frame
    void Update()
    {
		//if (gameOver)
		//{
		//	RestartMenuPanel.gameObject.SetActive(true);
		//}
    }

	//public void RestartButtonClick()
	//{
	//	SceneManager.LoadScene("SampleScene");
	//}
}
