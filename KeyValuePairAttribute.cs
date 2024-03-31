namespace System.ComponentModel.DataAnnotations;

public class KeyValuePairAttribute<TKey, TValue>(TKey key, TValue value) : ValueAttribute<TValue>(value)
{
    public TKey Key { get; } = key;
}
