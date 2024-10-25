using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    void Awake()
    {
        NameShape = "Cube";
        ColorShape = "Green";
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
