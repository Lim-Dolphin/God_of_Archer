using UnityEngine;

public class ArrowForce : MonoBehaviour {
    
    private Rigidbody rb;
    private ArrowSelector arrowSelector;
    public float shootForce = 2000;

    public void SetSelector(ArrowSelector selector)
    {
        arrowSelector = selector;
    }

    private void OnEnable() {
        rb = GetComponent<Rigidbody>(); //we'll get the rigidbody of the arrow
        rb.velocity = Vector3.zero; //zero-out the velocity
        rb.useGravity = arrowSelector.arrowData.IsGravity;
        ApplyForce(); //Apply force so the arrow flies
    }
    // 이거 빼면 처음 방향으로 유지됨
    private void Update() { transform.right = Vector3.Slerp(transform.right, transform.GetComponent<Rigidbody>().velocity.normalized, Time.deltaTime); }
    
    // 오른쪽 방향으로 힘 넣어 쏘기 
    private void ApplyForce() { rb.AddRelativeForce(Vector3.right * shootForce); }

    // 중력 On -> 곡사
    // 중력 Off -> 직선
}
