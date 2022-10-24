using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        GameObject myGameObject = new GameObject("kurierka"); // Make a new GO.
        Rigidbody gameObjectsRigidBody = myGameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
        gameObjectsRigidBody.mass = 0.1f; // Set the GO's mass to 5 via the Rigidbody.
    }
}