using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    [SerializeField] protected Text selectedShapeText;

    protected bool isSelecteble;
    private float totalTime = 3f;

    private string nameShape;
    public string NameShape // ENCAPSULATION
    {   
        get {return nameShape;}
        protected set {nameShape = value;}
    }
    private string colorShape;
    public string ColorShape // ENCAPSULATION
    {   
        get {return colorShape;}
        protected set {colorShape = value;}
    }
    
    protected virtual void DisplayText()
    {
        selectedShapeText.text = $"You selected: Shape";
    }

    protected void Timer()
    {
        totalTime -= Time.deltaTime;

        if(totalTime <= 0f)
        {
            isSelecteble = false;
            totalTime = 3f;
        }
    }
}
