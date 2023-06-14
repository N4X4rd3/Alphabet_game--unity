using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LearnUI : MonoBehaviour
{
    [SerializeField] private LearnManager LearnManager;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private Image questionImage;
    [SerializeField] private AudioSource questionAudio;
    [SerializeField] private List<Button> options;
    [SerializeField] private Color correctCol, wrongCol, NormalCol;

    private Question question;
    private bool answered;
    private float audioLenght;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetQuestion()
    {
        this.question = question;

        switch(question.questionType)
        {
            case QuestionType.TEXT:

                questionImage.transform.parent.gameObject.SetActive(false);

                break;
            case QuestionType.IMAGE:
                ImageHolder();
                questionImage.transform.gameObject.SetActive(true);
                questionImage.sprite = question.questionImg;
                break;
            case QuestionType.AUDIO:
                ImageHolder();
                questionAudio.transform.parent.gameObject.SetActive(true);

                audioLenght = question.questionClip.length;

                break;
        }

        questionText.text = question.questionInfo;

        List<string> answerList = ShuffleList.ShuffleListItems<string>(question.options);

        for(int i = 0; i < options.Count; i++)
        {
            options[i].GetComponentInChildren<Text>().text = answerList[i];
            options[i].name = answerList[i];
            options[i].image.color = NormalCol;
        }
    }

    IEnumerator PlayAudio()
    {
        if(question.questionType == QuestionType.AUDIO)
        {
            questionAudio.PlayOneShot(question.questionClip);

            yield return new WaitForSeconds(audioLenght + 0.5f);

            StartCoroutine(PlayAudio());
        }
        else 
        {
            StopCoroutine(PlayAudio());
            yield return null;
        }
    }

    void ImageHolder()
    {
        questionImage.transform.parent.gameObject.SetActive(true);
        questionImage.transform.gameObject.SetActive(false);
        questionAudio.transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
