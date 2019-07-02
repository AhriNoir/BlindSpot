using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FieldOfView : MonoBehaviour
{
    [SerializeField] float viewRadius = 10;
    [SerializeField] float viewAngle = 90;
    Collider2D[] playerInRadius;
    [SerializeField] LayerMask obstacleMask, playerMask;

    public List<Transform> visiblePlayer = new List<Transform>();

    void FixedUpdate()
    {
        FindVisiblePlayer();
    }

    void FindVisiblePlayer()
    {
        playerInRadius = Physics2D.OverlapCircleAll(transform.position, viewRadius);

        visiblePlayer.Clear();

        for(int i = 0; i < playerInRadius.Length; i++)
        {
            Transform player = playerInRadius[i].transform;
            Vector2 dirPlayer = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
            if (Vector2.Angle(dirPlayer, transform.right) < viewAngle / 2)
            {
                float distancePlayer = Vector2.Distance(transform.position, player.position);

                if(!Physics2D.Raycast(transform.position, dirPlayer, distancePlayer, obstacleMask))
                {
                    visiblePlayer.Add(player);
                }
            }
        }
    }

    public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.z;
        }
        return new Vector2(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
}