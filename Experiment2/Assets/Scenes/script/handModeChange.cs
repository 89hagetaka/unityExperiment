using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class handModeChange : MonoBehaviour
{
    public Transform hand;
    public Transform laserHand;

    public SteamVR_Action_Boolean GrabG = SteamVR_Actions.default_GrabGrip;
    public Boolean grabgrip;

    // Start is called before the first frame update
    void Start()
    {
        hand = transform.Find("hand");
        laserHand = transform.Find("laserHand");

    }

    // Update is called once per frame
    void Update()
    {

        grabgrip = GrabG.GetState(SteamVR_Input_Sources.LeftHand);
        if (grabgrip)
        {
            Debug.Log("GrabGrip");
        }

        if (hand.gameObject.activeSelf == true && grabgrip == true)
        {
            hand.gameObject.SetActive(false);
            laserHand.gameObject.SetActive(true);
        }
        if (laserHand.gameObject.activeSelf == true && grabgrip == true)
        {
            hand.gameObject.SetActive(false);
            laserHand.gameObject.SetActive(true);
        }
    }
}
