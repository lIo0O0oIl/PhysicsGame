using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField] GameObject p_S, n_S, p_1, n_1;

    [SerializeField]
    SpriteRenderer[] oO;

    [SerializeField] GameObject title, P, N;

    [SerializeField] GameObject p_B, n_B;

    SpriteRenderer[] p_1A, n_1A;

    [SerializeField] GameObject backButton, backButton_n;
    public int gogo = 0;

    public bool clearP, clearN, startP, startN = false;
    [SerializeField] GameObject noClickPanel;
    [SerializeField] GameObject me, message;
    [SerializeField] TextMeshProUGUI m_message;
    int PC, NC = 0;

    [SerializeField] GameObject goNextButton;

    DragAndDrop dragAndDrop;


    void Start()
    {
        title.GetComponent<TextMeshProUGUI>().DOFade(1f, 2f);
        Invoke("Setting", 2.5f);

        dragAndDrop = FindObjectOfType<DragAndDrop>();
    }

    private void Update()
    {
        if (gogo == 7 && !dragAndDrop.nnn)
        {
            backButton.SetActive(true);
        }
        else if (gogo == 7 && dragAndDrop.nnn)
        {
            backButton_n.SetActive(true);
        }


        if (startP && !clearP)
        {

            if (Input.GetMouseButtonDown(0))
            {
                PC++;
                switch (PC)
                {
                    case 1:
                        m_message.text = "이 빈 공간을 양공이라 해.";
                        break;
                    case 2:
                        m_message.text = "이 양공의 의해서 원자가 띠 위에 양공의 의한 불순물 에너지 준위가 생겨";
                        break;
                    case 3:
                        m_message.text = "불순물 에너지 준위로 이동하는 전자들로 인해 원자가 띠에 다수의 양공이 생겨 전류가 흐를 수 있게 돼.";
                            break;
                    case 4:
                        m_message.text = "전자들을 움직여서 전류를 흐르게 해볼까?";
                        break;
                    case 5:
                        me.GetComponent<Image>().DOFade(0f, 1f);
                        message.GetComponent<Image>().DOFade(0f, 1f);
                        m_message.GetComponent<TextMeshProUGUI>().DOFade(0f, 1f);
                        noClickPanel.SetActive(false);
                        clearP = true;
                        break;
                }
            }
        }



        if (startN && !clearN)
        {

            if (Input.GetMouseButtonDown(0))
            {
                NC++;
                switch (NC)
                {
                    case 1:
                        m_message.text = "그래서 전도띠 아래 남는 전자의 의한 불순물 에너지 준위가 생기지.";
                        break;
                    case 2:
                        m_message.text = "불순물 에너지 준위에서 전도띠로 이동하는 전자들로 인해 전류가 흐를 수 있게 돼.";
                        break;
                    case 3:
                        m_message.text = "전자들을 움직여서 전류를 흐르게 해볼까?";
                        break;
                    case 4:
                        me.GetComponent<Image>().DOFade(0f, 1f);
                        message.GetComponent<Image>().DOFade(0f, 1f);
                        m_message.GetComponent<TextMeshProUGUI>().DOFade(0f, 1f);
                        noClickPanel.SetActive(false);
                        clearN = true;
                        break;
                }
            }
        }
    }




    void Setting()
    {
        title.GetComponent<TextMeshProUGUI>().DOFade(0f, 2f);
        Invoke("Setting_2", 1.5f);
    }

    void Setting_2()
    {
        p_S.SetActive(true);
        n_S.SetActive(true);
        P.SetActive(true);
        N.SetActive(true);
        p_B.SetActive(true);
        n_B.SetActive(true);

        p_S.GetComponent<SpriteRenderer>().DOFade(1f, 1.5f);
        n_S.GetComponent<SpriteRenderer>().DOFade(1f, 1.5f);
        P.GetComponent<TextMeshProUGUI>().DOFade(1f, 1.5f);
        N.GetComponent<TextMeshProUGUI>().DOFade(1f, 1.5f);
    }



    public void P_S()
    {
        for (int i = 0; i < oO.Length; i++)
        {
            oO[i].transform.localScale = new Vector3(15, 15, 1);
        }
        oO[0].transform.position = new Vector3(0, -4, 0);
        oO[1].transform.position = new Vector3(2.97f, -3.28f, 0);
        oO[2].transform.position = new Vector3(5.23f, -4f, 0);
        oO[3].transform.position = new Vector3(7.43f, -3.1f, 0);
        oO[4].transform.position = new Vector3(-2.97f, -3.28f, 0);
        oO[5].transform.position = new Vector3(-5.23f, -4f, 0);
        oO[6].transform.position = new Vector3(-7.43f, -3.1f, 0);

        me.transform.localPosition = new Vector3(680, 195, 0);
        me.transform.Rotate(new Vector3(0, 0, 0));                      //여기 버그 있음 회전버그...
        message.transform.localPosition = new Vector3(180, 185, 0);

        n_S.SetActive(false);
        P.SetActive(false);
        N.SetActive(false);
        p_B.SetActive(false);
        n_B.SetActive(false);

        p_S.transform.DOMove(new Vector3(-16.8f, 20.8f, 0),3f).SetEase(Ease.InQuad);
        p_S.transform.DOScale(new Vector3(210, 210, 0), 3f).SetEase(Ease.InQuad);

        Invoke("SetA", 3.2f);
    }

    void SetA()
    {
        p_1.SetActive(true);
        p_1A = p_1.GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < p_1A.Length; i++)
        {
            p_1A[i].DOFade(1f, 1.5f);
        }

        Invoke("SetA_A", 1.2f);
    }

    void SetA_A()
    {
        for (int i = 0; i < oO.Length; i++)
        {
            oO[i].DOFade(1f, 1.5f);
        }

        P_Clear();
    }

    void P_Clear()
    {
        if (!clearP)
        {
            noClickPanel.SetActive(true);
            startP = true;
            m_message.text = "P형 반도체는 원자가 전자가 3개라 전자가 비어있는 공간이 생겨.";

            me.GetComponent<Image>().DOFade(1f, 1f);
            message.GetComponent<Image>().DOFade(1f, 1f);
            m_message.GetComponent<TextMeshProUGUI>().DOFade(1f, 1f);
        }
    }




    public void N_S()
    {
        for (int i = 0; i < oO.Length; i++)
        {
            oO[i].transform.localScale = new Vector3(5, 5, 1);
        }
        oO[0].transform.position = new Vector3(0, 0.432f, 0);
        oO[1].transform.position = new Vector3(0.9f, 0.432f, 0);
        oO[2].transform.position = new Vector3(1.87f, 0.432f, 0);
        oO[3].transform.position = new Vector3(2.78f, 0.432f, 0);
        oO[4].transform.position = new Vector3(-0.9f, 0.432f, 0);
        oO[5].transform.position = new Vector3(-1.87f, 0.432f, 0);
        oO[6].transform.position = new Vector3(-2.78f, 0.432f, 0);

        me.transform.localPosition = new Vector3(730, -234, 0);
        me.transform.Rotate(new Vector3(0, 0, 180));
        message.transform.localPosition = new Vector3(240, -234, 0);

        p_S.SetActive(false);
        P.SetActive(false);
        N.SetActive(false);
        p_B.SetActive(false);
        n_B.SetActive(false);

        n_S.transform.DOMove(new Vector3(19f, -43.5f, 0), 3f).SetEase(Ease.InQuad);
        n_S.transform.DOScale(new Vector3(235, 235, 0), 3f).SetEase(Ease.InQuad);
        Camera.main.DOOrthoSize(2f, 3f);

        Invoke("SetB", 3.1f);
    }

    void SetB()
    {
        n_1.SetActive(true);
        n_1A = n_1.GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < n_1A.Length; i++)
        {
            n_1A[i].DOFade(1f, 1.5f);
        }

        Invoke("SetB_B", 1.2f);
    }

    void SetB_B()
    {
        for (int i = 0; i < oO.Length; i++)
        {
            oO[i].DOFade(1f, 1.5f);
        }

        N_Clear();
    }

    void N_Clear()
    {
        if (!clearN)
        {
            noClickPanel.SetActive(true);
            startN = true;
            m_message.text = "N형 반도체는 원자가 전자가 5개라 전자가 남아져.";

            me.GetComponent<Image>().DOFade(1f, 1f);
            message.GetComponent<Image>().DOFade(1f, 1f);
            m_message.GetComponent<TextMeshProUGUI>().DOFade(1f, 1f);
        }
    }






    public void GoNext(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }

    void GoNextButton()
    {
        goNextButton.SetActive(true);
    }






    public void Back_B_P()
    {
        gogo = 0;

        backButton.SetActive(false);

        for (int i = 0; i < p_1A.Length; i++)
        {
            p_1A[i].DOFade(0f, 1.5f);
        }

        p_S.transform.DOMove(new Vector3(-4f, 0, 0), 3f).SetEase(Ease.InQuad);
        p_S.transform.DOScale(new Vector3(10, 10, 0), 3f).SetEase(Ease.InQuad);

        n_S.SetActive(true);
        P.SetActive(true);
        N.SetActive(true);

        n_S.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        P.GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0, 0);
        N.GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0, 0);

        Invoke("Back_1_2", 3f);
    }

    void Back_1_2()
    {
        p_B.SetActive(true);
        n_B.SetActive(true);

        n_S.GetComponent<SpriteRenderer>().DOFade(1f, 1.5f);
        P.GetComponent<TextMeshProUGUI>().DOFade(1f, 1.5f);
        N.GetComponent<TextMeshProUGUI>().DOFade(1f, 1.5f);

        if (clearN && clearP)
        {
            Invoke("GoNextButton", 1.5f);
        }
    }


    public void Back_B_N()
    {
        gogo = 0;

        backButton_n.SetActive(false);

        for (int i = 0; i < n_1A.Length; i++)
        {
            n_1A[i].DOFade(0f, .5f);
        }

        n_S.transform.DOMove(new Vector3(4, 0, 0), 3f).SetEase(Ease.InQuad);
        n_S.transform.DOScale(new Vector3(10, 10, 0), 3f).SetEase(Ease.InQuad);
        Camera.main.DOOrthoSize(5f, 3f);

        p_S.SetActive(true);
        P.SetActive(true);
        N.SetActive(true);

        p_S.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        P.GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0, 0);
        N.GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0, 0);

        Invoke("Back_2_2", 3f);

        
    }

    void Back_2_2()
    {
        p_B.SetActive(true);
        n_B.SetActive(true);

        p_S.GetComponent<SpriteRenderer>().DOFade(1f, 1.5f);
        P.GetComponent<TextMeshProUGUI>().DOFade(1f, 1.5f);
        N.GetComponent<TextMeshProUGUI>().DOFade(1f, 1.5f);

        if (clearP && clearN)
        {
        Invoke("GoNextButton", 1.5f);
        }
    }
}
