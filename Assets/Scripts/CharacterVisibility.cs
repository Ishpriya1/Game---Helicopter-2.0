using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterVisibility : MonoBehaviour
{
	public GameObject[] characters;
	public int selectedCharacter = 0;

	public GameObject Skin1;
	public GameObject Skin2;
	public GameObject Skin3;
	public GameObject Skin4;
	public GameObject Skin5;
	public GameObject Skin6;
	public GameObject Skin7;


	public void NextCharacter()
	{

		characters[selectedCharacter].SetActive(false);
		//characters[selectedCharacter].GetComponent<SpriteRenderer>().enabled = false;

		selectedCharacter = (selectedCharacter + 1) % characters.Length;

		characters[selectedCharacter].SetActive(true);

		if (selectedCharacter == 0)
		{
			Skin1.SetActive(true);
			Skin2.SetActive(false);
			Skin3.SetActive(false);
			Skin4.SetActive(false);
			Skin5.SetActive(false);
			Skin6.SetActive(false);
			Skin7.SetActive(false);
		}

		if (selectedCharacter == 1)
		{
			Skin1.SetActive(false);
			Skin2.SetActive(true);
			Skin3.SetActive(false);
			Skin4.SetActive(false);
			Skin5.SetActive(false);
			Skin6.SetActive(false);
			Skin7.SetActive(false);
		}

		if (selectedCharacter == 2)
		{
			Skin1.SetActive(false);
			Skin2.SetActive(false);
			Skin3.SetActive(true);
			Skin4.SetActive(false);
			Skin5.SetActive(false);
			Skin6.SetActive(false);
			Skin7.SetActive(false);
		}

		if (selectedCharacter == 3)
		{
			Skin1.SetActive(false);
			Skin2.SetActive(false);
			Skin3.SetActive(false);
			Skin4.SetActive(true);
			Skin5.SetActive(false);
			Skin6.SetActive(false);
			Skin7.SetActive(false);
		}

		if (selectedCharacter == 4)
		{
			Skin1.SetActive(false);
			Skin2.SetActive(false);
			Skin3.SetActive(false);
			Skin4.SetActive(false);
			Skin5.SetActive(true);
			Skin6.SetActive(false);
			Skin7.SetActive(false);
		}

		if (selectedCharacter == 5)
		{
			Skin1.SetActive(false);
			Skin2.SetActive(false);
			Skin3.SetActive(false);
			Skin4.SetActive(false);
			Skin5.SetActive(false);
			Skin6.SetActive(true);
			Skin7.SetActive(false);
		}

		if (selectedCharacter == 6)
		{
			Skin1.SetActive(false);
			Skin2.SetActive(false);
			Skin3.SetActive(false);
			Skin4.SetActive(false);
			Skin5.SetActive(false);
			Skin6.SetActive(false);
			Skin7.SetActive(true);
		}

	}

	public void PreviousCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter--;
		if (selectedCharacter < 0)
		{
			selectedCharacter += characters.Length;
		}
		characters[selectedCharacter].SetActive(true);

	}

	public void StartGame()
	{
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}


}
