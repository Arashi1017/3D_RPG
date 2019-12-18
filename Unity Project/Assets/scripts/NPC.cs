using UnityEngine;

public class NPC : MonoBehaviour
{
    private string _name = "聖誕老人";
    private string content = "可以幫我找找磁磚嗎";

    [Header("對話系統")]
    public DialogSystem Ds;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);

        if (other.name == "玩家") 
        {
            Ds.ShowDialog(_name, content);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print(other.name);

        if (other.name == "玩家") 
        {
            Ds.HideDialog();
        }
    }

}
