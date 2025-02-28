using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Grading_System : MonoBehaviour
{

    public InputField WW1;
    public InputField WW2;
    public InputField WW3;
    public InputField PT1;
    public InputField PT2;
    public InputField QA;

    public float Add1;
    public float Add2;
    public float Add3;

    public float Divide1;
    public float Divide2;
    public float Divide3;

    public float Total1;
    public float Total2;
    public float Total3;
    public float TotalScore;



    public string Result_Text1;
    public string Result_Text2;
    public string Result_Text3;
    public string Total_Result;

    public Text WW_Total;
    public Text PT_Total;
    public Text QA_Total;
    public Text Total_Score;

    public void Grading()
    {
        int ww1 = 0, ww2 = 0, ww3 = 0, pt1 = 0, pt2 = 0, qa = 0;

        if (int.TryParse(WW1.text, out ww1)
            && int.TryParse(WW2.text, out ww2)
            && int.TryParse(WW3.text, out ww3)
            && int.TryParse(PT1.text, out pt1)
            && int.TryParse(PT2.text, out pt2)  
            && int.TryParse(QA.text, out qa))
        {


            if (ww1 > 25)
            {
                Debug.Log("Some values exceed expected limits.");
                return;
            }
            if (ww2 > 30)
            {
                Debug.Log("Some values exceed expected limits.");
                return;
            }
            if (ww3 > 15)
            {
                Debug.Log("Some values exceed expected limits.");
                return;
            }
            if (pt1 > 36)
            {
                Debug.Log("Some values exceed expected limits.");
                return;
            }
            if (pt2 > 20)
            {
                Debug.Log("Some values exceed expected limits.");
                return;
            }
            if (qa > 50)
            {
                Debug.Log("Some values exceed expected limits.");
                return;
            }




            Add1 = ww1 + ww2 + ww3;
            Add2 = pt1 + pt2;
            Add3 = qa;  

            Divide1 = Add1 / 70;
            Divide2 = Add2 / 56;
            Divide3 = Add3 / 50;

            Total1 = Divide1 * 20;
            Total2 = Divide2 * 60;
            Total3 = Divide3 * 20;

            TotalScore = Total1 + Total2 + Total3;

            Result_Text1 = Total1.ToString();
            Result_Text2 = Total2.ToString();
            Result_Text3 = Total3.ToString();

            Total_Result = TotalScore.ToString();

            WW_Total.text = Result_Text1;
            PT_Total.text = Result_Text2;   
            QA_Total.text = Result_Text3;
            Total_Score.text = Total_Result;


        }
        else
        {
            Debug.Log("Invalid input! Please enter valid integers.");
        }

    }



}
