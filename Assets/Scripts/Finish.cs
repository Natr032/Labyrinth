using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    public UnityEvent OnReached;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            if (player.TryGetComponent(out IDisable input))
            {
                input.Disable();
                OnReached?.Invoke();
#if UNITY_EDITOR
                Debug.Log("Finish!");
#endif
            }
        }
    }
}
