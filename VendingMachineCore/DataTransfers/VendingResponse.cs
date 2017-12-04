namespace VendingMachine.DataTransfers
{
    public class VendingResponse
    {
        public int TenderValue { get; set; }
        public string Message { get; set; }
        public IProduct Delivery { get; set; }
    }
}