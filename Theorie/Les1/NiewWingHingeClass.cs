using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WingHinge
{
    [HideInInspector]
    public new string name = "WingHinge";

    public GameObject p0;
    public GameObject p1;
    [HideInInspector]
    public GameObject hingeObj;

    public Vector3 hingePos = Vector3.zero;

    public bool verticalHinge = false;
    public bool flipVertical = false;
    public bool horizontalHinge = false;
    public MinMax verticalAngle = new MinMax(0, 0);
    public MinMax horizontalAngle = new MinMax(0, 0);

    public float hingeLerp = 0;


    public WingHinge(string n) {
        this.name = n;
    }

    public void UpdateHinge() {
        if (p0 != null && p1 != null) {
            float _y = 0, _z = 0;
            if (horizontalHinge) {
                _y = Mathf.Lerp(horizontalAngle.Min,     horizontalAngle.Max,    hingeLerp);
            }
            if (verticalHinge) {
                _z = Mathf.Lerp(verticalAngle.Min,       verticalAngle.Max,      hingeLerp);
            }
            hingeObj.transform.localRotation = Quaternion.Euler(0, _y, _z);
        }
    }

}