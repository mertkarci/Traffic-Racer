using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class menuController : MonoBehaviour
{
    int control;
    public TextMeshProUGUI best;

    public bool menu;
    void Start()
    {
        
    }

    void Update()
    {
        if(menu)
        {
            best.text = "best <> " + ((int)PlayerPrefs.GetFloat("high")).ToString();

        }
    }
    public void menuControl(int control)
    {
        switch (control)
        {
            case 1:
                SceneManager.LoadScene("level");
                break;
            case 2:
                SceneManager.LoadScene("menu");
                break;
        }
    }
}
