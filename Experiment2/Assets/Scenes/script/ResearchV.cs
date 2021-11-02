using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ResearchV : MonoBehaviour
{
    // Start is called before the first frame update
    public FieldV field1_1;
    public FieldV field1_2;
    public FieldV field2_1;
    public FieldV field2_2;
    public FieldV field3_1;
    public FieldV field3_2;
    public FieldV field4_1;
    public FieldV field4_2;
    public FieldV field5_1;
    public FieldV field5_2;
    public GameObject Canvas;
    // 動画１と２
    public VideoClip MainClip;
    public VideoClip SubClip;
    // 動画を映すスクリーン設定
    public VideoPlayer VideoPlayerComponentMain;
    public VideoPlayer VideoPlayerComponentSub;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PushButton()
    {
        int Flag;
        
        int TCount1;
        TCount1 = field1_1.GetTCount();
        int TCount2;
        TCount2 = field1_2.GetTCount();
        int TCount3;
        TCount3 = field2_1.GetTCount();
        int TCount4;
        TCount4 = field2_2.GetTCount();
        int TCount5;
        TCount5 = field3_1.GetTCount();
        int TCount6;
        TCount6 = field3_2.GetTCount();
        int TCount7;
        TCount7 = field4_1.GetTCount();
        int TCount8;
        TCount8 = field4_2.GetTCount();
        int TCount9;
        TCount9 = field5_1.GetTCount();
        int TCount10;
        TCount10 = field5_2.GetTCount();
        if (TCount1 == 1000)
        {
            if (TCount2 == 1000)
            {
                VideoPlayerComponentSub.clip = SubClip;
                VideoPlayerComponentMain.clip = MainClip;
}
        }
      }
   }
