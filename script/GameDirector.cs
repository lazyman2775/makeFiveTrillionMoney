using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public int DayCount;
    public int GaYeongCount;
    public int SungHyeonCount;
    public int DoHyeonCount;
    public int InBaeCount;
    public int JiEunCount;
    public int six;
    public Button tutorialbutton;
    public Text tutorialtext;
    public int tutorialcheck;

    public Button gayeong;
    public Button sunghyeon;
    public Button dohyeon;
    public Button inbae;
    public Button jieun;
    // Start is called before the first frame update
    void Start()
    {
        DayCount = 0;
        GaYeongCount = 1;       //�̸��� ī��Ʈ�� Ȧ���� ��ġ ��ȭ ����. ī��Ʈ 1 = ��ġ��ȭ ù��°. ī��Ʈ3 = ��ġ��ȭ �ι�°.
        SungHyeonCount = 1;
        DoHyeonCount = 1;
        InBaeCount = 1;
        JiEunCount = 1;
        six = 0;
        tutorialcheck = 0;
        
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if(tutorialcheck == 1) //Ʃ�丮�� 1��.
        {
            tutorialbutton.gameObject.SetActive(true);
            tutorialtext.GetComponent<Text>().text = "+�ι����� Ʃ�丮��\n-�ι����� ��ȭ�� '��Ʈ'����\n��ȭ������ Ȯ���� �� �ֽ��ϴ�.";
            tutorialcheck = 0;
        }
        textchecking();
    }
    void textchecking() //��ȭ ������ ��Ȱ��ȭ ����.
    {
        if (GaYeongCount % 2 == 0)
            gayeong.gameObject.SetActive(false);
        if (SungHyeonCount % 2 == 0)
            sunghyeon.gameObject.SetActive(false);
        if (DoHyeonCount % 2 == 0)
            dohyeon.gameObject.SetActive(false);
        if (InBaeCount % 2 == 0)
            inbae.gameObject.SetActive(false);
        if (JiEunCount % 2 == 0)
            jieun.gameObject.SetActive(false);      
    }
}


