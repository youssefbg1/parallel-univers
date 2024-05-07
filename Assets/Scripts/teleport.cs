using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject ghost;
    private Vector3 firstpos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        ghost = GameObject.Find("Ghost");
        firstpos = ghost.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ghost.transform.position = player.transform.position + firstpos;
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            Vector3 tempPos = player.transform.position;
            player.transform.position = ghost.transform.position;
            ghost.transform.position = tempPos;
            Debug.Log("Teleport");
            firstpos = - firstpos;
        }
    }
}
