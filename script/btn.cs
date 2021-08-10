using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btn : MonoBehaviour
{
    public ButtonType currentType;
    private int num = 1;
    public void OnBtnClick()
    {
        switch(currentType)
        {
            case ButtonType.New:
               
                
                SceneManager.LoadScene("SuYeonRoom");
                break;
            case ButtonType.Continue:
                Debug.Log("이어하기");
                break;
        }
    }
}

