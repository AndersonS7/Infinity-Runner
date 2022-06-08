using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] Text scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = PlayerPrefs.GetInt("score").ToString();
    }
}
