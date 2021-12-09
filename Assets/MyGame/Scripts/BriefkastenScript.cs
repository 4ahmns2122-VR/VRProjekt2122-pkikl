using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefkastenScript : MonoBehaviour
{
    public GameObject letter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        letter.SetActive(false);
    }
}
