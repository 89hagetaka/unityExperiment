using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Field : MonoBehaviour
{
	// このスクリプトをつけるのは判定場所　coliderにis　trigerをつける必要あり
	int Value = 0;
    int sum = 0;
    void Start()
	{

    }
	
	void OnTriggerEnter(Collider other)
	{

            //other.name後ろはオームの抵抗値
            if (other.name == "100")
            {
                Set(100);
            sum = sum + Value;
            Debug.Log("合体"+sum);

        }
            else if (other.name == "20")
            {
                Set(20);
            sum = sum + Value;
            Debug.Log("合体" + sum);
        }
            else if (other.name == "30")
            {
                Set(30);
            sum = sum + Value;
            Debug.Log("合体" + sum);
        }
            else if (other.name == "51")
            {
                Set(51);
            sum = sum + Value;
            Debug.Log("合体" + sum);
        }	
	}


	// 重なり中の判定
	void OnTriggerStay(Collider other)
	{
     
    }

	// 重なり離脱の判定
	void OnTriggerExit(Collider other)
	{

        if (other.name == "100")
        {
            Set(100);
            sum = sum - Value;
            Debug.Log("離脱"+sum);

        }
        else if (other.name == "20")
        {
            Set(20);
            sum = sum - Value;
            Debug.Log("離脱"+sum);
        }
        else if (other.name == "30")
        {
            Set(30);
            sum = sum - Value;
            Debug.Log("離脱"+sum);
        }
        else if (other.name == "51")
        {
            Set(51);
            sum = sum - Value;
            Debug.Log("離脱"+sum);
        }
       

        //抵抗オブジェクト離脱時にVの値を０に戻す
    }

	// Update is called once per frame
	void Update()
    {
       

    }
	
	void Set(int V)
    {
		//getvalueに送るためのvをセット
		Value = V;
	}

    public int GetVCount()
	{
		//Vの値を別スクリプトへ送る
		return sum;
	}


}
