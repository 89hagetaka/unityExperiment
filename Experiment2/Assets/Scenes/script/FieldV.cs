using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldV : MonoBehaviour
{
    int Testa = 0;
    int sum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {

        //other.name後ろはオームの抵抗値
        if (other.name == "Testa")
        {
            Set(1000);
            sum = sum + Testa;
            Debug.Log("合体T" + sum);

        }
   
    }


    // 重なり中の判定
    void OnTriggerStay(Collider other)
    {

    }

    // 重なり離脱の判定
    void OnTriggerExit(Collider other)
    {

        if (other.name == "Testa")
        {
            Set(1000);
            sum = sum - Testa;
            Debug.Log("離脱T" + sum);

        }
       


        //抵抗オブジェクト離脱時にVの値を０に戻す
    }

    // Update is called once per frame

    void Set(int T)
    {
        //getvalueに送るためのvをセット
        Testa = T;
    }

    public int GetTCount()
    {
        //Vの値を別スクリプトへ送る
        return sum;
    }
}
