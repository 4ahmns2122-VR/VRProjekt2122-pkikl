using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BriefkastenScript : MonoBehaviour
{
    public GameObject letter;
    public GameObject doorNew;
    public GameObject doorOld;

    public TMP_Text newMission;


    public bool isLetterThrownIn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isLetterThrownIn == true)
        {
            doorOld.SetActive(false);
            doorNew.SetActive(true);
            isLetterThrownIn = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Letter"))
        {
            // print("1");
            letter.SetActive(false);
            isLetterThrownIn = true;
            newMission.text = "Gehe zum Tor";
        }
    }
}
