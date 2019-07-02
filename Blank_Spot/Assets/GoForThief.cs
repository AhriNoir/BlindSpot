using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoForThief : MonoBehaviour
{
    [SerializeField] GameObject followGameObject;

    // Выполняется каждый кадр.
    private void Update()
    {
        // Если игрок умер, ничего не делать.
        if (!followGameObject)
        {
            return;
        }

        // Задаёт камере такую же позицию в плоскости (x, y), как у игрока.
        transform.position = new Vector3(x: followGameObject.transform.position.x,
                                         y: followGameObject.transform.position.y,
                                         z: transform.position.z);
    }

}
