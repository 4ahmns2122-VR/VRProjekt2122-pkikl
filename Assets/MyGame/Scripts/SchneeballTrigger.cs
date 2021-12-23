using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchneeballTrigger : MonoBehaviour
{
    public GameObject snowball;
    public GameObject letter;

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
            snowball.SetActive(false);
            isTargetHit = true;
        }
    }
}
