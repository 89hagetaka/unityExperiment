using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class changeSceneLaser : MonoBehaviour
{
    //右手用
    public SteamVR_LaserPointer laserPointer;
    //左手用
    public SteamVR_LaserPointer laserPointer2;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerClick += PointerClick;
        laserPointer2.PointerIn += PointerInside;
        laserPointer2.PointerClick += PointerClick;
        GameObject button1 = GameObject.Find("Button1");
        button1.GetComponent<Image>().color = Color.red;
    }

    //レーザーポインターをtargetに焦点をあわせてトリガーをひいたとき
    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (GameObject.Find("Button1"))
        {
            Debug.Log("hello button1");
        }

        //3Dオブジェクト「TestCube」の色を赤色に変更する
        if (e.target.name == "Button1")
        {
            Debug.Log("found button1");
            GameObject button1 = GameObject.Find("Button1");
            button1.GetComponent<Image>().color = Color.red;
        }
    }

    //レーザーポインターがtargetに触れたとき
    public void PointerInside(object sender, PointerEventArgs e)
    {
        //3Dオブジェクト「TestCube」の色を青色に変更する
        if (e.target.name == "Button1")
        {
            GameObject button1 = GameObject.Find("Button1");
            button1.GetComponent<Image>().color = Color.blue;
        }
    }

}
