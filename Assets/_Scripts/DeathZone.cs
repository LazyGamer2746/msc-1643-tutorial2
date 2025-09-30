using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform startPos;
    public GameObject ballPreFab;
    public int opposingPlayer;

    private void OnTriggerEnter(Collider other)
    
    {
        if (other.transform.CompareTag("Ball"))
        {
            //Debug.Log($"{other.transform.name} just entered {transform.name}");
            GameManager.AddScore(opposingPlayer);

            Destroy(other.gameObject);

            Instantiate(ballPreFab, startPos.position, Quaternion.identity);
        }
        
    }
        
}
