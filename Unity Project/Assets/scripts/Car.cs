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

    //事件：在特定時間會以指定次數執行
    //開始事件：播放時執行一次
    //API功能-輸出(print)
    private void Start()
    {
        print("哈囉");
        //取得欄位
        print(cc);
        print(brand);
        //存放欄位
        //修改欄位資料，形態要相同
        //浮點數小數點必加f，整數不用
        weight = 999.9f;
        cc = 2000;
        color = "red";

    }

    //更新事件：約一秒執行60次(60FPS)
    //監聽玩家輸入事件
    private void Update()
    {
        print("拉拉拉");

        Drive(100,"前");    //呼叫自訂方法，必須給予引數
        Drive(200,"後","碰碰碰");
        Drive(300,"左",effect:"火花");    //具名方式

        int t = Tax();   //使用傳回方法，他會傳回一個資料
        print("稅金：" + t);
        print("減稅：" + (Tax() - 1000000));

    }

    //定義方法(宣告方法)
    //語法：
    //修飾詞+傳回類型+名稱 (參數1，參數2，......) {陳述式、演算法}
    //參數語法：類型+名稱
    //參數可加預設值：選填式參數(只能放在最右邊)
    //void 無傳回
    //自訂方法不會執行必須呼叫(到事件裡)


    public void Drive(int speed,string direction,string sound ="噗噗噗",string effect="煙霧")
    {
        print("開車~，時數："+speed);
        print("引擎聲："+sound);
        print("開車方向：" + direction);
        print("特效：" + effect);


    }

    public int Tax()
    {
        return cc * 1000;
    }


}
