using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public GameObject[] characters;
    public int charNum = 0;
    public const int startNum = 0;

    public void RightClick()
    {
      
            characters[charNum].SetActive(false);
            charNum = (charNum+ 1)% characters.Length;
            characters[charNum].SetActive(true);
          

    }

    public void LeftClick()
    {
        if (charNum > startNum)
        {
            characters[charNum].SetActive(false);
            charNum--;
            characters[charNum].SetActive(true);
        }
    }

    

    public void Select()
    {
        PlayerPrefs.SetInt("CharacterChoice", charNum);
        SceneManager.LoadScene(1);
    }

  
}
