namespace EventSeller.DataLayer.ExternalDTO
{
    public class JSONRootObjectResponse<TClass> where TClass : class
    {
        public TClass ProcessPaymentResponse { get; set; }
    }
}
