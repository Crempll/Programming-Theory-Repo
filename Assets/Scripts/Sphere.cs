using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    void Awake()
    {
        NameShape = "Sphere";
        ColorShape = "Red";
    }

    void Update()
    {
        if (isSelecteble == true)
        {
            Timer();
            RotateShape.RotateThisShape(transform);
        }
    }

    protected override void DisplayText()
    {
        selectedShapeText.text = $"You seleced: {ColorShape} {NameShape}";
    }

    void OnMouseDown()
    {
        isSelecteble = true;
        DisplayText();
    }
}
