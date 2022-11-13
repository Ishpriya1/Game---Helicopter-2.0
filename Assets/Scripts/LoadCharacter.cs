using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoadCharacter : MonoBehaviour
{
	public GameObject[] characterPrefabs;
	public Transform spawnPoint;
	GameObject clone;
	GameObject prefab;
	//public TMP_Text label;

	void Start()
	{
		/*if (clone != null) 
        {
			Destroy(clone);
        }*/
		int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
		prefab = characterPrefabs[selectedCharacter];
		clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
		clone.SetActive(true);

		//label.text = prefab.name;

		//CharacterSelection.characterSelection.characters[selectedCharacter].SetActive(true);


	}
}
