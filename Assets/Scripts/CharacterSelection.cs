using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
	public GameObject[] characters;
	private int selectedCharacter = 0;

	public GameObject Skin1;
	public GameObject Skin2;
	public GameObject Skin3;
	public GameObject Skin4;
	public GameObject Skin5;
	public GameObject Skin6;
	public GameObject Skin7;


	public string MainGame;

	public static CharacterSelection characterSelection;



	public void Start()
    {

		characterSelection = this;

		Time.timeScale = 1;

		//characters[selectedCharacter].SetActive(true);

		//selectedCharacter = (selectedCharacter + 1) % characters.Length;

		PlayerPrefs.GetInt("selectedCharacter", selectedCharacter);

		characters[selectedCharacter].SetActive(true);


	}

	



	public void NextCharacter()
	{
		
		characters[selectedCharacter].SetActive(false);
		
		selectedCharacter = (selectedCharacter + 1) % characters.Length;
		
		//characters[selectedCharacter].SetActive(true);
		for(int i = 0; i < characters.Length; i++)
        {
            if (i == selectedCharacter)
            {
				characters[i].SetActive(true);
			}

            else
            {
				characters[i].SetActive(false);
			}
        }


		/*if(selectedCharacter == 0)
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
		}*/

	}

	public void PreviousCharacter()
	{
		
		selectedCharacter--;
		if (selectedCharacter < 0)
		{
			selectedCharacter += characters.Length;
		}
		//characters[selectedCharacter].SetActive(true);

		for (int i = 0; i < characters.Length; i++)
		{
			if (i == selectedCharacter)
			{
				characters[i].SetActive(true);
			}

			else
			{
				characters[i].SetActive(false);
			}
		}

	}

	public void StartGame()
	{
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		Debug.Log("Selected character: " + selectedCharacter);
		characters[selectedCharacter].SetActive(true);
		SceneManager.LoadScene(MainGame, LoadSceneMode.Single);
	}

	public void Replay()
    {
		SceneManager.LoadScene(MainGame, LoadSceneMode.Single);
		int character = PlayerPrefs.GetInt("selectedCharacter", selectedCharacter);
		characters[character].SetActive(true);
		
	}


}
