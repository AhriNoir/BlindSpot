using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOmSwipe : MonoBehaviour
{

    private Vector3 fingerDown;
    private Vector3 fingerUp;
    private Vector3 move_vect;

    public float SWIPE_THRESHOLD = 20f;

    // Start is called before the first frame update
    void Start()
    {
        move_vect = new Vector3(x: 0, y: 0, z: 0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        foreach (Touch touch in Input.touches)
        {
            Debug.Log("TOuch");
            if (touch.phase == TouchPhase.Began)
            {
                fingerUp = touch.position;
                fingerDown = touch.position;
            }

            //Detects Swipe while finger is still moving
            if (touch.phase == TouchPhase.Moved)
            {
                fingerDown = touch.position;
                checkSwipe();
            }

            //Detects swipe after finger is released
            if (touch.phase == TouchPhase.Ended)
            {
                fingerDown = touch.position;
                checkSwipe();
                
            }
    
        }
    
    }

    void checkSwipe()
    {
        if (count_move() > SWIPE_THRESHOLD)
        {
            Vector3 vect = fingerDown - fingerUp;
            move_vect = new Vector3(x: vect.x / count_move() * (float)0.2,
                                    y: vect.y / count_move() * (float)0.2,
                                    z: 0);
            fingerUp = fingerDown;
        }
    }

    float count_move()
    {
        return Mathf.Sqrt(Mathf.Abs((fingerDown.y - fingerUp.y)* (fingerDown.y - fingerUp.y) + (fingerDown.x - fingerUp.x)* (fingerDown.x - fingerUp.x)));
    }

    //////////////////////////////////CALLBACK FUNCTIONS/////////////////////////////
    void Move()
    {
        transform.position = new Vector3(x: transform.position.x + move_vect.x,
                                         y: transform.position.y + move_vect.y,
                                         z: transform.position.z);
    }
    void OnCollisionStay(Collision collision)
    {
        move_vect = new Vector3(x: -move_vect.x,
                                    y: -move_vect.y,
                                    z: 0);
        Debug.Log("Enter");
    }
}
