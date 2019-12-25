using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EatProp : MonoBehaviour
{
    [Header("寶相數量介面")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;
    public int propTotal = 10;

    public bool finish;


    //碰撞物件時執行一次(碰撞類型 碰到物件的資訊)
    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject);

        if (collision.gameObject.tag == "壺") 
        {
            Destroy(collision.gameObject);

            propCount++;
            textCount.text = "壺 " + propCount + "/10";


            if (propCount==propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }
    }

    private void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (finish)
        {
            //按下esc離開
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();     //應用程式.離開()
            }
            //按下R重來
            if (Input.GetKeyDown(KeyCode.R))
            {
                //Application.LoadLevel("遊戲畫面");   //舊版API
                SceneManager.LoadScene("遊戲畫面");
            }

        }
    }
}
