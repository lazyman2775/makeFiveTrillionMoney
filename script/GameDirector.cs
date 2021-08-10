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
        GaYeongCount = 1;       //이름별 카운트의 홀수가 터치 대화 순서. 카운트 1 = 터치대화 첫번째. 카운트3 = 터치대화 두번째.
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
        if(tutorialcheck == 1) //튜토리얼 1번.
        {
            tutorialbutton.gameObject.SetActive(true);
            tutorialtext.GetComponent<Text>().text = "+인물과의 튜토리얼\n-인물과의 대화후 '노트'에서\n대화내용을 확인할 수 있습니다.";
            tutorialcheck = 0;
        }
        textchecking();
    }
    void textchecking() //대화 없으면 비활성화 상태.
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


