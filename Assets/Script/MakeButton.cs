using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    [SerializeField] 
    private bool physical;
    // Start is called before the first frame update
    private GameObject player;
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallBack(temp));
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void AttachCallBack(string btn)
    {
        if(btn.CompareTo("MeleeBtn") == 0)
        {
            player.GetComponent<FighterAction>().SelectAttack("melee");

        }
        else if(btn.CompareTo("RangeBtn") == 0)
        {
            player.GetComponent<FighterAction>().SelectAttack("range");
        }
        else
        {
            player.GetComponent<FighterAction>().SelectAttack("run");
        }
    }
}
