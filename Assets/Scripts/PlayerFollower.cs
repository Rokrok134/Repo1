using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform TargetObject;

    public Vector3 Offset = new Vector3 (0f, 3f, 5f);


    // Update is called once per frame
    private void Update()
    {
        if(TargetObject != null) 
        {
            transform.position = TargetObject.position + Offset;
        }
}
}
