namespace DebugTest.Client;

[AttributeUsage(AttributeTargets.Class)]
public sealed class BadAttribute<TInterface> : Attribute
{
}
