using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
    public Sprite na;

}
public class Dialoging : MonoBehaviour
{

    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private SpriteRenderer charname;
    [SerializeField] private Text txt_Dialogue;
    [SerializeField] private SpriteRenderer note;
    [SerializeField] private SpriteRenderer option;
    [SerializeField] private SpriteRenderer inventory;
    [SerializeField] private SpriteRenderer navigation;
    [SerializeField] private SpriteRenderer timeinfo;
    [SerializeField] private SpriteRenderer dayinfo;
    [SerializeField] private Button eoghk;

    private bool showcheck = true;
    private int count = 0;

    GameDirector gamedirectorVariable;

    GameObject BackGround1;
    GameObject BackGround2;

    [SerializeField] private Dialogue[] dialogue;

    private bool GaYeongtxtcheck = false;
    private bool SungHyeontxtcheck = false;
    private bool DoHyeontxtcheck = false;
    private bool InBaetxtcheck = false;
    private bool JiEuntxtcheck = false;
    public void ShowDialogue()
    {
        OnOff(true);
        NextDialogue();
    }
    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        charname.gameObject.SetActive(_flag);

        note.gameObject.SetActive(!_flag);
        option.gameObject.SetActive(!_flag);
        inventory.gameObject.SetActive(!_flag);
        navigation.gameObject.SetActive(!_flag);
        timeinfo.gameObject.SetActive(!_flag);
        dayinfo.gameObject.SetActive(!_flag);
        eoghk.gameObject.SetActive(!_flag);
    }
    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        charname.sprite = dialogue[count].na;
        count++;
    }
    // Start is called before the first frame update
    void Start()
    {
        gamedirectorVariable = GameObject.Find("GameDirector").GetComponent<GameDirector>(); //���ӵ��� ��ũ��Ʈ���� ������ �����������ؼ� �����Ѻκ�.
        BackGround1 = GameObject.Find("blog");
        BackGround2 = GameObject.Find("subway");
        this.BackGround2.gameObject.SetActive(false);
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
  
        if (gamedirectorVariable.DayCount == 0)  
        {
            Debug.Log(count);
            if(showcheck == true)
            {
                showcheck = false;
                ShowDialogue();
            }
            if (Input.GetMouseButtonDown(0)) //����� Input.touchCount > 0 Input.GetMouseButtonDown(0) Input.GetKeyDown(KeyCode.Space)
            {
                if(count == 1)
                {
                    this.BackGround1.gameObject.SetActive(false);
                    this.BackGround2.gameObject.SetActive(true);
                }
                if(count == 6)
                {
                    this.BackGround2.gameObject.SetActive(false);
                }
                if(count == 19)
                {
                    SceneManager.LoadScene("LivingRoom");
                }
                if(count <= 39)
                {
                    NextDialogue();
                }
                
                else
                {
                    OnOff(false);
                    gamedirectorVariable.DayCount += 1;
                    gamedirectorVariable.tutorialcheck = 1;
                    showcheck = true;              
                }
            }
        }//���ѷα�. fade in, out �߰��� �ϸ� �ϼ�.
        selecttext();       
    }
    private int checknum = 1;  //�� üũ�� � ī��Ʈ�� ¦���� �ʱ�ȭ ���� ����.
    private void selecttext()  //���� ��ȭ �Լ�
    {
        if (gamedirectorVariable.GaYeongCount == 1 && GaYeongtxtcheck) // ���� ����1 ���� ��
        {
            showtext(56);//56���ؽ�Ʈ ���� ����
            if(checknum == 2)
            {
                gamedirectorVariable.GaYeongCount = 2; 
                GaYeongtxtcheck = false;
                checknum = 1;
            }
        }
        else if (gamedirectorVariable.JiEunCount == 1 && JiEuntxtcheck) // ���� ���� 1 ���� ��
        {
            showtext(68);
            if (checknum == 2)
            {
                gamedirectorVariable.JiEunCount = 2;
                JiEuntxtcheck = false;
                checknum = 1;
            }
        }
        else if (gamedirectorVariable.SungHyeonCount == 1 && SungHyeontxtcheck) // ���� ���� 1 ���� ��
        {
            showtext(78);
            if (checknum == 2)
            {
                gamedirectorVariable.SungHyeonCount = 2;
                SungHyeontxtcheck = false;
                checknum = 1;
            }
        }
        else if (gamedirectorVariable.InBaeCount == 1 && InBaetxtcheck) // �ι� ���� 1 ���� ��
        {
            showtext(91);
            if (checknum == 2)
            {
                gamedirectorVariable.InBaeCount = 2;
                InBaetxtcheck = false;
                checknum = 1;
            }
        }
        else if (gamedirectorVariable.DoHyeonCount == 1 && DoHyeontxtcheck) // ���� ���� 1 ���� ��
        {
            showtext(102);
            if (checknum == 2)
            {
                gamedirectorVariable.DoHyeonCount = 2;
                DoHyeontxtcheck = false;
                checknum = 1;
            }
        }
        
    }
    private void showtext(int num) //���ô�ȭ �����ֱ�.
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (count <= num)
            {
                NextDialogue();
            }
            else
            {
                OnOff(false);
                checknum = 2;
            }
        }
    }
    public void gayeongtext()  //���� ���� ��ȭ ����.
    {
        if (gamedirectorVariable.GaYeongCount == 1) //���� ����1 ���� ���� �� ī��Ʈ�� ���� ���� ��ȭ x��° ���
        {
            count = 41;
        }
        
        GaYeongtxtcheck = true;             //�������� Ȱ��ȭ.
        ShowDialogue();
    }

    public void sunghyeontext()  //���� ���� ��ȭ ����.
    {
        if (gamedirectorVariable.SungHyeonCount == 1)
        {
            count = 70;
        }
        SungHyeontxtcheck = true;
        ShowDialogue();
    }

    public void dohyeontext()  //���� ���� ��ȭ ����.
    {
        if (gamedirectorVariable.DoHyeonCount == 1)
        {
            count = 93;
        }
        DoHyeontxtcheck = true;
        ShowDialogue();
    }

    public void inbaetext()  //�ι� ���� ��ȭ ����.
    {
        if (gamedirectorVariable.InBaeCount == 1)
        {
            count = 80;
        }
        InBaetxtcheck = true;
        ShowDialogue();
    }

    public void jieuntext()  //���� ���� ��ȭ ����.
    {
        if (gamedirectorVariable.JiEunCount == 1)
        {
            count = 58;
        }
        JiEuntxtcheck = true;
        ShowDialogue();
    }
}
