using IonDotnet.Internals;

namespace IonDotnet.Tree
{
    /// <summary>
    /// An Ion string value.
    /// </summary>
    public sealed class IonString : IonText
    {
        public IonString(bool isNull) : base(isNull)
        {
        }

        internal override void WriteBodyTo(IPrivateWriter writer) => writer.WriteString(_stringVal);

        public override IonType Type => IonType.String;
    }
}