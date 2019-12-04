using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;

    public int C = 1;
    public int Prop = 1;
    public int D = 9;

    public float E = 99.9f;
    public float F = 10.3f;

    public float HP = 100f;
    public bool key;
    public int enemy;

    private void Start()
    {
        #region 數學運算子
        //加減乘除餘：+、-、*、/、%
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        //指派：先運算指派符號右邊再傳回左邊
        C = 9 + 1;
        print("C運算結果：" + C);

        //遞增：prop = prop +1 ; ←原本寫法
        print(Prop++);  //後置遞增，先輸出再運算
        print(++Prop);  //前置遞增，先運算再輸出

        //符號：
        //遞增++
        //遞減--
        //指派=
        //加法指派+=
        //減法指派-=
        //乘、除、餘同上


        #endregion

        #region 比較運算子
        //結果為布林值
        print(E > F);
        print(E < F);
        print(E >= F);
        print(E <= F);
        print(E == F);
        print(E != F);

        #endregion

        #region 邏輯運算子
        //並且&& 只要有一個false 結果就是false
        print(true && true);
        print(false && true);
        print(true && false);
        print(false && false);

        //或者|| 只要有一個true 結果就是true
        print(true || true);
        print(false || true);
        print(true || false);
        print(false || false);

        //相反!
        print(!true);
        print(!false);

        #endregion
    }

    private void Update()
    {
        print("死亡：" + (HP <= 0));
        print("過關判定：" + (key && enemy >= 5));
    }

}
