using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour

{
public Animator StartButton;
public Animator SettingsButton; 
    // Start is called before the first frame update


    public void OpenSettings()
    {
        StartButton.SetBool("isHidden",true);
        SettingsButton.SetBool("isHidden", true);
    }
    public void StartGame()
    {

        SceneManager.LoadScene("RocketMouse");
    }
}