using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawn : MonoBehaviour
{
    public InputActionProperty createCube;
    public GameObject objectToCreate;

    void Start()
    {
        // Lier l'action pour créer l'objet
        createCube.action.performed += cxt => {
            var o = Instantiate(objectToCreate);
            o.transform.position = transform.position;
        };
    }

    private void OnDisable()
    {
        createCube.action.performed -= cxt => {
            var o = Instantiate(objectToCreate);
            o.transform.position = transform.position;
        };
    }
}
