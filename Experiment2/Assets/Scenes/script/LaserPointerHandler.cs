using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class LaserPointerHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public SteamVR_LaserPointer laserPointer2;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
        laserPointer2.PointerIn += PointerInside;
        laserPointer2.PointerOut += PointerOutside;
        laserPointer2.PointerClick += PointerClick;
    }
    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "TestCube")
        {
            Debug.Log("Test cube found");
            GameObject testcube = GameObject.Find("TestCube");
            Debug.Log(testcube);
            testcube.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "TestCube")
        {
            GameObject testcube = GameObject.Find("TestCube");
            testcube.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "TestCube")
        {
            GameObject testcube = GameObject.Find("TestCube");
            testcube.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
