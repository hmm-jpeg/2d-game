using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMFLIP : MonoBehaviour
{
    public Transform Player;
    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position;
    }
}
