using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    [SerializeField] protected Text selectedShapeText;

    private string nameShape;
    public string NameShape
    {   
        get {return nameShape;}
        protected set {nameShape = value;}
    }
    private string colorShape;
    public string ColorShape
    {   
        get {return colorShape;}
        protected set {colorShape = value;}
    }
    protected virtual void DisplayText()
    {
        selectedShapeText.text = $"You selected: Shape";
    }
}
