using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class QuizMensager : MonoBehaviour
{
    
    public Quiz[] perguntas;
    public TMP_Text QuizReceive;
    public Button[] QuizQuestions;
    
  
    public int QuizCount = 0;
    void Start()
    {
        MostrarQuiz();
    }


    public void MostrarQuiz()
    {
        Quiz pergunta = perguntas[QuizCount];
        QuizReceive.text = pergunta.QuizText;


        for (int i = 0; i < QuizQuestions.Length; i++) {
            QuizQuestions[i].GetComponentInChildren<TextMeshProUGUI>().text = pergunta.QuizGame[i];
            int index = i;

            QuizQuestions[i].onClick.AddListener(() => QuestionTrueOr(index));

            

        }
       
    }

   public void QuestionTrueOr(int index)
    {
        Quiz pergunta = perguntas[QuizCount];
        if (index == pergunta.QuizLevel)
        {

            Debug.Log("Acertou");
            
            

        }
        if (index != pergunta.QuizLevel)
        {

            Debug.Log("Errou");
            
        }
        QuizCount+= 1;
        MostrarQuiz();

    }
}


