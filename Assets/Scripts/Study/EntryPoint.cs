using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] Human _humanPrefab;
    [SerializeField] Elf _dlfPrefab;
    [SerializeField] Dworf _dworfPrefab;

    private PoolObject<Human> _humans;
    private PoolObject<Elf> _elfs;
    private PoolObject<Dworf> _dworfs;

    private Transform _humanParent;
    private Transform _elfsParent;
    private Transform _dworfsParent;

    private void Start()
    {
        _humans = new PoolObject<Human>(_humanPrefab, _humanParent, 10, false, false);
    }
}
