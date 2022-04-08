using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 100f;
    [SerializeField] private Transform playerTransform;
    private float rotation = 0f;

    private void Start()
    {
        //Hide the cursor to achieve a better first person experience
        Cursor.lockState = CursorLockMode.Locked;

        //Initialize the camera rotation to look at the front of player
        transform.Rotate(0, 0, 0);
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Lock Y axis rotation to not look more than 90 degrees, up and down
        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
