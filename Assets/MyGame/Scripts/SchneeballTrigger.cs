using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SchneeballTrigger : MonoBehaviour
{
    public GameObject letter;

    public AudioSource targetSound;

    public TMP_Text missionText;

    public bool isTargetHit = false;

    // Start is called before the first frame update
    void Start()
    {
        letter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isTargetHit == true)
        {
            letter.SetActive(true);
            isTargetHit = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Snowball"))
        {
            targetSound.Play();
            Destroy(other.transform.gameObject);
            isTargetHit = true;
            missionText.text = "Nimm den Brief und finde den Briefkasten";
        }
    }
}
