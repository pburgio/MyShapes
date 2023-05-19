namespace MyShapes
{
    /// <summary>
    /// This cannot be abstract because otherwise we cannot use AutoMapper
    /// TODO this *must* be fixed somehow, or we should find a workaround
    /// </summary>
    public class Shape : IShape
    {
        // This is a property, which is the preferred way of creating entities for MS
        public string Color { get; set; } = default!;

        public virtual int CalcArea() => -1;
    }
}
