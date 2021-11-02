using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class upAndDownMoveAtLeftHand : MonoBehaviour
{
    public SteamVR_Action_Vector2 TrackPad = SteamVR_Actions.default_TrackPad;
    private Vector2 pos;
    //GrabGripボタン（初期設定は側面ボタン）が押されてるのかを判定するためのGrabという関数にSteamVR_Actions.default_GrabGripを固定
    public SteamVR_Action_Boolean GrabG = SteamVR_Actions.default_GrabGrip;
    //結果の格納用Boolean型関数grapgrip
    private Boolean grapgrip;

    // Update is called once per frame
    void FixedUpdate()
    {
        grapgrip = GrabG.GetState(SteamVR_Input_Sources.LeftHand);

        /*
         * it is for debug
         * 
        if (grapgrip)
        {
            Debug.Log(grapgrip);
        }
        */

        //posに右手のtrackpad入力を入れている
        pos = TrackPad.GetLastAxis(SteamVR_Input_Sources.LeftHand);
        if (pos.y != 0.0 && grapgrip)
        {
            //Debug.Log("move vertically");
            //移動計算
            transform.position += new Vector3(0, pos.y*0.01f, 0);
        }
        //移動結果の座標表示
        //Debug.Log(pos.y);

    }
}
