using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;
    public int score;


    private void Start()
    {
        //if (布林值){陳述式或演算法}
        //()內布林值為 true 時執行{}內容

        if (true)
        {
            print("測試");
        }
    }

    private void Update()
    {
        if (openDoor)
        {
            //()內布林值為 true 時執行 if{}內容
            print("開門");
        }
        else
        {
            //()內布林值為 false 時執行 elsa{}內容
            print("關門");
        }

        if (score>=60)
        {
            print("及格");
        }
        else if (score>=50)
        {
            print("可以補考!");
        }
        else
        {
            print("不及格");
        }
    }

}
