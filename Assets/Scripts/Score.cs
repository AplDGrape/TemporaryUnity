using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI TMP;

    //public GameObject platform;
    public TMP_Text scoreText;
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PF")
        {
            score += 1;
            scoreText.text = score.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
