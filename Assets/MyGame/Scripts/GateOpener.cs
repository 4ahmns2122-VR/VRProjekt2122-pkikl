using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public GameObject player;
    public Animator doorOpenAnim;

    public AudioSource angelsSing;

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
        if (other.gameObject == player)
        {
            doorOpenAnim.SetTrigger("DoorOpen");
            angelsSing.Play();

        }
    }
}
