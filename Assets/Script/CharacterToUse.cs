using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterToUse : MonoBehaviour
{
    public GameObject[] charactersInGame;
    private int chosenCharacter;
    // Start is called before the first frame update
    void Awake()
    {
        chosenCharacter = PlayerPrefs.GetInt("CharacterChoice"); 

        for(int i =0; i< charactersInGame.Length; i++)
        {
            charactersInGame[i].gameObject.SetActive(false);

        }

        charactersInGame[chosenCharacter].gameObject.SetActive(true);

    }

   
}
