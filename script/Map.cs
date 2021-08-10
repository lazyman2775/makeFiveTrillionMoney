using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void SceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "GaYeongRoom":
                SceneManager.LoadScene("GaYeongRoom");
                break;
            case "Basement":
                SceneManager.LoadScene("Basement");
                break;
            case "Cafeteria":
                SceneManager.LoadScene("Cafeteria");
                break;
            case "SuYeonRoom":
                SceneManager.LoadScene("SuYeonRoom");
                break;
            case "InBaeRoom":
                SceneManager.LoadScene("InBaeRoom");
                break;
            case "DoHyenRoom":
                SceneManager.LoadScene("DoHyeneRoom");
                break;
        }
    }
}
