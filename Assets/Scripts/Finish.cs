using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    public UnityEvent OnReached;

    private Transform _cachedTransform;
    private bool _isReached;
    private float _scalingFactor = 20f;
    private float _scalingStep = .02f;

    private void Awake()
    {
        _cachedTransform = transform;
    }

    private void OnEnable()
    {
        OnReached.AddListener(ScaleFinish);
    }

    private void OnDisable()
    {
        OnReached.RemoveListener(ScaleFinish);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_isReached)
        {
            if (other.TryGetComponent(out Player player))
            {
                if (player.TryGetComponent(out IDisable input))
                {
                    _isReached = true;
                    input.Disable();
                    OnReached?.Invoke();
#if UNITY_EDITOR
                    Debug.Log("Finish!");
#endif
                }
            }
        }
    }

    private void ScaleFinish()
    {
        Vector3 newScale = new Vector3(
            _cachedTransform.localScale.x * _scalingFactor, 
            _cachedTransform.localScale.y, 
            _cachedTransform.localScale.z * _scalingFactor
        );
        StartCoroutine(ScaleIn(newScale));
    }

    private IEnumerator ScaleIn(Vector3 scale)
    {
        while (_cachedTransform.localScale.x < scale.x || _cachedTransform.localScale.y < scale.y)
        {
            yield return new WaitForEndOfFrame();
            _cachedTransform.localScale += new Vector3(
                _scalingStep, 
                scale.y, 
                _scalingStep
            );
        }
    }
}
