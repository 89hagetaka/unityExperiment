using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoChange2 : MonoBehaviour
{
    int Flag = 0;
    public Field field1;
    public Field field2;
    public Field field3;
    public Field field4;
    public Field field5;
    public GameObject Canvas;
    // インスペクター上で変更後の動画を指定
    public VideoClip MainClip2;
    // 動画１と２
    public VideoClip SubClip2;
    
    // 動画を映すスクリーン設定
    public VideoPlayer VideoPlayerComponentMain; //動画を見るのがメイン
    public VideoPlayer VideoPlayerComponentSub; //操作をするのがサブ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PushButton()
    {
        //各フィールドからの値を収集VCOUNTへ格納
        int VCount1;
        VCount1 = field1.GetVCount();
        int VCount2;
        VCount2 = field2.GetVCount();
        int VCount3;
        VCount3 = field3.GetVCount();
        int VCount4;
        VCount4 = field4.GetVCount();
        int VCount5;
        VCount5 = field5.GetVCount();
        Debug.Log("受け渡された値1→" + VCount1);
        Debug.Log("受け渡された値2→" + VCount2);
        Debug.Log("受け渡された値3→" + VCount3);
        Debug.Log("受け渡された値4→" + VCount4);
        Debug.Log("受け渡された値5→" + VCount5);
        if (VCount1==100){
            if (VCount2==30) {
                if (VCount3 == 20){
                    if (VCount4 == 100){
                        if (VCount5 == 51){
                            VideoPlayerComponentSub.clip = SubClip2;
                            VideoPlayerComponentMain.clip = MainClip2;
                            Flag = 1;
                        }
                    }
                }
            }
        }
       
    }
    public int GetFCount()
    {
        //Vの値を別スクリプトへ送る
        return Flag;
    }
}
