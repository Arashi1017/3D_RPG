using UnityEngine;

public class LearnAPIstatic : MonoBehaviour
{
    private void Start()
    {
        //使用靜態成員 static
        //成員：屬性 properties (類別欄位 fields)
        //成員：方法 methods

        //取得靜態屬性語法：類別.屬性
        //設定靜態屬性語法：類別.屬性 = 值

        print(Random.value);

        //使用靜態方法語法：類別.方法(對應引數)

        print(Random.Range(1, 101));

        int r = Random.Range(100, 201);
        print(r);

        //使用API輸出 PI
        //使用API把-10去負數

        print(Mathf.PI);
        print(Mathf.Abs(-10));
    }

    //輸入 使用更新事件
    private void Update()
    {
        //print(Input.mousePosition);
        //print(Input.anyKeyDown);

        //print(Input.GetKeyDown("mouse 0"));
        print(Input.GetKeyDown(KeyCode.Mouse0));
    }
}
