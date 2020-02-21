using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CalculaorLibrary;

public class Calculator : MonoBehaviour
{
    public CalculaorLibrary.Calculator helper = new CalculaorLibrary.Calculator();
    public InputField InputX;
    public InputField InputY;


    public int X;
    public int Y;
    // public float ans;
    
    public Text Answer;

    // Start is called before the first frame update
    void Start(){
        Answer.text = "";
    }

    public void GetX(){
        X = int.Parse(InputX.text);
    }

    public void GetY(){
        Y = int.Parse(InputY.text);
    }

    public void Sum(){
        Answer.text = "" + helper.calAddition(X, Y);
    }

    public void Sub(){
        Answer.text = "" + helper.calSubtraction(X, Y);
    }

    public void Mul(){
        Answer.text = "" + helper.calMultiplaction(X, Y);
    }

    public void Div(){
        Answer.text = "" + helper.calDivision(X, Y);
    }

}
