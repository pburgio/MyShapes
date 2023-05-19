namespace MyShapes.Web.Dto
{
    /// <summary>
    /// Data transfer object for REST API. This is typically negotiated
    /// with other cloud microservices
    /// </summary>
    public class ShapeDto
    {
        //TODO add Id field, to enable Patch and CalcArea
        public string Color { get; set; } = default!;
    }
}
