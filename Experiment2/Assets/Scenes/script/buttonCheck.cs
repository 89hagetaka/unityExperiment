using System;
using UnityEngine;
using Valve.VR;

//クラス名はファイル名（今回はbooleanlefttest）
public class buttonCheck : MonoBehaviour
{

    //GrabGripボタン（初期設定は側面ボタン）が押されてるのかを判定するためのGrabという関数にSteamVR_Actions.default_GrabGripを固定
    private SteamVR_Action_Boolean GrabG = SteamVR_Actions.default_GrabGrip;
    //結果の格納用Boolean型関数grapgrip
    private Boolean grapgrip;
    bool isCalledOnce = false;

    //1フレーム毎に呼び出されるUpdateメゾット
    void Update()
    {
        //結果をGetStateで取得してgrapgripに格納
        //SteamVR_Input_Sources.機器名（今回は左コントローラ）
        grapgrip = GrabG.GetState(SteamVR_Input_Sources.LeftHand);
        //GrabGripが押されているときにコンソールにGrabGripと表示
        if (grapgrip && !isCalledOnce)
        {
            isCalledOnce = true;
            Debug.Log(grapgrip);
        }

    }
}