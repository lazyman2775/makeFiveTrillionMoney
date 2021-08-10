using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fade : MonoBehaviour
{
    // Start is called before the first frame update
    public Image fadeout;
    void Start()
    {
        StartCoroutine(FadeCroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FadeCroutine()
    {
        float fadeCount = 1.0f;
        while (fadeCount > 0.0f)
        {
            fadeCount -= 0.005f;
            yield return new WaitForSeconds(0.01f);
            fadeout.color = new Color(0, 0, 0, fadeCount);
        }
        this.gameObject.SetActive(false);
    }
}
