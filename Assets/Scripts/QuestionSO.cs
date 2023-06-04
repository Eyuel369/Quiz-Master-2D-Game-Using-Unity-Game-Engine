using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Question", menuName = "Quiz Question")]
public class QuestionSO : ScriptableObject {
    
    [TextArea(2,6)]
    [SerializeField] string question = "enter new Question text here";
    [SerializeField] string[] Answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion(){
        return question;
    }

    public string GetAnswers(int index){
        return Answers[index];
    }

    public int GetCorrectAnswersIndex(){
        return correctAnswerIndex;
    }
}