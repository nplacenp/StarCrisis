using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float controlSpeedX = 60f;
    [SerializeField] float controlSpeedY = 15f;


    // Update is called once per frame
    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");


        float xOffset = xThrow * Time.deltaTime * controlSpeedX;
        float newXPos = transform.localPosition.x + xOffset;

        float yOffset = yThrow * Time.deltaTime * controlSpeedY;
        float newYPos = transform.localPosition.y + yOffset;


        transform.localPosition = new Vector3
            (newXPos,
            newYPos,
            transform.localPosition.z);

    }
}
