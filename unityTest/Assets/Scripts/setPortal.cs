using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPortal : MonoBehaviour
{
    public GameObject nextScene;
    private teleportManager teleportManagerObj;

    private void Start()
    {
        teleportManagerObj = GameObject.Find("TeleportMgr").GetComponent<teleportManager>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("포탈 이동");

            nextScene.SetActive(true);
            teleportManagerObj.GetComponent<teleportManager>().EnterPortals(nextScene);
        }
    }
}