using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testtwo : MonoBehaviour
{
    public Text m_TypingText;
    public string m_Message;
    public float m_Speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    }
    IEnumerator Typing(Text typingText, string message, float speed)
    {
        for (int i = 0; i < message.Length; i++)
        {
            typingText.text = message.Substring(0, i + 1);
            yield return new WaitForSeconds(speed);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
