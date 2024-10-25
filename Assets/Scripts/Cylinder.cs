using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    void Awake()
    {
        NameShape = "Cylinder";
        ColorShape = "Yellow";
    }

    protected override void DisplayText()
    {
        selectedShapeText.text = $"You seleced: {ColorShape} {NameShape}";
    }

    void OnMouseDown()
    {
        DisplayText();
    }
}
