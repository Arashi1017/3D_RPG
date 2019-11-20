using UnityEngine;

public class Car : MonoBehaviour
{
    //定義欄位(設定變數)
    //語法寫法：
    //修飾詞+類型+名稱+(指定值)+結束(;)
      //修飾詞:私人private(預設)、公開public

    //類型:
    //整數int (指定值:=值)
   public int cc =2000;
    //浮點數float (=值f)
   public float weight =150.5f;
    //字串string (="字串")
   public string brand ="BMW";
    //布林值bool (=true/false)
   public bool _break =true;

    //屬性attribute
    [Header("年代")]
   public int _bc;
    [Range(10,300)]
   public float speed;
    [Tooltip("這是車車的顏色")]
   public string color;
}
