using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape // INHERITANCE
{
    void Awake()
    {
        NameShape = "Cylinder";
        ColorShape = "Yellow";
    }

    void Update()
    {
        if (isSelecteble == true)
        {
            Timer(); // ABSTRACTION
            RotateShape.RotateThisShape(transform); // ABSTRACTION
        }
    }

    // POLYMORPHISM
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
