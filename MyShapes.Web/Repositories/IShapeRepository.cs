namespace MyShapes.Web.Repositories
{
    /// <summary>
    /// Interface for a generic repository (Db, file, inMem..) per le Shape
    /// </summary>
    public interface IShapeRepository
    {
        IEnumerable<Shape> GetShapes();
    }
}
