using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SaveName : MonoBehaviour
{
    public static SaveName instance;
    public TMP_InputField textBox;
    [SerializeField] public GameObject inputField;
    [SerializeField] public GameObject button;

    [SerializeField] UIManager displayName;
 
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        if (HighScore.high==true)

        {
            //Debug.Log("name is");
            inputField.SetActive(true);
            button.SetActive(true);
           
        }

    }

    public void clickSaveButton()

    {
        PlayerPrefs.SetString("name", textBox.text);
        inputField.SetActive(false);
        button.SetActive(false);
        HighScore.high = false;
        
    }
}
