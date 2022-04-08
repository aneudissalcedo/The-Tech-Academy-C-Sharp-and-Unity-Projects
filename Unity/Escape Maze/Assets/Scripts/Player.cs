using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    [SerializeField] private LoadScene loadScene;
    [Space]
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float speed = 3f;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Congratulations you reached the goal!");
            //Go to Win Screen
            loadScene.LoadSceneByName("WinScreen");
        }
        else if (other.CompareTag("Enemy"))
        {
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("You trigger with an enemy");
            //Go to lose Screen
            loadScene.LoadSceneByName("LoseScreen");
        }
    }
}
